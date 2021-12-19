using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Manage_Students : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Manage_Students()
        {
            InitializeComponent();
        }

        private void LoadStudents()
        {
            student_info_table.Columns.Clear();
            student_info_table.DataSource = null;
            student_info_table.Rows.Clear();
            student_info_table.Refresh();
            // view_timetable_table.CellClick += view_timetable_table_CellClick;
            databaseConnection.Open();
            string query = "select student_info.student_reg_no,student_info.student_name,student_info.student_course_stream,student_info.student_email,student_info.student_mobile,intakes.intake from student_info inner join intakes on intakes.id = student_info.intake_id order by intakes.intake";
            MySqlCommand sqlComman = new MySqlCommand(query, databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(sqlComman);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            student_info_table.DataSource = dt;
            databaseConnection.Close();

            student_info_table.Columns[0].Name = "registration_no";
            student_info_table.Columns[1].Name = "student_name";
            student_info_table.Columns[2].Name = "course_stream";
            student_info_table.Columns[3].Name = "email";
            student_info_table.Columns[4].Name = "mobile_no";
            student_info_table.Columns[5].Name = "intake";

            student_info_table.Columns[0].HeaderText = "Registration Number";
            student_info_table.Columns[1].HeaderText = "Student Name";
            student_info_table.Columns[2].HeaderText = "Course Stream";
            student_info_table.Columns[3].HeaderText = "Email";
            student_info_table.Columns[4].HeaderText = "Mobile No.";
            student_info_table.Columns[5].HeaderText = "Intake";

            DataGridViewImageColumn viewBtn = new DataGridViewImageColumn();
            DataGridViewImageColumn deleteBtn = new DataGridViewImageColumn();
            viewBtn.Name = "view_btn";
            viewBtn.HeaderText = "";
            viewBtn.Image = Resources.edit_btn;
            viewBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            student_info_table.Columns.Insert(6, viewBtn);

            deleteBtn.Name = "delete_btn";
            deleteBtn.HeaderText = "";
            deleteBtn.Image = Resources.delete;
            deleteBtn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            student_info_table.Columns.Insert(7, deleteBtn);


            //Set Column Width
            for (int i = 0; i <= 7; i++)
            {
                DataGridViewColumn tt_id_col = student_info_table.Columns[i];
                if (i == 0)
                {
                    tt_id_col.Width = 150;
                }
                else if (i == 1)
                {
                    tt_id_col.Width = 220;
                }
                else if (i == 2)
                {
                    tt_id_col.Width = 200;
                }
                else if (i == 3)
                {
                    tt_id_col.Width = 180;
                }
                else if (i == 4)
                {
                    tt_id_col.Width = 100;
                }
                else if (i == 5)
                {
                    tt_id_col.Width = 80;
                }
                else if (i == 6)
                {
                    tt_id_col.Width = 50;
                }
                else if (i == 7)
                {
                    tt_id_col.Width = 50;
                }
            }

        }

        private void MA_Accounts_Form_Load(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (Add_Update_Student add_stud_lecturer_frm = new Add_Update_Student())
            {
                add_stud_lecturer_frm.update_btn.Visible = false;
                add_stud_lecturer_frm.add_btn.Visible = true;
                add_stud_lecturer_frm.heading_lb.Text = "Add Student";
                add_stud_lecturer_frm.ShowDialog();
            }
            LoadStudents();
        }

        private void student_info_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select id from student_info where student_reg_no = '" + this.student_info_table.CurrentRow.Cells["registration_no"].Value.ToString() + "'", databaseConnection);
            int id = Convert.ToInt32(cmd1.ExecuteScalar());
            databaseConnection.Close();

            if (e.ColumnIndex == student_info_table.Columns["view_btn"].Index)
            {
                Add_Update_Student add_stud_lecturer_frm = new Add_Update_Student(id, this.student_info_table.CurrentRow.Cells["email"].Value.ToString());

                add_stud_lecturer_frm.stud_regnum_textbox.Text = this.student_info_table.CurrentRow.Cells["registration_no"].Value.ToString();
                add_stud_lecturer_frm.stud_name_textbox.Text = this.student_info_table.CurrentRow.Cells["student_name"].Value.ToString();
                add_stud_lecturer_frm.student_course_stream_combo.SelectedItem = this.student_info_table.CurrentRow.Cells["course_stream"].Value.ToString();
                add_stud_lecturer_frm.stud_email_textbox.Text = this.student_info_table.CurrentRow.Cells["email"].Value.ToString();
                add_stud_lecturer_frm.stud_mobile_textbox.Text = this.student_info_table.Rows[e.RowIndex].Cells["mobile_no"].Value.ToString();
                add_stud_lecturer_frm.intake_combobox.SelectedItem = this.student_info_table.CurrentRow.Cells["intake"].Value.ToString();

                add_stud_lecturer_frm.update_btn.Visible = true;
                add_stud_lecturer_frm.add_btn.Visible = false;
                add_stud_lecturer_frm.heading_lb.Text = "Edit Student";
                add_stud_lecturer_frm.ShowDialog();

                LoadStudents();
            }

            else if (e.ColumnIndex == student_info_table.Columns["delete_btn"].Index)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("Delete from student_info where student_reg_no = '" + this.student_info_table.CurrentRow.Cells["registration_no"].Value.ToString() + "'", databaseConnection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successful");
                    databaseConnection.Close();
                    //remove from datatable
                    student_info_table.Rows.Remove(student_info_table.CurrentRow);
                    //refresh table
                    LoadStudents();
                }
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            search_textbox.Text = null;
            LoadStudents();
        }

        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)

                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }

        private void export_btn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:";
            sfd.Title = "Save as Excel File";
            sfd.Filter = "Excel Files(2003)|*.xls";
            sfd.FileName = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");

                ToCsV(student_info_table, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (search_textbox.Text == null)
            {

            }
            else
            {
                databaseConnection.Open();
                string query = "select * from student_info where student_name like '%" + search_textbox.Text + "%' or student_reg_no like '%" + search_textbox.Text + "%'or student_email like '%" + search_textbox.Text + "%'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, databaseConnection);
                DataTable dttable = new DataTable();
                adpt.Fill(dttable);
                student_info_table.DataSource = dttable;
                databaseConnection.Close();

                if (student_info_table.Rows.Count > 0)
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
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand getRecords = new MySqlCommand("Select student_info.student_reg_no,student_info.student_name,student_info.student_course_stream,student_info.student_email,student_info.student_mobile,intakes.intake from student_info inner join intakes on intakes.id = student_info.intake_id where student_info.student_reg_no like '%" + search_textbox.Text + "%' or student_info.student_name like '%" + search_textbox.Text + "%' or student_info.student_course_stream like '%" + search_textbox.Text + "%' or student_info.student_email like '%" + search_textbox.Text + "%' or intakes.intake like '%" + search_textbox.Text + "%'  order by intakes.intake", databaseConnection);
            MySqlDataAdapter sdr = new MySqlDataAdapter(getRecords);
            databaseConnection.Close();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            student_info_table.DataSource = dt;


            if (student_info_table.Rows.Count > 0)
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

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}