using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class View_Timetables : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public View_Timetables()
        {
            InitializeComponent();
        }

        private void LoadViewTimetable()
        {
            string query = "select timetable_id,intake,degree_programme,semester,validity_period_start,validity_period_end,week from ttms_timetable_main t1 inner join ttms_degree_programme t2 on t1.degree_programme_id = t2.degree_programme_id inner join intakes t3 on t1.intake_id = t3.id order by validity_period_start desc";

            databaseConnection.Open();
            MySqlCommand sqlComman = new MySqlCommand(query, databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlComman);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            view_timetable_table.DataSource = dt;
            databaseConnection.Close();

            view_timetable_table.Columns[0].HeaderText = "Timetable ID";
            view_timetable_table.Columns[1].HeaderText = "Intake";
            view_timetable_table.Columns[2].HeaderText = "Degree Programme";
            view_timetable_table.Columns[3].HeaderText = "Semester";
            view_timetable_table.Columns[4].HeaderText = "Validity Period Start";
            view_timetable_table.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
            view_timetable_table.Columns[5].HeaderText = "Validity Period End";
            view_timetable_table.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";
            view_timetable_table.Columns[6].HeaderText = "Week";

            DataGridViewImageColumn viewBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
            viewBtn.Name = "download_btn";
            viewBtn.HeaderText = "";
            viewBtn.Image = Resources.download;
            viewBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            view_timetable_table.Columns.Insert(7, viewBtn);

            deleteBtn.Name = "delete_btn";
            deleteBtn.HeaderText = "";
            deleteBtn.Image = Resources.delete;
            deleteBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            view_timetable_table.Columns.Insert(8, deleteBtn);

            //Set Column Width
            for (int i = 0; i <= 8; i++)
            {
                DataGridViewColumn tt_id_col = view_timetable_table.Columns[i];
                if (i == 0)
                {
                    tt_id_col.Width = 90;
                }
                else if (i == 1)
                {
                    tt_id_col.Width = 50;
                }
                else if (i == 2)
                {
                    tt_id_col.Width = 300;
                }
                else if (i == 3)
                {
                    tt_id_col.Width = 60;
                }
                else if (i == 4)
                {
                    tt_id_col.Width = 120;
                }
                else if (i == 5)
                {
                    tt_id_col.Width = 120;
                }
                else if (i == 6)
                {
                    tt_id_col.Width = 40;
                }
                else if (i == 7)
                {
                    tt_id_col.Width = 40;
                }
                else if (i == 8)
                {
                    tt_id_col.Width = 50;
                }
            }
        }

        private void View_Timetables_Load(object sender, EventArgs e)
        {
            LoadViewTimetable();
        }

        private void view_timetable_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == view_timetable_table.Columns["download_btn"].Index)
            {
                string intake_val = this.view_timetable_table.CurrentRow.Cells[3].Value.ToString();
                string degree_programme = this.view_timetable_table.CurrentRow.Cells[4].Value.ToString();
                string semester = this.view_timetable_table.CurrentRow.Cells[5].Value.ToString();

                string validity_period_start = this.view_timetable_table.Rows[e.RowIndex].Cells[6].Value.ToString();

                string validity_period_end = this.view_timetable_table.Rows[e.RowIndex].Cells[7].Value.ToString();

                string week = this.view_timetable_table.Rows[e.RowIndex].Cells[8].Value.ToString();

                TimetableCrystalForm crfrm = new TimetableCrystalForm(intake_val, week, degree_programme, semester, validity_period_start, validity_period_end);
                crfrm.Show();
            }
            else if (e.ColumnIndex == view_timetable_table.Columns["delete_btn"].Index)
            {
                if (MessageBox.Show("Are you sure want to delete this timetable?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    databaseConnection.Open();
                    DataGridViewRow row = view_timetable_table.Rows[e.RowIndex];

                    MySqlCommand delete_mods = new MySqlCommand("Delete from ttms_lecture_module where timetable_id = '" + row.Cells[2].Value.ToString() + "'", databaseConnection);
                    delete_mods.ExecuteNonQuery();

                    MySqlCommand delete_tt = new MySqlCommand("Delete from ttms_timetable_main where timetable_id = '" + row.Cells[2].Value.ToString() + "'", databaseConnection);
                    delete_tt.ExecuteNonQuery();
                    MessageBox.Show("Delete Successful!");

                    //remove from datatable
                    view_timetable_table.Rows.Remove(view_timetable_table.CurrentRow);
                    databaseConnection.Close();

                    view_timetable_table.Update();
                    view_timetable_table.Refresh();
                }
            }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand getTimetables = new MySqlCommand("select timetable_id, intake, degree_programme, semester, validity_period_start, validity_period_end, week from ttms_timetable_main t1 inner join ttms_degree_programme t2 on t1.degree_programme_id = t2.degree_programme_id inner join intakes t3 on t1.intake_id = t3.id where semester like '%" + search_textbox.Text + "%' or validity_period_start like '%" + search_textbox.Text + "%' or week like '%" + search_textbox.Text + "%' or intake like '%" + search_textbox.Text + "%' order by validity_period_start desc", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getTimetables);
            databaseConnection.Close();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            view_timetable_table.DataSource = dt;

            if (view_timetable_table.Rows.Count > 0)
            {
                no_rec_label.Visible = false;
                try_search_again_label.Visible = false;
            }
            else
            {
                no_rec_label.Visible = true;
                try_search_again_label.Visible = true;
            }
        }

        private void LoadFromDates(string start_date, string end_date)
        {
            databaseConnection.Open();
            MySqlCommand getTimetables = new MySqlCommand("select timetable_id, intake, degree_programme, semester, validity_period_start, validity_period_end, week from ttms_timetable_main t1 inner join ttms_degree_programme t2 on t1.degree_programme_id = t2.degree_programme_id inner join intakes t3 on t1.intake_id = t3.id where validity_period_start >= '" + start_date + "' and validity_period_end <= '" + end_date + "' order by validity_period_start desc", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getTimetables);
            databaseConnection.Close();
            DataTable dt = new DataTable();
            sda.Fill(dt);
            view_timetable_table.DataSource = dt;

            if (view_timetable_table.Rows.Count > 0)
            {
                no_rec_label.Visible = false;
                try_search_again_label.Visible = false;
            }
            else
            {
                no_rec_label.Visible = true;
                try_search_again_label.Visible = true;
            }
        }

        private void start_ValueChanged(object sender, EventArgs e)
        {
            search_textbox.Text = null;
            sort_combo.SelectedIndex = 0;
            string start_date = start.Value.ToString("yyyy-MM-dd");
            string end_date = end.Value.ToString("yyyy-MM-dd");

            LoadFromDates(start_date, end_date);
        }

        private void end_ValueChanged(object sender, EventArgs e)
        {
            search_textbox.Text = null;
            sort_combo.SelectedIndex = 0;
            string start_date = start.Value.ToString("yyyy-MM-dd");
            string end_date = end.Value.ToString("yyyy-MM-dd");

            LoadFromDates(start_date, end_date);
        }

        private void sort_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_textbox.Text = null;


            if (sort_combo.SelectedIndex == 1)
            {
                var today = DateTime.Today.Year;
                Int32 last_year = Convert.ToInt32(today.ToString()) - 1;

                string start_date = last_year + "-01-01";

                databaseConnection.Open();
                MySqlCommand getTimetables = new MySqlCommand("select timetable_id, intake, degree_programme, semester, validity_period_start, validity_period_end, week from ttms_timetable_main t1 inner join ttms_degree_programme t2 on t1.degree_programme_id = t2.degree_programme_id inner join intakes t3 on t1.intake_id = t3.id where validity_period_start < '" + start_date + "' order by validity_period_start desc", databaseConnection);
                MySqlDataAdapter sda = new MySqlDataAdapter(getTimetables);
                databaseConnection.Close();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                view_timetable_table.DataSource = dt;

                if (view_timetable_table.Rows.Count > 0)
                {
                    no_rec_label.Visible = false;
                    try_search_again_label.Visible = false;
                }
                else
                {
                    no_rec_label.Visible = true;
                    try_search_again_label.Visible = true;
                }
            }
            else if (sort_combo.SelectedIndex == 2)
            {
                var today = DateTime.Today.Year;
                Int32 last_year = Convert.ToInt32(today.ToString()) - 1;

                string start_date = last_year + "-01-01";
                string end_date = last_year + "-12-31";

                LoadFromDates(start_date, end_date);

            }
            else if (sort_combo.SelectedIndex == 3)
            {
                var today = DateTime.Today;
                var month = new DateTime(today.Year, today.Month, 1);
                var first = month.AddMonths(-1);
                string start_date = first.ToString("yyyy-MM-dd");
                var last = month.AddDays(-1);
                string end_date = last.ToString("yyyy-MM-dd");

                LoadFromDates(start_date, end_date);
            }
            else if (sort_combo.SelectedIndex == 4)
            {
                DayOfWeek weekStart = DayOfWeek.Monday;
                DateTime startingDate = DateTime.Today;

                while (startingDate.DayOfWeek != weekStart)
                    startingDate = startingDate.AddDays(-1);

                string previousWeekStart = startingDate.AddDays(-7).ToString("yyyy-MM-dd");
                string previousWeekEnd = startingDate.AddDays(-1).ToString("yyyy-MM-dd");

                LoadFromDates(previousWeekStart, previousWeekEnd);
            }

        }


        private void refresh_btn_Click(object sender, EventArgs e)
        {
            no_rec_label.Visible = false;
            try_search_again_label.Visible = false;

            sort_combo.SelectedIndex = 0;
            search_textbox.Text = null;
            databaseConnection.Open();
            string query = "select timetable_id,intake,degree_programme,semester,validity_period_start,validity_period_end,week from ttms_timetable_main t1 inner join ttms_degree_programme t2 on t1.degree_programme_id = t2.degree_programme_id inner join intakes t3 on t1.intake_id = t3.id order by validity_period_start desc";

            MySqlCommand sqlComman = new MySqlCommand(query, databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlComman);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            view_timetable_table.DataSource = dt;
            databaseConnection.Close();
        }
    }
}
