using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace KDU_Time_Table_Management_System
{
    public partial class Forgot_Password : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        HashCode hc = new HashCode();
        public Forgot_Password()
        {
            InitializeComponent();
        }
        Thread th;
        private void go_back_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
            th = new Thread(openLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLoginForm(object obj)
        {
            Application.Run(new Login_Form());
        }

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

        public bool SendMailWithOutlook(string subject, string htmlBody, string recipients, MailSendType sendType)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            finally
            {
                MessageBox.Show("An Email has been sent to your account, check your inbox", "Email Sent Successfully!");
            }
        }

        private void reset_password_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(email_textbox.Text))
            {
                email_textbox.Focus();
                email_errorProvider.SetError(email_textbox, "Please enter your email!");
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand("Select COUNT(*) from login_info where email=@email", databaseConnection);
                cmd.Parameters.AddWithValue("@email", email_textbox.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    string getPassword = RandomString(8);
                    string subject = "KDU Timetable Management System Password Reset";
                    string body = "Hi " + email_textbox.Text + "!\n\nYou recently requested to reset your password for your KDU Timetable Management System Account. Your Reset Account details are shown below.\nEmail - " + email_textbox.Text + "\nPassword -" + getPassword + "\n\nThanks, KDU";
                    SendMailWithOutlook(subject, body, email_textbox.Text, MailSendType.SendDirect);


                    MySqlCommand update = new MySqlCommand("update login_info set password=@password where email = '" + email_textbox.Text + "'", databaseConnection);
                    update.Parameters.AddWithValue("@password", hc.PassHash(getPassword));
                    update.ExecuteNonQuery();
                }
                else
                {
                    MessageBox.Show("This email does not exist or not created! \n Please contact with your admin or assistant");
                }
                databaseConnection.Close();
            }
        }


    }
}
