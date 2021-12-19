using Guna.UI2.WinForms;
using Microsoft.Office.Interop.Outlook;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;

namespace KDU_Time_Table_Management_System
{
    public partial class Send_Email_Form : Form
    {
        public bool button3Clicked = false;

        public string trigger = null;

        public Send_Email_Form(string trigger)
        {
            InitializeComponent();
            this.trigger = trigger;
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

        private void send_btn_Click(object sender, EventArgs e)
        {
            if (trigger == "lecturers")
            {
                Outlook.Application outlookApp = new Outlook.Application();
                MailItem mailItem = (MailItem)outlookApp.CreateItem(OlItemType.olMailItem);
                mailItem.Subject = guna2TextBox1.Text;
                mailItem.Body = guna2TextBox2.Text;
                mailItem.Importance = OlImportance.olImportanceNormal;
                Recipients oRecips = mailItem.Recipients;

                //if attachment button is clicked
                if (button3Clicked == true)
                {
                    button3Clicked = false;
                    if (attachment.FileName.Length > 0)
                    {
                        MySqlCommand command = new MySqlCommand("SELECT lecturer_email FROM lecturer_info", databaseConnection);
                        command.Connection = databaseConnection;
                        DataSet dataset = new DataSet();
                        MySqlDataAdapter adp = new MySqlDataAdapter(command);
                        adp.Fill(dataset);

                        foreach (DataTable table in dataset.Tables)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                foreach (object item in row.ItemArray)
                                {
                                    Recipient oRecip = oRecips.Add((string)item);
                                    oRecip.Resolve();
                                }
                            }
                        }
                    }
                    mailItem.Attachments.Add(attachment.FileName, OlAttachmentType.olByValue, 1, attachment.FileName);
                    oRecips = null;
                }

                mailItem.Send();
                showSuccess("Message has been sent successfully!");
            }
            else
            {
                Outlook.Application outlookApp = new Outlook.Application();
                MailItem mailItem = (MailItem)outlookApp.CreateItem(OlItemType.olMailItem);
                mailItem.Subject = guna2TextBox1.Text;
                mailItem.Body = guna2TextBox2.Text;
                mailItem.Importance = OlImportance.olImportanceNormal;
                Recipients oRecips = mailItem.Recipients;

                //if attachment button is clicked
                if (button3Clicked == true)
                {
                    button3Clicked = false;
                    if (attachment.FileName.Length > 0)
                    {

                        MySqlCommand command = new MySqlCommand("SELECT student_email FROM student_info WHERE intake_id='" + trigger + "'", databaseConnection);
                        command.Connection = databaseConnection;
                        DataSet dataset = new DataSet();
                        MySqlDataAdapter adp = new MySqlDataAdapter(command);
                        adp.Fill(dataset);

                        foreach (DataTable table in dataset.Tables)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                foreach (object item in row.ItemArray)
                                {
                                    Recipient oRecip = oRecips.Add((string)item);
                                    oRecip.Resolve();
                                }
                            }
                        }
                    }
                    mailItem.Attachments.Add(attachment.FileName, OlAttachmentType.olByValue, 1, attachment.FileName);
                    oRecips = null;
                }

                mailItem.Send();
                showSuccess("Message has been sent successfully!");
            }

        }

        OpenFileDialog attachment = new OpenFileDialog();
        Stream myStream;
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            button3Clicked = true;
            attachment.Title = "Browse a file to send";
            attachment.Multiselect = true;
            //attachment.ShowDialog();

            if (attachment.ShowDialog() == DialogResult.OK)
            {
                foreach (String file in attachment.FileNames)
                {
                    try
                    {
                        if ((myStream = attachment.OpenFile()) != null)
                        {
                            using (myStream)
                            {
                                Guna2HtmlLabel newFilename = new Guna2HtmlLabel();
                                newFilename.Text = Path.GetFileName(file);
                                newFilename.ForeColor = Color.FromArgb(94, 148, 255);
                                newFilename.Font = new Font("SegoeUI", 10);
                                flowLayoutPanel2.Controls.Add(newFilename);
                            }
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                    }
                }
            }
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadStudents()
        {
            MySqlCommand command = new MySqlCommand("SELECT student_email FROM student_info WHERE intake_id='" + trigger + "'", databaseConnection);
            command.Connection = databaseConnection;
            DataSet dataset = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            adp.Fill(dataset);

            foreach (DataTable table in dataset.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        Guna2HtmlLabel recipients = new Guna2HtmlLabel();
                        recipients.Text = item.ToString();
                        recipients.Font = new Font("SegoeUI", 10);
                        flowLayoutPanel1.Controls.Add(recipients);
                        //   hello += item + ", ";
                    }
                }
            }
        }

        private void loadLecturers()
        {
            MySqlCommand command = new MySqlCommand("SELECT lecturer_email FROM lecturer_info", databaseConnection);
            command.Connection = databaseConnection;
            DataSet dataset = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            adp.Fill(dataset);

            foreach (DataTable table in dataset.Tables)
            {
                foreach (DataRow row in table.Rows)
                {
                    foreach (object item in row.ItemArray)
                    {
                        Guna2HtmlLabel recipients = new Guna2HtmlLabel();
                        recipients.Text = item.ToString();
                        recipients.Font = new Font("SegoeUI", 10);
                        flowLayoutPanel1.Controls.Add(recipients);
                        //   hello += item + ", ";
                    }
                }
            }
        }

        private void Send_Email_Form_Load(object sender, EventArgs e)
        {
            if (trigger == "lecturers")
            {
                loadLecturers();
            }
            else
            {
                loadStudents();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            message_panel.Visible = false;
        }
    }
}
