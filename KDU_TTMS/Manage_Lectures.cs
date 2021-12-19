using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Lecture_Management_Form : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db;");

        public Lecture_Management_Form()
        {
            InitializeComponent();
        }

        private void new_module_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Add_Update_Module add_module_frm = new Add_Update_Module();
                add_module_frm.update_btn.Visible = false;
                add_module_frm.add_module_btn.Visible = true;
                add_module_frm.add_update_lb.Text = "Add Module";
                add_module_frm.ShowDialog();

                this.module_infoTableAdapter.Fill(this.dataSet_getModule_Info.module_info);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Lecture_Management_Form_Load(object sender, EventArgs e)
        {


            this.module_infoTableAdapter.Fill(this.dataSet_getModule_Info.module_info);
        }

        private void lecture_info_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("Select id from module_info where lecture_code = '" + this.module_info_table.CurrentRow.Cells[0].Value.ToString() + "'", databaseConnection);
            int id = Convert.ToInt32(cmd.ExecuteScalar());
            databaseConnection.Close();

            if (e.ColumnIndex == 8)
            {
                Add_Update_Module add_module_frm = new Add_Update_Module(id);

                add_module_frm.lecture_code_textbox.Text = this.module_info_table.CurrentRow.Cells[0].Value.ToString();
                add_module_frm.abbr.Text = this.module_info_table.CurrentRow.Cells[1].Value.ToString();
                add_module_frm.lecture_module_textbox.Text = this.module_info_table.CurrentRow.Cells[2].Value.ToString();

                add_module_frm.credit_val.Value = Convert.ToInt32(this.module_info_table.CurrentRow.Cells[3].Value.ToString());
                if (this.module_info_table.CurrentRow.Cells[4].Value.ToString() == "GPA")
                {
                    add_module_frm.gpa_btn.Checked = true;
                    add_module_frm.ngpa_btn.Checked = false;
                    add_module_frm.mgpa_btn.Checked = false;
                }
                if (this.module_info_table.CurrentRow.Cells[4].Value.ToString() == "NGPA")
                {
                    add_module_frm.ngpa_btn.Checked = true;
                    add_module_frm.gpa_btn.Checked = false;
                    add_module_frm.mgpa_btn.Checked = false;
                }
                if (this.module_info_table.CurrentRow.Cells[4].Value.ToString() == "MGPA")
                {
                    add_module_frm.ngpa_btn.Checked = false;
                    add_module_frm.gpa_btn.Checked = false;
                    add_module_frm.mgpa_btn.Checked = true;
                }

                Char optionval = Convert.ToChar(module_info_table.Rows[e.RowIndex].Cells[5].Value.ToString());
                if (optionval == 'C')
                {
                    add_module_frm.compulsory_btn.Checked = true;
                    add_module_frm.elective_btn.Checked = false;
                }
                else
                {
                    add_module_frm.elective_btn.Checked = true;
                    add_module_frm.compulsory_btn.Checked = false;
                }
                add_module_frm.select_sem_combo.SelectedItem = this.module_info_table.CurrentRow.Cells[6].Value.ToString();
                add_module_frm.select_degree_programme.SelectedItem = this.module_info_table.CurrentRow.Cells[7].Value.ToString();

                add_module_frm.update_btn.Visible = true;
                add_module_frm.add_module_btn.Visible = false;
                add_module_frm.add_update_lb.Text = "Edit Module";
                add_module_frm.ShowDialog();

                //Refresh Module Table
                this.module_infoTableAdapter.Fill(this.dataSet_getModule_Info.module_info);
            }
            if (e.ColumnIndex == 9)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    databaseConnection.Open();
                    DataGridViewRow row = module_info_table.Rows[e.RowIndex];
                    MySqlCommand cmd1 = new MySqlCommand("Delete from module_info where lecture_code = '" + row.Cells[0].Value.ToString() + "'", databaseConnection);
                    cmd1.ExecuteNonQuery();
                    databaseConnection.Close();
                    //remove from datatable
                    moduleinfoBindingSource.RemoveCurrent();

                    //Refresh Module Table
                    this.module_infoTableAdapter.Fill(this.dataSet_getModule_Info.module_info);
                }
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            search_textbox.Text = null;
            module_info_table.DataSource = null;
            module_info_table.Rows.Clear();
            module_info_table.Refresh();

            databaseConnection.Open();
            MySqlCommand getRecords = new MySqlCommand("Select lecture_code,lecture_abbr,lecture_module,credit,gpatype,module_type,semester,degree_programme from module_info", databaseConnection);
            MySqlDataAdapter sdr = new MySqlDataAdapter(getRecords);
            databaseConnection.Close();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            module_info_table.DataSource = dt;

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

                ToCsV(module_info_table, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }

        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand getRecords = new MySqlCommand("Select lecture_code,lecture_abbr,lecture_module,credit,gpatype,module_type,semester,degree_programme from module_info where lecture_code like '%" + search_textbox.Text + "%' or lecture_abbr like '%" + search_textbox.Text + "%' or lecture_module like '%" + search_textbox.Text + "%' or credit like '%" + search_textbox.Text + "%'", databaseConnection);
            MySqlDataAdapter sdr = new MySqlDataAdapter(getRecords);
            databaseConnection.Close();
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            module_info_table.DataSource = dt;


            if (module_info_table.Rows.Count > 0)
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

