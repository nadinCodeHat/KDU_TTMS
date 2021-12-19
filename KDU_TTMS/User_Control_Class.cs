using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    class User_Control_Class
    {
        public static void showControl(System.Windows.Forms.Control control, System.Windows.Forms.Control panel)
        {
            panel.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panel.Controls.Add(control);
        }
    }
}
