using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Manage_LectureHalls : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db;");

        public Manage_LectureHalls()
        {
            InitializeComponent();
        }

        private void LectureHall_Management_Form_Load(object sender, EventArgs e)
        {
            this.lecture_hall_infoTableAdapter.Fill(this.dataSet_getLectureHallInfo.lecture_hall_info);
            CheckIFAvailable();
        }

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

            if (e.ColumnIndex == 3)
            {

                Add_Update_LectureHall add_update_lecture_hall = new Add_Update_LectureHall(id);
                add_update_lecture_hall.lecture_hall_textbox.Text = this.lecturehall_info_table.CurrentRow.Cells[0].Value.ToString();
                add_update_lecture_hall.capacity_numeric.Value = (int)this.lecturehall_info_table.CurrentRow.Cells[1].Value;
                add_update_lecture_hall.update_btn.Visible = true;
                add_update_lecture_hall.add_hall_btn.Visible = false;
                add_update_lecture_hall.add_update_heading.Text = "Edit Lecture Hall";
                add_update_lecture_hall.ShowDialog();

                //Refresh LectureHall table
                this.lecture_hall_infoTableAdapter.Fill(this.dataSet_getLectureHallInfo.lecture_hall_info);
            }
            if (e.ColumnIndex == 4)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    if (e.RowIndex >= 0)
                    {
                        databaseConnection.Open();
                        DataGridViewRow row = lecturehall_info_table.Rows[e.RowIndex];
                        MySqlCommand cmd1 = new MySqlCommand("Delete from lecture_hall_info where lecture_hall = '" + row.Cells[0].Value.ToString() + "'", databaseConnection);
                        cmd1.ExecuteNonQuery();

                        //remove from datatable
                        lecturehallinfoBindingSource.RemoveCurrent();

                        //Refresh Module Table
                        this.lecture_hall_infoTableAdapter.Fill(this.dataSet_getLectureHallInfo.lecture_hall_info);
                        databaseConnection.Close();
                    }
            }

            lecture_hall_name.Text = this.lecturehall_info_table.CurrentRow.Cells[0].Value.ToString();
            hall_capacity.Text = this.lecturehall_info_table.CurrentRow.Cells[1].Value.ToString();
            availability.Text = this.lecturehall_info_table.CurrentRow.Cells[2].Value.ToString();
            if (lecturehall_info_table.CurrentRow.Cells[2].Value.ToString() == "Available")
            {
                guna2CirclePictureBox1.Image = Properties.Resources.available;
                groupBox1.Visible = false;
            }
            else
            {
                guna2CirclePictureBox1.Image = Properties.Resources.busy;
                groupBox1.Visible = true;

            }
        }

        string today = DateTime.Now.ToString("yyyy-MM-dd");
        private void CheckIFAvailable()
        {
            databaseConnection.Open();
            MySqlCommand getavailability = new MySqlCommand("Select timetable_id from ttms_timetable_main where validity_period_start<='" + today + "' and validity_period_end>='" + today + "'", databaseConnection);
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

        private void add_btn_Click(object sender, EventArgs e)
        {
            //Add_Update_LectureHall add_update_lecture_hall = new Add_Update_LectureHall();
            //add_update_lecture_hall.update_btn.Visible = false;
            //add_update_lecture_hall.add_hall_btn.Visible = true;
            //add_update_lecture_hall.add_update_heading.Text = "Add Lecture Hall";
            //add_update_lecture_hall.ShowDialog();
            Add_Update_LectureHall add_update_lecture_hall = new Add_Update_LectureHall();
            add_update_lecture_hall.ShowDialog();
        }

        private void lecturer_name_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
