using KDU_Time_Table_Management_System.Properties;
using Microsoft.Office.Interop.Outlook;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Assist_Admin_DashBoard : UserControl
    {

        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Assist_Admin_DashBoard()
        {
            InitializeComponent();
        }

        private string email, accountType, real;
        private bool priviledges;
        public Assist_Admin_DashBoard(string email, string accountType, bool priviledges, string real)
        {
            InitializeComponent();
            this.email = email;
            this.accountType = accountType;
            this.priviledges = priviledges;
            this.real = real;
        }


        private void get_assistant()
        {
            string query = "select message from messages where sender = '" + "Administrator" + "'";
            MySqlCommand sqlComman = new MySqlCommand(query, databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlComman);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                messages_table.DataSource = dt;
            }
            else
            {
                no_messages_panel.Visible = true;
            }
        }

        private void setTable()
        {
            messages_table.Columns[0].Name = "messages";
            messages_table.Columns[0].HeaderText = "Recieved Messages";
        }

        private void getMessages()
        {
            messages_table.Columns.Clear();
            messages_table.DataSource = null;
            messages_table.Rows.Clear();
            messages_table.Refresh();

            databaseConnection.Open();
            if (accountType == "Administrator")
            {
                if (real == "Admin")
                {
                    string query = "select message from messages where sender = '" + "Assistant" + "'";
                    MySqlCommand sqlComman = new MySqlCommand(query, databaseConnection);
                    MySqlDataAdapter sda = new MySqlDataAdapter(sqlComman);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        messages_table.DataSource = dt;
                        setTable();
                    }
                    else
                    {
                        no_messages_panel.Visible = true;
                    }
                }
                else
                {
                    get_assistant();
                    setTable();
                }

            }
            else
            {
                get_assistant();
                setTable();
            }
            databaseConnection.Close();


        }

        private static Assist_Admin_DashBoard _instance;

        public static Assist_Admin_DashBoard Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Assist_Admin_DashBoard();
                return _instance;
            }
        }

        Int32 student_count, lecturer_count, intake_count, course_mod_count = 0;

        int count1, count2, count3, count4 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count1 += 1;
            if (count1 >= student_count)
            {
                timer1.Enabled = false;
                timer1.Stop();
            }
            no_of_students_lb.Text = count1.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count2 += 1;
            if (count2 >= lecturer_count)
            {
                timer2.Enabled = false;
                timer2.Stop();
            }
            no_of_lect_lb.Text = count2.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            count3 += 1;
            if (count3 >= intake_count)
            {
                timer3.Enabled = false;
                timer3.Stop();
            }
            no_of_intakes_lb.Text = count3.ToString();
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

        private void add_new_event_Click(object sender, EventArgs e)
        {
            Add_Edit_Calendar_Events calendar_event_frm = new Add_Edit_Calendar_Events();
            calendar_event_frm.ShowDialog();

            calender_events_table.Rows.Clear();
            calender_events_table.Refresh();

            loadCalenderEvents();
        }

        private void new_message_Click(object sender, EventArgs e)
        {
            if (accountType == "Administrator")
            {
                if (real == "Admin")
                {
                    Send_Messages new_mesg = new Send_Messages("Administrator");
                    new_mesg.ShowDialog();
                }
                else
                {
                    Send_Messages new_mesg = new Send_Messages("Assistant");
                    new_mesg.ShowDialog();
                }

            }
            else
            {
                Send_Messages new_mesg = new Send_Messages("Assistant");
                new_mesg.ShowDialog();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            count4 += 1;
            if (count4 >= course_mod_count)
            {
                timer4.Enabled = false;
                timer4.Stop();
            }
            no_of_course_mod_lb.Text = count4.ToString();
        }

        private void intake_combo_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            databaseConnection.Open();
            loadIntakeChart();
            databaseConnection.Close();
        }

        private void loadIntakeChart()
        {
            MySqlCommand getintakes = new MySqlCommand("Select id from intakes", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getintakes);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    MySqlCommand getcsCount = new MySqlCommand("Select count(*) from student_info where intake_id='" + dr["id"].ToString() + "' and student_course_stream ='" + "Computer Science" + "'", databaseConnection);
                    Int32 cscount = Convert.ToInt32(getcsCount.ExecuteScalar().ToString());

                    MySqlCommand getceCount = new MySqlCommand("Select count(*) from student_info where intake_id='" + dr["id"].ToString() + "' and student_course_stream ='" + "Computer Engineering" + "'", databaseConnection);
                    Int32 cecount = Convert.ToInt32(getceCount.ExecuteScalar().ToString());

                    MySqlCommand getseCount = new MySqlCommand("Select count(*) from student_info where intake_id='" + dr["id"].ToString() + "' and student_course_stream ='" + "Software Engineering" + "'", databaseConnection);
                    Int32 secount = Convert.ToInt32(getseCount.ExecuteScalar().ToString());

                    MySqlCommand getitCount = new MySqlCommand("Select count(*) from student_info where intake_id='" + dr["id"].ToString() + "' and student_course_stream ='" + "Information Technology" + "'", databaseConnection);
                    Int32 itcount = Convert.ToInt32(getitCount.ExecuteScalar().ToString());

                    MySqlCommand getisCount = new MySqlCommand("Select count(*) from student_info where intake_id='" + dr["id"].ToString() + "' and student_course_stream ='" + "Information Systems" + "'", databaseConnection);
                    Int32 iscount = Convert.ToInt32(getisCount.ExecuteScalar().ToString());

                    MySqlCommand getIntake = new MySqlCommand("Select intake from intakes where id='" + dr["id"].ToString() + "'", databaseConnection);
                    Int32 intake = Convert.ToInt32(getIntake.ExecuteScalar().ToString());

                    this.chart1.Series["Computer Science"].Points.AddXY("Intake " + intake, cscount);
                    this.chart1.Series["Computer Engineering"].Points.AddXY("Intake " + intake, cecount);
                    this.chart1.Series["Software Engineering"].Points.AddXY("Intake " + intake, secount);
                    this.chart1.Series["Information Technology"].Points.AddXY("Intake " + intake, itcount);
                    this.chart1.Series["Information Systems"].Points.AddXY("Intake " + intake, iscount);
                }
            }
            else
            {
            }
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

        private void New_MA_DashBoard_Load(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand get_Stud_cmd = new MySqlCommand("Select count(*) from student_info", databaseConnection);
            student_count = Convert.ToInt32(get_Stud_cmd.ExecuteScalar());

            MySqlCommand get_Lect_cmd = new MySqlCommand("Select count(*) from lecturer_info", databaseConnection);
            lecturer_count = Convert.ToInt32(get_Lect_cmd.ExecuteScalar());

            MySqlCommand get_intake_cmd = new MySqlCommand("Select count(*) from intakes", databaseConnection);
            intake_count = Convert.ToInt32(get_intake_cmd.ExecuteScalar());

            MySqlCommand get_course_mod_cmd = new MySqlCommand("Select count(*) from module_info", databaseConnection);
            course_mod_count = Convert.ToInt32(get_course_mod_cmd.ExecuteScalar());



            loadCalenderEvents();

            loadIntakeChart();

            databaseConnection.Close();
            getMessages();

            timer1.Enabled = true;
            timer1.Interval = 20;
            timer2.Enabled = true;
            timer2.Interval = 100;
            timer3.Enabled = true;
            timer3.Interval = 100;
            timer4.Enabled = true;
            timer4.Interval = 100;
        }
    }
}
