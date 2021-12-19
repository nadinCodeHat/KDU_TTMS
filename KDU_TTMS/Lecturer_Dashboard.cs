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
    public partial class Lecturer_Dashboard : UserControl
    {
        public Lecturer_Dashboard()
        {
            InitializeComponent();
        }

        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public string email;
        public Lecturer_Dashboard(string email)
        {
            InitializeComponent();
            this.email = email;
        }

        private void LoadWeeklyTimetable()
        {
            time_table_panel.Controls.Clear();
            Show_Weekly_Timetable lect = new Show_Weekly_Timetable(email, "Lecturer");
            lect.TopLevel = false;
            time_table_panel.Controls.Add(lect);
            lect.FormBorderStyle = FormBorderStyle.None;
            lect.Dock = DockStyle.Fill;
            lect.Show();
        }

        private DataTable dt = new DataTable();
        //  Timetable for this week
        private void getDatesAndWeeks()
        {
            databaseConnection.Open();

            string today = DateTime.Now.ToString("yyyy-MM-dd");
            MySqlCommand sem = new MySqlCommand("Select timetable_id,validity_period_start,validity_period_end,week from ttms_timetable_main where validity_period_start <= '" + today + "' AND validity_period_end >= '" + today + "'", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(sem);
            da.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {

                    week_value.Text = dt.Rows[0]["week"].ToString();
                    DateTime v_start = (DateTime)dt.Rows[0]["validity_period_start"];
                    DateTime v_end = (DateTime)dt.Rows[0]["validity_period_end"];

                    validity_period.Text = v_start.ToString("yyyy-MM-dd") + " to " + v_end.ToString("yyyy-MM-dd");
                }
                else
                {
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

            Guna2HtmlLabel intake = new Guna2HtmlLabel();
            intake.Text = "INTAKE " + dr["intake"].ToString();
            intake.Font = new Font("Segoe UI Semibold", 14);
            intake.ForeColor = Color.DimGray;
            intake.Location = new Point(19, 95);

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
            lecture_panel.Controls.Add(intake);
            lecture_panel.Controls.Add(lecture_code);
            lecture_panel.Controls.Add(lecture_hall);

            lectures_today_flowlayout.Controls.Add(lecture_panel);
        }












        private void getTimetable_ForToday()
        {
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            string day_name = DateTime.Now.DayOfWeek.ToString().ToUpper();
            dayname.Text = day_name;

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
                    MySqlCommand getModulesandCodes = new MySqlCommand("Select ttms_lecture_module.time_slot,ttms_lecture_module.lecture_abbr,module_info.lecture_module,ttms_lecture_module.strength,ttms_lecture_module.lecture_hall,ttms_lecture_module.day,ttms_lecture_module.lecture_code,intakes.intake,module_info.credit,module_info.gpatype,module_info.module_type from ttms_lecture_module inner join ttms_timetable_main on ttms_lecture_module.timetable_id=ttms_timetable_main.timetable_id inner join intakes on ttms_timetable_main.intake_id=intakes.id inner join module_info on ttms_lecture_module.lecture_code=module_info.lecture_code where ttms_lecture_module.lecture_code='" + drs["lecture_code"] + "' and ttms_lecture_module.timetable_id='" + dr["timetable_id"] + "' and ttms_lecture_module.day='" + day_name + "' order by ttms_lecture_module.time_slot", databaseConnection);
                    MySqlDataAdapter getLecAdap = new MySqlDataAdapter(getModulesandCodes);
                    getLecAdap.Fill(ttFinal);
                }
            }

            foreach (DataRow dr in ttFinal.Rows)
            {
                createSlot(dr);
            }

            databaseConnection.Close();
        }







        private void Lecturer_Dashboard_Load(object sender, EventArgs e)
        {


            LoadWeeklyTimetable();
            getDatesAndWeeks();
            getTimetable_ForToday();
            loadCalenderEvents();
        }
    }
}
