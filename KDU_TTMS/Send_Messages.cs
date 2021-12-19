using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Send_Messages : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Send_Messages()
        {
            InitializeComponent();
        }

        private string accountType;
        public Send_Messages(string accountType)
        {
            this.accountType = accountType;
            InitializeComponent();
        }


        private void loadMessages()
        {
            if (accountType == "Administrator")
            {
                databaseConnection.Open();
                MySqlCommand getmessages = new MySqlCommand("select message from messages where sender= '" + "Administrator" + "'", databaseConnection);
                MySqlDataAdapter sda = new MySqlDataAdapter(getmessages);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        message_listbox.Items.Add(">> Administrator: " + dr["message"].ToString());
                    }
                }
                else
                {
                    message_listbox.Items.Add("You haven't sent any messages yet");
                }
                databaseConnection.Close();
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand getmessages = new MySqlCommand("select message from messages where sender= '" + "Assistant" + "'", databaseConnection);
                MySqlDataAdapter sda = new MySqlDataAdapter(getmessages);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        message_listbox.Items.Add(">> Assistant: " + dr["message"].ToString());
                    }
                }
                else
                {
                    message_listbox.Items.Add("You haven't sent any messages yet");
                }
                databaseConnection.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (send_message_text.Text != null)
            {
                message_listbox.Items.Clear();
                if (accountType == "Administrator")
                {
                    databaseConnection.Open();
                    MySqlCommand send_message = new MySqlCommand(@"INSERT INTO messages(sender,reciever,message) VALUES(@sender,@reciever,@message)", databaseConnection);
                    send_message.Parameters.AddWithValue("@sender", "Administrator");
                    send_message.Parameters.AddWithValue("@reciever", "Assistant");
                    send_message.Parameters.AddWithValue("@message", send_message_text.Text);
                    send_message.ExecuteNonQuery();
                    databaseConnection.Close();
                }
                else
                {
                    databaseConnection.Open();
                    MySqlCommand send_message = new MySqlCommand(@"INSERT INTO messages(sender,reciever,message) VALUES(@sender,@reciever,@message)", databaseConnection);
                    send_message.Parameters.AddWithValue("@sender", "Assistant");
                    send_message.Parameters.AddWithValue("@reciever", "Administrator");
                    send_message.Parameters.AddWithValue("@message", send_message_text.Text);
                    send_message.ExecuteNonQuery();
                    databaseConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please type a message to send");
            }
            loadMessages();

        }

        private void Send_Messages_Load(object sender, EventArgs e)
        {
            loadMessages();
        }
    }
}
