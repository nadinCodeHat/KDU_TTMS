using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Manage_Assistants : Form
    {
        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Manage_Assistants()
        {
            InitializeComponent();
        }

        private void Manage_Assistants_Load(object sender, EventArgs e)
        {
            this.assistant_infoTableAdapter.Fill(this.dataSet_getAssistant_Info.assistant_info);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Add_Update_Assistant add_assistant_form = new Add_Update_Assistant();
            add_assistant_form.update_btn.Visible = false;
            add_assistant_form.add_btn.Visible = true;
            add_assistant_form.heading_lb.Text = "Add Lecturer Details";
            add_assistant_form.ShowDialog();
            this.assistant_infoTableAdapter.Fill(this.dataSet_getAssistant_Info.assistant_info);
        }

        private void assistants_info_table_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand cmd1 = new MySqlCommand("Select id from assistant_info where assistant_name = '" + this.assistant_info_table.CurrentRow.Cells[0].Value.ToString() + "'", databaseConnection);
            int id = Convert.ToInt32(cmd1.ExecuteScalar());
            databaseConnection.Close();

            if (e.ColumnIndex == 6)
            {
                Add_Update_Assistant edit_assistant = new Add_Update_Assistant(id, this.assistant_info_table.CurrentRow.Cells[3].Value.ToString());

                edit_assistant.assistant_name_textbox.Text = this.assistant_info_table.CurrentRow.Cells[0].Value.ToString();
                edit_assistant.work_email_textbox.Text = this.assistant_info_table.CurrentRow.Cells[3].Value.ToString();
                edit_assistant.mobile_number_textbox.Text = this.assistant_info_table.Rows[e.RowIndex].Cells[4].Value.ToString();
                edit_assistant.gender_combobox.SelectedItem = this.assistant_info_table.Rows[e.RowIndex].Cells[1].Value.ToString();
                string priviledge = this.assistant_info_table.Rows[e.RowIndex].Cells[2].Value.ToString();
                if (priviledge == "Assistant")
                {
                    edit_assistant.enable_checkbox.Checked = false;
                }
                else
                {
                    edit_assistant.enable_checkbox.Checked = true;
                }

                edit_assistant.update_btn.Visible = true;
                edit_assistant.add_btn.Visible = false;
                edit_assistant.heading_lb.Text = "Edit Assitant Details";
                edit_assistant.ShowDialog();

                this.assistant_infoTableAdapter.Fill(this.dataSet_getAssistant_Info.assistant_info);
            }
            else if (e.ColumnIndex == 7)
            {
                if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    databaseConnection.Open();
                    DataGridViewRow row = assistant_info_table.Rows[e.RowIndex];
                    MySqlCommand cmd = new MySqlCommand("Delete from assistant_info where assistant_name = '" + row.Cells[0].Value.ToString() + "'", databaseConnection);
                    cmd.ExecuteNonQuery();
                    databaseConnection.Close();
                    //remove from datatable
                    assistantinfoBindingSource.RemoveCurrent();
                    //refresh table
                    this.assistant_infoTableAdapter.Fill(this.dataSet_getAssistant_Info.assistant_info);

                }
            }
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

                ToCsV(assistant_info_table, sfd.FileName); // Here dataGridview1 is your grid view name
            }
        }


        private void search_textbox_TextChanged(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand getRecords = new MySqlCommand("Select assistant_name,gender,priviledges,assistant_email,assistant_mobile,status from assistant_info where assistant_name like '%" + search_textbox.Text + "%' or assistant_email like '%" + search_textbox.Text + "%'", databaseConnection);
            MySqlDataAdapter sdr = new MySqlDataAdapter(getRecords);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            assistant_info_table.DataSource = dt;
            databaseConnection.Close();

            if (assistant_info_table.Rows.Count > 0)
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

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            search_textbox.Text = null;
            assistant_info_table.DataSource = null;
            assistant_info_table.Rows.Clear();
            assistant_info_table.Refresh();

            databaseConnection.Open();
            MySqlCommand getRecords = new MySqlCommand("Select assistant_name,gender,priviledges,assistant_email,assistant_mobile,status from assistant_info", databaseConnection);
            MySqlDataAdapter sdr = new MySqlDataAdapter(getRecords);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            assistant_info_table.DataSource = dt;
            databaseConnection.Close();
        }
    }
}
