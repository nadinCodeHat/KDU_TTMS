using Guna.UI2.WinForms;
using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Student_View_Lecturers : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Student_View_Lecturers()
        {
            InitializeComponent();
        }

        private void getLecturers()
        {
            databaseConnection.Open();
            MySqlCommand cmd = databaseConnection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select lecturer_name,lecturer_email,lecturer_mobile,lecturer_profile_pic from lecturer_info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                Guna2Panel panel = new Guna2Panel();
                panel.Size = new Size(1053, 100);
                Guna2HtmlLabel lecturer_name = new Guna2HtmlLabel();
                lecturer_name.Text = row["lecturer_name"].ToString();
                lecturer_name.Location = new Point(126, 22);

                Guna2HtmlLabel email = new Guna2HtmlLabel();
                email.Text = "Email";
                email.Location = new Point(126, 64);
                Guna2HtmlLabel mobile = new Guna2HtmlLabel();
                mobile.Text = "Mobile Number";
                mobile.Location = new Point(333, 64);

                LinkLabel email_address = new LinkLabel();
                email_address.Text = row["lecturer_email"].ToString();
                email_address.Location = new Point(160, 64);

                LinkLabel mobile_number = new LinkLabel();
                mobile_number.Text = row["lecturer_mobile"].ToString();
                mobile_number.Location = new Point(413, 64);

                Guna2PictureBox profile_pic = new Guna2PictureBox();
                profile_pic.Size = new Size(100, 100);
                profile_pic.SizeMode = PictureBoxSizeMode.Zoom;
                profile_pic.Dock = DockStyle.Left;
                profile_pic.Image = Resources.default_profile_pic;
                //if (string.IsNullOrEmpty(row["lecturer_profile_pic"].ToString()))
                //{
                //    profile_pic.Image = Resources.download__1_;
                //}
                //else
                //{
                //    byte[] img = (byte[])row["lecturer_profile_pic"];
                //    MemoryStream ms = new MemoryStream(img);
                //    Image imgs = Image.FromStream(ms);
                //    profile_pic.Image = imgs;
                //}

                panel.Controls.Add(lecturer_name);
                panel.Controls.Add(email);
                panel.Controls.Add(mobile);
                panel.Controls.Add(email_address);
                panel.Controls.Add(mobile_number);
                panel.Controls.Add(profile_pic);

                flowLayoutPanel1.Controls.Add(panel);
            }
        }




        private void Student_View_Lecturers_Load(object sender, EventArgs e)
        {
            getLecturers();
        }
    }
}
