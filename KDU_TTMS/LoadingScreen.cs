using System;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class LoadingScreen : Form
    {
        public Action Worker { get; set; }

        public LoadingScreen(Action worker)
        {
            InitializeComponent();
            if (worker == null)
            {
                throw new ArgumentNullException();
            }
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
