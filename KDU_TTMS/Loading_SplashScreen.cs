using System;
using System.Threading;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Loading_SplashScreen : Form
    {
        Thread th;
        public Loading_SplashScreen()
        {
            InitializeComponent();
        }
        int step = 0;
        private void timer2_Tick(object sender, EventArgs e)
        {
            switch (step)
            {
                case 0:
                    this.Opacity = 1;
                    timer2.Interval = 2000;
                    break;
                case 1:
                    guna2HtmlLabel1.Text = "Initializing Modules...100%";
                    break;
                case 2:
                    guna2HtmlLabel1.Text = "Initializing UI...100%";
                    break;
                case 3:
                    guna2HtmlLabel1.Text = "Initializing Packages...100%";
                    break;
                case 4:
                    guna2HtmlLabel1.Text = "Loading...";
                    break;
                case 5:
                    this.Close();
                    th = new Thread(openHomePage);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    break;

            }
            step++;
            ///this.Enabled = false;
            //timer2.Stop();
            //this.Hide();
            //this.Close();

            //  var frm = new Login_Form();
            //frm.Closed += (s, args) => this.Close();
            // frm.Show();
        }

        private void Loading_SplashScreen_Load(object sender, EventArgs e)
        {
            timer2.Start();
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void openHomePage(object obj)
        {
            Application.Run(new HomePage());
        }


    }
}
