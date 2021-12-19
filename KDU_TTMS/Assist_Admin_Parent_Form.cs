using Guna.UI2.WinForms;
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
    public partial class Assist_Admin_Parent_Form : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        private string email, accountType;
        private bool enablePriviledges;

        public Assist_Admin_Parent_Form()
        {
            InitializeComponent();
        }

        public void customizeDesgin()
        {
            timetable_panel_submenu.Visible = false;
        }

        private void hideAllSubMenus()
        {
            if (timetable_panel_submenu.Visible == true)
                timetable_panel_submenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideAllSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }

        }
        string real;
        public Assist_Admin_Parent_Form(string getEmail, string getAccountType, bool getPriviledges, string real)
        {
            email = getEmail;
            accountType = getAccountType;
            enablePriviledges = getPriviledges;
            this.real = real;
            InitializeComponent();
        }

        //User Control Dashboard
        static Assist_Admin_Parent_Form _obj;

        public static Assist_Admin_Parent_Form Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Assist_Admin_Parent_Form();
                }
                return _obj;
            }
        }

        public Guna2Panel PnlContainer
        {
            get { return mid_panel; }
            set { mid_panel = value; }
        }

        public Guna2TileButton BackButton
        {
            get { return go_back_btn; }
            set { go_back_btn = value; }
        }

        private void LoadDashboard()
        {
            go_back_btn.Visible = false;
            _obj = this;

            Assist_Admin_DashBoard vtt = new Assist_Admin_DashBoard(email, accountType, enablePriviledges, real);
            vtt.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(vtt);
        }

        private void go_back_btn_Click(object sender, EventArgs e)
        {
            if (!mid_panel.Controls.Contains(Assist_Admin_DashBoard.Instance))
            {
                mid_panel.Controls.Add(Assist_Admin_DashBoard.Instance);
                Assist_Admin_DashBoard.Instance.Dock = DockStyle.Fill;
                Assist_Admin_DashBoard.Instance.BringToFront();
            }
            else
            {
                Assist_Admin_DashBoard.Instance.BringToFront();

            }
            go_back_btn.Visible = false;
        }

        ///////////////////////////////
        private void getPriviledges()
        {
            if (enablePriviledges == true)
            {
                manage_assistants_btn.Visible = true;
                Assist_Admin_Parent_Form.ActiveForm.Text = "Time Table Management System 1.0.1 - Administator";
                title.Text = "KDU - TTMS ADMIN";
            }
            else
            {
                manage_assistants_btn.Visible = false;
                Assist_Admin_Parent_Form.ActiveForm.Text = "Time Table Management System 1.0.1 - Assistant";
                title.Text = "KDU - TTMS ASSISTANT";
            }
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
            foreach (DataRow dr in dt.Rows)
            {
                object value = dr["assistant_profile_pic"];

                if (value != DBNull.Value)
                {
                    String selectQuery = "SELECT assistant_profile_pic FROM assistant_info WHERE assistant_email = '" + email + "'";
                    MySqlCommand command = new MySqlCommand(selectQuery, databaseConnection);
                    MySqlDataAdapter da = new MySqlDataAdapter(command);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    byte[] img = (byte[])table.Rows[0]["assistant_profile_pic"];
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
            MySqlCommand adpt = new MySqlCommand("select assistant_name,status from assistant_info where assistant_email = '" + email + "'", databaseConnection);
            MySqlDataReader reader = adpt.ExecuteReader();

            while (reader.Read())
            {
                show_user_name.Text = reader["assistant_name"].ToString();
                status.Text = reader["status"].ToString();

            }
            databaseConnection.Close();
        }

        private void Assistant_New_Main_Load(object sender, EventArgs e)
        {
            initializeUserInfo();
            getPriviledges();
            LoadDashboard();
            getUserImage();
            hideAllSubMenus();
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            if (!mid_panel.Controls.Contains(Assist_Admin_DashBoard.Instance))
            {
                mid_panel.Controls.Add(Assist_Admin_DashBoard.Instance);
                Assist_Admin_DashBoard.Instance.Dock = DockStyle.Fill;
                Assist_Admin_DashBoard.Instance.BringToFront();
            }
            else
            {
                Assist_Admin_DashBoard.Instance.BringToFront();

            }
            LoadDashboard();

            dashboard_btn.Checked = true;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            hideAllSubMenus();
        }

        private void timetable_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            showSubMenu(timetable_panel_submenu);
        }

        private void add_timetable_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = true;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            openadd_timetable_Form(new Assist_Admin_Add_TT_Form());

        }

        private Form activeFormAdd_timetableForm = null;
        private void openadd_timetable_Form(Form add_timetable)
        {
            if (activeFormAdd_timetableForm != null) activeFormAdd_timetableForm.Close();
            activeFormAdd_timetableForm = add_timetable;
            add_timetable.TopLevel = false;
            add_timetable.FormBorderStyle = FormBorderStyle.None;
            add_timetable.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(add_timetable);
            mid_panel.Tag = add_timetable;
            add_timetable.BringToFront();
            add_timetable.Show();
        }

        private void view_timetables_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = true;
            manage_students_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            openview_timetables_Form(new View_Timetables());

        }

        private Form activeFormView_TimetableForm = null;
        private void openview_timetables_Form(Form view_timetables)
        {
            if (activeFormView_TimetableForm != null) activeFormView_TimetableForm.Close();
            activeFormView_TimetableForm = view_timetables;
            view_timetables.TopLevel = false;
            view_timetables.FormBorderStyle = FormBorderStyle.None;
            view_timetables.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(view_timetables);
            mid_panel.Tag = view_timetables;
            view_timetables.BringToFront();
            view_timetables.Show();
        }

        private void manage_students_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = true;
            manage_lecturers_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            hideAllSubMenus();
            openManage_Students_Form(new Manage_Students());
        }

        private Form activeFormManage_Students_Form = null;
        private void openManage_Students_Form(Form manage_students_frm)
        {
            if (activeFormManage_Students_Form != null) activeFormManage_Students_Form.Close();
            activeFormManage_Students_Form = manage_students_frm;
            manage_students_frm.TopLevel = false;
            manage_students_frm.FormBorderStyle = FormBorderStyle.None;
            manage_students_frm.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(manage_students_frm);
            mid_panel.Tag = manage_students_frm;
            manage_students_frm.BringToFront();
            manage_students_frm.Show();
        }

        private void manage_lecturers_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = true;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            hideAllSubMenus();
            openManage_Lecturers_Form(new Manage_Lecturers());
        }

        private Form activeFormManage_Lecturers_Form = null;
        private void openManage_Lecturers_Form(Form manage_lecturers_frm)
        {
            if (activeFormManage_Lecturers_Form != null) activeFormManage_Lecturers_Form.Close();
            activeFormManage_Lecturers_Form = manage_lecturers_frm;
            manage_lecturers_frm.TopLevel = false;
            manage_lecturers_frm.FormBorderStyle = FormBorderStyle.None;
            manage_lecturers_frm.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(manage_lecturers_frm);
            mid_panel.Tag = manage_lecturers_frm;
            manage_lecturers_frm.BringToFront();
            manage_lecturers_frm.Show();
        }

        private void manage_assistants_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            manage_assistants_btn.Checked = true;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            hideAllSubMenus();
            openManage_Assistants_Form(new Manage_Assistants());
        }

        private Form activeFormManage_Assistants_Form = null;
        private void openManage_Assistants_Form(Form manage_assistants_form)
        {
            if (activeFormManage_Assistants_Form != null) activeFormManage_Assistants_Form.Close();
            activeFormManage_Assistants_Form = manage_assistants_form;
            manage_assistants_form.TopLevel = false;
            manage_assistants_form.FormBorderStyle = FormBorderStyle.None;
            manage_assistants_form.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(manage_assistants_form);
            mid_panel.Tag = manage_assistants_form;
            manage_assistants_form.BringToFront();
            manage_assistants_form.Show();
        }
        private void intake_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = true;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            hideAllSubMenus();
            openMA_Intake_Form(new Assist_Admin_Intake_Form());
        }

        private Form activeFormMA_Intake_Form = null;
        private void openMA_Intake_Form(Form CreateGroup_New_Form)
        {
            if (activeFormMA_Intake_Form != null) activeFormMA_Intake_Form.Close();
            activeFormMA_Intake_Form = CreateGroup_New_Form;
            CreateGroup_New_Form.TopLevel = false;
            CreateGroup_New_Form.FormBorderStyle = FormBorderStyle.None;
            CreateGroup_New_Form.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(CreateGroup_New_Form);
            mid_panel.Tag = CreateGroup_New_Form;
            CreateGroup_New_Form.BringToFront();
            CreateGroup_New_Form.Show();
        }

        private void lecture_halls_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = true;
            profile_btn.Checked = false;
            hideAllSubMenus();
            openlecturehall_management_Form(new Manage_LectureHalls());
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

        private void lecture_modules_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = true;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = false;
            hideAllSubMenus();
            openlecture_management_Form(new Lecture_Management_Form());
        }

        private Form activeFormLectureManagement_Form = null;
        private void openlecture_management_Form(Form add_timetable)
        {
            if (activeFormLectureManagement_Form != null) activeFormLectureManagement_Form.Close();
            activeFormLectureManagement_Form = add_timetable;
            add_timetable.TopLevel = false;
            add_timetable.FormBorderStyle = FormBorderStyle.None;
            add_timetable.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(add_timetable);
            mid_panel.Tag = add_timetable;
            add_timetable.BringToFront();
            add_timetable.Show();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {
            dashboard_btn.Checked = false;
            add_timetable_btn.Checked = false;
            view_timetables_btn.Checked = false;
            manage_students_btn.Checked = false;
            manage_lecturers_btn.Checked = false;
            manage_assistants_btn.Checked = false;
            intake_btn.Checked = false;
            lecture_modules_btn.Checked = false;
            lecture_halls_btn.Checked = false;
            profile_btn.Checked = true;
            hideAllSubMenus();
            openMA_Profile_Form(new Assist_Admin_Profile(email, this, accountType));
        }

        private Form activeFormMA_Profile_Form = null;
        private void openMA_Profile_Form(Form MA_Profile_Form)
        {
            if (activeFormMA_Profile_Form != null) activeFormMA_Profile_Form.Close();
            activeFormMA_Profile_Form = MA_Profile_Form;
            MA_Profile_Form.TopLevel = false;
            MA_Profile_Form.FormBorderStyle = FormBorderStyle.None;
            MA_Profile_Form.Dock = DockStyle.Fill;
            mid_panel.Controls.Add(MA_Profile_Form);
            mid_panel.Tag = MA_Profile_Form;
            MA_Profile_Form.BringToFront();
            MA_Profile_Form.Show();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            new Thread(() => new Login_Form().ShowDialog()).Start();
            this.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
