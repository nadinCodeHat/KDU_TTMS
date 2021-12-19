using Guna.UI2.WinForms;
using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Student_Intake : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db;");

        public Student_Intake()
        {
            InitializeComponent();
        }

        private string email;
        public Student_Intake(string email)
        {
            this.email = email;
            InitializeComponent();
        }


        private void createPanel(DataRow dr)
        {
            Guna2Panel back_panel = new Guna2Panel();
            back_panel.BackColor = Color.White;
            back_panel.Size = new Size(250, 225);
            back_panel.Margin = new Padding(10, 37, 10, 10);
            back_panel.Padding = new Padding(5, 5, 5, 5);

            Guna2Panel top_panel = new Guna2Panel();
            top_panel.BackColor = Color.WhiteSmoke;
            top_panel.Dock = DockStyle.Top;
            top_panel.Size = new Size(240, 86);
            top_panel.ShadowDecoration.Depth = 5;
            top_panel.ShadowDecoration.Shadow = new Padding(3, 3, 3, 0);
            top_panel.ShadowDecoration.Enabled = true;

            Guna2Panel bottom_panel = new Guna2Panel();
            bottom_panel.BackColor = Color.WhiteSmoke;
            bottom_panel.Dock = DockStyle.Bottom;
            bottom_panel.Size = new Size(240, 127);
            bottom_panel.ShadowDecoration.Depth = 5;
            bottom_panel.ShadowDecoration.Shadow = new Padding(3, 0, 3, 3);
            bottom_panel.ShadowDecoration.Enabled = true;

            Guna2PictureBox profile_pic = new Guna2PictureBox();
            profile_pic.Size = new Size(60, 60);
            profile_pic.SizeMode = PictureBoxSizeMode.Zoom;
            profile_pic.Location = new Point(20, 13);
            profile_pic.Image = Resources.default_profile_pic;
            //Get profile pic
            //databaseConnection.Open();
            //MySqlCommand cmd = databaseConnection.CreateCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "select student_profile_pic from student_info WHERE student_reg_no = '" + dr["student_reg_no"].ToString() + "'";
            //cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            //sda.Fill(dt);
            //int i = dt.Rows.Count;
            //if (i > 0)
            //{
            //    String selectQuery = "SELECT student_profile_pic FROM student_info WHERE student_reg_no = '" + dr["student_reg_no"].ToString() + "'";
            //    MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);
            //    MySqlDataAdapter da = new MySqlDataAdapter(command);
            //    DataTable table = new DataTable();
            //    da.Fill(table);
            //    byte[] img = (byte[])table.Rows[0]["student_profile_pic"];
            //    MemoryStream ms = new MemoryStream(img);
            //    profile_pic.Image = Image.FromStream(ms);
            //   da.Dispose();
            //}
            //else
            //{
            //    profile_pic.Image = Resources.default_profile_pic;
            //}
            //databaseConnection.Close();
            //

            Guna2HtmlLabel student_name = new Guna2HtmlLabel();
            student_name.ForeColor = Color.Black;
            student_name.Font = new Font("Segoe UI Semibold", 10);
            student_name.Location = new Point(86, 21);
            student_name.Text = dr["student_name"].ToString();

            Guna2HtmlLabel index_no = new Guna2HtmlLabel();
            index_no.Font = new Font("Segoe UI", 10);
            index_no.ForeColor = Color.DimGray;
            index_no.Location = new Point(86, 46);
            index_no.Text = dr["student_reg_no"].ToString();

            Guna2PictureBox mail_pic = new Guna2PictureBox();
            mail_pic.Image = Resources.mail;
            mail_pic.Size = new Size(20, 20);
            mail_pic.SizeMode = PictureBoxSizeMode.Zoom;
            mail_pic.Location = new Point(40, 32);

            Guna2PictureBox phone_pic = new Guna2PictureBox();
            phone_pic.Image = Resources.phone;
            phone_pic.Size = new Size(20, 20);
            phone_pic.SizeMode = PictureBoxSizeMode.Zoom;
            phone_pic.Location = new Point(40, 71);

            Guna2HtmlLabel email = new Guna2HtmlLabel();
            email.ForeColor = Color.DimGray;
            email.Font = new Font("Segoe UI", 9);
            email.Location = new Point(69, 33);
            email.Text = dr["student_email"].ToString();

            Guna2HtmlLabel phone = new Guna2HtmlLabel();
            phone.ForeColor = Color.DimGray;
            phone.Font = new Font("Segoe UI", 9);
            phone.Location = new Point(69, 73);
            phone.Text = dr["student_mobile"].ToString();

            back_panel.Controls.Add(top_panel);
            back_panel.Controls.Add(bottom_panel);
            top_panel.Controls.Add(profile_pic);
            top_panel.Controls.Add(index_no);
            top_panel.Controls.Add(student_name);

            bottom_panel.Controls.Add(mail_pic);
            bottom_panel.Controls.Add(email);
            bottom_panel.Controls.Add(phone);
            bottom_panel.Controls.Add(phone_pic);

            students_layout.Controls.Add(back_panel);
        }

        private void LoadStudentsAll()
        {
            databaseConnection.Open();
            MySqlCommand getIntakeId = new MySqlCommand("Select intake_id from student_info where student_email='" + email + "'", databaseConnection);
            Int32 intake_id = Convert.ToInt32(getIntakeId.ExecuteScalar());

            MySqlCommand getStudents = new MySqlCommand("Select student_reg_no,student_name,student_course_stream,student_email,student_mobile from student_info where intake_id='" + intake_id + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getStudents);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            databaseConnection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                createPanel(dr);
            }
            Guna2Panel final_panel = new Guna2Panel();
            final_panel.BackColor = Color.White;
            final_panel.Margin = new Padding(10, 37, 10, 10);
            final_panel.Padding = new Padding(5, 5, 5, 5);
            final_panel.Size = new Size(1060, 25);

            students_layout.Controls.Add(final_panel);
        }

        private void LoadStudentsCS()
        {
            databaseConnection.Open();
            MySqlCommand getIntakeId = new MySqlCommand("Select intake_id from student_info where student_email='" + email + "'", databaseConnection);
            Int32 intake_id = Convert.ToInt32(getIntakeId.ExecuteScalar());

            MySqlCommand getStudents = new MySqlCommand("Select student_reg_no,student_name,student_course_stream,student_email,student_mobile from student_info where intake_id='" + intake_id + "' and student_course_stream ='" + "Computer Science" + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getStudents);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            databaseConnection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                createPanel(dr);
            }
            Guna2Panel final_panel = new Guna2Panel();
            final_panel.BackColor = Color.White;
            final_panel.Margin = new Padding(10, 37, 10, 10);
            final_panel.Padding = new Padding(5, 5, 5, 5);
            final_panel.Size = new Size(1060, 25);

            students_layout.Controls.Add(final_panel);
        }

        private void LoadStudentsCE()
        {
            databaseConnection.Open();
            MySqlCommand getIntakeId = new MySqlCommand("Select intake_id from student_info where student_email='" + email + "'", databaseConnection);
            Int32 intake_id = Convert.ToInt32(getIntakeId.ExecuteScalar());

            MySqlCommand getStudents = new MySqlCommand("Select student_reg_no,student_name,student_course_stream,student_email,student_mobile from student_info where intake_id='" + intake_id + "' and student_course_stream ='" + "Computer Engineering" + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getStudents);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            databaseConnection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                createPanel(dr);
            }
            Guna2Panel final_panel = new Guna2Panel();
            final_panel.BackColor = Color.White;
            final_panel.Margin = new Padding(10, 37, 10, 10);
            final_panel.Padding = new Padding(5, 5, 5, 5);
            final_panel.Size = new Size(1060, 25);

            students_layout.Controls.Add(final_panel);
        }

        private void LoadStudentsSE()
        {
            databaseConnection.Open();
            MySqlCommand getIntakeId = new MySqlCommand("Select intake_id from student_info where student_email='" + email + "'", databaseConnection);
            Int32 intake_id = Convert.ToInt32(getIntakeId.ExecuteScalar());

            MySqlCommand getStudents = new MySqlCommand("Select student_reg_no,student_name,student_course_stream,student_email,student_mobile from student_info where intake_id='" + intake_id + "' and student_course_stream ='" + "Software Engineering" + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getStudents);

            DataTable dt = new DataTable();
            sda.Fill(dt);
            databaseConnection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                createPanel(dr);
            }
            Guna2Panel final_panel = new Guna2Panel();
            final_panel.BackColor = Color.White;
            final_panel.Margin = new Padding(10, 37, 10, 10);
            final_panel.Padding = new Padding(5, 5, 5, 5);
            final_panel.Size = new Size(1060, 25);

            students_layout.Controls.Add(final_panel);
        }

        private void Student_Intake_Load(object sender, EventArgs e)
        {
            LoadStudentsAll();
        }

        private void all_btn_Click(object sender, EventArgs e)
        {
            all_btn.Checked = true;
            cs_btn.Checked = false;
            ce_btn.Checked = false;
            se_btn.Checked = false;
            students_layout.Controls.Clear();
            LoadStudentsAll();
        }

        private void cs_btn_Click(object sender, EventArgs e)
        {
            all_btn.Checked = false;
            cs_btn.Checked = true;
            ce_btn.Checked = false;
            se_btn.Checked = false;
            students_layout.Controls.Clear();
            LoadStudentsCS();
        }

        private void ce_btn_Click(object sender, EventArgs e)
        {
            all_btn.Checked = false;
            cs_btn.Checked = false;
            ce_btn.Checked = true;
            se_btn.Checked = false;
            students_layout.Controls.Clear();
            LoadStudentsCE();
        }

        private void se_btn_Click(object sender, EventArgs e)
        {
            all_btn.Checked = false;
            cs_btn.Checked = false;
            ce_btn.Checked = false;
            se_btn.Checked = true;
            students_layout.Controls.Clear();
            LoadStudentsSE();
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
