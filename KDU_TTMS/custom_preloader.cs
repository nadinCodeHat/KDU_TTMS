using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class custom_preloader : UserControl
    {
        List<Color> colors = new List<Color>();
        int cur_color = 0;
        public custom_preloader()
        {
            InitializeComponent();
            colors.Add(Color.FromArgb(0, 150, 136));
            colors.Add(Color.FromArgb(0, 188, 212));
            colors.Add(Color.FromArgb(63, 81, 181));
            colors.Add(Color.FromArgb(156, 39, 176));

            guna2CircleProgressBar1.ProgressColor = colors[cur_color];
            guna2CircleProgressBar1.ProgressColor2 = colors[cur_color];
        }

        int dir = 1;
        private void timer_stretch_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 90)
            {
                dir = -1;
                guna2CircleProgressBar1.AnimationSpeed = 5;
                SwitchColor();
            }
            else if (guna2CircleProgressBar1.Value == 10)
            {
                dir = +1;
                guna2CircleProgressBar1.AnimationSpeed = 3;
                SwitchColor();
            }
            guna2CircleProgressBar1.Value += dir;
        }


        void SwitchColor()
        {
            guna2ColorTransition1.StartColor = colors[cur_color];

            if (cur_color < colors.Count - 1)
            {
                cur_color++;
            }
            else
            {
                cur_color = 0;
            }
            guna2ColorTransition1.EndColor = colors[cur_color];

            color_transition.Start();
        }

        private void color_transition_Tick(object sender, EventArgs e)
        {
            if (guna2ColorTransition1.ProgressValue < 100)
            {
                guna2ColorTransition1.ProgressValue++;
                guna2CircleProgressBar1.ProgressColor = guna2ColorTransition1.Value;
                guna2CircleProgressBar1.ProgressColor2 = guna2ColorTransition1.Value;
            }
            else
            {
                color_transition.Stop();
                guna2ColorTransition1.StartColor = guna2ColorTransition1.EndColor;
                guna2ColorTransition1.ProgressValue = 0;
            }
        }
    }
}
