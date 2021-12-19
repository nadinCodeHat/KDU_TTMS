using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Show_Weekly_Timetable : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Show_Weekly_Timetable()
        {
            InitializeComponent();
        }

        private string email;
        private string getType;
        public Show_Weekly_Timetable(string email, string getType)
        {
            this.email = email;
            this.getType = getType;
            InitializeComponent();
        }

        private void createSlot(FlowLayoutPanel control_panel_slot, DataRow dr, int lay, int lcy, int lecty, int lhy, int height)
        {
            Guna2Panel panel_slot = new Guna2Panel();
            panel_slot.BackColor = Color.White;
            panel_slot.ShadowDecoration.Color = Color.Black;
            panel_slot.ShadowDecoration.Depth = 5;
            panel_slot.ShadowDecoration.Enabled = true;
            panel_slot.ShadowDecoration.Shadow = new Padding(10, 10, 10, 10);
            panel_slot.Size = new Size(204, height);

            Guna2HtmlLabel lecture_abbr = new Guna2HtmlLabel();
            lecture_abbr.Text = dr["lecture_abbr"].ToString();
            lecture_abbr.Font = new Font("Segoe UI Semibold", 12);
            lecture_abbr.ForeColor = Color.FromArgb(100, 88, 255);
            lecture_abbr.Location = new Point(10, lay);

            Guna2HtmlLabel lecture_code = new Guna2HtmlLabel();
            lecture_code.Text = dr["lecture_code"].ToString();
            lecture_code.Font = new Font("Segoe UI", 9);
            lecture_code.ForeColor = Color.Orange;
            lecture_code.Location = new Point(153, lcy);

            Guna2HtmlLabel lecture_hall = new Guna2HtmlLabel();
            lecture_hall.Text = "Lecture Hall :- " + dr["lecture_hall"].ToString();
            lecture_hall.AutoSize = false;
            lecture_hall.Size = new Size(194, 17);
            lecture_hall.TextAlignment = ContentAlignment.MiddleRight;
            lecture_hall.Font = new Font("Segoe UI", 9);
            lecture_hall.ForeColor = Color.Tomato;
            lecture_hall.Location = new Point(0, lhy);

            Guna2HtmlLabel lecturer = new Guna2HtmlLabel();
            lecturer.Text = dr["lecturer"].ToString();
            lecturer.Font = new Font("Segoe UI Semibold", 7);
            lecturer.ForeColor = Color.DimGray;
            lecturer.Location = new Point(10, lecty);

            panel_slot.Controls.Add(lecture_abbr);
            panel_slot.Controls.Add(lecture_code);
            panel_slot.Controls.Add(lecture_hall);
            panel_slot.Controls.Add(lecturer);

            control_panel_slot.Controls.Add(panel_slot);
        }

        private void fillTimetable(DataRow dr)
        {
            if (dr["day"].ToString() == "Monday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createSlot(m_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createSlot(m_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createSlot(m_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createSlot(m_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createSlot(m_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createSlot(m_morning_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createSlot(m_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createSlot(m_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createSlot(m_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createSlot(m_evening_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createSlot(m_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createSlot(m_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createSlot(m_evening_slot, dr, 5, 9, 31, 55, 76);
                }
            }
            else if (dr["day"].ToString() == "Tuesday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createSlot(t_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createSlot(t_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createSlot(t_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createSlot(t_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createSlot(t_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createSlot(t_morning_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createSlot(t_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createSlot(t_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createSlot(t_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createSlot(t_evening_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createSlot(t_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createSlot(t_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createSlot(t_evening_slot, dr, 5, 9, 31, 55, 76);
                }

            }
            else if (dr["day"].ToString() == "Wednesday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createSlot(w_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createSlot(w_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createSlot(w_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createSlot(w_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createSlot(w_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createSlot(w_morning_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createSlot(w_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createSlot(w_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createSlot(w_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createSlot(w_evening_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createSlot(w_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createSlot(w_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createSlot(w_evening_slot, dr, 5, 9, 31, 55, 76);
                }
            }
            else if (dr["day"].ToString() == "Thursday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createSlot(th_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createSlot(th_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createSlot(th_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createSlot(th_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createSlot(th_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createSlot(th_morning_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createSlot(th_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createSlot(th_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createSlot(th_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createSlot(th_evening_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createSlot(th_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createSlot(th_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createSlot(th_evening_slot, dr, 5, 9, 31, 55, 76);
                }
            }
            else if (dr["day"].ToString() == "Friday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createSlot(fr_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createSlot(fr_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createSlot(fr_morning_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createSlot(fr_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createSlot(fr_morning_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createSlot(fr_morning_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createSlot(fr_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createSlot(fr_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createSlot(fr_evening_slot, dr, 5, 9, 31, 55, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createSlot(fr_evening_slot, dr, 87, 91, 113, 219, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createSlot(fr_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createSlot(fr_evening_slot, dr, 55, 59, 81, 137, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createSlot(fr_evening_slot, dr, 5, 9, 31, 55, 76);
                }
            }
        }

        private DataTable dt = new DataTable();
        //  Timetable for this week
        private void getStudentTimetable_This_Week()
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT intake_id FROM student_info where student_email = '" + email + "'", databaseConnection);
            Int32 intake_id = Convert.ToInt32(cmd.ExecuteScalar());

            string today = DateTime.Now.ToString("yyyy-MM-dd");

            MySqlCommand sem = new MySqlCommand("Select timetable_id,validity_period_start from ttms_timetable_main where intake_id='" + intake_id + "' AND validity_period_start <= '" + today + "' AND validity_period_end >= '" + today + "'", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(sem);
            da.Fill(dt);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    DataTable dt_lec = new DataTable();
                    MySqlCommand lec_mod = new MySqlCommand("Select time_slot,lecture_abbr,lecture_hall,day,lecturer,lecture_code from ttms_lecture_module where timetable_id='" + dt.Rows[0]["timetable_id"] + "' order by time_slot", databaseConnection);
                    MySqlDataAdapter adap = new MySqlDataAdapter(lec_mod);
                    adap.Fill(dt_lec);
                    foreach (DataRow dr in dt_lec.Rows)
                    {
                        fillTimetable(dr);
                    }

                    DateTime validity_period_start = DateTime.Parse(dt.Rows[0]["validity_period_start"].ToString());

                    monday.Text = validity_period_start.AddDays(1).ToString("yyyy-MM-dd");
                    tuesday.Text = validity_period_start.AddDays(2).ToString("yyyy-MM-dd");
                    wednesday.Text = validity_period_start.AddDays(3).ToString("yyyy-MM-dd");
                    thursday.Text = validity_period_start.AddDays(4).ToString("yyyy-MM-dd");
                    friday.Text = validity_period_start.AddDays(5).ToString("yyyy-MM-dd");
                }
                else
                {
                    no_timetable_pn1.Visible = true;
                    no_timetable_pn2.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("No Timetable");
            }
            databaseConnection.Close();
        }


        string today = DateTime.Now.ToString("yyyy-MM-dd");
        private void getLecturerTimetable_This_Week()
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("select id from lecturer_info where lecturer_email = '" + "punsisi@kdu.ac.lk" + "'", databaseConnection);
            Int32 lecturer_id = Convert.ToInt32(cmd.ExecuteScalar().ToString());


            MySqlCommand modid = new MySqlCommand("Select module_id from lecturer_module_tb where lecturer_id ='" + lecturer_id + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(modid);
            DataTable module_idTable = new DataTable();
            sda.Fill(module_idTable);
            DataTable lecture_code = new DataTable();
            foreach (DataRow dr in module_idTable.Rows)
            {

                MySqlCommand get_lecture_codes = new MySqlCommand("Select lecture_code from module_info where id = '" + dr["module_id"] + "'", databaseConnection);
                MySqlDataAdapter mysda = new MySqlDataAdapter(get_lecture_codes);

                mysda.Fill(lecture_code);

            }

            MySqlCommand sem = new MySqlCommand("Select timetable_id,intake from ttms_timetable_main t1 inner join intakes t2 on t1.intake_id=t2.id where validity_period_start <= '" + today + "' AND validity_period_end >= '" + today + "'", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(sem);
            DataTable TTId = new DataTable();
            da.Fill(TTId);

            DataTable ttFinal = new DataTable();
            foreach (DataRow dr in TTId.Rows)
            {
                foreach (DataRow drs in lecture_code.Rows)
                {
                    MySqlCommand getModulesandCodes = new MySqlCommand("Select time_slot,lecture_abbr,strength,lecture_hall,day,lecture_code,intake from ttms_lecture_module t1 inner join ttms_timetable_main t2 on t1.timetable_id=t2.timetable_id inner join intakes t3 on t2.intake_id=t3.id where t1.lecture_code='" + drs["lecture_code"] + "' and t1.timetable_id='" + dr["timetable_id"] + "'", databaseConnection);
                    MySqlDataAdapter getLecAdap = new MySqlDataAdapter(getModulesandCodes);
                    getLecAdap.Fill(ttFinal);
                }
            }

            foreach (DataRow dr in ttFinal.Rows)
            {
                fillLecturerTimetable(dr);
            }

            //DateTime validity_period_start = DateTime.Parse(dt.Rows[0]["validity_period_start"].ToString());

            //monday.Text = validity_period_start.AddDays(1).ToString("yyyy-MM-dd");
            //tuesday.Text = validity_period_start.AddDays(2).ToString("yyyy-MM-dd");
            //wednesday.Text = validity_period_start.AddDays(3).ToString("yyyy-MM-dd");
            //thursday.Text = validity_period_start.AddDays(4).ToString("yyyy-MM-dd");
            //friday.Text = validity_period_start.AddDays(5).ToString("yyyy-MM-dd");
            databaseConnection.Close();
        }

        private void createLecturerSlot(FlowLayoutPanel control_panel_slot, DataRow dr, int lay, int lcy, int lhy, int stry, int intakey, int height)
        {
            Guna2Panel panel_slot = new Guna2Panel();
            panel_slot.BackColor = Color.White;
            panel_slot.ShadowDecoration.Color = Color.Black;
            panel_slot.ShadowDecoration.Depth = 5;
            panel_slot.ShadowDecoration.Enabled = true;
            panel_slot.ShadowDecoration.Shadow = new Padding(10, 10, 10, 10);
            panel_slot.Size = new Size(204, height);

            Guna2HtmlLabel lecture_abbr = new Guna2HtmlLabel();
            lecture_abbr.Text = dr["lecture_abbr"].ToString();
            lecture_abbr.Font = new Font("Segoe UI Semibold", 12);
            lecture_abbr.ForeColor = Color.FromArgb(100, 88, 255);
            lecture_abbr.Location = new Point(10, lay);

            Guna2HtmlLabel lecture_code = new Guna2HtmlLabel();
            lecture_code.Text = dr["lecture_code"].ToString();
            lecture_code.Font = new Font("Segoe UI", 9);
            lecture_code.ForeColor = Color.Orange;
            lecture_code.Location = new Point(153, lcy);

            Guna2HtmlLabel lecture_hall = new Guna2HtmlLabel();
            lecture_hall.Text = "Lecture Hall :- " + dr["lecture_hall"].ToString();
            lecture_hall.AutoSize = false;
            lecture_hall.Size = new Size(194, 17);
            lecture_hall.TextAlignment = ContentAlignment.MiddleRight;
            lecture_hall.Font = new Font("Segoe UI", 9);
            lecture_hall.ForeColor = Color.Tomato;
            lecture_hall.Location = new Point(0, lhy);

            Guna2HtmlLabel str = new Guna2HtmlLabel();
            str.Text = "STR: " + dr["strength"].ToString();
            str.Font = new Font("Segoe UI", 9);
            str.ForeColor = Color.DimGray;
            str.Location = new Point(107, stry);

            Guna2HtmlLabel intake = new Guna2HtmlLabel();
            intake.Text = "Intake: " + dr["intake"].ToString();
            intake.Font = new Font("Segoe UI Semibold", 12);
            intake.ForeColor = Color.Black;
            intake.Location = new Point(10, intakey);

            panel_slot.Controls.Add(lecture_abbr);
            panel_slot.Controls.Add(lecture_code);
            panel_slot.Controls.Add(lecture_hall);
            panel_slot.Controls.Add(str);
            panel_slot.Controls.Add(intake);

            control_panel_slot.Controls.Add(panel_slot);
        }


        private void fillLecturerTimetable(DataRow dr)
        {
            if (dr["day"].ToString() == "Monday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createLecturerSlot(m_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createLecturerSlot(m_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createLecturerSlot(m_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createLecturerSlot(m_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createLecturerSlot(m_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createLecturerSlot(m_morning_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createLecturerSlot(m_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createLecturerSlot(m_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createLecturerSlot(m_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createLecturerSlot(m_evening_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createLecturerSlot(m_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createLecturerSlot(m_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createLecturerSlot(m_evening_slot2, dr, 5, 9, 55, 9, 34, 76);
                }
            }
            else if (dr["day"].ToString() == "Tuesday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createLecturerSlot(t_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createLecturerSlot(t_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createLecturerSlot(t_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createLecturerSlot(t_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createLecturerSlot(t_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createLecturerSlot(t_morning_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createLecturerSlot(t_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createLecturerSlot(t_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createLecturerSlot(t_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createLecturerSlot(t_evening_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createLecturerSlot(t_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createLecturerSlot(t_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createLecturerSlot(t_evening_slot2, dr, 5, 9, 55, 9, 34, 76);
                }
            }
            else if (dr["day"].ToString() == "Wednesday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createLecturerSlot(w_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createLecturerSlot(w_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createLecturerSlot(w_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createLecturerSlot(w_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createLecturerSlot(w_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createLecturerSlot(w_morning_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createLecturerSlot(w_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createLecturerSlot(w_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createLecturerSlot(w_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createLecturerSlot(w_evening_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createLecturerSlot(w_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createLecturerSlot(w_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createLecturerSlot(w_evening_slot2, dr, 5, 9, 55, 9, 34, 76);
                }
            }
            else if (dr["day"].ToString() == "Thursday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createLecturerSlot(th_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createLecturerSlot(th_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createLecturerSlot(th_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createLecturerSlot(th_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createLecturerSlot(th_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createLecturerSlot(th_morning_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createLecturerSlot(th_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createLecturerSlot(th_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createLecturerSlot(th_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createLecturerSlot(th_evening_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createLecturerSlot(th_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createLecturerSlot(th_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createLecturerSlot(th_evening_slot2, dr, 5, 9, 55, 9, 34, 76);
                }
            }
            else if (dr["day"].ToString() == "Friday")
            {
                if (dr["time_slot"].ToString() == "0800 - 0900")
                {
                    createLecturerSlot(fr_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1000")
                {
                    createLecturerSlot(fr_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1000 - 1100")
                {
                    createLecturerSlot(fr_morning_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1000")
                {
                    createLecturerSlot(fr_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0900 - 1100")
                {
                    createLecturerSlot(fr_morning_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "0800 - 1100")
                {
                    createLecturerSlot(fr_morning_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1215")
                {
                    createLecturerSlot(fr_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1315")
                {
                    createLecturerSlot(fr_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1315 - 1415")
                {
                    createLecturerSlot(fr_evening_slot, dr, 5, 9, 55, 9, 34, 76);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1415")
                {
                    createLecturerSlot(fr_evening_slot, dr, 87, 91, 219, 91, 116, 240);
                }
                else if (dr["time_slot"].ToString() == "1115 - 1315")
                {
                    createLecturerSlot(fr_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1215 - 1415")
                {
                    createLecturerSlot(fr_evening_slot, dr, 55, 59, 137, 59, 84, 158);
                }
                else if (dr["time_slot"].ToString() == "1430 - 1615")
                {
                    createLecturerSlot(fr_evening_slot2, dr, 5, 9, 55, 9, 34, 76);
                }
            }

        }

        private void Show_Weekly_Timetable_Load(object sender, EventArgs e)
        {
            if (getType == "Student")
            {
                getStudentTimetable_This_Week();
            }
            else
            {
                getLecturerTimetable_This_Week();

            }
        }
    }
}
