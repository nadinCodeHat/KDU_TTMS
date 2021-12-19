using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Assist_Admin_Profile : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Assist_Admin_Profile()
        {
            InitializeComponent();
        }

        private string email, accountType;
        Assist_Admin_Parent_Form ths;

        public Assist_Admin_Profile(string email, Assist_Admin_Parent_Form mainFrm, string accountType)
        {
            InitializeComponent();
            this.email = email;
            ths = mainFrm;
            this.accountType = accountType;
        }

        public void getUserImage()
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select assistant_profile_pic from assistant_info WHERE assistant_email = '" + email + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            int i = dt.Rows.Count;
            if (i > 0)
            {
                String selectQuery = "SELECT assistant_profile_pic FROM assistant_info WHERE assistant_email = '" + email + "'";
                MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);
                MySqlDataAdapter da = new MySqlDataAdapter(command);
                DataTable table = new DataTable();
                da.Fill(table);
                byte[] img = (byte[])table.Rows[0]["assistant_profile_pic"];
                MemoryStream ms = new MemoryStream(img);
                profile_pic.Image = Image.FromStream(ms);
                da.Dispose();
            }
            else
            {
                profile_pic.Image = Resources.default_profile_pic;
            }
            databaseConnection.Close();
        }


        private void getAdmin_Assistant_ProfileDetails()
        {
            MySqlDataAdapter da;
            DataTable table = new DataTable();
            databaseConnection.Open();
            if (accountType == "Assistant")
            {
                MySqlCommand getDetails = new MySqlCommand("Select assistant_name,gender,priviledges,assistant_email,assistant_mobile from assistant_info where assistant_email='" + email + "'", databaseConnection);
                da = new MySqlDataAdapter(getDetails);
                da.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    name.Text = row.Field<string>("assistant_name");
                    name_top.Text = row.Field<string>("assistant_name");
                    gender.Text = row.Field<string>("gender");
                    priviledges.Text = row.Field<string>("priviledges");
                    email_lb.Text = row.Field<string>("assistant_email");
                    email_top_lb.Text = row.Field<string>("assistant_email");
                    mobile.Text = row.Field<Int32>("assistant_mobile").ToString();
                }
            }
            else
            {
                MySqlCommand getDetails = new MySqlCommand("Select admin_name,gender,admin_email,admin_mobile from admin_info where admin_email='" + email + "'", databaseConnection);
                da = new MySqlDataAdapter(getDetails);
                da.Fill(table);
                foreach (DataRow row in table.Rows)
                {
                    name.Text = row.Field<string>("admin_name");
                    name_top.Text = row.Field<string>("admin_name");
                    gender.Text = row.Field<string>("gender");
                    priviledges.Text = "Administrator";
                    email_lb.Text = row.Field<string>("admin_email");
                    email_top_lb.Text = row.Field<string>("admin_email");
                    mobile.Text = row.Field<Int32>("admin_mobile").ToString();
                }
            }
            databaseConnection.Close();
        }

        private void Profile_Form_Load(object sender, EventArgs e)
        {
            getUserImage();
            getAdmin_Assistant_ProfileDetails();
        }
        //  private boolicked = false;

        private void profile_pic_MouseEnter(object sender, EventArgs e)
        {
            profile_pic.Image = Resources.edit;
        }

        private void profile_pic_MouseLeave(object sender, EventArgs e)
        {
            getUserImage();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Do you wish to delete your profile icon", "Remove profile icon", buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                profile_pic.Image = Resources.default_profile_pic;
            }
            else
            {

            }
        }

        private void profile_pic_Click(object sender, EventArgs e)
        {
            OpenFileDialog opn = new OpenFileDialog();
            opn.Filter = "Choose Image(*.jpg; *.png; *.jpeg)|*.jpg; *.png; *.jpeg";
            opn.Multiselect = false;
            if (opn.ShowDialog() == DialogResult.OK)
            {
                profile_pic.Image = Image.FromFile(opn.FileName);
                try
                {
                    MemoryStream ms = new MemoryStream();
                    profile_pic.Image.Save(ms, profile_pic.Image.RawFormat);
                    byte[] ImageData = ms.ToArray();
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("", databaseConnection);
                    cmd.CommandText = "UPDATE assistant_info SET assistant_profile_pic=@assistant_profile_pic WHERE assistant_email='" + email + "'";
                    MySqlParameter blob = new MySqlParameter("@assistant_profile_pic", MySqlDbType.Blob, ImageData.Length);
                    blob.Value = ImageData;
                    cmd.Parameters.Add(blob);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your profile icon has been updated!");
                    ths.getUserImage();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
