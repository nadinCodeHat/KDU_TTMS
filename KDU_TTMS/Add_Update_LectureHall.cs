using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Add_Update_LectureHall : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Add_Update_LectureHall()
        {
            InitializeComponent();
        }

        int getID;

        public Add_Update_LectureHall(int getID)
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
            if (String.IsNullOrEmpty(lecture_hall_textbox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        string lecture_hall;

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                try
                {
                    databaseConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("update lecture_hall_info set lecture_hall=@lecture_hall,capacity=@capacity where id = '" + getID + "'", databaseConnection);

                    cmd.Parameters.AddWithValue("@lecture_hall", lecture_hall_textbox.Text);
                    cmd.Parameters.AddWithValue("@capacity", Convert.ToInt32(capacity_numeric.Value));
                    cmd.ExecuteNonQuery();

                    showSuccess("Data Updated Successfully!");
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void add_hall_btn_Click(object sender, EventArgs e)
        {
            if (checkEmptyFields() == true)
            {
                showError("Incomplete Data, Please Check Again!");
            }
            else
            {
                databaseConnection.Open();
                MySqlCommand checkDuplicate = new MySqlCommand("Select COUNT(*) from lecture_hall_info where lecture_hall = @lecture_hall", databaseConnection);
                checkDuplicate.Parameters.AddWithValue("@lecture_hall", lecture_hall_textbox.Text);
                int lecture_hall_count = Convert.ToInt32(checkDuplicate.ExecuteScalar());

                if (lecture_hall_count > 0)
                {
                    showError("This lecture hall was already inserted, Please check again");
                }
                else
                {
                    MySqlCommand insertLectureHall = new MySqlCommand(@"INSERT INTO lecture_hall_info(lecture_hall,capacity) VALUES(@lecture_hall,@capacity)", databaseConnection);
                    insertLectureHall.Parameters.AddWithValue("@lecture_hall", lecture_hall_textbox.Text);
                    insertLectureHall.Parameters.AddWithValue("@capacity", Convert.ToInt32(capacity_numeric.Value));
                    insertLectureHall.ExecuteNonQuery();

                    showSuccess("Data Saved Successfully!");
                }
                databaseConnection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            message_panel.Visible = false;
        }
    }
}
