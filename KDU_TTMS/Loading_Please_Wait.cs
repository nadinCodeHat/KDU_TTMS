using MySql.Data.MySqlClient;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Loading_Please_Wait : Form
    {

        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        public Action Worker { get; set; }
        public string email, account_type;
        public Boolean correctVal;
        Thread th;

        public Loading_Please_Wait(Action worker, string email, Boolean correct, string account_type)
        {
            InitializeComponent();
            this.email = email;
            correctVal = correct;
            this.account_type = account_type;

            if (worker == null)
            {
                throw new ArgumentNullException();
            }
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            if (correctVal == true)
            {
                base.OnLoad(e);
                Task.Factory.StartNew(Worker).ContinueWith(t =>
                {
                    this.Close();
                    if (account_type == "Student")
                    {
                        th = new Thread(openStudentForm);
                    }
                    else if (account_type == "Lecturer")
                    {
                        th = new Thread(openLecturerForm);
                    }
                    else if (account_type == "Assistant")
                    {
                        th = new Thread(openNewMainForm);
                    }
                    else if (account_type == "Administrator")
                    {
                        th = new Thread(openAdminForm);
                    }

                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();

                }, TaskScheduler.FromCurrentSynchronizationContext());
            }
            else
            {
                base.OnLoad(e);
                Task.Factory.StartNew(Worker).ContinueWith(t => { this.Dispose(); }, TaskScheduler.FromCurrentSynchronizationContext());
            }
        }

        private void openAdminForm(object obj)
        {
            string real = "Admin";
            bool enablePriviledges = true;
            Application.Run(new Assist_Admin_Parent_Form(email, account_type, enablePriviledges, real));
        }

        private void openNewMainForm(object obj)
        {
            bool enablePriviledges = false;
            string real = "Assistant";
            databaseConnection.Open();
            MySqlCommand cmdPriviledges = new MySqlCommand("Select priviledges from assistant_info where assistant_email = @assistant_email", databaseConnection);
            cmdPriviledges.Parameters.AddWithValue("@assistant_email", email);
            string getPriviledges = cmdPriviledges.ExecuteScalar().ToString();
            databaseConnection.Close();
            if (getPriviledges == "Assistant")
            {
                Application.Run(new Assist_Admin_Parent_Form(email, account_type, enablePriviledges, real));
            }
            else
            {
                enablePriviledges = true;
                Application.Run(new Assist_Admin_Parent_Form(email, account_type, enablePriviledges, real));
            }

        }
        private void openStudentForm(object obj)
        {
            Application.Run(new Student_Parent_Form(email));
        }
        private void openLecturerForm(object obj)
        {
            Application.Run(new Lecturer_Parent_Form(email));
        }
    }
}
