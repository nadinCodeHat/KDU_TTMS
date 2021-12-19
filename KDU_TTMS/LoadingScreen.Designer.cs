namespace KDU_Time_Table_Management_System
{
    partial class LoadingScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.custom_preloader1 = new KDU_Time_Table_Management_System.custom_preloader();
            this.SuspendLayout();
            // 
            // custom_preloader1
            // 
            this.custom_preloader1.Location = new System.Drawing.Point(550, 297);
            this.custom_preloader1.Name = "custom_preloader1";
            this.custom_preloader1.Size = new System.Drawing.Size(80, 80);
            this.custom_preloader1.TabIndex = 0;
            // 
            // LoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1180, 674);
            this.Controls.Add(this.custom_preloader1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingScreen";
            this.Text = "LoadingSplashscreen";
            this.ResumeLayout(false);

        }

        #endregion

        private custom_preloader custom_preloader1;
    }
}