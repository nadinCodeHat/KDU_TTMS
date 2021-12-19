namespace KDU_Time_Table_Management_System
{
    partial class Add_Update_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Update_Student));
            this.heading_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.blue_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.white_panel_back = new Guna.UI2.WinForms.Guna2Panel();
            this.intake_combobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.stud_mobile_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.stud_email_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.message_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.message_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.stud_reg_no_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.stud_name_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.intake_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.stud_mobile_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.stud_regnum_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.stud_name_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.stud_email_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.stud_coursestream_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.student_course_stream_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.blue_panel.SuspendLayout();
            this.white_panel_back.SuspendLayout();
            this.message_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // heading_lb
            // 
            this.heading_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.heading_lb.AutoSize = false;
            this.heading_lb.BackColor = System.Drawing.Color.Transparent;
            this.heading_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F);
            this.heading_lb.ForeColor = System.Drawing.Color.White;
            this.heading_lb.Location = new System.Drawing.Point(0, 14);
            this.heading_lb.Name = "heading_lb";
            this.heading_lb.Size = new System.Drawing.Size(349, 23);
            this.heading_lb.TabIndex = 20;
            this.heading_lb.Text = "Add Student";
            this.heading_lb.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blue_panel
            // 
            this.blue_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.blue_panel.Controls.Add(this.heading_lb);
            this.blue_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.blue_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.blue_panel.ForeColor = System.Drawing.Color.DimGray;
            this.blue_panel.Location = new System.Drawing.Point(0, 0);
            this.blue_panel.Name = "blue_panel";
            this.blue_panel.ShadowDecoration.Parent = this.blue_panel;
            this.blue_panel.Size = new System.Drawing.Size(349, 50);
            this.blue_panel.TabIndex = 43;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // white_panel_back
            // 
            this.white_panel_back.Controls.Add(this.intake_combobox);
            this.white_panel_back.Controls.Add(this.stud_mobile_textbox);
            this.white_panel_back.Controls.Add(this.stud_email_textbox);
            this.white_panel_back.Controls.Add(this.message_panel);
            this.white_panel_back.Controls.Add(this.stud_reg_no_lb);
            this.white_panel_back.Controls.Add(this.add_btn);
            this.white_panel_back.Controls.Add(this.stud_name_lb);
            this.white_panel_back.Controls.Add(this.intake_lb);
            this.white_panel_back.Controls.Add(this.stud_mobile_lb);
            this.white_panel_back.Controls.Add(this.stud_regnum_textbox);
            this.white_panel_back.Controls.Add(this.stud_name_textbox);
            this.white_panel_back.Controls.Add(this.stud_email_lb);
            this.white_panel_back.Controls.Add(this.stud_coursestream_lb);
            this.white_panel_back.Controls.Add(this.student_course_stream_combo);
            this.white_panel_back.Controls.Add(this.update_btn);
            this.white_panel_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.white_panel_back.FillColor = System.Drawing.Color.White;
            this.white_panel_back.Location = new System.Drawing.Point(0, 50);
            this.white_panel_back.Name = "white_panel_back";
            this.white_panel_back.ShadowDecoration.Parent = this.white_panel_back;
            this.white_panel_back.Size = new System.Drawing.Size(349, 436);
            this.white_panel_back.TabIndex = 44;
            // 
            // intake_combobox
            // 
            this.intake_combobox.BackColor = System.Drawing.Color.Transparent;
            this.intake_combobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.intake_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.intake_combobox.FocusedColor = System.Drawing.Color.Empty;
            this.intake_combobox.FocusedState.Parent = this.intake_combobox;
            this.intake_combobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.intake_combobox.ForeColor = System.Drawing.Color.DimGray;
            this.intake_combobox.FormattingEnabled = true;
            this.intake_combobox.HoverState.Parent = this.intake_combobox;
            this.intake_combobox.ItemHeight = 16;
            this.intake_combobox.ItemsAppearance.Parent = this.intake_combobox;
            this.intake_combobox.Location = new System.Drawing.Point(33, 258);
            this.intake_combobox.Name = "intake_combobox";
            this.intake_combobox.ShadowDecoration.Parent = this.intake_combobox;
            this.intake_combobox.Size = new System.Drawing.Size(96, 22);
            this.intake_combobox.TabIndex = 48;
            // 
            // stud_mobile_textbox
            // 
            this.stud_mobile_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stud_mobile_textbox.DefaultText = "";
            this.stud_mobile_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stud_mobile_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stud_mobile_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stud_mobile_textbox.DisabledState.Parent = this.stud_mobile_textbox;
            this.stud_mobile_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stud_mobile_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stud_mobile_textbox.FocusedState.Parent = this.stud_mobile_textbox;
            this.stud_mobile_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_mobile_textbox.ForeColor = System.Drawing.Color.Black;
            this.stud_mobile_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stud_mobile_textbox.HoverState.Parent = this.stud_mobile_textbox;
            this.stud_mobile_textbox.Location = new System.Drawing.Point(160, 258);
            this.stud_mobile_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stud_mobile_textbox.Name = "stud_mobile_textbox";
            this.stud_mobile_textbox.PasswordChar = '\0';
            this.stud_mobile_textbox.PlaceholderText = "";
            this.stud_mobile_textbox.SelectedText = "";
            this.stud_mobile_textbox.ShadowDecoration.Parent = this.stud_mobile_textbox;
            this.stud_mobile_textbox.Size = new System.Drawing.Size(156, 24);
            this.stud_mobile_textbox.TabIndex = 47;
            this.stud_mobile_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stud_mobile_textbox_KeyPress);
            // 
            // stud_email_textbox
            // 
            this.stud_email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stud_email_textbox.DefaultText = "";
            this.stud_email_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stud_email_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stud_email_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stud_email_textbox.DisabledState.Parent = this.stud_email_textbox;
            this.stud_email_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stud_email_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stud_email_textbox.FocusedState.Parent = this.stud_email_textbox;
            this.stud_email_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_email_textbox.ForeColor = System.Drawing.Color.Black;
            this.stud_email_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stud_email_textbox.HoverState.Parent = this.stud_email_textbox;
            this.stud_email_textbox.Location = new System.Drawing.Point(33, 323);
            this.stud_email_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stud_email_textbox.Name = "stud_email_textbox";
            this.stud_email_textbox.PasswordChar = '\0';
            this.stud_email_textbox.PlaceholderText = "";
            this.stud_email_textbox.SelectedText = "";
            this.stud_email_textbox.ShadowDecoration.Parent = this.stud_email_textbox;
            this.stud_email_textbox.Size = new System.Drawing.Size(283, 24);
            this.stud_email_textbox.TabIndex = 46;
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
            this.message_panel.TabIndex = 44;
            this.message_panel.Visible = false;
            // 
            // message_label
            // 
            this.message_label.AutoSize = false;
            this.message_label.BackColor = System.Drawing.Color.Transparent;
            this.message_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_label.ForeColor = System.Drawing.Color.White;
            this.message_label.Location = new System.Drawing.Point(0, 6);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(348, 22);
            this.message_label.TabIndex = 45;
            this.message_label.Text = "Text";
            this.message_label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stud_reg_no_lb
            // 
            this.stud_reg_no_lb.BackColor = System.Drawing.Color.Transparent;
            this.stud_reg_no_lb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stud_reg_no_lb.ForeColor = System.Drawing.Color.DimGray;
            this.stud_reg_no_lb.Location = new System.Drawing.Point(33, 51);
            this.stud_reg_no_lb.Name = "stud_reg_no_lb";
            this.stud_reg_no_lb.Size = new System.Drawing.Size(157, 17);
            this.stud_reg_no_lb.TabIndex = 21;
            this.stud_reg_no_lb.Text = "Student Registration Number";
            // 
            // add_btn
            // 
            this.add_btn.CheckedState.Parent = this.add_btn;
            this.add_btn.CustomImages.Parent = this.add_btn;
            this.add_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.HoverState.Parent = this.add_btn;
            this.add_btn.Location = new System.Drawing.Point(216, 384);
            this.add_btn.Name = "add_btn";
            this.add_btn.ShadowDecoration.Parent = this.add_btn;
            this.add_btn.Size = new System.Drawing.Size(100, 25);
            this.add_btn.TabIndex = 27;
            this.add_btn.Text = "Add Student";
            this.add_btn.Visible = false;
            this.add_btn.Click += new System.EventHandler(this.add_student_btn_Click);
            // 
            // stud_name_lb
            // 
            this.stud_name_lb.BackColor = System.Drawing.Color.Transparent;
            this.stud_name_lb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stud_name_lb.ForeColor = System.Drawing.Color.DimGray;
            this.stud_name_lb.Location = new System.Drawing.Point(33, 113);
            this.stud_name_lb.Name = "stud_name_lb";
            this.stud_name_lb.Size = new System.Drawing.Size(79, 17);
            this.stud_name_lb.TabIndex = 22;
            this.stud_name_lb.Text = "Student Name";
            // 
            // intake_lb
            // 
            this.intake_lb.BackColor = System.Drawing.Color.Transparent;
            this.intake_lb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.intake_lb.ForeColor = System.Drawing.Color.DimGray;
            this.intake_lb.Location = new System.Drawing.Point(33, 233);
            this.intake_lb.Name = "intake_lb";
            this.intake_lb.Size = new System.Drawing.Size(35, 17);
            this.intake_lb.TabIndex = 23;
            this.intake_lb.Text = "Intake";
            // 
            // stud_mobile_lb
            // 
            this.stud_mobile_lb.BackColor = System.Drawing.Color.Transparent;
            this.stud_mobile_lb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stud_mobile_lb.ForeColor = System.Drawing.Color.DimGray;
            this.stud_mobile_lb.Location = new System.Drawing.Point(160, 233);
            this.stud_mobile_lb.Name = "stud_mobile_lb";
            this.stud_mobile_lb.Size = new System.Drawing.Size(84, 17);
            this.stud_mobile_lb.TabIndex = 39;
            this.stud_mobile_lb.Text = "Student Mobile";
            // 
            // stud_regnum_textbox
            // 
            this.stud_regnum_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stud_regnum_textbox.DefaultText = "";
            this.stud_regnum_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stud_regnum_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stud_regnum_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stud_regnum_textbox.DisabledState.Parent = this.stud_regnum_textbox;
            this.stud_regnum_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stud_regnum_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stud_regnum_textbox.FocusedState.Parent = this.stud_regnum_textbox;
            this.stud_regnum_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_regnum_textbox.ForeColor = System.Drawing.Color.Black;
            this.stud_regnum_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stud_regnum_textbox.HoverState.Parent = this.stud_regnum_textbox;
            this.stud_regnum_textbox.Location = new System.Drawing.Point(33, 75);
            this.stud_regnum_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stud_regnum_textbox.Name = "stud_regnum_textbox";
            this.stud_regnum_textbox.PasswordChar = '\0';
            this.stud_regnum_textbox.PlaceholderText = "";
            this.stud_regnum_textbox.SelectedText = "";
            this.stud_regnum_textbox.ShadowDecoration.Parent = this.stud_regnum_textbox;
            this.stud_regnum_textbox.Size = new System.Drawing.Size(283, 24);
            this.stud_regnum_textbox.TabIndex = 24;
            // 
            // stud_name_textbox
            // 
            this.stud_name_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stud_name_textbox.DefaultText = "";
            this.stud_name_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stud_name_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stud_name_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stud_name_textbox.DisabledState.Parent = this.stud_name_textbox;
            this.stud_name_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stud_name_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stud_name_textbox.FocusedState.Parent = this.stud_name_textbox;
            this.stud_name_textbox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stud_name_textbox.ForeColor = System.Drawing.Color.Black;
            this.stud_name_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stud_name_textbox.HoverState.Parent = this.stud_name_textbox;
            this.stud_name_textbox.Location = new System.Drawing.Point(33, 138);
            this.stud_name_textbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stud_name_textbox.Name = "stud_name_textbox";
            this.stud_name_textbox.PasswordChar = '\0';
            this.stud_name_textbox.PlaceholderText = "";
            this.stud_name_textbox.SelectedText = "";
            this.stud_name_textbox.ShadowDecoration.Parent = this.stud_name_textbox;
            this.stud_name_textbox.Size = new System.Drawing.Size(283, 24);
            this.stud_name_textbox.TabIndex = 25;
            this.stud_name_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stud_name_textbox_KeyPress);
            // 
            // stud_email_lb
            // 
            this.stud_email_lb.BackColor = System.Drawing.Color.Transparent;
            this.stud_email_lb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stud_email_lb.ForeColor = System.Drawing.Color.DimGray;
            this.stud_email_lb.Location = new System.Drawing.Point(33, 298);
            this.stud_email_lb.Name = "stud_email_lb";
            this.stud_email_lb.Size = new System.Drawing.Size(76, 17);
            this.stud_email_lb.TabIndex = 37;
            this.stud_email_lb.Text = "Student Email";
            // 
            // stud_coursestream_lb
            // 
            this.stud_coursestream_lb.BackColor = System.Drawing.Color.Transparent;
            this.stud_coursestream_lb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.stud_coursestream_lb.ForeColor = System.Drawing.Color.DimGray;
            this.stud_coursestream_lb.Location = new System.Drawing.Point(33, 171);
            this.stud_coursestream_lb.Name = "stud_coursestream_lb";
            this.stud_coursestream_lb.Size = new System.Drawing.Size(124, 17);
            this.stud_coursestream_lb.TabIndex = 30;
            this.stud_coursestream_lb.Text = "Student Course Stream";
            // 
            // student_course_stream_combo
            // 
            this.student_course_stream_combo.BackColor = System.Drawing.Color.Transparent;
            this.student_course_stream_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.student_course_stream_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.student_course_stream_combo.FocusedColor = System.Drawing.Color.Empty;
            this.student_course_stream_combo.FocusedState.Parent = this.student_course_stream_combo;
            this.student_course_stream_combo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_course_stream_combo.ForeColor = System.Drawing.Color.DimGray;
            this.student_course_stream_combo.FormattingEnabled = true;
            this.student_course_stream_combo.HoverState.Parent = this.student_course_stream_combo;
            this.student_course_stream_combo.ItemHeight = 16;
            this.student_course_stream_combo.Items.AddRange(new object[] {
            "Computer Science",
            "Computer Engineering",
            "Software Engineering",
            "Information Technology",
            "Information Systems"});
            this.student_course_stream_combo.ItemsAppearance.Parent = this.student_course_stream_combo;
            this.student_course_stream_combo.Location = new System.Drawing.Point(33, 196);
            this.student_course_stream_combo.Name = "student_course_stream_combo";
            this.student_course_stream_combo.ShadowDecoration.Parent = this.student_course_stream_combo;
            this.student_course_stream_combo.Size = new System.Drawing.Size(283, 22);
            this.student_course_stream_combo.TabIndex = 31;
            // 
            // update_btn
            // 
            this.update_btn.CheckedState.Parent = this.update_btn;
            this.update_btn.CustomImages.Parent = this.update_btn;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.HoverState.Parent = this.update_btn;
            this.update_btn.Location = new System.Drawing.Point(216, 382);
            this.update_btn.Name = "update_btn";
            this.update_btn.ShadowDecoration.Parent = this.update_btn;
            this.update_btn.Size = new System.Drawing.Size(100, 25);
            this.update_btn.TabIndex = 35;
            this.update_btn.Text = "Update";
            this.update_btn.Visible = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Add_Update_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(349, 486);
            this.Controls.Add(this.white_panel_back);
            this.Controls.Add(this.blue_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Update_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student Form";
            this.Load += new System.EventHandler(this.Add_Update_Student_Load);
            this.blue_panel.ResumeLayout(false);
            this.white_panel_back.ResumeLayout(false);
            this.white_panel_back.PerformLayout();
            this.message_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2HtmlLabel heading_lb;
        private Guna.UI2.WinForms.Guna2Panel blue_panel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel white_panel_back;
        private Guna.UI2.WinForms.Guna2Panel message_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel message_label;
        public Guna.UI2.WinForms.Guna2HtmlLabel stud_reg_no_lb;
        public Guna.UI2.WinForms.Guna2Button add_btn;
        public Guna.UI2.WinForms.Guna2HtmlLabel stud_name_lb;
        public Guna.UI2.WinForms.Guna2HtmlLabel intake_lb;
        public Guna.UI2.WinForms.Guna2HtmlLabel stud_mobile_lb;
        public Guna.UI2.WinForms.Guna2TextBox stud_regnum_textbox;
        public Guna.UI2.WinForms.Guna2TextBox stud_name_textbox;
        public Guna.UI2.WinForms.Guna2HtmlLabel stud_email_lb;
        public Guna.UI2.WinForms.Guna2HtmlLabel stud_coursestream_lb;
        public Guna.UI2.WinForms.Guna2ComboBox student_course_stream_combo;
        public Guna.UI2.WinForms.Guna2Button update_btn;
        public Guna.UI2.WinForms.Guna2TextBox stud_mobile_textbox;
        public Guna.UI2.WinForms.Guna2TextBox stud_email_textbox;
        public Guna.UI2.WinForms.Guna2ComboBox intake_combobox;
    }
}