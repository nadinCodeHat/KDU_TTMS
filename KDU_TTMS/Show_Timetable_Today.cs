using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Show_Timetable_Today : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Show_Timetable_Today()
        {
            InitializeComponent();
        }
        private string email;

        public Show_Timetable_Today(string email)
        {
            this.email = email;
            InitializeComponent();
        }
        private void createSlot(DataRow dr)
        {
            Guna2Panel top_panel = new Guna2Panel();
            top_panel.BackColor = Color.White;
            top_panel.ShadowDecoration.Color = Color.Black;
            top_panel.ShadowDecoration.Depth = 5;
            top_panel.ShadowDecoration.Enabled = true;
            top_panel.ShadowDecoration.Shadow = new Padding(5, 5, 5, 5);
            top_panel.Size = new Size(1007, 45);

            Guna2Panel lecture_panel = new Guna2Panel();
            lecture_panel.BackColor = Color.White;
            lecture_panel.ShadowDecoration.Color = Color.Black;
            lecture_panel.ShadowDecoration.Depth = 5;
            lecture_panel.ShadowDecoration.Enabled = true;
            lecture_panel.ShadowDecoration.Shadow = new Padding(5, 5, 5, 5);
            lecture_panel.Size = new Size(1007, 90);

            Guna2HtmlLabel time_slot = new Guna2HtmlLabel();
            time_slot.Text = dr["time_slot"].ToString();
            time_slot.Font = new Font("Segoe UI", 14);
            time_slot.ForeColor = Color.DimGray;
            time_slot.Location = new Point(13, 9);

            Guna2HtmlLabel str = new Guna2HtmlLabel();
            str.Text = "Strength - " + dr["strength"].ToString();
            str.Font = new Font("Segoe UI", 12);
            str.ForeColor = Color.DimGray;
            str.Location = new Point(717, 11);

            Guna2HtmlLabel credit = new Guna2HtmlLabel();
            credit.Text = dr["credit"].ToString() + " Credit";
            credit.Font = new Font("Segoe UI", 12);
            credit.ForeColor = Color.DimGray;
            credit.Location = new Point(837, 11);

            Guna2HtmlLabel module_type = new Guna2HtmlLabel();
            module_type.Text = dr["module_type"].ToString();
            module_type.Font = new Font("Segoe UI", 12);
            module_type.ForeColor = Color.DimGray;
            module_type.Location = new Point(920, 11);

            Guna2HtmlLabel gpa_type = new Guna2HtmlLabel();
            gpa_type.Text = dr["gpatype"].ToString();
            gpa_type.Font = new Font("Segoe UI", 12);
            gpa_type.ForeColor = Color.DimGray;
            gpa_type.Location = new Point(958, 11);

            Guna2HtmlLabel lecture_abbr = new Guna2HtmlLabel();
            lecture_abbr.Text = dr["lecture_abbr"].ToString();
            lecture_abbr.Font = new Font("Segoe UI Semibold", 18);
            lecture_abbr.ForeColor = Color.FromArgb(100, 88, 255);
            lecture_abbr.Location = new Point(13, 14);

            Guna2HtmlLabel lecture_module = new Guna2HtmlLabel();
            lecture_module.Text = dr["lecture_module"].ToString();
            lecture_module.Font = new Font("Segoe UI", 12);
            lecture_module.ForeColor = Color.FromArgb(100, 88, 255);
            lecture_module.Location = new Point(13, 54);

            Guna2HtmlLabel lecturer = new Guna2HtmlLabel();
            lecturer.Text = dr["lecturer"].ToString();
            lecturer.Font = new Font("Segoe UI Semibold", 12);
            lecturer.ForeColor = Color.DimGray;
            lecturer.Location = new Point(661, 14);

            Guna2HtmlLabel lecture_code = new Guna2HtmlLabel();
            lecture_code.Text = dr["lecture_code"].ToString();
            lecture_code.Font = new Font("Segoe UI", 12);
            lecture_code.ForeColor = Color.Orange;
            lecture_code.Location = new Point(666, 54);

            Guna2HtmlLabel lecture_hall = new Guna2HtmlLabel();
            lecture_hall.Text = "Lecture Hall :- " + dr["lecture_hall"].ToString();
            lecture_hall.AutoSize = false;
            lecture_hall.Size = new Size(155, 23);
            lecture_hall.TextAlignment = ContentAlignment.MiddleRight;
            lecture_hall.Font = new Font("Segoe UI", 12);
            lecture_hall.ForeColor = Color.Tomato;
            lecture_hall.Location = new Point(836, 54);

            top_panel.Controls.Add(time_slot);
            top_panel.Controls.Add(str);
            top_panel.Controls.Add(credit);
            top_panel.Controls.Add(module_type);
            top_panel.Controls.Add(gpa_type);

            today_all_slots.Controls.Add(top_panel);

            lecture_panel.Controls.Add(lecture_abbr);
            lecture_panel.Controls.Add(lecture_module);
            lecture_panel.Controls.Add(lecturer);
            lecture_panel.Controls.Add(lecture_code);
            lecture_panel.Controls.Add(lecture_hall);

            today_all_slots.Controls.Add(lecture_panel);
        }

        private DataTable dt = new DataTable();
        //  Timetable for this week
        private void getTimetable_ForToday()
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT intake_id FROM student_info where student_email = '" + email + "'", databaseConnection);
            Int32 intake_id = Convert.ToInt32(cmd.ExecuteScalar());

            string today = DateTime.Now.ToString("yyyy-MM-dd");

            MySqlCommand sem = new MySqlCommand("Select timetable_id from ttms_timetable_main where intake_id='" + intake_id + "' AND validity_period_start <= '" + today + "' AND validity_period_end >= '" + today + "'", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(sem);

            string day_name = DateTime.Now.DayOfWeek.ToString().ToUpper();
            dayname.Text = day_name;

            date_today.Text = DateTime.Now.ToString("dd.MM.yyyy");

            da.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataTable dt_lec = new DataTable();
                    MySqlCommand lec_mod = new MySqlCommand("Select ttms_lecture_module.time_slot,ttms_lecture_module.lecture_abbr,module_info.lecture_module,ttms_lecture_module.strength,ttms_lecture_module.lecture_hall,ttms_lecture_module.lecturer,ttms_lecture_module.lecture_code,module_info.credit,module_info.gpatype,module_info.module_type from ttms_lecture_module inner join module_info on ttms_lecture_module.lecture_code = module_info.lecture_code where ttms_lecture_module.timetable_id='" + dt.Rows[0]["timetable_id"] + "' AND ttms_lecture_module.day='" + day_name + "' order by ttms_lecture_module.time_slot", databaseConnection);
                    MySqlDataAdapter adap = new MySqlDataAdapter(lec_mod);
                    adap.Fill(dt_lec);
                    foreach (DataRow dr in dt_lec.Rows)
                    {
                        createSlot(dr);
                    }
                }
                else
                {
                    no_timetable_pn1.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("No Timetable");
            }
            databaseConnection.Close();
        }

        private void Show_Timetable_Today_Load(object sender, EventArgs e)
        {
            getTimetable_ForToday();
        }
    }
}
