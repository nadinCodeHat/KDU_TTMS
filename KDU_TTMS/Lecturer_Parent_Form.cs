using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Lecturer_Parent_Form : Form
    {

        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Lecturer_Parent_Form()
        {
            InitializeComponent();
        }

        public string email;
        public Lecturer_Parent_Form(string email)
        {
            this.email = email;
            InitializeComponent();
        }

        private void LoadDashboard()
        {
            Lecturer_Dashboard ld = new Lecturer_Dashboard(email);
            User_Control_Class.showControl(ld, mid_panel);
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
                    String selectQuery = "select lecturer_profile_pic from lecturer_info WHERE lecturer_email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0]["lecturer_profile_pic"];
                    MemoryStream ms = new MemoryStream(img);
                    // profile_icon.Image = Image.FromStream(ms);
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
            MySqlCommand adpt = new MySqlCommand("select lecturer_name from lecturer_info where lecturer_email = '" + email + "'", databaseConnection);
            MySqlDataReader reader = adpt.ExecuteReader();

            while (reader.Read())
            {
                show_user_name.Text = reader["lecturer_name"].ToString();
            }
            databaseConnection.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            new Thread(() => new Login_Form().ShowDialog()).Start();
            this.Dispose();
        }

        private void Lecturer_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Lecturer_Parent_Form_Load(object sender, EventArgs e)
        {
            LoadDashboard();
            initializeUserInfo();
            getUserImage();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            LoadDashboard();
            dashboard_btn.Checked = true;
            timetable_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;

        }

        private void manage_lecturers_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            timetable_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = true;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;

            openStudentIntake(new Contact_Lecturers());
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

        private void manage_students_btn_Click(object sender, EventArgs e)
        {

            dashboard_btn.Checked = false;
            timetable_btn.Checked = false;
            manage_students_btn.Checked = true;
            manage_lecturers_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            openStudents(new Lecturer_View_Students());
        }

        private Form activeformstud = null;
        private void openStudents(Form ttbs)
        {
            if (activeformstud != null) activeformstud.Close();
            activeformstud = ttbs;
            ttbs.TopLevel = false;
            ttbs.FormBorderStyle = FormBorderStyle.None;
            ttbs.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(ttbs);
            mid_panel.Tag = ttbs;
            ttbs.BringToFront();
            ttbs.Show();
        }

        private void timetable_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            timetable_btn.Checked = true;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            openViewttbs(new Lecturer_View_Timetables());
        }

        private Form activeForm_ttbs = null;
        private void openViewttbs(Form ttbs)
        {
            if (activeForm_ttbs != null) activeForm_ttbs.Close();
            activeForm_ttbs = ttbs;
            ttbs.TopLevel = false;
            ttbs.FormBorderStyle = FormBorderStyle.None;
            ttbs.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(ttbs);
            mid_panel.Tag = ttbs;
            ttbs.BringToFront();
            ttbs.Show();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            timetable_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = true;
            openStudent_Profile(new Lecturer_Profile_Form(email, this));
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

        private void lecture_halls_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            timetable_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            lecture_halls_btn.Checked = true;
            profile_btn.Checked = false;
            openlecturehall_management_Form(new Check_LectureHalls());
        }

        private Form activeFormLectureHallManagement_Form = null;
        private void openlecturehall_management_Form(Form lecturehall_manage_frm)
        {
            if (activeFormLectureHallManagement_Form != null) activeFormLectureHallManagement_Form.Close();
            activeFormLectureHallManagement_Form = lecturehall_manage_frm;
            lecturehall_manage_frm.TopLevel = false;
            lecturehall_manage_frm.FormBorderStyle = FormBorderStyle.None;
            lecturehall_manage_frm.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(lecturehall_manage_frm);
            mid_panel.Tag = lecturehall_manage_frm;
            lecturehall_manage_frm.BringToFront();
            lecturehall_manage_frm.Show();
        }
    }
}
