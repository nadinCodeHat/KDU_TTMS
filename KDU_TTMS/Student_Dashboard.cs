using Guna.UI2.WinForms;
using KDU_Time_Table_Management_System.Properties;
using Microsoft.Office.Interop.Outlook;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Student_Dashboard : UserControl
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Student_Dashboard()
        {
            InitializeComponent();
        }

        public string email;
        public Student_Dashboard(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void LoadWeeklyTimetable()
        {
            time_table_panel.Controls.Clear();
            Show_Weekly_Timetable std = new Show_Weekly_Timetable(email, "Student");
            std.TopLevel = false;
            time_table_panel.Controls.Add(std);
            std.FormBorderStyle = FormBorderStyle.None;
            std.Dock = DockStyle.Fill;
            std.Show();
        }

        private DataTable dt = new DataTable();
        //  Timetable for this week
        private void getDatesAndWeeks()
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT intake_id FROM student_info where student_email = '" + email + "'", databaseConnection);
            string intake_id = cmd.ExecuteScalar().ToString();

            string today = DateTime.Now.ToString("yyyy-MM-dd");

            MySqlCommand sem = new MySqlCommand("Select semester,validity_period_start,validity_period_end,week from ttms_timetable_main where intake_id='" + intake_id + "' AND validity_period_start <= '" + today + "' AND validity_period_end >= '" + today + "'", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(sem);
            da.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    //set values
                    sem_val.Text = dt.Rows[0]["Semester"].ToString();

                    week_value.Text = dt.Rows[0]["week"].ToString();
                    DateTime v_start = (DateTime)dt.Rows[0]["validity_period_start"];
                    DateTime v_end = (DateTime)dt.Rows[0]["validity_period_end"];

                    validity_period.Text = v_start.ToString("yyyy-MM-dd") + " to " + v_end.ToString("yyyy-MM-dd");
                }
                else
                {
                    sem_val.Text = null;
                    week_value.Text = null;
                    validity_period.Text = null;
                }
            }
            else
            {
                MessageBox.Show("No Timetable");
            }
            databaseConnection.Close();
        }


        private void loadCalenderEvents()
        {
            calender_events_table.ColumnCount = 8;
            calender_events_table.Columns[0].Name = "Subject";
            calender_events_table.Columns[1].Name = "Organizer";
            calender_events_table.Columns[2].Name = "Location";

            calender_events_table.Columns[3].Name = "StartTime";
            //Styling
            calender_events_table.Columns["StartTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            calender_events_table.Columns[4].Name = "EndTime";
            //Styling
            calender_events_table.Columns["EndTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            calender_events_table.Columns[5].Name = "StartDate";
            //Styling
            calender_events_table.Columns["StartDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            calender_events_table.Columns[6].Name = "EndDate";
            //Styling
            calender_events_table.Columns["EndDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //
            calender_events_table.Columns[7].Name = "AllDayEvent";
            //Styling
            calender_events_table.Columns["AllDayEvent"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //

            //Styling
            for (int i = 3; i <= 7; i++)
            {
                calender_events_table.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                calender_events_table.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            Microsoft.Office.Interop.Outlook.Application oApp = null;
            NameSpace mapiNamespace = null;
            MAPIFolder CalendarFolder = null;
            Items outlookCalendarItems = null;

            oApp = new Microsoft.Office.Interop.Outlook.Application();
            mapiNamespace = oApp.GetNamespace("MAPI"); ;
            CalendarFolder = mapiNamespace.GetDefaultFolder(OlDefaultFolders.olFolderCalendar);
            outlookCalendarItems = CalendarFolder.Items;
            outlookCalendarItems.IncludeRecurrences = true;

            foreach (AppointmentItem item in outlookCalendarItems)
            {
                if (item.IsRecurring)
                {
                    RecurrencePattern rp = item.GetRecurrencePattern();
                    DateTime date = DateTime.Now;

                    DateTime first = new DateTime((int)date.Year, (int)date.Month, (int)date.Day, item.Start.Hour, item.Start.Minute, 0);
                    DateTime last = new DateTime((int)date.Year, (int)date.Month, (int)date.Day);
                    AppointmentItem recur = null;

                    for (DateTime cur = first; cur <= last; cur = cur.AddDays(1))
                    {
                        try
                        {
                            recur = rp.GetOccurrence(cur);
                            //MessageBox.Show(recur.Subject + " -> " + cur.ToLongDateString());
                            int rowID = calender_events_table.Rows.Add();
                            DataGridViewRow row = calender_events_table.Rows[rowID];
                            row.Cells["Subject"].Value = recur.Subject;
                            row.Cells["Organizer"].Value = recur.Organizer;
                            if (recur.Location == null)
                            {
                                row.Cells["Location"].Value = "Not Set";
                            }
                            else
                            {
                                row.Cells["Location"].Value = recur.Location;
                            }
                            row.Cells["StartTime"].Value = recur.Start.TimeOfDay.ToString();
                            row.Cells["EndTime"].Value = recur.End.TimeOfDay.ToString();
                            row.Cells["StartDate"].Value = recur.Start.Date.ToShortDateString();
                            row.Cells["End Date"].Value = recur.End.Date.ToShortDateString();
                            row.Cells["AllDayEvent"].Value = recur.AllDayEvent;
                        }
                        catch
                        { }
                    }
                }
                else
                {
                    int rowID = calender_events_table.Rows.Add();
                    DataGridViewRow row = calender_events_table.Rows[rowID];
                    row.Cells["Subject"].Value = item.Subject;
                    row.Cells["Organizer"].Value = item.Organizer;
                    if (item.Location == null)
                    {
                        row.Cells["Location"].Value = "Not Set";
                    }
                    else
                    {
                        row.Cells["Location"].Value = item.Location;
                    }
                    row.Cells["StartTime"].Value = item.Start.TimeOfDay.ToString();
                    row.Cells["EndTime"].Value = item.End.TimeOfDay.ToString();
                    row.Cells["StartDate"].Value = item.Start.Date.ToShortDateString();
                    row.Cells["EndDate"].Value = item.End.Date.ToShortDateString();
                    row.Cells["AllDayEvent"].Value = item.AllDayEvent;
                }
            }

            calender_events_table.Columns[0].HeaderText = "Subject";
            calender_events_table.Columns[1].HeaderText = "Organizer";
            calender_events_table.Columns[2].HeaderText = "Location";
            calender_events_table.Columns[3].HeaderText = "Start Time";
            calender_events_table.Columns[4].HeaderText = "End Time";
            calender_events_table.Columns[5].HeaderText = "Start Date";
            calender_events_table.Columns[6].HeaderText = "End Date";
            calender_events_table.Columns[7].HeaderText = "All Day Event";

            DataGridViewImageColumn viewBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
            viewBtn.Name = "view_btn";
            viewBtn.HeaderText = "";
            viewBtn.Image = Resources.view;
            viewBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            calender_events_table.Columns.Insert(8, viewBtn);

            deleteBtn.Name = "delete_btn";
            deleteBtn.HeaderText = "";
            deleteBtn.Image = Resources.delete;
            deleteBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            calender_events_table.Columns.Insert(9, deleteBtn);
            //Set Column Width
            for (int i = 0; i <= 7; i++)
            {
                DataGridViewColumn tt_id_col = calender_events_table.Columns[i];
                if (i == 0)
                {
                    tt_id_col.Width = 230;
                }
                else if (i == 1)
                {
                    tt_id_col.Width = 160;
                }
                else if (i == 2)
                {
                    tt_id_col.Width = 100;
                }
                else if (i == 3)
                {
                    tt_id_col.Width = 80;
                }
                else if (i == 4)
                {
                    tt_id_col.Width = 80;
                }
                else if (i == 5)
                {
                    tt_id_col.Width = 80;
                }
                else if (i == 6)
                {
                    tt_id_col.Width = 80;
                }
                else if (i == 7)
                {
                    tt_id_col.Width = 110;
                }
            }
        }

        private void add_new_event_Click(object sender, EventArgs e)
        {
            Add_Edit_Calendar_Events calendar_event_frm = new Add_Edit_Calendar_Events();
            calendar_event_frm.ShowDialog();
            calender_events_table.Rows.Clear();
            calender_events_table.Refresh();

            loadCalenderEvents();
        }

        private void calender_events_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                Show_Calendar_Events ce = new Show_Calendar_Events();
                ce.subject_lb.Text = this.calender_events_table.CurrentRow.Cells[0].Value.ToString();
                ce.organizer_lb.Text = this.calender_events_table.CurrentRow.Cells[1].Value.ToString();
                ce.location_lb.Text = this.calender_events_table.CurrentRow.Cells[2].Value.ToString();
                ce.start_time_lb.Text = this.calender_events_table.CurrentRow.Cells[3].Value.ToString();
                ce.end_time_lb.Text = this.calender_events_table.CurrentRow.Cells[4].Value.ToString();
                ce.start_date_lb.Text = this.calender_events_table.CurrentRow.Cells[5].Value.ToString();
                ce.end_date_lb.Text = this.calender_events_table.CurrentRow.Cells[6].Value.ToString();
                ce.all_day_event_lb.Text = this.calender_events_table.CurrentRow.Cells[7].Value.ToString();
                ce.ShowDialog();
            }
            else if (e.ColumnIndex == 9)
            {
                Microsoft.Office.Interop.Outlook.Application OlApp = new Microsoft.Office.Interop.Outlook.Application();
                NameSpace OlNamspace = OlApp.GetNamespace("MAPI");
                MAPIFolder AppointmentFolder = OlNamspace.GetDefaultFolder(OlDefaultFolders.olFolderCalendar);

                AppointmentFolder.Items.IncludeRecurrences = true;

                Items calendarItems = AppointmentFolder.Items;

                AppointmentItem item = calendarItems[this.calender_events_table.CurrentRow.Cells[0].Value.ToString()] as AppointmentItem;

                item.Delete();
                MessageBox.Show("Calendar event has been deleted.");
                calender_events_table.Rows.Remove(calender_events_table.CurrentRow);
                calender_events_table.Update();
                calender_events_table.Refresh();
            }
        }

        public void GetAllCalendarItems()
        {
            Microsoft.Office.Interop.Outlook.Application oApp = null;
            NameSpace mapiNamespace = null;
            MAPIFolder CalendarFolder = null;
            Items outlookCalendarItems = null;

            oApp = new Microsoft.Office.Interop.Outlook.Application();
            mapiNamespace = oApp.GetNamespace("MAPI"); ;
            CalendarFolder = mapiNamespace.GetDefaultFolder(OlDefaultFolders.olFolderCalendar);
            outlookCalendarItems = CalendarFolder.Items;
            outlookCalendarItems.IncludeRecurrences = true;

            foreach (AppointmentItem item in outlookCalendarItems)
            {
                if (item.IsRecurring)
                {
                    RecurrencePattern rp = item.GetRecurrencePattern();
                    DateTime date = DateTime.Now;

                    DateTime first = new DateTime((int)date.Year, (int)date.Month, (int)date.Day, item.Start.Hour, item.Start.Minute, 0);
                    DateTime last = new DateTime((int)date.Year, (int)date.Month, (int)date.Day);
                    AppointmentItem recur = null;

                    for (DateTime cur = first; cur <= last; cur = cur.AddDays(1))
                    {
                        try
                        {
                            recur = rp.GetOccurrence(cur);
                            //MessageBox.Show(recur.Subject + " -> " + cur.ToLongDateString());
                        }
                        catch
                        { }
                    }
                }
                else
                {
                    Guna2Panel panel = new Guna2Panel();
                    panel.BackColor = Color.White;
                    panel.Size = new Size(1080, 50);
                    Guna2HtmlLabel message = new Guna2HtmlLabel();
                    message.Text = item.Subject + " --> " + item.Start.ToLongDateString();
                    message.Font = new Font("SegoeUI", 10);
                    message.Location = new Point(0, 15);
                    message.ForeColor = Color.FromArgb(71, 69, 94);
                    panel.Controls.Add(message);

                    //flowLayoutPanel3.Controls.Add(panel);
                    //MessageBox.Show(item.Subject + " -> " + item.Start.ToLongDateString());        
                }
            }
        }

        private void createSlot(DataRow dr)
        {

            Guna2Panel lecture_panel = new Guna2Panel();
            lecture_panel.BackColor = Color.White;
            lecture_panel.ShadowDecoration.Color = Color.Black;
            lecture_panel.ShadowDecoration.Depth = 5;
            lecture_panel.ShadowDecoration.Enabled = true;
            lecture_panel.ShadowDecoration.Shadow = new Padding(5, 5, 5, 5);
            lecture_panel.Size = new Size(300, 270);

            Guna2HtmlLabel time_slot = new Guna2HtmlLabel();
            time_slot.Text = dr["time_slot"].ToString();
            time_slot.Font = new Font("Segoe UI Semibold", 14);
            time_slot.ForeColor = Color.DimGray;
            time_slot.Location = new Point(18, 34);

            Guna2HtmlLabel str = new Guna2HtmlLabel();
            str.Text = "Strength - " + dr["strength"].ToString();
            str.Font = new Font("Segoe UI", 10);
            str.ForeColor = Color.DimGray;
            str.Location = new Point(18, 162);

            Guna2HtmlLabel credit = new Guna2HtmlLabel();
            credit.Text = dr["credit"].ToString() + " Credit";
            credit.Font = new Font("Segoe UI", 10);
            credit.ForeColor = Color.DimGray;
            credit.Location = new Point(117, 162);

            Guna2HtmlLabel module_type = new Guna2HtmlLabel();
            module_type.Text = dr["module_type"].ToString();
            module_type.Font = new Font("Segoe UI", 10);
            module_type.ForeColor = Color.DimGray;
            module_type.Location = new Point(187, 162);

            Guna2HtmlLabel gpa_type = new Guna2HtmlLabel();
            gpa_type.Text = dr["gpatype"].ToString();
            gpa_type.Font = new Font("Segoe UI", 10);
            gpa_type.ForeColor = Color.DimGray;
            gpa_type.Location = new Point(225, 162);

            Guna2HtmlLabel lecture_abbr = new Guna2HtmlLabel();
            lecture_abbr.Text = dr["lecture_abbr"].ToString();
            lecture_abbr.Font = new Font("Segoe UI Semibold", 14);
            lecture_abbr.ForeColor = Color.FromArgb(100, 88, 255);
            lecture_abbr.Location = new Point(127, 34);

            Guna2HtmlLabel lecture_module = new Guna2HtmlLabel();
            lecture_module.Text = dr["lecture_module"].ToString();
            lecture_module.Font = new Font("Segoe UI", 10);
            lecture_module.ForeColor = Color.FromArgb(100, 88, 255);
            lecture_module.Location = new Point(18, 67);

            Guna2HtmlLabel lecturer = new Guna2HtmlLabel();
            lecturer.Text = dr["lecturer"].ToString();
            lecturer.Font = new Font("Segoe UI", 10);
            lecturer.ForeColor = Color.DimGray;
            lecturer.Location = new Point(18, 100);

            Guna2HtmlLabel lecture_code = new Guna2HtmlLabel();
            lecture_code.Text = dr["lecture_code"].ToString();
            lecture_code.Font = new Font("Segoe UI", 10);
            lecture_code.ForeColor = Color.Orange;
            lecture_code.Location = new Point(18, 132);

            Guna2HtmlLabel lecture_hall = new Guna2HtmlLabel();
            lecture_hall.Text = "Lecture Hall :- " + dr["lecture_hall"].ToString();
            lecture_hall.Font = new Font("Segoe UI Semibold", 12);
            lecture_hall.ForeColor = Color.Tomato;
            lecture_hall.Location = new Point(18, 197);

            lecture_panel.Controls.Add(time_slot);
            lecture_panel.Controls.Add(str);
            lecture_panel.Controls.Add(credit);
            lecture_panel.Controls.Add(module_type);
            lecture_panel.Controls.Add(gpa_type);
            lecture_panel.Controls.Add(lecture_abbr);
            lecture_panel.Controls.Add(lecture_module);
            lecture_panel.Controls.Add(lecturer);
            lecture_panel.Controls.Add(lecture_code);
            lecture_panel.Controls.Add(lecture_hall);

            lectures_today_flowlayout.Controls.Add(lecture_panel);
        }

        private DataTable newdt = new DataTable();
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

            da.Fill(newdt);
            if (newdt != null)
            {
                if (newdt.Rows.Count > 0)
                {
                    DataTable dt_lec = new DataTable();
                    MySqlCommand lec_mod = new MySqlCommand("Select ttms_lecture_module.time_slot,ttms_lecture_module.lecture_abbr,module_info.lecture_module,ttms_lecture_module.strength,ttms_lecture_module.lecture_hall,ttms_lecture_module.lecturer,ttms_lecture_module.lecture_code,module_info.credit,module_info.gpatype,module_info.module_type from ttms_lecture_module inner join module_info on ttms_lecture_module.lecture_code = module_info.lecture_code where ttms_lecture_module.timetable_id='" + newdt.Rows[0]["timetable_id"] + "' AND ttms_lecture_module.day='" + day_name + "' order by ttms_lecture_module.time_slot", databaseConnection);
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
                    no_timetable_pn1.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("No Timetable");
            }
            databaseConnection.Close();
        }


        private void MA_Dashboard_Load(object sender, EventArgs e)
        {


            // GetAllCalendarItems();
            LoadWeeklyTimetable();
            getDatesAndWeeks();
            getTimetable_ForToday();
            loadCalenderEvents();
        }

        private void week_btn_Click(object sender, EventArgs e)
        {
            day_week.Text = "This Week";
            LoadWeeklyTimetable();
            week_btn.Checked = true;
        }

        private void day_btn_Click(object sender, EventArgs e)
        {
            day_week.Text = "Today";
            time_table_panel.Controls.Clear();
            Show_Timetable_Today stt = new Show_Timetable_Today(email);
            stt.TopLevel = false;
            time_table_panel.Controls.Add(stt);
            stt.FormBorderStyle = FormBorderStyle.None;
            stt.Dock = DockStyle.Fill;
            stt.Show();

            week_btn.Checked = false;
        }
    }
}
