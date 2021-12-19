using Guna.UI2.WinForms;
using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace KDU_Time_Table_Management_System
{
    public partial class Add_Update_Lecturer : Form
    {
        public Add_Update_Lecturer()
        {
            InitializeComponent();
        }

        HashCode hc = new HashCode();
        int getID;
        string oldEmail;

        private string edit = null;
        public Add_Update_Lecturer(int getID, string email, string edit)
        {
            InitializeComponent();
            this.getID = getID;
            oldEmail = email;
            this.edit = edit;
        }

        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            message_panel.Visible = false;
        }

        private bool checkEmptyFields()
        {
            if (String.IsNullOrEmpty(lect_reg_textbox.Text) || String.IsNullOrEmpty(lect_name_textbox.Text) || String.IsNullOrEmpty(lect_email_textbox.Text) || String.IsNullOrEmpty(lect_mobile_textbox.Text))
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

            if (checkEmptyFields() == true || flowLayoutPanel1.Controls.Count == 0)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand checkDuplicate = new MySqlCommand("Select COUNT(*) from lecturer_info where lecturer_id = @lecturer_id or lecturer_name = @lecturer_name", databaseConnection);
                checkDuplicate.Parameters.AddWithValue("@lecturer_id", lect_reg_textbox.Text);
                checkDuplicate.Parameters.AddWithValue("@lecturer_name", lect_name_textbox.Text);
                Int32 lecture_code_count = Convert.ToInt32(checkDuplicate.ExecuteScalar());
                Int32 lecture_module_count = Convert.ToInt32(checkDuplicate.ExecuteScalar());

                if (lecture_code_count > 0 || lecture_module_count > 0)
                {
                    showError("This lecture module was already inserted, Please check again");
                }
                else
                {
                    string getPassword = RandomString(8);
                    string subject = "KDU Timetable Management System Account Created";
                    string body = "New Lecturer account was created for " + lect_email_textbox.Text + "\nUse the login details below to connect.\nEmail - " + lect_email_textbox.Text + "\nPassword -" + getPassword + "\n\nThankyou, KDU";

                    try
                    {
                        SendMailWithOutlook(subject, body, lect_email_textbox.Text, MailSendType.SendDirect);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        MessageBox.Show("The entered email is invalid or does not exist, please check the email");
                        addexception = true;
                    }

                    //if (addexception == false)
                    //{
                    MySqlCommand insertLecturer = new MySqlCommand(@"INSERT INTO lecturer_info(lecturer_id,lecturer_name,lecturer_email,lecturer_mobile) VALUES(@lecturer_id,@lecturer_name,@lecturer_email,@lecturer_mobile)", databaseConnection);
                    insertLecturer.Parameters.AddWithValue("@lecturer_id", lect_reg_textbox.Text);
                    insertLecturer.Parameters.AddWithValue("@lecturer_name", lect_name_textbox.Text);
                    insertLecturer.Parameters.AddWithValue("@lecturer_email", lect_email_textbox.Text);
                    insertLecturer.Parameters.AddWithValue("@lecturer_mobile", lect_mobile_textbox.Text);
                    insertLecturer.ExecuteNonQuery();

                    foreach (Control c in flowLayoutPanel1.Controls)
                    {
                        if (c is Guna2ComboBox)
                        {
                            MySqlCommand getmodid = new MySqlCommand("Select id from module_info where lecture_module = '" + ((Guna2ComboBox)c).SelectedItem.ToString() + "'", databaseConnection);
                            string getModId = getmodid.ExecuteScalar().ToString();

                            MySqlCommand getlecturerId = new MySqlCommand("Select id from lecturer_info where lecturer_id='" + lect_reg_textbox.Text + "'", databaseConnection);
                            string getlecId = getlecturerId.ExecuteScalar().ToString();

                            MySqlCommand insertids = new MySqlCommand(@"INSERT INTO lecturer_module_tb(lecturer_id,module_id) VALUES(@lecturer_id,@module_id)", databaseConnection);
                            insertids.Parameters.AddWithValue("@lecturer_id", getlecId);
                            insertids.Parameters.AddWithValue("@module_id", getModId);
                            insertids.ExecuteNonQuery();
                        }
                    }

                    MySqlCommand insertLogin = new MySqlCommand(@"Insert into login_info(email,password,account_type) Values(@email,@password,@account_type)", databaseConnection);
                    insertLogin.Parameters.AddWithValue("@email", lect_email_textbox.Text);
                    insertLogin.Parameters.AddWithValue("@password", hc.PassHash(getPassword));
                    insertLogin.Parameters.AddWithValue("@account_type", "Lecturer");
                    insertLogin.ExecuteNonQuery();
                    showSuccess("Data saved successfully, New Lecturer account was created!");

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Lecturer account was not saved");
                    //}
                }
                databaseConnection.Close();
            }
        }

        bool updateexception = false;
        private void update_btn_Click(object sender, EventArgs e)
        {

            if (checkEmptyFields() == true || flowLayoutPanel1.Controls.Count == 0)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                databaseConnection.Open();
                //string getPassword = RandomString(8);
                //string subject = "KDU Timetable Management System Account Updated";
                //string body = "Lecturer account was updated for " + lect_email_textbox.Text + "\nUse the login details below to connect.\nEmail - " + lect_email_textbox.Text + "\nPassword -" + getPassword + "\n\nThankyou, KDU";

                //try
                //{
                //    SendMailWithOutlook(subject, body, lect_email_textbox.Text, MailSendType.SendDirect);
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.ToString());
                //    MessageBox.Show("The entered email is invalid or does not exist, please check the email");
                //    updateexception = true;
                //}
                //if (updateexception == false)
                // {
                MySqlCommand cmd = new MySqlCommand("update lecturer_info set lecturer_id=@lecturer_id,lecturer_name=@lecturer_name,lecturer_email=@lecturer_email,lecturer_mobile=@lecturer_mobile where id='" + getID + "'", databaseConnection);
                cmd.Parameters.AddWithValue("@lecturer_id", lect_reg_textbox.Text);
                cmd.Parameters.AddWithValue("@lecturer_name", lect_name_textbox.Text);
                cmd.Parameters.AddWithValue("@lecturer_email", lect_email_textbox.Text);
                cmd.Parameters.AddWithValue("@lecturer_mobile", lect_mobile_textbox.Text);

                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c is Guna2ComboBox)
                    {
                        MySqlCommand getmodid = new MySqlCommand("Select id from module_info where lecture_module = '" + ((Guna2ComboBox)c).SelectedItem.ToString() + "'", databaseConnection);
                        string getModId = getmodid.ExecuteScalar().ToString();

                        MySqlCommand getlecturerId = new MySqlCommand("Select id from lecturer_info where lecturer_id='" + lect_reg_textbox.Text + "'", databaseConnection);
                        string getlecId = getlecturerId.ExecuteScalar().ToString();

                        MySqlCommand insertids = new MySqlCommand("update lecturer_module_tb set lecturer_id=@lecturer_id,module_id=@module_id", databaseConnection);
                        insertids.Parameters.AddWithValue("@lecturer_id", getlecId);
                        insertids.Parameters.AddWithValue("@module_id", getModId);
                        insertids.ExecuteNonQuery();
                    }
                }

                //    MySqlCommand updateLogin = new MySqlCommand("update login_info set email=@email,password=@password where email='" + oldEmail + "'", databaseConnection);
                //    updateLogin.Parameters.AddWithValue("@email", lect_email_textbox.Text);
                //    updateLogin.Parameters.AddWithValue("@password", getPassword);

                //    updateLogin.ExecuteNonQuery();
                //    showSuccess("Data Updated Successfully!");

                //}
                //else
                //{
                //    MessageBox.Show("Lecturer account was not updated");
                //}
            }
            databaseConnection.Close();
        }

        private void lect_mobile_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void lect_name_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Guna2ImageButton deleteBtn = (sender as Guna2ImageButton);
            int index = int.Parse(deleteBtn.Name.Split('_')[1]);

            flowLayoutPanel1.Controls.Remove(flowLayoutPanel1.Controls.Find("combo_" + index, true)[0]);
            flowLayoutPanel1.Controls.Remove(deleteBtn);
            databaseConnection.Close();
        }
        DataTable modIdTable = new DataTable();
        public void onEdit()
        {
            databaseConnection.Open();
            MySqlCommand getmoduleId = new MySqlCommand("Select module_id from lecturer_module_tb where lecturer_id = '" + getID + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getmoduleId);
            sda.Fill(modIdTable);
            //  DataTable dts = new DataTable();

            foreach (DataRow dr in modIdTable.Rows)
            {
                MySqlCommand getModule = new MySqlCommand("Select lecture_module from module_info where id='" + dr["module_id"] + "'", databaseConnection);
                string modulename = getModule.ExecuteScalar().ToString();

                int count = flowLayoutPanel1.Controls.OfType<Guna2TextBox>().ToList().Count;
                Guna2ComboBox select_mod = new Guna2ComboBox();

                select_mod.Size = new Size(328, 24);
                select_mod.DrawMode = DrawMode.Normal;
                select_mod.Name = "combo_" + (count + 1);
                select_sem_combo.DropDownStyle = ComboBoxStyle.DropDownList;
                select_sem_combo.Font = new Font("Segoe UI", 9);

                loadForEdit();

                foreach (DataRow drt in editDT.Rows)
                {
                    select_mod.Items.Add(drt["lecture_module"].ToString());
                }
                select_mod.SelectedItem = modulename;

                Guna2ImageButton delete = new Guna2ImageButton();
                delete.Size = new Size(24, 24);
                delete.BackColor = Color.White;
                delete.Name = "btnDelete_" + (count + 1);
                delete.Image = Resources.delete_red;
                delete.HoverState.ImageSize = new Size(22, 22);
                delete.Click += new EventHandler(deleteBtn_Click);



                flowLayoutPanel1.Controls.Add(delete);
                flowLayoutPanel1.Controls.Add(select_mod);

            }
            databaseConnection.Close();
        }

        private DataTable editDT = new DataTable();
        private void loadForEdit()
        {

            MySqlCommand getlectures = new MySqlCommand("Select lecture_module from module_info where semester = '" + 1 + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getlectures);

            sda.Fill(editDT);

            sda.Dispose();
        }


        private void add_module_btn_Click(object sender, EventArgs e)
        {
            int count = flowLayoutPanel1.Controls.OfType<Guna2TextBox>().ToList().Count;
            Guna2ComboBox select_mod = new Guna2ComboBox();

            select_mod.Size = new Size(328, 24);
            select_mod.DrawMode = DrawMode.Normal;
            select_mod.Name = "combo_" + (count + 1);
            select_sem_combo.DropDownStyle = ComboBoxStyle.DropDownList;
            select_sem_combo.Font = new Font("Segoe UI", 9);
            foreach (DataRow dr in dt.Rows)
            {
                select_mod.Items.Add(dr["lecture_module"].ToString());
            }
            //  select_mod.SelectedIndex = 0;

            Guna2ImageButton delete = new Guna2ImageButton();
            delete.Size = new Size(24, 24);
            delete.BackColor = Color.White;
            delete.Name = "btnDelete_" + (count + 1);
            delete.Image = Resources.delete_red;
            delete.HoverState.ImageSize = new Size(22, 22);
            delete.Click += new EventHandler(deleteBtn_Click);



            flowLayoutPanel1.Controls.Add(delete);
            flowLayoutPanel1.Controls.Add(select_mod);
        }

        private DataTable dt = new DataTable();
        private void Add_Update_Lecturer_Load(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand getlectures = new MySqlCommand("Select lecture_module from module_info where semester = '" + 1 + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getlectures);

            sda.Fill(dt);
            databaseConnection.Close();
            sda.Dispose();
            onEdit();

        }


        private void select_sem_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            databaseConnection.Open();
            MySqlCommand getlectures = new MySqlCommand("Select lecture_module from module_info where semester = '" + select_sem_combo.SelectedItem + "'", databaseConnection); ;
            MySqlDataAdapter sda = new MySqlDataAdapter(getlectures);

            sda.Fill(dt);
            databaseConnection.Close();
            sda.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is Guna2ComboBox)
                {
                    databaseConnection.Open();

                    MySqlCommand getmodid = new MySqlCommand("Select id from module_info where lecture_module = '" + ((Guna2ComboBox)c).SelectedItem.ToString() + "'", databaseConnection);
                    string getModId = getmodid.ExecuteScalar().ToString();

                    MySqlCommand getlecturerId = new MySqlCommand("Select id from lecturer_info where lecturer_id='" + 34 + "'", databaseConnection);
                    string getlecId = getlecturerId.ExecuteScalar().ToString();

                    MySqlCommand insertids = new MySqlCommand(@"INSERT INTO lecturer_module_tb(lecturer_id,module_id) VALUES(@lecturer_id,@module_id)", databaseConnection);
                    insertids.Parameters.AddWithValue("@lecturer_id", getlecId);
                    insertids.Parameters.AddWithValue("@module_id", getModId);
                    insertids.ExecuteNonQuery();
                    MessageBox.Show(getModId);
                    databaseConnection.Close();
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}