using KDU_Time_Table_Management_System.Properties;
using KDU_TTMS.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Student_Profile : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Student_Profile()
        {
            InitializeComponent();
        }

        private string email;

        Student_Parent_Form stud_frm;

        public Student_Profile(string email, Student_Parent_Form mainFrm)
        {
            InitializeComponent();
            this.email = email;
            stud_frm = mainFrm;
        }

        public void getUserImage()
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select student_profile_pic from student_info WHERE student_email = '" + email + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                object value = dr["student_profile_pic"];

                if (value != DBNull.Value)
                {
                    String selectQuery = "SELECT student_profile_pic FROM student_info WHERE student_email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0]["student_profile_pic"];
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
            MySqlCommand getDetails = new MySqlCommand("Select student_reg_no,student_name,student_course_stream,student_email,student_mobile from student_info where student_email='" + email + "'", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(getDetails);
            databaseConnection.Close();
            DataTable table = new DataTable();
            da.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                reg_no.Text = row.Field<string>("student_reg_no");
                name.Text = row.Field<string>("student_name");
                name_top.Text = row.Field<string>("student_name");
                degree.Text = row.Field<string>("student_course_stream");
                email_lb.Text = row.Field<string>("student_email");
                email_top_lb.Text = row.Field<string>("student_email");
                mobile.Text = row.Field<Int32>("student_mobile").ToString();
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
                    cmd.CommandText = "UPDATE student_info SET student_profile_pic=@student_profile_pic WHERE student_email='" + email + "'";
                    MySqlParameter blob = new MySqlParameter("@student_profile_pic", MySqlDbType.Blob, ImageData.Length);
                    blob.Value = ImageData;
                    cmd.Parameters.Add(blob);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your profile icon has been updated!");
                    stud_frm.getUserImage();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
