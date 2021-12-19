using Guna.UI2.WinForms;
using KDU_Time_Table_Management_System.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Assist_Admin_Intake_Form : Form
    {

        //Connection String
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Assist_Admin_Intake_Form()
        {
            InitializeComponent();
        }

        private void loadIntakes()
        {
            select_intake_comboBox.Items.Clear();
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT intake FROM intakes", databaseConnection);
            cmd.Connection = databaseConnection;

            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                select_intake_comboBox.Items.Add(reader["intake"]);
            }
            reader.Close();
            databaseConnection.Close();
            select_intake_comboBox.SelectedIndex = 0;
        }

        private void loadStudents(string intake)
        {
            MySqlCommand command = new MySqlCommand("SELECT student_reg_no,student_name,student_email,intake FROM student_info t1 inner join intakes t2 on t1.intake_id = t2.id WHERE intake='" + intake + "'", databaseConnection);
            command.Connection = databaseConnection;
            DataSet dataset = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            adp.Fill(dataset);
            intakeDataGridView.DataSource = dataset.Tables[0];
            intakeDataGridView.Columns[0].HeaderText = "Registration Number";
            intakeDataGridView.Columns[1].HeaderText = "Student Name";
            intakeDataGridView.Columns[2].HeaderText = "Student Email";
            intakeDataGridView.Columns[3].HeaderText = "Intake";
            databaseConnection.Close();
            // string myString = select_intake_comboBox.SelectedItem.ToString();
        }

        private void loadLecturers()
        {
            MySqlCommand command = new MySqlCommand("SELECT lecturer_id,lecturer_name,lecturer_email FROM lecturer_info", databaseConnection);
            command.Connection = databaseConnection;
            DataSet dataset = new DataSet();
            MySqlDataAdapter adp = new MySqlDataAdapter(command);
            adp.Fill(dataset);
            intakeDataGridView.DataSource = dataset.Tables[0];
            intakeDataGridView.Columns[0].HeaderText = "Registration Number";
            intakeDataGridView.Columns[1].HeaderText = "Lecturer Name";
            intakeDataGridView.Columns[2].HeaderText = "Lectuer Email";
        }



        private void select_intake_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadStudents(select_intake_comboBox.SelectedItem.ToString()); ;
        }

        public static String hello;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (students_btn.Checked)
            {
                try
                {
                    databaseConnection.Open();
                    MySqlCommand getIntakeId = new MySqlCommand("Select id from intakes where intake = '" + select_intake_comboBox.SelectedItem.ToString() + "'", databaseConnection);
                    string intake_id = getIntakeId.ExecuteScalar().ToString();
                    databaseConnection.Close();

                    using (Send_Email_Form sendEmailForm = new Send_Email_Form(intake_id))
                    {
                        sendEmailForm.ShowDialog();
                        hello = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    using (Send_Email_Form sendEmailForm = new Send_Email_Form("lecturers"))
                    {
                        sendEmailForm.ShowDialog();
                        hello = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void new_intake_btn_Click(object sender, EventArgs e)
        {
            databaseConnection.Open();
            MySqlCommand insert_intake = new MySqlCommand(@"Insert into intakes(intake) VALUES(@intake)", databaseConnection);
            insert_intake.Parameters.AddWithValue("@intake", intake_numeric.Value);
            insert_intake.ExecuteNonQuery();
            databaseConnection.Close();
            setIntakes(intake_numeric.Value.ToString(), "0");
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Guna2ImageButton deleteBtn = (sender as Guna2ImageButton);

            string message = "Are you sure want to delete this Intake?" + Environment.NewLine + "Deleting an intake will delete all the students associated with it";
            if (MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                intakes_flowlayout_panel.Controls.Remove(intakes_flowlayout_panel.Controls.Find(deleteBtn.Name, true)[0]);
                databaseConnection.Open();
                MySqlCommand deleteIntake = new MySqlCommand("Delete from intakes where intake='" + deleteBtn.Name + "'", databaseConnection);
                deleteIntake.ExecuteNonQuery();
                databaseConnection.Close();
            }
        }

        private void setIntakes(string intake, string no)
        {
            Guna2ImageButton deleteBtn = new Guna2ImageButton();
            deleteBtn.Image = Resources.remove;
            deleteBtn.Name = intake;
            deleteBtn.Size = new Size(22, 22);
            deleteBtn.Location = new Point(168, 14);
            deleteBtn.HoverState.ImageSize = new Size(22, 22);
            deleteBtn.Click += new EventHandler(deleteBtn_Click);

            Guna2Panel back_panel = new Guna2Panel();
            back_panel.Name = intake;
            back_panel.Tag = deleteBtn;
            back_panel.FillColor = Color.White;
            back_panel.BackColor = Color.White;
            back_panel.Size = new Size(200, 160);
            back_panel.ShadowDecoration.Depth = 5;
            back_panel.ShadowDecoration.Color = Color.Black;
            back_panel.ShadowDecoration.BorderRadius = 0;
            back_panel.Margin = new Padding(20, 3, 3, 3);
            back_panel.ShadowDecoration.Shadow = new Padding(5, 5, 5, 5);
            back_panel.ShadowDecoration.Enabled = true;

            Guna2Panel top_panel = new Guna2Panel();
            top_panel.FillColor = Color.FromArgb(100, 88, 255);
            top_panel.BackColor = Color.FromArgb(100, 88, 255);
            top_panel.Dock = DockStyle.Top;
            top_panel.Size = new Size(200, 50);

            Guna2HtmlLabel intake_name = new Guna2HtmlLabel();
            intake_name.Text = "Intake " + intake;
            intake_name.Font = new Font("Segoe UI", 12);
            intake_name.ForeColor = Color.White;
            intake_name.Location = new Point(60, 12);

            Guna2HtmlLabel count = new Guna2HtmlLabel();
            count.Text = no;
            count.ForeColor = Color.Black;
            count.Font = new Font("Segoe UI", 18);
            count.Location = new Point(84, 84);

            top_panel.Controls.Add(intake_name);
            top_panel.Controls.Add(deleteBtn);
            back_panel.Controls.Add(count);
            back_panel.Controls.Add(top_panel);
            intakes_flowlayout_panel.Controls.Add(back_panel);
        }

        private DataTable dt = new DataTable();

        private void load()
        {
            databaseConnection.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT intake FROM intakes", databaseConnection);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                MySqlCommand count = new MySqlCommand("Select distinct(count(*)) from student_info t1 inner join intakes t2 on t1.intake_id = t2.id where intake ='" + row["intake"].ToString() + "'", databaseConnection);
                string c = count.ExecuteScalar().ToString();
                setIntakes(row["intake"].ToString(), c);
            }
            databaseConnection.Close();
        }

        private void CreateGroup_New_Form_Load(object sender, EventArgs e)
        {
            loadIntakes();
            load();
            // loadStudents(select_intake_comboBox.SelectedItem.ToString());
        }

        private void students_btn_Click(object sender, EventArgs e)
        {
            students_btn.Checked = true;
            lecturers_btn.Checked = false;

            select_intake_lb.Visible = true;
            select_intake_comboBox.Visible = true;
            loadIntakes();
        }

        private void lecturers_btn_Click(object sender, EventArgs e)
        {
            students_btn.Checked = false;
            lecturers_btn.Checked = true;

            select_intake_lb.Visible = false;
            select_intake_comboBox.Visible = false;
            loadLecturers();
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
