using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Manage_Lecturers : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Manage_Lecturers()
        {
            InitializeComponent();
        }

        private void Manage_lects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ttms_dbDataSet1.lecturer_info' table. You can move, or remove it, as needed.
            this.lecturer_infoTableAdapter.Fill(this.ttms_dbDataSet1.lecturer_info);

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add_Update_Lecturer add_stud_lecturer_frm = new Add_Update_Lecturer();
            add_stud_lecturer_frm.update_btn.Visible = false;
            add_stud_lecturer_frm.add_btn.Visible = true;
            add_stud_lecturer_frm.heading_lb.Text = "Add Lecturer";
            add_stud_lecturer_frm.ShowDialog();
            this.lecturer_infoTableAdapter.Fill(this.ttms_dbDataSet1.lecturer_info);

        }

        private void lecturer_info_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select id from lecturer_info where lecturer_id = '" + this.lecturer_info_table.CurrentRow.Cells[0].Value.ToString() + "'", databaseConnection);
            int id = Convert.ToInt32(cmd1.ExecuteScalar());

            databaseConnection.Close();

            if (e.ColumnIndex == 4)
            {
                string edit = "edit";
                Add_Update_Lecturer add_stud_lecturer_frm = new Add_Update_Lecturer(id, this.lecturer_info_table.CurrentRow.Cells[2].Value.ToString(), edit);

                add_stud_lecturer_frm.lect_reg_textbox.Text = this.lecturer_info_table.CurrentRow.Cells[0].Value.ToString();
                add_stud_lecturer_frm.lect_name_textbox.Text = this.lecturer_info_table.CurrentRow.Cells[1].Value.ToString();
                add_stud_lecturer_frm.lect_email_textbox.Text = this.lecturer_info_table.CurrentRow.Cells[2].Value.ToString();
                add_stud_lecturer_frm.lect_mobile_textbox.Text = this.lecturer_info_table.Rows[e.RowIndex].Cells[3].Value.ToString();

                add_stud_lecturer_frm.update_btn.Visible = true;
                add_stud_lecturer_frm.add_btn.Visible = false;
                add_stud_lecturer_frm.heading_lb.Text = "Edit Lecturer";
                add_stud_lecturer_frm.ShowDialog();

                this.lecturer_infoTableAdapter.Fill(this.ttms_dbDataSet1.lecturer_info);
            }
            else if (e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    databaseConnection.Open();
                    DataGridViewRow row = lecturer_info_table.Rows[e.RowIndex];
                    MySqlCommand cmd = new MySqlCommand("Delete from lecturer_info where lecturer_id = '" + row.Cells[0].Value.ToString() + "'", databaseConnection);
                    cmd.ExecuteNonQuery();

                    //remove from datatable
                    lecturerinfoBindingSource.RemoveCurrent();
                    //refresh table
                    this.lecturer_infoTableAdapter.Fill(this.ttms_dbDataSet1.lecturer_info);
                    databaseConnection.Close();
                }

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
                string query = "select * from lecturer_info where lecturer_name like '%" + search_textbox.Text + "%' or lecturer_id like '%" + search_textbox.Text + "%'or lecturer_email like '%" + search_textbox.Text + "%'";
                MySqlDataAdapter adpt = new MySqlDataAdapter(query, databaseConnection);
                DataTable dttable = new DataTable();
                adpt.Fill(dttable);
                lecturer_info_table.DataSource = dttable;
                databaseConnection.Close();

                if (lecturer_info_table.Rows.Count > 0)
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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            search_textbox.Text = null;
            lecturer_info_table.DataSource = null;
            lecturer_info_table.Rows.Clear();
            lecturer_info_table.Refresh();

            databaseConnection.Open();
            MySqlCommand getRecords = new MySqlCommand("Select lecturer_id,lecturer_name,lecturer_email,lecturer_mobile from lecturer_info", databaseConnection);
            MySqlDataAdapter sdr = new MySqlDataAdapter(getRecords);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            lecturer_info_table.DataSource = dt;
            databaseConnection.Close();
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

        struct DataParameter
        {
            public List<ttms_dbDataSet1.lecturer_infoDataTable> LecturerList;
            public string FileName { get; set; }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = "C:";
            sfd.Title = "Save as Excel File";
            sfd.Filter = "Excel Files(2003)|*.xls";
            sfd.FileName = "";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                //ToCsV(dataGridView1, @"c:\export.xls");

                ToCsV(lecturer_info_table, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand getRecords = new MySqlCommand("Select lecturer_id,lecturer_name,lecturer_email,lecturer_mobile from lecturer_info where lecturer_id like '%" + search_textbox.Text + "%' or lecturer_name like '%" + search_textbox.Text + "%' or lecturer_email like '%" + search_textbox.Text + "%'", databaseConnection);
            MySqlDataAdapter sdr = new MySqlDataAdapter(getRecords);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            lecturer_info_table.DataSource = dt;
            databaseConnection.Close();

            if (lecturer_info_table.Rows.Count > 0)
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
}
