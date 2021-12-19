namespace KDU_Time_Table_Management_System
{
    partial class Lecturer_Parent_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lecturer_Parent_Form));
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.logout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.profile_btn = new Guna.UI2.WinForms.Guna2Button();
            this.lecture_halls_btn = new Guna.UI2.WinForms.Guna2Button();
            this.manage_lecturers_btn = new Guna.UI2.WinForms.Guna2Button();
            this.manage_students_btn = new Guna.UI2.WinForms.Guna2Button();
            this.timetable_btn = new Guna.UI2.WinForms.Guna2Button();
            this.dashboard_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.go_back_btn = new Guna.UI2.WinForms.Guna2TileButton();
            this.status_picturebox = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.status = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.show_user_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.profile_icon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.sideMenuPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.mid_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideMenuPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Controls.Add(this.logout_btn);
            this.guna2Panel2.Controls.Add(this.profile_btn);
            this.guna2Panel2.Controls.Add(this.lecture_halls_btn);
            this.guna2Panel2.Controls.Add(this.manage_lecturers_btn);
            this.guna2Panel2.Controls.Add(this.manage_students_btn);
            this.guna2Panel2.Controls.Add(this.timetable_btn);
            this.guna2Panel2.Controls.Add(this.dashboard_btn);
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.guna2Panel2.Size = new System.Drawing.Size(190, 749);
            this.guna2Panel2.TabIndex = 7;
            // 
            // logout_btn
            // 
            this.logout_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.logout_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.logout_btn.CheckedState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.logout_checked;
            this.logout_btn.CheckedState.Parent = this.logout_btn;
            this.logout_btn.CustomImages.Parent = this.logout_btn;
            this.logout_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.logout_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.logout_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_btn.ForeColor = System.Drawing.Color.LightGray;
            this.logout_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.logout_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.logout_btn.HoverState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.logout_checked;
            this.logout_btn.HoverState.Parent = this.logout_btn;
            this.logout_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.logout;
            this.logout_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logout_btn.ImageOffset = new System.Drawing.Point(10, 0);
            this.logout_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.logout_btn.Location = new System.Drawing.Point(0, 333);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.PressedDepth = 20;
            this.logout_btn.ShadowDecoration.Parent = this.logout_btn;
            this.logout_btn.Size = new System.Drawing.Size(190, 40);
            this.logout_btn.TabIndex = 52;
            this.logout_btn.Text = "Log Out";
            this.logout_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.logout_btn.TextOffset = new System.Drawing.Point(20, 0);
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // profile_btn
            // 
            this.profile_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.profile_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.profile_btn.CheckedState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.profile_checked;
            this.profile_btn.CheckedState.Parent = this.profile_btn;
            this.profile_btn.CustomImages.Parent = this.profile_btn;
            this.profile_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.profile_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.profile_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.profile_btn.ForeColor = System.Drawing.Color.LightGray;
            this.profile_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.profile_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.profile_btn.HoverState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.profile_checked;
            this.profile_btn.HoverState.Parent = this.profile_btn;
            this.profile_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.profile;
            this.profile_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.profile_btn.ImageOffset = new System.Drawing.Point(10, 0);
            this.profile_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.profile_btn.Location = new System.Drawing.Point(0, 293);
            this.profile_btn.Name = "profile_btn";
            this.profile_btn.PressedDepth = 20;
            this.profile_btn.ShadowDecoration.Parent = this.profile_btn;
            this.profile_btn.Size = new System.Drawing.Size(190, 40);
            this.profile_btn.TabIndex = 26;
            this.profile_btn.Text = "Profile";
            this.profile_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.profile_btn.TextOffset = new System.Drawing.Point(20, 0);
            this.profile_btn.Click += new System.EventHandler(this.profile_btn_Click);
            // 
            // lecture_halls_btn
            // 
            this.lecture_halls_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.lecture_halls_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.lecture_halls_btn.CheckedState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.lecture_hall_checked;
            this.lecture_halls_btn.CheckedState.Parent = this.lecture_halls_btn;
            this.lecture_halls_btn.CustomImages.Parent = this.lecture_halls_btn;
            this.lecture_halls_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.lecture_halls_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.lecture_halls_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecture_halls_btn.ForeColor = System.Drawing.Color.LightGray;
            this.lecture_halls_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.lecture_halls_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.lecture_halls_btn.HoverState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.lecture_hall_checked;
            this.lecture_halls_btn.HoverState.Parent = this.lecture_halls_btn;
            this.lecture_halls_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.lecture_hall;
            this.lecture_halls_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lecture_halls_btn.ImageOffset = new System.Drawing.Point(10, 0);
            this.lecture_halls_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.lecture_halls_btn.Location = new System.Drawing.Point(0, 253);
            this.lecture_halls_btn.Name = "lecture_halls_btn";
            this.lecture_halls_btn.PressedDepth = 20;
            this.lecture_halls_btn.ShadowDecoration.Parent = this.lecture_halls_btn;
            this.lecture_halls_btn.Size = new System.Drawing.Size(190, 40);
            this.lecture_halls_btn.TabIndex = 24;
            this.lecture_halls_btn.Text = "Lecture Halls";
            this.lecture_halls_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lecture_halls_btn.TextOffset = new System.Drawing.Point(20, 0);
            this.lecture_halls_btn.Click += new System.EventHandler(this.lecture_halls_btn_Click);
            // 
            // manage_lecturers_btn
            // 
            this.manage_lecturers_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.manage_lecturers_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.manage_lecturers_btn.CheckedState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.lecturers_checked;
            this.manage_lecturers_btn.CheckedState.Parent = this.manage_lecturers_btn;
            this.manage_lecturers_btn.CustomImages.Parent = this.manage_lecturers_btn;
            this.manage_lecturers_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manage_lecturers_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.manage_lecturers_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.manage_lecturers_btn.ForeColor = System.Drawing.Color.LightGray;
            this.manage_lecturers_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.manage_lecturers_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.manage_lecturers_btn.HoverState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.lecturers_checked;
            this.manage_lecturers_btn.HoverState.Parent = this.manage_lecturers_btn;
            this.manage_lecturers_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.lecturer;
            this.manage_lecturers_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manage_lecturers_btn.ImageOffset = new System.Drawing.Point(10, 0);
            this.manage_lecturers_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.manage_lecturers_btn.Location = new System.Drawing.Point(0, 213);
            this.manage_lecturers_btn.Name = "manage_lecturers_btn";
            this.manage_lecturers_btn.PressedDepth = 20;
            this.manage_lecturers_btn.ShadowDecoration.Parent = this.manage_lecturers_btn;
            this.manage_lecturers_btn.Size = new System.Drawing.Size(190, 40);
            this.manage_lecturers_btn.TabIndex = 20;
            this.manage_lecturers_btn.Text = "Contact Lecturers";
            this.manage_lecturers_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manage_lecturers_btn.TextOffset = new System.Drawing.Point(20, 0);
            this.manage_lecturers_btn.Click += new System.EventHandler(this.manage_lecturers_btn_Click);
            // 
            // manage_students_btn
            // 
            this.manage_students_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.manage_students_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.manage_students_btn.CheckedState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.students_checked;
            this.manage_students_btn.CheckedState.Parent = this.manage_students_btn;
            this.manage_students_btn.CustomImages.Parent = this.manage_students_btn;
            this.manage_students_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manage_students_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.manage_students_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.manage_students_btn.ForeColor = System.Drawing.Color.LightGray;
            this.manage_students_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.manage_students_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.manage_students_btn.HoverState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.students_checked;
            this.manage_students_btn.HoverState.Parent = this.manage_students_btn;
            this.manage_students_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.students;
            this.manage_students_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manage_students_btn.ImageOffset = new System.Drawing.Point(10, 0);
            this.manage_students_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.manage_students_btn.Location = new System.Drawing.Point(0, 173);
            this.manage_students_btn.Name = "manage_students_btn";
            this.manage_students_btn.PressedDepth = 20;
            this.manage_students_btn.ShadowDecoration.Parent = this.manage_students_btn;
            this.manage_students_btn.Size = new System.Drawing.Size(190, 40);
            this.manage_students_btn.TabIndex = 11;
            this.manage_students_btn.Text = "Students";
            this.manage_students_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manage_students_btn.TextOffset = new System.Drawing.Point(20, 0);
            this.manage_students_btn.Click += new System.EventHandler(this.manage_students_btn_Click);
            // 
            // timetable_btn
            // 
            this.timetable_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.timetable_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.timetable_btn.CheckedState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.timetable_checked;
            this.timetable_btn.CheckedState.Parent = this.timetable_btn;
            this.timetable_btn.CustomImages.Parent = this.timetable_btn;
            this.timetable_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.timetable_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.timetable_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timetable_btn.ForeColor = System.Drawing.Color.LightGray;
            this.timetable_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.timetable_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.timetable_btn.HoverState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.timetable_checked;
            this.timetable_btn.HoverState.Parent = this.timetable_btn;
            this.timetable_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.timetable;
            this.timetable_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.timetable_btn.ImageOffset = new System.Drawing.Point(10, 0);
            this.timetable_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.timetable_btn.Location = new System.Drawing.Point(0, 133);
            this.timetable_btn.Name = "timetable_btn";
            this.timetable_btn.PressedDepth = 20;
            this.timetable_btn.ShadowDecoration.Parent = this.timetable_btn;
            this.timetable_btn.Size = new System.Drawing.Size(190, 40);
            this.timetable_btn.TabIndex = 10;
            this.timetable_btn.Text = "Timetable";
            this.timetable_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.timetable_btn.TextOffset = new System.Drawing.Point(20, 0);
            this.timetable_btn.Click += new System.EventHandler(this.timetable_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Checked = true;
            this.dashboard_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.dashboard_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.CheckedState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.dashboard_checked;
            this.dashboard_btn.CheckedState.Parent = this.dashboard_btn;
            this.dashboard_btn.CustomImages.Parent = this.dashboard_btn;
            this.dashboard_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboard_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dashboard_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dashboard_btn.ForeColor = System.Drawing.Color.LightGray;
            this.dashboard_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(117)))), ((int)(((byte)(255)))));
            this.dashboard_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.dashboard_btn.HoverState.Image = global::KDU_Time_Table_Management_System.Properties.Resources.dashboard_checked;
            this.dashboard_btn.HoverState.Parent = this.dashboard_btn;
            this.dashboard_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.dashboard;
            this.dashboard_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboard_btn.ImageOffset = new System.Drawing.Point(10, 0);
            this.dashboard_btn.ImageSize = new System.Drawing.Size(15, 15);
            this.dashboard_btn.Location = new System.Drawing.Point(0, 93);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.PressedDepth = 20;
            this.dashboard_btn.ShadowDecoration.Parent = this.dashboard_btn;
            this.dashboard_btn.Size = new System.Drawing.Size(190, 40);
            this.dashboard_btn.TabIndex = 9;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboard_btn.TextOffset = new System.Drawing.Point(20, 0);
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(190, 93);
            this.guna2Panel4.TabIndex = 0;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(12, 24);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(166, 23);
            this.guna2HtmlLabel2.TabIndex = 13;
            this.guna2HtmlLabel2.Text = "KDU-TTMS LECTURER";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.go_back_btn);
            this.guna2Panel1.Controls.Add(this.status_picturebox);
            this.guna2Panel1.Controls.Add(this.status);
            this.guna2Panel1.Controls.Add(this.show_user_name);
            this.guna2Panel1.Controls.Add(this.profile_icon);
            this.guna2Panel1.Controls.Add(this.sideMenuPicture);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(190, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.guna2Panel1.Size = new System.Drawing.Size(1180, 70);
            this.guna2Panel1.TabIndex = 9;
            // 
            // go_back_btn
            // 
            this.go_back_btn.CheckedState.Parent = this.go_back_btn;
            this.go_back_btn.CustomImages.Parent = this.go_back_btn;
            this.go_back_btn.FillColor = System.Drawing.Color.White;
            this.go_back_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.go_back_btn.ForeColor = System.Drawing.Color.White;
            this.go_back_btn.HoverState.Parent = this.go_back_btn;
            this.go_back_btn.Location = new System.Drawing.Point(190, 26);
            this.go_back_btn.Name = "go_back_btn";
            this.go_back_btn.ShadowDecoration.Parent = this.go_back_btn;
            this.go_back_btn.Size = new System.Drawing.Size(25, 25);
            this.go_back_btn.TabIndex = 0;
            // 
            // status_picturebox
            // 
            this.status_picturebox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status_picturebox.BackColor = System.Drawing.Color.Transparent;
            this.status_picturebox.Image = global::KDU_Time_Table_Management_System.Properties.Resources.available;
            this.status_picturebox.Location = new System.Drawing.Point(1047, 37);
            this.status_picturebox.Name = "status_picturebox";
            this.status_picturebox.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.status_picturebox.ShadowDecoration.Parent = this.status_picturebox;
            this.status_picturebox.Size = new System.Drawing.Size(20, 20);
            this.status_picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.status_picturebox.TabIndex = 24;
            this.status_picturebox.TabStop = false;
            // 
            // status
            // 
            this.status.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.status.BackColor = System.Drawing.Color.Transparent;
            this.status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.status.Location = new System.Drawing.Point(1073, 39);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(53, 17);
            this.status.TabIndex = 29;
            this.status.Text = "Available";
            // 
            // show_user_name
            // 
            this.show_user_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.show_user_name.BackColor = System.Drawing.Color.Transparent;
            this.show_user_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_user_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.show_user_name.Location = new System.Drawing.Point(1047, 13);
            this.show_user_name.Name = "show_user_name";
            this.show_user_name.Size = new System.Drawing.Size(126, 17);
            this.show_user_name.TabIndex = 26;
            this.show_user_name.Text = "AMRNVB Pethiyagoda";
            // 
            // profile_icon
            // 
            this.profile_icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profile_icon.BackColor = System.Drawing.Color.Transparent;
            this.profile_icon.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.profile_icon.Image = global::KDU_Time_Table_Management_System.Properties.Resources.default_profile_pic;
            this.profile_icon.Location = new System.Drawing.Point(994, 10);
            this.profile_icon.Name = "profile_icon";
            this.profile_icon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profile_icon.ShadowDecoration.Parent = this.profile_icon;
            this.profile_icon.Size = new System.Drawing.Size(50, 50);
            this.profile_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_icon.TabIndex = 27;
            this.profile_icon.TabStop = false;
            // 
            // sideMenuPicture
            // 
            this.sideMenuPicture.BackColor = System.Drawing.Color.Transparent;
            this.sideMenuPicture.Image = ((System.Drawing.Image)(resources.GetObject("sideMenuPicture.Image")));
            this.sideMenuPicture.Location = new System.Drawing.Point(21, 0);
            this.sideMenuPicture.Name = "sideMenuPicture";
            this.sideMenuPicture.ShadowDecoration.Parent = this.sideMenuPicture;
            this.sideMenuPicture.Size = new System.Drawing.Size(70, 70);
            this.sideMenuPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.sideMenuPicture.TabIndex = 12;
            this.sideMenuPicture.TabStop = false;
            // 
            // mid_panel
            // 
            this.mid_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mid_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mid_panel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.mid_panel.Location = new System.Drawing.Point(190, 70);
            this.mid_panel.Name = "mid_panel";
            this.mid_panel.ShadowDecoration.Parent = this.mid_panel;
            this.mid_panel.Size = new System.Drawing.Size(1180, 679);
            this.mid_panel.TabIndex = 10;
            // 
            // Lecturer_Parent_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.mid_panel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lecturer_Parent_Form";
            this.Text = "Lecturer Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lecturer_Form_FormClosing);
            this.Load += new System.EventHandler(this.Lecturer_Parent_Form_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.status_picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sideMenuPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button profile_btn;
        private Guna.UI2.WinForms.Guna2Button lecture_halls_btn;
        private Guna.UI2.WinForms.Guna2Button manage_lecturers_btn;
        private Guna.UI2.WinForms.Guna2Button manage_students_btn;
        private Guna.UI2.WinForms.Guna2Button timetable_btn;
        private Guna.UI2.WinForms.Guna2Button dashboard_btn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TileButton go_back_btn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox status_picturebox;
        private Guna.UI2.WinForms.Guna2HtmlLabel status;
        private Guna.UI2.WinForms.Guna2HtmlLabel show_user_name;
        public Guna.UI2.WinForms.Guna2CirclePictureBox profile_icon;
        private Guna.UI2.WinForms.Guna2PictureBox sideMenuPicture;
        private Guna.UI2.WinForms.Guna2Panel mid_panel;
        private Guna.UI2.WinForms.Guna2Button logout_btn;
    }
}