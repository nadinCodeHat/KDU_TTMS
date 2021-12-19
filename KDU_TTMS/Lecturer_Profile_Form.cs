using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Lecturer_Profile_Form : Form
    {
        public Lecturer_Profile_Form()
        {
            InitializeComponent();
        }

        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");


        private string email;

        Lecturer_Parent_Form lect_frm;

        public Lecturer_Profile_Form(string email, Lecturer_Parent_Form mainFrm)
        {
            InitializeComponent();
            this.email = email;
            lect_frm = mainFrm;
        }

        public void getUserImage()
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select lecturer_profile_pic from lecturer_info WHERE lecturer_email = '" + email + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                object value = dr["lecturer_profile_pic"];

                if (value != DBNull.Value)
                {
                    String selectQuery = "SELECT lecturer_profile_pic FROM lecturer_info WHERE lecturer_email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0]["lecturer_profile_pic"];
                    MemoryStream ms = new MemoryStream(img);
                    profile_pic.Image = Image.FromStream(ms);
                    da.Dispose();
                }
                else
                {
                    profile_pic.Image = Resources.default_profile_pic;
                }
            }
            databaseConnection.Close();
        }


        private void getStudentProfileDetails()
        {
            databaseConnection.Open();
            MySqlCommand getDetails = new MySqlCommand("Select lecturer_id,lecturer_name,lecturer_email,lecturer_mobile from lecturer_info where lecturer_email='" + email + "'", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(getDetails);
            databaseConnection.Close();
            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                reg_no.Text = row.Field<string>("lecturer_id");
                name.Text = row.Field<string>("lecturer_name");
                name_top.Text = row.Field<string>("lecturer_name");
                email_lb.Text = row.Field<string>("lecturer_email");
                email_top_lb.Text = row.Field<string>("lecturer_email");
                mobile.Text = row.Field<Int32>("lecturer_mobile").ToString();
            }
        }

        private void Student_Profile_Load(object sender, EventArgs e)
        {
            getUserImage();
            getStudentProfileDetails();
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
                    cmd.CommandText = "UPDATE lecturer_info SET lecturer_profile_pic=@lecturer_profile_pic WHERE lecturer_email='" + email + "'";
                    MySqlParameter blob = new MySqlParameter("@lecturer_profile_pic", MySqlDbType.Blob, ImageData.Length);
                    blob.Value = ImageData;
                    cmd.Parameters.Add(blob);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your profile icon has been updated!");
                    lect_frm.getUserImage();
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
