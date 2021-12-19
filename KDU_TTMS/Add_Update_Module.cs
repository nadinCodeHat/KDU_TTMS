using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Add_Update_Module : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Add_Update_Module()
        {
            InitializeComponent();
        }

        int getID;
        public Add_Update_Module(int getID)
        {
            InitializeComponent();

            this.getID = getID;
        }

        private void showError(string errorMessage)
        {
            message_label.Text = errorMessage;
            message_panel.Visible = true;
            message_panel.FillColor = Color.Tomato;
            timer1.Start();
        }

        private void showSuccess(string message)
        {
            message_label.Text = message;
            message_panel.Visible = true;
            message_panel.FillColor = Color.MediumSeaGreen;
            timer1.Start();
        }

        private bool checkEmptyFields()
        {
            if (String.IsNullOrEmpty(lecture_code_textbox.Text) || String.IsNullOrEmpty(lecture_module_textbox.Text) || String.IsNullOrEmpty(abbr.Text) || select_sem_combo.SelectedItem == null || select_degree_programme.SelectedItem == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private void loadLecturers()
        {
            try
            {
                databaseConnection.Open();
                string query = "select lecturer_name,id from lecturer_info";
                MySqlDataAdapter da = new MySqlDataAdapter(query, databaseConnection);
                DataSet ds = new DataSet();
                da.Fill(ds, "lecturer_info");
                lecturer_combo.DisplayMember = "lecturer_name";
                lecturer_combo.ValueMember = "id";
                lecturer_combo.DataSource = ds.Tables["lecturer_info"];
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void add_module_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand checkDuplicate = new MySqlCommand("Select COUNT(*) from module_info where lecture_code = @lecture_code and semester = @semester", databaseConnection);
                checkDuplicate.Parameters.AddWithValue("@lecture_code", lecture_code_textbox.Text);
                checkDuplicate.Parameters.AddWithValue("@semester", select_sem_combo.SelectedItem);
                int lecture_code_count = Convert.ToInt32(checkDuplicate.ExecuteScalar());
                int lecture_module_count = Convert.ToInt32(checkDuplicate.ExecuteScalar());

                if (lecture_code_count > 0 || lecture_module_count > 0)
                {
                    showError("This lecture module was already inserted, Please check again");
                }
                else
                {
                    MySqlCommand insertLectureInfo = new MySqlCommand(@"INSERT INTO module_info(lecture_code,lecture_module,lecturer,lecture_abbr,credit,gpatype,module_type,semester,degree_programme) VALUES(@lecture_code,@lecture_module,@lecturer,@lecture_abbr,@credit,@gpatype,@module_type,@semester,@degree_programme)", databaseConnection);
                    insertLectureInfo.Parameters.AddWithValue("@lecture_code", lecture_code_textbox.Text);
                    insertLectureInfo.Parameters.AddWithValue("@lecture_module", lecture_module_textbox.Text);
                    insertLectureInfo.Parameters.AddWithValue("@lecturer", "Dr. (Mrs.) W Gunathilake");
                    insertLectureInfo.Parameters.AddWithValue("@lecture_abbr", abbr.Text);
                    insertLectureInfo.Parameters.AddWithValue("@credit", credit_val.Value);
                    if (gpa_btn.Checked)
                    {
                        insertLectureInfo.Parameters.AddWithValue("@gpatype", "GPA");
                    }
                    if (ngpa_btn.Checked)
                    {
                        insertLectureInfo.Parameters.AddWithValue("@gpatype", "NGPA");
                    }
                    if (mgpa_btn.Checked)
                    {
                        insertLectureInfo.Parameters.AddWithValue("@gpatype", "MGPA");
                    }


                    if (compulsory_btn.Checked)
                    {
                        insertLectureInfo.Parameters.AddWithValue("@module_type", "C");
                    }
                    if (elective_btn.Checked)
                    {
                        insertLectureInfo.Parameters.AddWithValue("@module_type", "E");
                    }
                    insertLectureInfo.Parameters.AddWithValue("@semester", select_sem_combo.SelectedItem);
                    insertLectureInfo.Parameters.AddWithValue("@degree_programme", select_degree_programme.SelectedItem);
                    insertLectureInfo.ExecuteNonQuery();

                    showSuccess("Data Saved Successfully!");
                }
                databaseConnection.Close();
            }
        }

        private void Add_Module_Form_Load(object sender, EventArgs e)
        {
            loadLecturers();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand cmd = new MySqlCommand("update module_info set lecture_code=@lecture_code,lecture_abbr=@lecture_abbr,lecture_module=@lecture_module,lecturer=@lecturer,credit=@credit,gpatype=@gpatype,module_type=@module_type,degree_programme=@degree_programme where id='" + getID + "'", databaseConnection);

                cmd.Parameters.AddWithValue("@lecture_code", lecture_code_textbox.Text);
                cmd.Parameters.AddWithValue("@lecture_abbr", abbr.Text);
                cmd.Parameters.AddWithValue("@lecture_module", lecture_module_textbox.Text);
                cmd.Parameters.AddWithValue("@lecturer", "Dr. (Mrs.) W Gunathilake");
                cmd.Parameters.AddWithValue("@credit", credit_val.Value);
                if (gpa_btn.Checked)
                {
                    cmd.Parameters.AddWithValue("@gpatype", "GPA");
                }
                if (ngpa_btn.Checked)
                {
                    cmd.Parameters.AddWithValue("@gpatype", "NGPA");
                }
                if (mgpa_btn.Checked)
                {
                    cmd.Parameters.AddWithValue("@gpatype", "MGPA");
                }

                if (compulsory_btn.Checked)
                {
                    cmd.Parameters.AddWithValue("@module_type", "C");
                }
                if (elective_btn.Checked)
                {
                    cmd.Parameters.AddWithValue("@module_type", "E");
                }
                cmd.Parameters.AddWithValue("@degree_programme", select_degree_programme.SelectedItem);
                cmd.ExecuteNonQuery();
                showSuccess("Data Updated Successfully!");
                databaseConnection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            message_panel.Visible = false;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            elective_btn.Checked = true;
            compulsory_btn.Checked = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            elective_btn.Checked = false;
            compulsory_btn.Checked = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            gpa_btn.Checked = true;
            ngpa_btn.Checked = false;
            mgpa_btn.Checked = false;

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            gpa_btn.Checked = false;
            ngpa_btn.Checked = true;
            mgpa_btn.Checked = false;
        }

        private void mgpa_btn_Click(object sender, EventArgs e)
        {
            mgpa_btn.Checked = true;
            gpa_btn.Checked = false;
            ngpa_btn.Checked = false;
        }
    }
}
