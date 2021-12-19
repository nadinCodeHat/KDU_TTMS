using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Student_Parent_Form : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Student_Parent_Form()
        {
            InitializeComponent();
        }

        public string email;
        public Student_Parent_Form(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void LoadDashboard()
        {
            Student_Dashboard sd = new Student_Dashboard(email);
            User_Control_Class.showControl(sd, mid_panel);
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
                    String selectQuery = "select student_profile_pic from student_info WHERE student_email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0]["student_profile_pic"];
                    MemoryStream ms = new MemoryStream(img);
                    profile_icon.Image = Image.FromStream(ms);
                    da.Dispose();
                }
                else
                {
                    profile_icon.Image = Resources.default_profile_pic;
                }
                databaseConnection.Close();
            }
        }

        private void initializeUserInfo()
        {
            databaseConnection.Open();
            MySqlCommand adpt = new MySqlCommand("select student_name from student_info where student_email = '" + email + "'", databaseConnection);
            MySqlDataReader reader = adpt.ExecuteReader();

            while (reader.Read())
            {
                show_user_name.Text = reader["student_name"].ToString();
            }
            databaseConnection.Close();
        }

        private void Student_Main_Form_Load(object sender, EventArgs e)
        {
            initializeUserInfo();
            LoadDashboard();
            getUserImage();
        }

        private void timetable_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            timetable_btn.Checked = true;
            intake_btn.Checked = false;
            profile_btn.Checked = false;
            openView_Timetables(new Student_View_Timetables(email));
        }

        private Form activeForm_View_Timetables = null;
        private void openView_Timetables(Form view_timetables)
        {
            if (activeForm_View_Timetables != null) activeForm_View_Timetables.Close();
            activeForm_View_Timetables = view_timetables;
            view_timetables.TopLevel = false;
            view_timetables.FormBorderStyle = FormBorderStyle.None;
            view_timetables.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(view_timetables);
            mid_panel.Tag = view_timetables;
            view_timetables.BringToFront();
            view_timetables.Show();
        }

        private void intake_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            timetable_btn.Checked = false;
            intake_btn.Checked = true;
            profile_btn.Checked = false;
            openStudentIntake(new Student_Intake(email));
        }

        private Form activeForm_StudentIntake = null;
        private void openStudentIntake(Form student_intake)
        {
            if (activeForm_StudentIntake != null) activeForm_StudentIntake.Close();
            activeForm_StudentIntake = student_intake;
            student_intake.TopLevel = false;
            student_intake.FormBorderStyle = FormBorderStyle.None;
            student_intake.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(student_intake);
            mid_panel.Tag = student_intake;
            student_intake.BringToFront();
            student_intake.Show();
        }


        private void lecture_modules_btn_Click(object sender, EventArgs e)
        {

        }

        private void events_btn_Click(object sender, EventArgs e)
        {

        }
        private void profile_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            timetable_btn.Checked = false;
            intake_btn.Checked = false;
            profile_btn.Checked = true;
            openStudent_Profile(new Student_Profile(email, this));
        }

        private Form activeFormStudent_Profile = null;
        private void openStudent_Profile(Form stud_profile_frm)
        {
            if (activeFormStudent_Profile != null) activeFormStudent_Profile.Close();
            activeFormStudent_Profile = stud_profile_frm;
            stud_profile_frm.TopLevel = false;
            stud_profile_frm.FormBorderStyle = FormBorderStyle.None;
            stud_profile_frm.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(stud_profile_frm);
            mid_panel.Tag = stud_profile_frm;
            stud_profile_frm.BringToFront();
            stud_profile_frm.Show();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void Student_Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            new Thread(() => new Login_Form().ShowDialog()).Start();
            this.Dispose();
        }
    }
}
