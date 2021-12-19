using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace KDU_Time_Table_Management_System
{
    public partial class Add_Update_Student : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        HashCode hc = new HashCode();

        public Add_Update_Student()
        {
            InitializeComponent();
        }

        int getID;
        string oldEmail;
        public Add_Update_Student(int getID, string email)
        {
            InitializeComponent();
            this.getID = getID;
            oldEmail = email;
        }

        private void showError(string errorMessage)
        {
            message_label.Text = errorMessage;
            message_panel.Visible = true;
            message_panel.FillColor = Color.Tomato;
            timer1.Start();
        }

        private void showSuccess(string message)
        {
            message_label.Text = message;
            message_panel.Visible = true;
            message_panel.FillColor = Color.MediumSeaGreen;
            timer1.Start();
        }

        private void loadIntakes()
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT intake FROM intakes", databaseConnection);
            cmd.Connection = databaseConnection;

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                intake_combobox.Items.Add(reader["intake"]);
            }
            reader.Close();
            databaseConnection.Close();
        }

        private bool checkEmptyFields()
        {
            if (String.IsNullOrEmpty(stud_regnum_textbox.Text) || String.IsNullOrEmpty(stud_name_textbox.Text) || student_course_stream_combo.SelectedItem == null || String.IsNullOrEmpty(stud_email_textbox.Text) || String.IsNullOrEmpty(stud_mobile_textbox.Text) || intake_combobox.SelectedItem == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Generate Random String
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public enum MailSendType
        {
            SendDirect = 0,
            ShowModal = 1,
            ShowModeless = 2,
        }

        //Send Email with password
        public bool SendMailWithOutlook(string subject, string htmlBody, string recipients, MailSendType sendType)
        {
            // create the outlook application.
            Outlook.Application outlookApp = new Outlook.Application();
            if (outlookApp == null)
                return false;

            // create a new mail item.
            Outlook.MailItem mail = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

            // set html body. 
            // add the body of the email
            mail.HTMLBody = htmlBody;
            mail.Subject = subject;
            mail.To = recipients;

            if (sendType == MailSendType.SendDirect)
                mail.Send();
            else if (sendType == MailSendType.ShowModal)
                mail.Display(true);
            else if (sendType == MailSendType.ShowModeless)
                mail.Display(false);

            mail = null;
            outlookApp = null;
            return true;
        }

        bool addexception = false;
        private void add_student_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand checkDuplicate = new MySqlCommand("Select COUNT(*) from student_info WHERE student_reg_no = @student_reg_no or student_name = @student_name", databaseConnection);
                checkDuplicate.Parameters.AddWithValue("@student_reg_no", stud_regnum_textbox.Text);
                checkDuplicate.Parameters.AddWithValue("@student_name", stud_name_textbox.Text);
                int student_reg_count = Convert.ToInt32(checkDuplicate.ExecuteScalar());
                int student_name_count = Convert.ToInt32(checkDuplicate.ExecuteScalar());

                if (student_reg_count > 0 || student_name_count > 0)
                {
                    showError("This student was already inserted, Please check again");
                }
                else
                {

                    string getPassword = RandomString(8);
                    string subject = "KDU Timetable Management System Account Created";
                    string body = "New Student account was created for " + stud_email_textbox.Text + Environment.NewLine + "Use the login details below to connect." + Environment.NewLine + "Email - " + stud_email_textbox.Text + Environment.NewLine + "Password -" + getPassword + Environment.NewLine + Environment.NewLine + "Thankyou, KDU";

                    try
                    {
                        SendMailWithOutlook(subject, body, stud_email_textbox.Text, MailSendType.SendDirect);
                    }

                    catch (Exception ex)
                    {

                        MessageBox.Show("The entered email is invalid or does not exist, please remove the account or update the email");
                        addexception = true;
                    }
                    if (addexception == false)
                    {

                        MySqlCommand getIntakeId = new MySqlCommand("Select id from intakes where intake='" + intake_combobox.SelectedItem + "'", databaseConnection);
                        Int32 intake_id = Convert.ToInt32(getIntakeId.ExecuteScalar());

                        MySqlCommand insertStudentCMD = new MySqlCommand(@"INSERT INTO student_info(student_reg_no,student_name,student_course_stream,student_email,student_mobile,intake_id) VALUES(@student_reg_no,@student_name,@student_course_stream,@student_email,@student_mobile,@intake_id)", databaseConnection);
                        insertStudentCMD.Parameters.AddWithValue("@student_reg_no", stud_regnum_textbox.Text);
                        insertStudentCMD.Parameters.AddWithValue("@student_name", stud_name_textbox.Text);
                        insertStudentCMD.Parameters.AddWithValue("@student_course_stream", student_course_stream_combo.SelectedItem);
                        insertStudentCMD.Parameters.AddWithValue("@student_email", stud_email_textbox.Text);
                        insertStudentCMD.Parameters.AddWithValue("@student_mobile", stud_mobile_textbox.Text);
                        insertStudentCMD.Parameters.AddWithValue("@intake_id", intake_id);
                        insertStudentCMD.ExecuteNonQuery();


                        MySqlCommand insertLogin = new MySqlCommand(@"Insert into login_info(email,password,account_type) Values(@email,@password,@account_type)", databaseConnection);
                        insertLogin.Parameters.AddWithValue("@email", stud_email_textbox.Text);
                        insertLogin.Parameters.AddWithValue("@password", hc.PassHash(getPassword));
                        insertLogin.ExecuteNonQuery();


                        showSuccess("Data saved successfully, New Student account was created!");
                    }
                    else
                    {
                        MessageBox.Show("Student account was not saved");
                    }
                }
                databaseConnection.Close();
            }
        }


        //bool updateexception = false;
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                //databaseConnection.Open();
                //string getPassword = RandomString(8);
                //string subject = "KDU Timetable Management System Account Updated";
                //string body = "Student account was updated for " + stud_email_textbox.Text + "\nUse the login details below to connect.\nEmail - " + stud_email_textbox.Text + "\nPassword -" + getPassword + "\n\nThankyou, KDU";

                //try
                //{
                //    SendMailWithOutlook(subject, body, stud_email_textbox.Text, MailSendType.SendDirect);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //    MessageBox.Show("The entered email is invalid or does not exist, please check the email");
                //    updateexception = true;
                //}
                // if (updateexception == false)
                // {
                databaseConnection.Open();
                MySqlCommand getIntake = new MySqlCommand("Select id from intakes where intake = '" + intake_combobox.SelectedItem.ToString() + "'", databaseConnection);
                Int32 intakeId = Convert.ToInt32(getIntake.ExecuteScalar());

                MySqlCommand cmd = new MySqlCommand("update student_info set student_reg_no=@student_reg_no,student_name=@student_name,student_course_stream=@student_course_stream,student_email=@student_email,student_mobile=@student_mobile,intake_id=@intake_id where id='" + getID + "'", databaseConnection);

                cmd.Parameters.AddWithValue("@student_reg_no", stud_regnum_textbox.Text);
                cmd.Parameters.AddWithValue("@student_name", stud_name_textbox.Text);
                cmd.Parameters.AddWithValue("@student_course_stream", student_course_stream_combo.SelectedItem);
                cmd.Parameters.AddWithValue("@student_email", stud_email_textbox.Text);
                cmd.Parameters.AddWithValue("@student_mobile", stud_mobile_textbox.Text);
                cmd.Parameters.AddWithValue("@intake_id", intakeId);

                //MySqlCommand updateLogin = new MySqlCommand("update login_info set email=@email,password=@password where email='" + oldEmail + "'", databaseConnection);
                //updateLogin.Parameters.AddWithValue("@email", stud_email_textbox.Text);
                //updateLogin.Parameters.AddWithValue("@password", getPassword);
                //updateLogin.ExecuteNonQuery();

                cmd.ExecuteNonQuery();
                showSuccess("Data updated successfully!");
                //}
                //else
                //{
                //    MessageBox.Show("Student account was not updated");
                //}
                databaseConnection.Close();
            }
        }

        private void stud_mobile_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            message_panel.Visible = false;
        }

        private void stud_name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Add_Update_Student_Load(object sender, EventArgs e)
        {
            loadIntakes();
        }
    }
}
