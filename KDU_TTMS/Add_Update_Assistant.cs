using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace KDU_Time_Table_Management_System
{
    public partial class Add_Update_Assistant : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Add_Update_Assistant()
        {
            InitializeComponent();
        }
        HashCode hc = new HashCode();
        int getID;
        string oldEmail;

        public Add_Update_Assistant(int getID, string email)
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

        private bool checkEmptyFields()
        {
            if (String.IsNullOrEmpty(assistant_name_textbox.Text) || String.IsNullOrEmpty(work_email_textbox.Text) || String.IsNullOrEmpty(mobile_number_textbox.Text))
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
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand checkDuplicate = new MySqlCommand("Select COUNT(*) from assistant_info WHERE assistant_name = @assistant_name", databaseConnection);
                checkDuplicate.Parameters.AddWithValue("@assistant_name", assistant_name_textbox.Text);
                int assistant_count = Convert.ToInt32(checkDuplicate.ExecuteScalar());

                if (assistant_count > 0)
                {
                    showError("This asistant was already inserted, Please check again");
                }
                else
                {
                    string getPassword = RandomString(8);
                    string subject = "KDU Timetable Management System Account Created";
                    string body = "New Assistant account was created for " + work_email_textbox.Text + Environment.NewLine + "Use the login details below to connect." + Environment.NewLine + "Email - " + work_email_textbox.Text + Environment.NewLine + "Password -" + getPassword + Environment.NewLine + Environment.NewLine + "Thankyou, KDU";

                    try
                    {
                        SendMailWithOutlook(subject, body, work_email_textbox.Text, MailSendType.SendDirect);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("The entered email is invalid or does not exist, please remove the account or update the email");
                        addexception = true;
                    }
                    if (addexception == false)
                    {

                        MySqlCommand insertAssistant = new MySqlCommand(@"INSERT INTO assistant_info(assistant_name,assistant_email,assistant_mobile,gender,priviledges,status) VALUES(@assistant_name,@assistant_email,@assistant_mobile,@gender,@priviledges,@status)", databaseConnection);
                        insertAssistant.Parameters.AddWithValue("@assistant_name", assistant_name_textbox.Text);
                        insertAssistant.Parameters.AddWithValue("@assistant_email", work_email_textbox.Text);
                        insertAssistant.Parameters.AddWithValue("@assistant_mobile", mobile_number_textbox.Text);
                        insertAssistant.Parameters.AddWithValue("@gender", gender_combobox.SelectedItem);
                        if (enable_checkbox.Checked)
                        {
                            insertAssistant.Parameters.AddWithValue("@priviledges", "Administrator");
                        }
                        else
                        {
                            insertAssistant.Parameters.AddWithValue("@priviledges", "Assistant");
                        }
                        insertAssistant.Parameters.AddWithValue("@status", "Not Available");
                        insertAssistant.ExecuteNonQuery();

                        MySqlCommand insertLogin = new MySqlCommand(@"Insert into login_info(email,password,account_type) Values(@email,@password,@account_type)", databaseConnection);
                        insertLogin.Parameters.AddWithValue("@email", work_email_textbox.Text);
                        insertLogin.Parameters.AddWithValue("@password", hc.PassHash(getPassword));
                        if (enable_checkbox.Checked)
                        {
                            insertLogin.Parameters.AddWithValue("@account_type", "Administrator");
                        }
                        else
                        {
                            insertLogin.Parameters.AddWithValue("@account_type", "Assistant");
                        }

                        insertLogin.ExecuteNonQuery();


                        showSuccess("Data saved successfully, New Assistant account was created!");
                    }
                }
                databaseConnection.Close();
            }
        }

        bool updateexception = false;
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                databaseConnection.Open();
                //string getPassword = RandomString(8);
                //string subject = "KDU Timetable Management System Account Updated";
                //string body = "Assistant account was updated for " + work_email_textbox.Text + "\nUse the login details below to connect.\nEmail - " + work_email_textbox.Text + "\nPassword -" + getPassword + "\n\nThankyou, KDU";

                //try
                //{
                //    SendMailWithOutlook(subject, body, work_email_textbox.Text, MailSendType.SendDirect);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //    MessageBox.Show("The entered email is invalid or does not exist, please check the email");
                //    updateexception = true;
                //}
                //  if (updateexception == false)
                //{
                MySqlCommand cmd = new MySqlCommand("update assistant_info set assistant_name=@assistant_name,assistant_email=@assistant_email,assistant_mobile=@assistant_mobile, gender=@gender,priviledges=@priviledges where id='" + getID + "'", databaseConnection);

                cmd.Parameters.AddWithValue("@assistant_name", assistant_name_textbox.Text);
                cmd.Parameters.AddWithValue("@assistant_email", work_email_textbox.Text);
                cmd.Parameters.AddWithValue("@assistant_mobile", mobile_number_textbox.Text);
                cmd.Parameters.AddWithValue("@gender", gender_combobox.SelectedItem);
                if (enable_checkbox.Checked)
                {
                    cmd.Parameters.AddWithValue("@priviledges", "Administrator");
                }
                else
                {
                    cmd.Parameters.AddWithValue("@priviledges", "Assistant");
                }
                cmd.ExecuteNonQuery();

                //MySqlCommand updateLogin = new MySqlCommand("update login_info set email=@email,password=@password where email='" + oldEmail + "'", databaseConnection);
                //updateLogin.Parameters.AddWithValue("@email", work_email_textbox.Text);
                //updateLogin.Parameters.AddWithValue("@password", getPassword);
                //updateLogin.ExecuteNonQuery();

                showSuccess("Data Updated Successfully!");
                //  }
                // else
                // {
                //      MessageBox.Show("Assistant account was not updated");
                //  }

                databaseConnection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            message_panel.Visible = false;
        }

        private void mobile_number_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
