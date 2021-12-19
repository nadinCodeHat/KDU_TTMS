namespace KDU_Time_Table_Management_System
{
    partial class custom_preloader
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2CircleProgressBar1 = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.timer_stretch = new System.Windows.Forms.Timer(this.components);
            this.color_transition = new System.Windows.Forms.Timer(this.components);
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.SuspendLayout();
            // 
            // guna2CircleProgressBar1
            // 
            this.guna2CircleProgressBar1.Animated = true;
            this.guna2CircleProgressBar1.AnimationSpeed = 1F;
            this.guna2CircleProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CircleProgressBar1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleProgressBar1.FillThickness = 6;
            this.guna2CircleProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.guna2CircleProgressBar1.Name = "guna2CircleProgressBar1";
            this.guna2CircleProgressBar1.ProgressBrushMode = Guna.UI2.WinForms.Enums.BrushMode.SolidTransition;
            this.guna2CircleProgressBar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.guna2CircleProgressBar1.ProgressColor2 = System.Drawing.Color.SeaGreen;
            this.guna2CircleProgressBar1.ProgressThickness = 6;
            this.guna2CircleProgressBar1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleProgressBar1.ShadowDecoration.Parent = this.guna2CircleProgressBar1;
            this.guna2CircleProgressBar1.Size = new System.Drawing.Size(260, 260);
            this.guna2CircleProgressBar1.TabIndex = 1;
            this.guna2CircleProgressBar1.Value = 30;
            // 
            // timer_stretch
            // 
            this.timer_stretch.Enabled = true;
            this.timer_stretch.Interval = 1;
            this.timer_stretch.Tick += new System.EventHandler(this.timer_stretch_Tick);
            // 
            // color_transition
            // 
            this.color_transition.Interval = 10;
            this.color_transition.Tick += new System.EventHandler(this.color_transition_Tick);
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            this.guna2ColorTransition1.EndColor = System.Drawing.Color.White;
            this.guna2ColorTransition1.StartColor = System.Drawing.Color.White;
            // 
            // custom_preloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CircleProgressBar1);
            this.Name = "custom_preloader";
            this.Size = new System.Drawing.Size(260, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleProgressBar guna2CircleProgressBar1;
        private System.Windows.Forms.Timer timer_stretch;
        private System.Windows.Forms.Timer color_transition;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
    }
}
