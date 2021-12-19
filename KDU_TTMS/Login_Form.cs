using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using Exception = System.Exception;

namespace KDU_Time_Table_Management_System
{
    public partial class Login_Form : Form
    {
        Thread th;

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db;";

        public Login_Form()
        {
            InitializeComponent();
            password_textbox.PasswordChar = '*';
            guna2ShadowForm1.SetShadowForm(this);
        }

        HashCode hc = new HashCode();

        void saveData()
        {
            for (int i = 1; i <= 200; i++)
            {
                Thread.Sleep(20);
            }
        }

        public string account_type;
        String email;

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_textbox.Text))
            {
                email_errorProvider.Icon = Resources.error;
                email_errorProvider.SetError(email_textbox, "Please enter your email!");
            }
            else
            {
                email_errorProvider.Icon = Resources.check;
                email_errorProvider.SetError(email_textbox, "Ok");
            }
            if (string.IsNullOrEmpty(password_textbox.Text))
            {
                password_errorProvider.Icon = Resources.error;
                password_errorProvider.SetError(password_textbox, "Please enter your password!");
            }
            else
            {
                password_errorProvider.Icon = Resources.check;
                password_errorProvider.SetError(password_textbox, "Ok");

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                string query = "select email,password,account_type from login_info where email='" + email_textbox.Text + "'and password='" + hc.PassHash(password_textbox.Text) + "'";
                DataTable dt = new DataTable();

                try
                {
                    databaseConnection.Open();

                    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                    //commandDatabase.CommandTimeout = 60;

                    using (MySqlDataAdapter da = new MySqlDataAdapter(commandDatabase))
                    {
                        da.Fill(dt);
                    }
                    Boolean correct = false;
                    if (dt.Rows.Count > 0)
                    {
                        email = email_textbox.Text;

                        correct = true;
                        if (dt.Rows[0][2].ToString() == "Student")
                        {
                            account_type = "Student";
                        }
                        else if (dt.Rows[0][2].ToString() == "Lecturer")
                        {
                            account_type = "Lecturer";
                        }
                        else if (dt.Rows[0][2].ToString() == "Assistant")
                        {
                            account_type = "Assistant";
                        }
                        else if (dt.Rows[0][2].ToString() == "Administrator")
                        {
                            account_type = "Administrator";
                        }
                        using (var frm = new Loading_Please_Wait(saveData, email, correct, account_type))
                        {
                            frm.guna2HtmlLabel1.Text = "Verifying...";
                            frm.ShowDialog(this);
                            this.Hide();
                        }
                    }
                    else
                    {
                        correct = false;
                        account_type = null;
                        try
                        {
                            using (var frm = new Loading_Please_Wait(saveData, email, correct, account_type))
                            {
                                frm.guna2HtmlLabel1.Text = "Verifying...";
                                frm.ShowDialog(this);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        finally
                        {
                            invalid_login_panel.Visible = true;
                        }
                    }

                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Thread th;
        private void forgot_password_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            th = new Thread(openForgotPassword);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openForgotPassword(object obj)
        {
            Application.Run(new Forgot_Password());
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                caps_lb.Visible = true;
            }
            else
            {
                caps_lb.Visible = false;
            }

            if (Settings.Default.email != string.Empty)
            {
                email_textbox.Text = Settings.Default.email;
            }

        }

        private void Login_Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                caps_lb.Visible = true;
            }
            else
            {
                caps_lb.Visible = false;
            }
        }

        private bool showPasswordClicked = false;
        private void password_textbox_IconRightClick(object sender, EventArgs e)
        {
            if (showPasswordClicked == false)
            {
                password_textbox.IconRight = Resources.show_pass;
                showPasswordClicked = true;
            }
            else
            {
                password_textbox.IconRight = Resources.not_show_pass;
                showPasswordClicked = false;
            }
            password_textbox.PasswordChar = showPasswordClicked ? '\0' : '*';
        }

        private void email_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_textbox.Text))
            {
                email_errorProvider.Icon = Resources.error;
                email_errorProvider.SetError(email_textbox, "Please enter your email!");
            }
            else
            {
                email_errorProvider.Icon = Resources.check;
                email_errorProvider.SetError(email_textbox, "Ok");
            }
        }

        private void password_textbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(password_textbox.Text))
            {
                password_errorProvider.Icon = Resources.error;
                password_errorProvider.SetError(password_textbox, "Please enter your password!");
            }
            else
            {
                password_errorProvider.Icon = Resources.check;
                password_errorProvider.SetError(password_textbox, "Ok");
            }
        }

        private void checkRemember_CheckedChanged(object sender, EventArgs e)
        {
            if (checkRemember.Checked)
            {
                if (string.IsNullOrEmpty(email_textbox.Text))
                {

                }
                else
                {
                    Settings.Default.email = email_textbox.Text;
                    Settings.Default.Save();
                }
            }
        }

        private void back_to_home_btn_Click(object sender, EventArgs e)
        {
            new Thread(() => new HomePage().ShowDialog()).Start();
            this.Dispose();
        }
    }
}
