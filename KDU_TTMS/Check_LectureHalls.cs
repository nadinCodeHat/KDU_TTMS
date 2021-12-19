using KDU_TTMS.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Check_LectureHalls : Form
    {
        public Check_LectureHalls()
        {
            InitializeComponent();
        }
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db;");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Get_Lecturer_Info get_lecturer_info = new Get_Lecturer_Info();
            get_lecturer_info.ShowDialog();
        }

        private void lecturehall_info_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("Select id from lecture_hall_info where lecture_hall = '" + this.lecturehall_info_table.CurrentRow.Cells[0].Value.ToString() + "'", databaseConnection);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            databaseConnection.Close();

            lecture_hall_name.Text = this.lecturehall_info_table.CurrentRow.Cells[0].Value.ToString();
            hall_capacity.Text = this.lecturehall_info_table.CurrentRow.Cells[1].Value.ToString();
            availability.Text = this.lecturehall_info_table.CurrentRow.Cells[2].Value.ToString();
            if (lecturehall_info_table.CurrentRow.Cells[2].Value.ToString() == "Available")
            {
                guna2CirclePictureBox1.Image = Resources.available;
                groupBox1.Visible = false;
            }
            else
            {
                guna2CirclePictureBox1.Image = Resources.busy;
                groupBox1.Visible = true;

            }
        }

        private void Check_LectureHalls_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet_getLectureHallInfo.lecture_hall_info' table. You can move, or remove it, as needed.
            this.lecture_hall_infoTableAdapter.Fill(this.dataSet_getLectureHallInfo.lecture_hall_info);
            CheckIFAvailable();
        }

        string today = DateTime.Now.ToString("yyyy-MM-dd");
        private void CheckIFAvailable()
        {
            databaseConnection.Open();
            MySqlCommand getavailability = new MySqlCommand("Select timetable_id from ttms_timetable_main where validity_period_start <='" + today + "' and validity_period_end >='" + today + "'", databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(getavailability);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                DataTable nwDt = new DataTable();
                foreach (DataRow dr in dt.Rows)
                {
                    MySqlCommand getDay_and_lecture_hall = new MySqlCommand("Select lecture_hall from ttms_lecture_module where day = '" + DateTime.Now.DayOfWeek.ToString() + "' and timetable_id='" + dr["timetable_id"] + "'", databaseConnection);
                    MySqlDataAdapter sda2 = new MySqlDataAdapter(getDay_and_lecture_hall);
                    sda2.Fill(nwDt);
                }
                if (nwDt.Rows.Count > 0)
                {
                    foreach (DataRow dr in nwDt.Rows)
                    {
                        MySqlCommand setAvailability = new MySqlCommand(@"INSERT INTO lecture_hall_info(availability) VALUES(@availability) where lecture_hall='" + dr["lecture_hall"] + "'", databaseConnection);
                        setAvailability.Parameters.AddWithValue("@availability", "Not Availabe");
                        setAvailability.ExecuteNonQuery();
                    }
                }
                else
                {

                }
            }
            databaseConnection.Close();
        }
    }
}
