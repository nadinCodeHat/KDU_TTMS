using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace KDU_Time_Table_Management_System
{
    public partial class Assist_Admin_Add_TT_Form : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Assist_Admin_Add_TT_Form()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        private void MA_Add_Timetable_Form_Load(object sender, EventArgs e)
        {
            populateTable();
            loadIntakes();

            dt.Rows.Clear();
            databaseConnection.Open();
            MySqlCommand checkVaidity_period = new MySqlCommand("Select ttms_timetable_main.timetable_id,ttms_lecture_module.time_slot,ttms_lecture_module.lecture_hall,ttms_lecture_module.day from ttms_timetable_main inner join ttms_lecture_module on ttms_timetable_main.timetable_id=ttms_lecture_module.timetable_id where validity_period_start <= '" + today + "' and validity_period_end >='" + today + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(checkVaidity_period);

            sda.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MySqlCommand updateAllLectureHalls = new MySqlCommand("Update lecture_hall_info set availability=@availability", databaseConnection);
                updateAllLectureHalls.Parameters.AddWithValue("availability", "Available");
                updateAllLectureHalls.ExecuteNonQuery();

            }
            databaseConnection.Close();
        }

        bool IsTheSameCellValue(int column, int row)
        {
            DataGridViewCell cell1 = timetable_table[column, row];
            DataGridViewCell cell2 = timetable_table[column, row - 1];
            if (cell1.Value == null || cell2.Value == null)
            {
                return false;
            }
            return cell1.Value.ToString() == cell2.Value.ToString();
        }


        /// <summary>
        /// Disables the Tea Break and Lunch Break Times and the Time Slots     
        private void disableCells()
        {
            timetable_table.Rows[0].Cells[0].ReadOnly = true;
            timetable_table.Rows[1].Cells[0].ReadOnly = true;
            timetable_table.Rows[2].Cells[0].ReadOnly = true;
            for (int i = 0; i <= 15; i++)
            {
                timetable_table.Rows[3].Cells[i].ReadOnly = true;
            }

            timetable_table.Rows[4].Cells[0].ReadOnly = true;
            timetable_table.Rows[5].Cells[0].ReadOnly = true;
            timetable_table.Rows[6].Cells[0].ReadOnly = true;

            for (int i = 0; i <= 15; i++)
            {
                timetable_table.Rows[7].Cells[i].ReadOnly = true;
            }

            timetable_table.Rows[8].Cells[0].ReadOnly = true;
        }
        /// </summary>

        /// <summary>
        /// Styling the grid and setting Time Slots
        private void populateTable()
        {
            timetable_table.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            foreach (DataGridViewColumn item in timetable_table.Columns)
            {
                item.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // foreach (DataGridViewRow row in timetable_table.Rows)
            // {
            //Reference the ComboBoxCell.
            //     DataGridViewComboBoxCell comboBoxCell = (row.Cells[3] as DataGridViewComboBoxCell);
            //     comboBoxCell.Items.Add("Select Country");
            //Set the Default Value as the Selected Value.
            ///      comboBoxCell.Value = "Select Country";
            //  }


            timetable_table.Rows.Add("0800 - 0900", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            timetable_table.Rows[0].Cells[1].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[0].Cells[4].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[0].Cells[7].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[0].Cells[10].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[0].Cells[13].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            timetable_table.Rows.Add("0900 - 1000", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            timetable_table.Rows[1].Cells[1].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[1].Cells[4].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[1].Cells[7].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[1].Cells[10].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[1].Cells[13].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            timetable_table.Rows.Add("1000 - 1100", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            timetable_table.Rows[2].Cells[1].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[2].Cells[4].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[2].Cells[7].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[2].Cells[10].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[2].Cells[13].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            timetable_table.Rows.Add("1100 - 1115", null, null, null, "T", "E", "A", null, "B", "R", "E", "A", "K", null, null, null);
            timetable_table.Rows[3].Cells[0].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            for (int i = 0; i <= 15; i++)
            {
                timetable_table.Rows[3].Cells[i].Style.BackColor = Color.LightGray;
            }
            for (int i = 4; i < 7; i++)
            {
                timetable_table.Rows[3].Cells[i].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                timetable_table.Rows[3].Cells[i].Style.BackColor = Color.LightGray;
            }
            for (int i = 8; i < 13; i++)
            {
                timetable_table.Rows[3].Cells[i].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                timetable_table.Rows[3].Cells[i].Style.BackColor = Color.LightGray;
            }


            timetable_table.Rows.Add("1115 - 1215", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            timetable_table.Rows[4].Cells[1].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[4].Cells[4].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[4].Cells[7].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[4].Cells[10].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[4].Cells[13].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            timetable_table.Rows.Add("1215 - 1315", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            timetable_table.Rows[5].Cells[1].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[5].Cells[4].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[5].Cells[7].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[5].Cells[10].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[5].Cells[13].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            timetable_table.Rows.Add("1315 - 1415", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            timetable_table.Rows[6].Cells[1].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[6].Cells[4].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[6].Cells[7].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[6].Cells[10].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[6].Cells[13].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            timetable_table.Rows.Add("1415 - 1430", null, null, "L", "U", "N", "C", "H", null, "B", "R", "E", "A", "K", null, null);
            timetable_table.Rows[7].Cells[0].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            for (int i = 0; i <= 15; i++)
            {
                timetable_table.Rows[7].Cells[i].Style.BackColor = Color.LightGray;
            }
            for (int i = 3; i < 8; i++)
            {
                timetable_table.Rows[7].Cells[i].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
            for (int i = 9; i < 14; i++)
            {
                timetable_table.Rows[7].Cells[i].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }

            timetable_table.Rows.Add("1430 - 1615", null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
            timetable_table.Rows[8].Cells[1].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[8].Cells[4].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[8].Cells[7].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[8].Cells[10].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            timetable_table.Rows[8].Cells[13].Style.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            disableCells();
        }
        /// </summary>

        private void loadIntakes()
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT intake FROM intakes", databaseConnection);
            cmd.Connection = databaseConnection;

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                select_intake_combobox.Items.Add(reader["intake"]);
            }
            reader.Close();
            databaseConnection.Close();
            select_intake_combobox.SelectedIndex = 0;
        }

        private void select_lecture_modules(int sem)
        {
            MySqlDataAdapter sqlcmd = new MySqlDataAdapter("Select lecture_code,lecture_module,lecture_abbr,lecturer,credit,gpatype,module_type from module_info where semester ='" + sem + "'", databaseConnection);
            DataTable dt = new DataTable();
            sqlcmd.Fill(dt);
            guna2DataGridView1.DataSource = dt;

            guna2DataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            guna2DataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            guna2DataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.Columns[0].HeaderText = "Module Code";
            guna2DataGridView1.Columns[1].HeaderText = "Module Name";
            guna2DataGridView1.Columns[2].HeaderText = "";
            guna2DataGridView1.Columns[3].HeaderText = "Lecturer";
            guna2DataGridView1.Columns[4].HeaderText = "Credits";
            guna2DataGridView1.Columns[5].HeaderText = "Type";
            guna2DataGridView1.Columns[6].HeaderText = "C / E";
        }

        private void select_sem_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (select_sem_combo.SelectedIndex == 0)
            {
                int sem = int.Parse(select_sem_combo.SelectedItem.ToString());
                select_lecture_modules(sem);
            }
            else if (select_sem_combo.SelectedIndex == 1)
            {
                int sem = int.Parse(select_sem_combo.SelectedItem.ToString());
                select_lecture_modules(sem);
            }
            else if (select_sem_combo.SelectedIndex == 2)
            {
                int sem = int.Parse(select_sem_combo.SelectedItem.ToString());
                select_lecture_modules(sem);
            }
            else if (select_sem_combo.SelectedIndex == 3)
            {
                int sem = int.Parse(select_sem_combo.SelectedItem.ToString());
                select_lecture_modules(sem);
            }
        }

        private void timetable_table_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex == 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.Value = "";
                e.FormattingApplied = true;

            }
        }

        private void timetable_table_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;
            if (e.RowIndex < 1 || e.ColumnIndex < 0)
                return;
            if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
            {
                e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;

            }
            else
            {
                e.AdvancedBorderStyle.Top = timetable_table.AdvancedCellBorderStyle.Top;
            }
        }

        public void executeLecture(string vall, int cellNo1, int cellNo2, int cellNo3, string dayVal, string timeSlot, int rowNo)
        {
            if (Convert.ToString(timetable_table.Rows[rowNo].Cells[cellNo1].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo].Cells[cellNo2].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo].Cells[cellNo3].Value) == string.Empty)
            {


            }
            else
            {
                MySqlCommand insertMondayMt1 = new MySqlCommand(@"Insert into ttms_lecture_module(time_slot,lecture_abbr,strength,lecture_hall,day,lecturer,timetable_id,lecture_code) VALUES(@time_slot,@lecture_abbr,@strength,@lecture_hall,@day,@lecturer,@timetable_id,@lecture_code)", databaseConnection);
                insertMondayMt1.Parameters.AddWithValue("@time_slot", timeSlot);
                insertMondayMt1.Parameters.AddWithValue("@lecture_abbr", timetable_table.Rows[rowNo].Cells[cellNo1].Value);
                insertMondayMt1.Parameters.AddWithValue("@strength", timetable_table.Rows[rowNo].Cells[cellNo2].Value);
                insertMondayMt1.Parameters.AddWithValue("@lecture_hall", timetable_table.Rows[rowNo].Cells[cellNo3].Value);
                insertMondayMt1.Parameters.AddWithValue("@day", dayVal);

                MySqlCommand getLecturer = new MySqlCommand("SELECT lecturer from module_info where lecture_abbr ='" + timetable_table.Rows[rowNo].Cells[cellNo1].Value + "'", databaseConnection);
                string lecturer = getLecturer.ExecuteScalar().ToString();

                MySqlCommand getCode = new MySqlCommand("SELECT lecture_code from module_info where lecture_abbr ='" + timetable_table.Rows[rowNo].Cells[cellNo1].Value + "'", databaseConnection);
                string code = getCode.ExecuteScalar().ToString();

                insertMondayMt1.Parameters.AddWithValue("@lecturer", lecturer);
                insertMondayMt1.Parameters.AddWithValue("@timetable_id", vall);
                insertMondayMt1.Parameters.AddWithValue("@lecture_code", code);
                insertMondayMt1.ExecuteNonQuery();
            }

            //////////////////////////////////////////////////////////////////////////////////////////////////////HERE
        }
        /// ///////////////////////////////////////////////////////////////////////

        public int checkModules(int cellNo1, int cellNo2, int cellNo3, int rowNo1, int rowNo2, int rowNo3)
        {
            if (Convert.ToString(timetable_table.Rows[rowNo1].Cells[cellNo1].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo1].Cells[cellNo2].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo1].Cells[cellNo3].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo2].Cells[cellNo1].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo2].Cells[cellNo2].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo2].Cells[cellNo3].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo3].Cells[cellNo1].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo3].Cells[cellNo2].Value) == string.Empty || Convert.ToString(timetable_table.Rows[rowNo3].Cells[cellNo3].Value) == string.Empty)
            {
                return 10;
            }
            else
            {
                if (timetable_table.Rows[rowNo1].Cells[cellNo1].Value.ToString() != timetable_table.Rows[rowNo2].Cells[cellNo1].Value.ToString()
                && timetable_table.Rows[rowNo2].Cells[cellNo1].Value.ToString() != timetable_table.Rows[rowNo3].Cells[cellNo1].Value.ToString())
                {
                    return 1;
                }
                else if (timetable_table.Rows[rowNo2].Cells[cellNo1].Value.ToString() == timetable_table.Rows[rowNo1].Cells[cellNo1].Value.ToString()
                    && timetable_table.Rows[rowNo3].Cells[cellNo1].Value.ToString() != timetable_table.Rows[rowNo2].Cells[cellNo1].Value.ToString())
                {
                    return 2;
                }
                else if (timetable_table.Rows[rowNo2].Cells[cellNo1].Value.ToString() == timetable_table.Rows[rowNo3].Cells[cellNo1].Value.ToString()
                    && timetable_table.Rows[rowNo2].Cells[cellNo1].Value.ToString() != timetable_table.Rows[rowNo1].Cells[cellNo1].Value.ToString())
                {
                    return 3;
                }
                else if (timetable_table.Rows[rowNo1].Cells[cellNo1].Value.ToString() == timetable_table.Rows[rowNo2].Cells[cellNo1].Value.ToString()
                    && timetable_table.Rows[rowNo2].Cells[cellNo1].Value.ToString() == timetable_table.Rows[rowNo3].Cells[cellNo1].Value.ToString())
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                databaseConnection.Open();
                MySqlCommand getDegreeProgramme = new MySqlCommand("Select degree_programme_id from ttms_degree_programme where degree_programme ='" + select_degree_prog_combo.SelectedItem + "'", databaseConnection);
                Int32 degreeID = Convert.ToInt32(getDegreeProgramme.ExecuteScalar());

                //SqlCommand reset_id = new SqlCommand("DBCC CHECKIDENT(ttms_timetable_initiate_table,reseed,1)", conn1);
                // reset_id.ExecuteNonQuery();

                MySqlCommand getIntakeId = new MySqlCommand("Select id from intakes where intake= '" + select_intake_combobox.SelectedItem + "'", databaseConnection);
                Int32 intakeId = Convert.ToInt32(getIntakeId.ExecuteScalar());

                MySqlCommand inserttimetableInitiate = new MySqlCommand(@"INSERT INTO ttms_timetable_main(intake_id,degree_programme_id,semester,validity_period_start,validity_period_end,week) VALUES(@intake_id,@degree_programme_id,@semester,@validity_period_start,@validity_period_end,@week)", databaseConnection);
                inserttimetableInitiate.Parameters.AddWithValue("@intake_id", intakeId);
                inserttimetableInitiate.Parameters.AddWithValue("@degree_programme_id", degreeID);
                inserttimetableInitiate.Parameters.AddWithValue("@semester", select_sem_combo.SelectedItem);
                inserttimetableInitiate.Parameters.AddWithValue("@validity_period_start", validity_period_start.Value.ToString("yyyy-MM-dd"));
                inserttimetableInitiate.Parameters.AddWithValue("@validity_period_end", validity_period_end.Value.ToString("yyyy-MM-dd"));
                inserttimetableInitiate.Parameters.AddWithValue("@week", select_week_combo.SelectedItem);
                inserttimetableInitiate.ExecuteNonQuery();

                //Int32 modified = (Int32)inserttimetableInitiate.ExecuteScalar();

                //    if (conn1.State == ConnectionState.Open)
                //    {
                //    conn1.Close();
                //    }
                //    string vall = modified.ToString();


                //FOR GETTING MAX ID
                MySqlCommand cmmd = new MySqlCommand("SELECT MAX(timetable_id) FROM ttms_timetable_main", databaseConnection);
                string vall = cmmd.ExecuteScalar().ToString();


                // SqlCommand cmmd = new SqlCommand("SELECT SCOPE_IDENTITY() FROM ttms_timetable_initiate_table", conn1);
                //    string vall = cmmd.ExecuteScalar().ToString();


                //FOR RESEEDING
                // SqlCommand reset_lecture_module_id = new SqlCommand("DBCC CHECKIDENT(ttms_lecture_module_table,reseed,1)", conn1);
                // reset_lecture_module_id.ExecuteNonQuery();
                //conn1.Close();

                //Monday Morning lectures
                int m_morning = checkModules(1, 2, 3, 0, 1, 2);
                if (m_morning == 10)
                {

                }
                else
                {
                    if (m_morning == 1)
                    {
                        executeLecture(vall, 1, 2, 3, "Monday", "0800 - 0900", 0);
                        executeLecture(vall, 1, 2, 3, "Monday", "0900 - 1000", 1);
                        executeLecture(vall, 1, 2, 3, "Monday", "1000 - 1100", 2);
                    }
                    else if (m_morning == 2)
                    {
                        executeLecture(vall, 1, 2, 3, "Monday", "0800 - 1000", 0);
                        executeLecture(vall, 1, 2, 3, "Monday", "1000 - 1100", 2);
                    }
                    else if (m_morning == 3)
                    {
                        executeLecture(vall, 1, 2, 3, "Monday", "0800 - 0900", 0);
                        executeLecture(vall, 1, 2, 3, "Monday", "0900 - 1100", 1);
                    }
                    else if (m_morning == 4)
                    {
                        executeLecture(vall, 1, 2, 3, "Monday", "0800 - 1100", 0);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }


                //Tuesday Morning lectures
                int t_morning = checkModules(4, 5, 6, 0, 1, 2);
                if (t_morning == 10)
                {

                }
                else
                {
                    if (t_morning == 1)
                    {
                        executeLecture(vall, 4, 5, 6, "Tuesday", "0800 - 0900", 0);
                        executeLecture(vall, 4, 5, 6, "Tuesday", "0900 - 1000", 1);
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1000 - 1100", 2);
                    }
                    else if (t_morning == 2)
                    {
                        executeLecture(vall, 4, 5, 6, "Tuesday", "0800 - 1000", 0);
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1000 - 1100", 2);
                    }
                    else if (t_morning == 3)
                    {
                        executeLecture(vall, 4, 5, 6, "Tuesday", "0800 - 0900", 0);
                        executeLecture(vall, 4, 5, 6, "Tuesday", "0900 - 1100", 1);
                    }
                    else if (t_morning == 4)
                    {
                        executeLecture(vall, 4, 5, 6, "Tuesday", "0800 - 1100", 0);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }


                //Wednesday Morning lectures
                int w_morning = checkModules(7, 8, 9, 0, 1, 2);
                if (w_morning == 10)
                {

                }
                else
                {
                    if (w_morning == 1)
                    {
                        executeLecture(vall, 7, 8, 9, "Wednesday", "0800 - 0900", 0);
                        executeLecture(vall, 7, 8, 9, "Wednesday", "0900 - 1000", 1);
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1000 - 1100", 2);
                    }
                    else if (w_morning == 2)
                    {
                        executeLecture(vall, 7, 8, 9, "Wednesday", "0800 - 1000", 0);
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1000 - 1100", 2);
                    }
                    else if (w_morning == 3)
                    {
                        executeLecture(vall, 7, 8, 9, "Wednesday", "0800 - 0900", 0);
                        executeLecture(vall, 7, 8, 9, "Wednesday", "0900 - 1100", 1);
                    }
                    else if (w_morning == 4)
                    {
                        executeLecture(vall, 7, 8, 9, "Wednesday", "0800 - 1100", 0);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }



                //Thursday Morning lectures
                int th_morning = checkModules(10, 11, 12, 0, 1, 2);

                if (th_morning == 10)
                {

                }
                else
                {
                    if (th_morning == 1)
                    {
                        executeLecture(vall, 10, 11, 12, "Thursday", "0800 - 0900", 0);
                        executeLecture(vall, 10, 11, 12, "Thursday", "0900 - 1000", 1);
                        executeLecture(vall, 10, 11, 12, "Thursday", "1000 - 1100", 2);
                    }
                    else if (th_morning == 2)
                    {
                        executeLecture(vall, 10, 11, 12, "Thursday", "0800 - 1000", 0);
                        executeLecture(vall, 10, 11, 12, "Thursday", "1000 - 1100", 2);
                    }
                    else if (th_morning == 3)
                    {
                        executeLecture(vall, 10, 11, 12, "Thursday", "0800 - 0900", 0);
                        executeLecture(vall, 10, 11, 12, "Thursday", "0900 - 1100", 1);
                    }
                    else if (th_morning == 4)
                    {
                        executeLecture(vall, 10, 11, 12, "Thursday", "0800 - 1100", 0);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }

                // Friday Morning lectures
                int fr_morning = checkModules(13, 14, 15, 0, 1, 2);

                if (fr_morning == 10)
                {

                }
                else
                {
                    if (fr_morning == 1)
                    {
                        executeLecture(vall, 13, 14, 15, "Friday", "0800 - 0900", 0);
                        executeLecture(vall, 13, 14, 15, "Friday", "0900 - 1000", 1);
                        executeLecture(vall, 13, 14, 15, "Friday", "1000 - 1100", 2);
                    }
                    else if (fr_morning == 2)
                    {
                        executeLecture(vall, 13, 14, 151, "Friday", "0800 - 1000", 0);
                        executeLecture(vall, 13, 14, 15, "Friday", "1000 - 1100", 2);
                    }
                    else if (fr_morning == 3)
                    {
                        executeLecture(vall, 13, 14, 15, "Friday", "0800 - 0900", 0);
                        executeLecture(vall, 13, 14, 15, "Friday", "0900 - 1100", 1);
                    }
                    else if (fr_morning == 4)
                    {
                        executeLecture(vall, 13, 14, 15, "Friday", "0800 - 1100", 0);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }

                // Monday Evening lectures
                int m_evening = checkModules(1, 2, 3, 4, 5, 6);

                if (m_evening == 10)
                {

                }
                else
                {
                    if (m_evening == 1)
                    {
                        executeLecture(vall, 1, 2, 3, "Monday", "1115 - 1215", 4);
                        executeLecture(vall, 1, 2, 3, "Monday", "1215 - 1315", 5);
                        executeLecture(vall, 1, 2, 3, "Monday", "1315 - 1415", 6);
                    }
                    else if (m_evening == 2)
                    {
                        executeLecture(vall, 1, 2, 3, "Monday", "1115 - 1315", 4);
                        executeLecture(vall, 1, 2, 3, "Monday", "1315 - 1415", 6);
                    }
                    else if (m_evening == 3)
                    {
                        executeLecture(vall, 1, 2, 3, "Monday", "1115 - 1215", 4);
                        executeLecture(vall, 1, 2, 3, "Monday", "1215 - 1415", 5);
                    }
                    else if (m_evening == 4)
                    {
                        executeLecture(vall, 1, 2, 3, "Monday", "1115 - 1415", 4);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }

                // Monday Evening lectures 2
                executeLecture(vall, 1, 2, 3, "Monday", "1430 - 1615", 8);

                // Tuesday Evening lectures
                int t_evening = checkModules(4, 5, 6, 4, 5, 6);

                if (t_evening == 10)
                {

                }
                else
                {
                    if (t_evening == 1)
                    {
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1115 - 1215", 4);
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1215 - 1315", 5);
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1315 - 1415", 6);
                    }
                    else if (t_evening == 2)
                    {
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1115 - 1315", 4);
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1315 - 1415", 6);
                    }
                    else if (t_evening == 3)
                    {
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1115 - 1215", 4);
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1215 - 1415", 5);
                    }
                    else if (t_evening == 4)
                    {
                        executeLecture(vall, 4, 5, 6, "Tuesday", "1115 - 1415", 4);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }

                // Tuesday Evening lectures 2
                executeLecture(vall, 4, 5, 6, "Tuesday", "1430 - 1615", 8);


                // Wednesday Evening lectures
                int w_evening = checkModules(7, 8, 9, 4, 5, 6);

                if (w_evening == 10)
                {

                }
                else
                {
                    if (w_evening == 1)
                    {
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1115 - 1215", 4);
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1215 - 1315", 5);
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1315 - 1415", 6);
                    }
                    else if (w_evening == 2)
                    {
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1115 - 1315", 4);
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1315 - 1415", 6);
                    }
                    else if (w_evening == 3)
                    {
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1115 - 1215", 4);
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1215 - 1415", 5);
                    }
                    else if (w_evening == 4)
                    {
                        executeLecture(vall, 7, 8, 9, "Wednesday", "1115 - 1415", 4);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }

                //Wednesday Evening lectures 2
                executeLecture(vall, 7, 8, 9, "Wednesday", "1430 - 1615", 8);


                // Thursday Evening lectures
                int th_evening = checkModules(10, 11, 12, 4, 5, 6);
                if (th_evening == 10)
                {

                }
                else
                {
                    if (th_evening == 1)
                    {
                        executeLecture(vall, 10, 11, 12, "Thursday", "1115 - 1215", 4);
                        executeLecture(vall, 10, 11, 12, "Thursday", "1215 - 1315", 5);
                        executeLecture(vall, 10, 11, 12, "Thursday", "1315 - 1415", 6);
                    }
                    else if (th_evening == 2)
                    {
                        executeLecture(vall, 10, 11, 12, "Thursday", "1115 - 1315", 4);
                        executeLecture(vall, 10, 11, 12, "Thursday", "1315 - 1415", 6);
                    }
                    else if (th_evening == 3)
                    {
                        executeLecture(vall, 10, 11, 12, "Thursday", "1115 - 1215", 4);
                        executeLecture(vall, 10, 11, 12, "Thursday", "1215 - 1415", 5);
                    }
                    else if (th_evening == 4)
                    {
                        executeLecture(vall, 10, 11, 12, "Thursday", "1115 - 1415", 4);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }
                }

                // Thursday Evening lectures 2
                executeLecture(vall, 10, 11, 12, "Thursday", "1430 - 1615", 8);

                // Friday Evening lectures
                int fr_evening = checkModules(13, 14, 15, 4, 5, 6);

                if (fr_evening == 10)
                {

                }
                else
                {
                    if (fr_evening == 1)
                    {
                        executeLecture(vall, 13, 14, 15, "Friday", "1115 - 1215", 4);
                        executeLecture(vall, 13, 14, 15, "Friday", "1215 - 1315", 5);
                        executeLecture(vall, 13, 14, 15, "Friday", "1315 - 1415", 6);
                    }
                    else if (fr_evening == 2)
                    {
                        executeLecture(vall, 13, 14, 15, "Friday", "1115 - 1315", 4);
                        executeLecture(vall, 13, 14, 15, "Friday", "1315 - 1415", 6);
                    }
                    else if (fr_evening == 3)
                    {
                        executeLecture(vall, 13, 14, 15, "Friday", "1115 - 1215", 4);
                        executeLecture(vall, 13, 14, 15, "Friday", "1215 - 1415", 5);
                    }
                    else if (fr_evening == 4)
                    {
                        executeLecture(vall, 13, 14, 15, "Friday", "1115 - 1415", 4);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Format");
                    }

                }
                // Friday Evening lectures 2
                executeLecture(vall, 13, 14, 15, "Friday", "1430 - 1615", 8);

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                databaseConnection.Close();

                TimetableCrystalForm crfrm = new TimetableCrystalForm(select_intake_combobox.SelectedItem.ToString(), select_week_combo.SelectedItem.ToString(), select_degree_prog_combo.SelectedItem.ToString(), select_sem_combo.SelectedItem.ToString(), validity_period_start.Value.ToString("yyyy-MM-dd"), validity_period_end.Value.ToString("yyyy-MM-dd"));
                crfrm.Show();
            }
        }

        string today = DateTime.Now.ToString("yyyy-MM-dd");
        //string[] dont_getthisLectureHall = new string[15];
        List<string> dontGet = new List<string>();
        private void checExistingTimetables(string getDay)
        {
            dontGet.Clear();

            if (dt.Rows.Count == 0)
            {

            }
            else
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["day"].ToString() == getDay)
                    {
                        if (dr["time_slot"].ToString() == "0800 - 0900")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "0900 - 1000")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "1000 - 1100")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "0800 - 1000")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "0900 - 1100")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "0800 - 1100")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());

                        }
                        else if (dr["time_slot"].ToString() == "1115 - 1215")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());

                        }
                        else if (dr["time_slot"].ToString() == "1215 - 1315")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "1315 - 1415")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "1430 - 1615")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "1215 - 1415")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "1115 - 1315")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }
                        else if (dr["time_slot"].ToString() == "1115 - 1415")
                        {
                            dontGet.Add(dr["lecture_hall"].ToString());
                        }

                    }
                }
            }
            databaseConnection.Close();
        }

        private List<string> FillCombo()
        {
            if (dt.Rows.Count == 0)
            {
                databaseConnection.Open();
                MySqlCommand cb = new MySqlCommand("Select lecture_hall from lecture_hall_info", databaseConnection);
                MySqlDataAdapter sda = new MySqlDataAdapter(cb);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                databaseConnection.Close();
                List<string> result = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    result.Add(dr["lecture_hall"].ToString());
                }
                return result;
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand cb = new MySqlCommand("Select lecture_hall from lecture_hall_info", databaseConnection);
                MySqlDataAdapter sda = new MySqlDataAdapter(cb);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                databaseConnection.Close();
                List<string> all = new List<string>();
                foreach (DataRow dr in dt.Rows)
                {
                    all.Add(dr["lecture_hall"].ToString());
                }
                List<string> result = all.Except(dontGet).ToList();
                return result;
            }
        }


        private void timetable_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex > -1)
            {
                // Bind grid cell with combobox and than bind combobox with datasource.  
                DataGridViewComboBoxCell l_objGridDropbox = new DataGridViewComboBoxCell();

                // Check the column  cell, in which it click.  
                if (timetable_table.Columns[e.ColumnIndex].Name.Contains("Column4"))
                {
                    if (e.RowIndex == 3 && e.ColumnIndex == 3 || e.RowIndex == 7 && e.ColumnIndex == 3)
                    {
                        //Block cell
                    }
                    else
                    {
                        checExistingTimetables("Monday");
                        timetable_table[e.ColumnIndex, e.RowIndex] = l_objGridDropbox;
                        l_objGridDropbox.DataSource = FillCombo();
                    }
                }
                if (timetable_table.Columns[e.ColumnIndex].Name.Contains("Column7"))
                {
                    if (e.RowIndex == 3 && e.ColumnIndex == 6 || e.RowIndex == 7 && e.ColumnIndex == 6)
                    {
                        //Block cell
                    }
                    else
                    {
                        checExistingTimetables("Tuesday");
                        timetable_table[e.ColumnIndex, e.RowIndex] = l_objGridDropbox;
                        l_objGridDropbox.DataSource = FillCombo();
                    }
                }
                if (timetable_table.Columns[e.ColumnIndex].Name.Contains("Column10"))
                {
                    if (e.RowIndex == 3 && e.ColumnIndex == 9 || e.RowIndex == 7 && e.ColumnIndex == 9)
                    {
                        //Block cell
                    }
                    else
                    {
                        checExistingTimetables("Wednesday");
                        timetable_table[e.ColumnIndex, e.RowIndex] = l_objGridDropbox;
                        l_objGridDropbox.DataSource = FillCombo();
                    }
                }
                if (timetable_table.Columns[e.ColumnIndex].Name.Contains("Column13"))
                {
                    if (e.RowIndex == 3 && e.ColumnIndex == 12 || e.RowIndex == 7 && e.ColumnIndex == 12)
                    {
                        //Block cell
                    }
                    else
                    {
                        checExistingTimetables("Thursday");
                        timetable_table[e.ColumnIndex, e.RowIndex] = l_objGridDropbox;
                        l_objGridDropbox.DataSource = FillCombo();
                    }
                }
                if (timetable_table.Columns[e.ColumnIndex].Name.Contains("Column16"))
                {
                    if (e.RowIndex == 3 && e.ColumnIndex == 15 || e.RowIndex == 7 && e.ColumnIndex == 15)
                    {
                        //Block cell
                    }
                    else
                    {
                        checExistingTimetables("Friday");
                        timetable_table[e.ColumnIndex, e.RowIndex] = l_objGridDropbox;
                        l_objGridDropbox.DataSource = FillCombo();
                    }
                }
            }
        }
    }
}
