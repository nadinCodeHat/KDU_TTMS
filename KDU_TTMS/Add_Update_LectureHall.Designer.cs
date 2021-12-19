namespace KDU_Time_Table_Management_System
{
    partial class Add_Update_LectureHall
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Update_LectureHall));
            this.add_update_heading = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lecture_hall_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.add_hall_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.capacity_numeric = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.message_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.message_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity_numeric)).BeginInit();
            this.message_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_update_heading
            // 
            this.add_update_heading.AutoSize = false;
            this.add_update_heading.BackColor = System.Drawing.Color.Transparent;
            this.add_update_heading.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_update_heading.ForeColor = System.Drawing.Color.White;
            this.add_update_heading.Location = new System.Drawing.Point(0, 14);
            this.add_update_heading.Name = "add_update_heading";
            this.add_update_heading.Size = new System.Drawing.Size(349, 23);
            this.add_update_heading.TabIndex = 17;
            this.add_update_heading.Text = "Add Lecture Hall";
            this.add_update_heading.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lecture_hall_textbox
            // 
            this.lecture_hall_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lecture_hall_textbox.DefaultText = "";
            this.lecture_hall_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lecture_hall_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lecture_hall_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lecture_hall_textbox.DisabledState.Parent = this.lecture_hall_textbox;
            this.lecture_hall_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lecture_hall_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lecture_hall_textbox.FocusedState.Parent = this.lecture_hall_textbox;
            this.lecture_hall_textbox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lecture_hall_textbox.ForeColor = System.Drawing.Color.Black;
            this.lecture_hall_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lecture_hall_textbox.HoverState.Parent = this.lecture_hall_textbox;
            this.lecture_hall_textbox.Location = new System.Drawing.Point(33, 74);
            this.lecture_hall_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lecture_hall_textbox.Name = "lecture_hall_textbox";
            this.lecture_hall_textbox.PasswordChar = '\0';
            this.lecture_hall_textbox.PlaceholderText = "";
            this.lecture_hall_textbox.SelectedText = "";
            this.lecture_hall_textbox.ShadowDecoration.Parent = this.lecture_hall_textbox;
            this.lecture_hall_textbox.Size = new System.Drawing.Size(283, 24);
            this.lecture_hall_textbox.TabIndex = 62;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(33, 105);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(49, 17);
            this.guna2HtmlLabel3.TabIndex = 61;
            this.guna2HtmlLabel3.Text = "Capacity";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.DimGray;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(33, 48);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(66, 17);
            this.guna2HtmlLabel2.TabIndex = 60;
            this.guna2HtmlLabel2.Text = "Lecture Hall";
            // 
            // add_hall_btn
            // 
            this.add_hall_btn.CheckedState.Parent = this.add_hall_btn;
            this.add_hall_btn.CustomImages.Parent = this.add_hall_btn;
            this.add_hall_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.add_hall_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_hall_btn.ForeColor = System.Drawing.Color.White;
            this.add_hall_btn.HoverState.Parent = this.add_hall_btn;
            this.add_hall_btn.Location = new System.Drawing.Point(216, 174);
            this.add_hall_btn.Name = "add_hall_btn";
            this.add_hall_btn.ShadowDecoration.Parent = this.add_hall_btn;
            this.add_hall_btn.Size = new System.Drawing.Size(100, 25);
            this.add_hall_btn.TabIndex = 64;
            this.add_hall_btn.Text = "Add Halll";
            this.add_hall_btn.Click += new System.EventHandler(this.add_hall_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.CheckedState.Parent = this.update_btn;
            this.update_btn.CustomImages.Parent = this.update_btn;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.HoverState.Parent = this.update_btn;
            this.update_btn.Location = new System.Drawing.Point(216, 174);
            this.update_btn.Name = "update_btn";
            this.update_btn.ShadowDecoration.Parent = this.update_btn;
            this.update_btn.Size = new System.Drawing.Size(100, 25);
            this.update_btn.TabIndex = 65;
            this.update_btn.Text = "Update";
            this.update_btn.Visible = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Controls.Add(this.add_update_heading);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(349, 50);
            this.guna2Panel1.TabIndex = 67;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.capacity_numeric);
            this.guna2Panel2.Controls.Add(this.message_panel);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel2.Controls.Add(this.add_hall_btn);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.update_btn);
            this.guna2Panel2.Controls.Add(this.lecture_hall_textbox);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 50);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(349, 239);
            this.guna2Panel2.TabIndex = 68;
            // 
            // capacity_numeric
            // 
            this.capacity_numeric.BackColor = System.Drawing.Color.Transparent;
            this.capacity_numeric.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.capacity_numeric.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.capacity_numeric.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.capacity_numeric.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.capacity_numeric.DisabledState.Parent = this.capacity_numeric;
            this.capacity_numeric.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.capacity_numeric.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.capacity_numeric.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.capacity_numeric.FocusedState.Parent = this.capacity_numeric;
            this.capacity_numeric.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capacity_numeric.ForeColor = System.Drawing.Color.Black;
            this.capacity_numeric.Location = new System.Drawing.Point(33, 130);
            this.capacity_numeric.Name = "capacity_numeric";
            this.capacity_numeric.ShadowDecoration.Parent = this.capacity_numeric;
            this.capacity_numeric.Size = new System.Drawing.Size(92, 24);
            this.capacity_numeric.TabIndex = 68;
            this.capacity_numeric.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            // 
            // message_panel
            // 
            this.message_panel.Controls.Add(this.message_label);
            this.message_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.message_panel.FillColor = System.Drawing.Color.Tomato;
            this.message_panel.Location = new System.Drawing.Point(0, 0);
            this.message_panel.Name = "message_panel";
            this.message_panel.ShadowDecoration.Parent = this.message_panel;
            this.message_panel.Size = new System.Drawing.Size(349, 35);
            this.message_panel.TabIndex = 67;
            this.message_panel.Visible = false;
            // 
            // message_label
            // 
            this.message_label.AutoSize = false;
            this.message_label.BackColor = System.Drawing.Color.Transparent;
            this.message_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_label.ForeColor = System.Drawing.Color.White;
            this.message_label.Location = new System.Drawing.Point(1, 6);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(346, 22);
            this.message_label.TabIndex = 46;
            this.message_label.Text = "Text";
            this.message_label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Add_Update_LectureHall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(349, 289);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Update_LectureHall";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LectureHall";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capacity_numeric)).EndInit();
            this.message_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        public Guna.UI2.WinForms.Guna2Button add_hall_btn;
        public Guna.UI2.WinForms.Guna2Button update_btn;
        public Guna.UI2.WinForms.Guna2TextBox lecture_hall_textbox;
        public Guna.UI2.WinForms.Guna2HtmlLabel add_update_heading;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel message_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel message_label;
        private System.Windows.Forms.Timer timer1;
        public Guna.UI2.WinForms.Guna2NumericUpDown capacity_numeric;
    }
}