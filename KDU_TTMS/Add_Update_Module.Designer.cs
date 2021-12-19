namespace KDU_Time_Table_Management_System
{
    partial class Add_Update_Module
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_Update_Module));
            this.add_update_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.blue_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.white_panel_back = new Guna.UI2.WinForms.Guna2Panel();
            this.lecturer_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.mgpa_btn = new Guna.UI2.WinForms.Guna2Button();
            this.ngpa_btn = new Guna.UI2.WinForms.Guna2Button();
            this.gpa_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.elective_btn = new Guna.UI2.WinForms.Guna2Button();
            this.compulsory_btn = new Guna.UI2.WinForms.Guna2Button();
            this.module_short_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.message_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.message_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.add_module_btn = new Guna.UI2.WinForms.Guna2Button();
            this.update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.select_degree_prog_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.select_degree_programme = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lecture_code_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.abbr = new Guna.UI2.WinForms.Guna2TextBox();
            this.lecture_code_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.lecture_module_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.semester_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lecture_module_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.select_sem_combo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.credit_val = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.credit_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.blue_panel.SuspendLayout();
            this.white_panel_back.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.message_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.credit_val)).BeginInit();
            this.SuspendLayout();
            // 
            // add_update_lb
            // 
            this.add_update_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_update_lb.AutoSize = false;
            this.add_update_lb.BackColor = System.Drawing.Color.Transparent;
            this.add_update_lb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_update_lb.ForeColor = System.Drawing.Color.White;
            this.add_update_lb.Location = new System.Drawing.Point(0, 11);
            this.add_update_lb.Name = "add_update_lb";
            this.add_update_lb.Size = new System.Drawing.Size(443, 23);
            this.add_update_lb.TabIndex = 0;
            this.add_update_lb.Text = "Add Module";
            this.add_update_lb.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blue_panel
            // 
            this.blue_panel.Controls.Add(this.add_update_lb);
            this.blue_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.blue_panel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.blue_panel.Location = new System.Drawing.Point(0, 0);
            this.blue_panel.Name = "blue_panel";
            this.blue_panel.ShadowDecoration.Parent = this.blue_panel;
            this.blue_panel.Size = new System.Drawing.Size(443, 44);
            this.blue_panel.TabIndex = 68;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // white_panel_back
            // 
            this.white_panel_back.Controls.Add(this.lecturer_combo);
            this.white_panel_back.Controls.Add(this.guna2HtmlLabel1);
            this.white_panel_back.Controls.Add(this.guna2Panel2);
            this.white_panel_back.Controls.Add(this.guna2Panel1);
            this.white_panel_back.Controls.Add(this.module_short_lb);
            this.white_panel_back.Controls.Add(this.message_panel);
            this.white_panel_back.Controls.Add(this.add_module_btn);
            this.white_panel_back.Controls.Add(this.update_btn);
            this.white_panel_back.Controls.Add(this.select_degree_prog_lb);
            this.white_panel_back.Controls.Add(this.select_degree_programme);
            this.white_panel_back.Controls.Add(this.lecture_code_lb);
            this.white_panel_back.Controls.Add(this.abbr);
            this.white_panel_back.Controls.Add(this.lecture_code_textbox);
            this.white_panel_back.Controls.Add(this.lecture_module_lb);
            this.white_panel_back.Controls.Add(this.semester_lb);
            this.white_panel_back.Controls.Add(this.lecture_module_textbox);
            this.white_panel_back.Controls.Add(this.select_sem_combo);
            this.white_panel_back.Controls.Add(this.credit_val);
            this.white_panel_back.Controls.Add(this.credit_lb);
            this.white_panel_back.Dock = System.Windows.Forms.DockStyle.Fill;
            this.white_panel_back.FillColor = System.Drawing.Color.White;
            this.white_panel_back.Location = new System.Drawing.Point(0, 44);
            this.white_panel_back.Name = "white_panel_back";
            this.white_panel_back.ShadowDecoration.Parent = this.white_panel_back;
            this.white_panel_back.Size = new System.Drawing.Size(443, 477);
            this.white_panel_back.TabIndex = 69;
            // 
            // lecturer_combo
            // 
            this.lecturer_combo.BackColor = System.Drawing.Color.Transparent;
            this.lecturer_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lecturer_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lecturer_combo.FocusedColor = System.Drawing.Color.Empty;
            this.lecturer_combo.FocusedState.Parent = this.lecturer_combo;
            this.lecturer_combo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lecturer_combo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.lecturer_combo.FormattingEnabled = true;
            this.lecturer_combo.HoverState.Parent = this.lecturer_combo;
            this.lecturer_combo.ItemHeight = 16;
            this.lecturer_combo.ItemsAppearance.Parent = this.lecturer_combo;
            this.lecturer_combo.Location = new System.Drawing.Point(24, 470);
            this.lecturer_combo.Name = "lecturer_combo";
            this.lecturer_combo.ShadowDecoration.Parent = this.lecturer_combo;
            this.lecturer_combo.Size = new System.Drawing.Size(396, 22);
            this.lecturer_combo.TabIndex = 52;
            this.lecturer_combo.Visible = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(141)))), ((int)(((byte)(167)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(24, 447);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(46, 17);
            this.guna2HtmlLabel1.TabIndex = 51;
            this.guna2HtmlLabel1.Text = "Lecturer";
            this.guna2HtmlLabel1.Visible = false;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.mgpa_btn);
            this.guna2Panel2.Controls.Add(this.ngpa_btn);
            this.guna2Panel2.Controls.Add(this.gpa_btn);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(23, 250);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(396, 24);
            this.guna2Panel2.TabIndex = 50;
            // 
            // mgpa_btn
            // 
            this.mgpa_btn.BorderColor = System.Drawing.Color.Empty;
            this.mgpa_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.mgpa_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.mgpa_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.mgpa_btn.CheckedState.Parent = this.mgpa_btn;
            this.mgpa_btn.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.mgpa_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.mgpa_btn.CustomImages.Parent = this.mgpa_btn;
            this.mgpa_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.mgpa_btn.FillColor = System.Drawing.Color.White;
            this.mgpa_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mgpa_btn.ForeColor = System.Drawing.Color.DimGray;
            this.mgpa_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.mgpa_btn.HoverState.Parent = this.mgpa_btn;
            this.mgpa_btn.Location = new System.Drawing.Point(264, 0);
            this.mgpa_btn.Name = "mgpa_btn";
            this.mgpa_btn.PressedColor = System.Drawing.Color.White;
            this.mgpa_btn.PressedDepth = 0;
            this.mgpa_btn.ShadowDecoration.Parent = this.mgpa_btn;
            this.mgpa_btn.Size = new System.Drawing.Size(132, 24);
            this.mgpa_btn.TabIndex = 2;
            this.mgpa_btn.Text = "MGPA";
            this.mgpa_btn.Click += new System.EventHandler(this.mgpa_btn_Click);
            // 
            // ngpa_btn
            // 
            this.ngpa_btn.BorderColor = System.Drawing.Color.Empty;
            this.ngpa_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.ngpa_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.ngpa_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.ngpa_btn.CheckedState.Parent = this.ngpa_btn;
            this.ngpa_btn.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ngpa_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.ngpa_btn.CustomImages.Parent = this.ngpa_btn;
            this.ngpa_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ngpa_btn.FillColor = System.Drawing.Color.White;
            this.ngpa_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ngpa_btn.ForeColor = System.Drawing.Color.DimGray;
            this.ngpa_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.ngpa_btn.HoverState.Parent = this.ngpa_btn;
            this.ngpa_btn.Location = new System.Drawing.Point(132, 0);
            this.ngpa_btn.Name = "ngpa_btn";
            this.ngpa_btn.PressedColor = System.Drawing.Color.White;
            this.ngpa_btn.PressedDepth = 0;
            this.ngpa_btn.ShadowDecoration.Parent = this.ngpa_btn;
            this.ngpa_btn.Size = new System.Drawing.Size(132, 24);
            this.ngpa_btn.TabIndex = 1;
            this.ngpa_btn.Text = "NGPA";
            this.ngpa_btn.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // gpa_btn
            // 
            this.gpa_btn.BorderColor = System.Drawing.Color.Empty;
            this.gpa_btn.Checked = true;
            this.gpa_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.gpa_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.gpa_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.gpa_btn.CheckedState.Parent = this.gpa_btn;
            this.gpa_btn.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gpa_btn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.gpa_btn.CustomImages.Parent = this.gpa_btn;
            this.gpa_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpa_btn.FillColor = System.Drawing.Color.White;
            this.gpa_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gpa_btn.ForeColor = System.Drawing.Color.DimGray;
            this.gpa_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.gpa_btn.HoverState.Parent = this.gpa_btn;
            this.gpa_btn.Location = new System.Drawing.Point(0, 0);
            this.gpa_btn.Name = "gpa_btn";
            this.gpa_btn.PressedColor = System.Drawing.Color.White;
            this.gpa_btn.PressedDepth = 0;
            this.gpa_btn.ShadowDecoration.Parent = this.gpa_btn;
            this.gpa_btn.Size = new System.Drawing.Size(132, 24);
            this.gpa_btn.TabIndex = 0;
            this.gpa_btn.Text = "GPA";
            this.gpa_btn.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.elective_btn);
            this.guna2Panel1.Controls.Add(this.compulsory_btn);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(24, 370);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(396, 24);
            this.guna2Panel1.TabIndex = 49;
            // 
            // elective_btn
            // 
            this.elective_btn.BorderColor = System.Drawing.Color.Empty;
            this.elective_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.elective_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.elective_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.elective_btn.CheckedState.Parent = this.elective_btn;
            this.elective_btn.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.elective_btn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.elective_btn.CustomImages.Parent = this.elective_btn;
            this.elective_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.elective_btn.FillColor = System.Drawing.Color.White;
            this.elective_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.elective_btn.ForeColor = System.Drawing.Color.DimGray;
            this.elective_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.elective_btn.HoverState.Parent = this.elective_btn;
            this.elective_btn.Location = new System.Drawing.Point(198, 0);
            this.elective_btn.Name = "elective_btn";
            this.elective_btn.PressedColor = System.Drawing.Color.White;
            this.elective_btn.PressedDepth = 0;
            this.elective_btn.ShadowDecoration.Parent = this.elective_btn;
            this.elective_btn.Size = new System.Drawing.Size(198, 24);
            this.elective_btn.TabIndex = 1;
            this.elective_btn.Text = "Elective";
            this.elective_btn.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // compulsory_btn
            // 
            this.compulsory_btn.BorderColor = System.Drawing.Color.Empty;
            this.compulsory_btn.Checked = true;
            this.compulsory_btn.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.compulsory_btn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.compulsory_btn.CheckedState.ForeColor = System.Drawing.Color.White;
            this.compulsory_btn.CheckedState.Parent = this.compulsory_btn;
            this.compulsory_btn.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.compulsory_btn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.compulsory_btn.CustomImages.Parent = this.compulsory_btn;
            this.compulsory_btn.Dock = System.Windows.Forms.DockStyle.Left;
            this.compulsory_btn.FillColor = System.Drawing.Color.White;
            this.compulsory_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.compulsory_btn.ForeColor = System.Drawing.Color.DimGray;
            this.compulsory_btn.HoverState.FillColor = System.Drawing.Color.White;
            this.compulsory_btn.HoverState.Parent = this.compulsory_btn;
            this.compulsory_btn.Location = new System.Drawing.Point(0, 0);
            this.compulsory_btn.Name = "compulsory_btn";
            this.compulsory_btn.PressedColor = System.Drawing.Color.White;
            this.compulsory_btn.PressedDepth = 0;
            this.compulsory_btn.ShadowDecoration.Parent = this.compulsory_btn;
            this.compulsory_btn.Size = new System.Drawing.Size(198, 24);
            this.compulsory_btn.TabIndex = 0;
            this.compulsory_btn.Text = "Compulsory";
            this.compulsory_btn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // module_short_lb
            // 
            this.module_short_lb.BackColor = System.Drawing.Color.Transparent;
            this.module_short_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.module_short_lb.ForeColor = System.Drawing.Color.DimGray;
            this.module_short_lb.Location = new System.Drawing.Point(24, 181);
            this.module_short_lb.Name = "module_short_lb";
            this.module_short_lb.Size = new System.Drawing.Size(74, 17);
            this.module_short_lb.TabIndex = 48;
            this.module_short_lb.Text = "Lecture Abbr.";
            // 
            // message_panel
            // 
            this.message_panel.BackColor = System.Drawing.Color.Transparent;
            this.message_panel.Controls.Add(this.message_label);
            this.message_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.message_panel.FillColor = System.Drawing.Color.Tomato;
            this.message_panel.Location = new System.Drawing.Point(0, 0);
            this.message_panel.Name = "message_panel";
            this.message_panel.ShadowDecoration.Parent = this.message_panel;
            this.message_panel.Size = new System.Drawing.Size(443, 35);
            this.message_panel.TabIndex = 44;
            this.message_panel.Visible = false;
            // 
            // message_label
            // 
            this.message_label.AutoSize = false;
            this.message_label.BackColor = System.Drawing.Color.Transparent;
            this.message_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message_label.ForeColor = System.Drawing.Color.White;
            this.message_label.Location = new System.Drawing.Point(-1, 6);
            this.message_label.Name = "message_label";
            this.message_label.Size = new System.Drawing.Size(445, 22);
            this.message_label.TabIndex = 44;
            this.message_label.Text = "Text";
            this.message_label.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // add_module_btn
            // 
            this.add_module_btn.CheckedState.Parent = this.add_module_btn;
            this.add_module_btn.CustomImages.Parent = this.add_module_btn;
            this.add_module_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.add_module_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_module_btn.ForeColor = System.Drawing.Color.White;
            this.add_module_btn.HoverState.Parent = this.add_module_btn;
            this.add_module_btn.Location = new System.Drawing.Point(331, 421);
            this.add_module_btn.Name = "add_module_btn";
            this.add_module_btn.ShadowDecoration.Parent = this.add_module_btn;
            this.add_module_btn.Size = new System.Drawing.Size(100, 25);
            this.add_module_btn.TabIndex = 7;
            this.add_module_btn.Text = "Add Module";
            this.add_module_btn.Click += new System.EventHandler(this.add_module_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.CheckedState.Parent = this.update_btn;
            this.update_btn.CustomImages.Parent = this.update_btn;
            this.update_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.update_btn.ForeColor = System.Drawing.Color.White;
            this.update_btn.HoverState.Parent = this.update_btn;
            this.update_btn.Location = new System.Drawing.Point(331, 421);
            this.update_btn.Name = "update_btn";
            this.update_btn.ShadowDecoration.Parent = this.update_btn;
            this.update_btn.Size = new System.Drawing.Size(100, 25);
            this.update_btn.TabIndex = 18;
            this.update_btn.Text = "Update";
            this.update_btn.Visible = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // select_degree_prog_lb
            // 
            this.select_degree_prog_lb.BackColor = System.Drawing.Color.Transparent;
            this.select_degree_prog_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_degree_prog_lb.ForeColor = System.Drawing.Color.DimGray;
            this.select_degree_prog_lb.Location = new System.Drawing.Point(24, 298);
            this.select_degree_prog_lb.Name = "select_degree_prog_lb";
            this.select_degree_prog_lb.Size = new System.Drawing.Size(139, 17);
            this.select_degree_prog_lb.TabIndex = 46;
            this.select_degree_prog_lb.Text = "Select degree programme";
            // 
            // select_degree_programme
            // 
            this.select_degree_programme.BackColor = System.Drawing.Color.Transparent;
            this.select_degree_programme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.select_degree_programme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_degree_programme.FocusedColor = System.Drawing.Color.Empty;
            this.select_degree_programme.FocusedState.Parent = this.select_degree_programme;
            this.select_degree_programme.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_degree_programme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.select_degree_programme.FormattingEnabled = true;
            this.select_degree_programme.HoverState.Parent = this.select_degree_programme;
            this.select_degree_programme.ItemHeight = 16;
            this.select_degree_programme.Items.AddRange(new object[] {
            "Computer Science",
            "Computer Engineering",
            "Software Engineering",
            "Computer Science,Computer Engineering,Software Engineering",
            "Information Technology",
            "Information Systems"});
            this.select_degree_programme.ItemsAppearance.Parent = this.select_degree_programme;
            this.select_degree_programme.Location = new System.Drawing.Point(24, 321);
            this.select_degree_programme.Name = "select_degree_programme";
            this.select_degree_programme.ShadowDecoration.Parent = this.select_degree_programme;
            this.select_degree_programme.Size = new System.Drawing.Size(395, 22);
            this.select_degree_programme.TabIndex = 45;
            // 
            // lecture_code_lb
            // 
            this.lecture_code_lb.BackColor = System.Drawing.Color.Transparent;
            this.lecture_code_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecture_code_lb.ForeColor = System.Drawing.Color.DimGray;
            this.lecture_code_lb.Location = new System.Drawing.Point(24, 50);
            this.lecture_code_lb.Name = "lecture_code_lb";
            this.lecture_code_lb.Size = new System.Drawing.Size(73, 17);
            this.lecture_code_lb.TabIndex = 1;
            this.lecture_code_lb.Text = "Lecture Code";
            // 
            // abbr
            // 
            this.abbr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.abbr.DefaultText = "";
            this.abbr.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.abbr.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.abbr.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.abbr.DisabledState.Parent = this.abbr;
            this.abbr.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.abbr.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.abbr.FocusedState.Parent = this.abbr;
            this.abbr.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abbr.ForeColor = System.Drawing.Color.Black;
            this.abbr.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.abbr.HoverState.Parent = this.abbr;
            this.abbr.Location = new System.Drawing.Point(24, 204);
            this.abbr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.abbr.Name = "abbr";
            this.abbr.PasswordChar = '\0';
            this.abbr.PlaceholderText = "E.g DSA II";
            this.abbr.SelectedText = "";
            this.abbr.ShadowDecoration.Parent = this.abbr;
            this.abbr.Size = new System.Drawing.Size(100, 24);
            this.abbr.TabIndex = 47;
            // 
            // lecture_code_textbox
            // 
            this.lecture_code_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lecture_code_textbox.DefaultText = "";
            this.lecture_code_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lecture_code_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lecture_code_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lecture_code_textbox.DisabledState.Parent = this.lecture_code_textbox;
            this.lecture_code_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lecture_code_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lecture_code_textbox.FocusedState.Parent = this.lecture_code_textbox;
            this.lecture_code_textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecture_code_textbox.ForeColor = System.Drawing.Color.Black;
            this.lecture_code_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lecture_code_textbox.HoverState.Parent = this.lecture_code_textbox;
            this.lecture_code_textbox.Location = new System.Drawing.Point(24, 73);
            this.lecture_code_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lecture_code_textbox.Name = "lecture_code_textbox";
            this.lecture_code_textbox.PasswordChar = '\0';
            this.lecture_code_textbox.PlaceholderText = "";
            this.lecture_code_textbox.SelectedText = "";
            this.lecture_code_textbox.ShadowDecoration.Parent = this.lecture_code_textbox;
            this.lecture_code_textbox.Size = new System.Drawing.Size(395, 24);
            this.lecture_code_textbox.TabIndex = 4;
            // 
            // lecture_module_lb
            // 
            this.lecture_module_lb.BackColor = System.Drawing.Color.Transparent;
            this.lecture_module_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecture_module_lb.ForeColor = System.Drawing.Color.DimGray;
            this.lecture_module_lb.Location = new System.Drawing.Point(23, 109);
            this.lecture_module_lb.Name = "lecture_module_lb";
            this.lecture_module_lb.Size = new System.Drawing.Size(77, 17);
            this.lecture_module_lb.TabIndex = 2;
            this.lecture_module_lb.Text = "Lecture Name";
            // 
            // semester_lb
            // 
            this.semester_lb.BackColor = System.Drawing.Color.Transparent;
            this.semester_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester_lb.ForeColor = System.Drawing.Color.DimGray;
            this.semester_lb.Location = new System.Drawing.Point(287, 181);
            this.semester_lb.Name = "semester_lb";
            this.semester_lb.Size = new System.Drawing.Size(51, 17);
            this.semester_lb.TabIndex = 44;
            this.semester_lb.Text = "Semester";
            // 
            // lecture_module_textbox
            // 
            this.lecture_module_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lecture_module_textbox.DefaultText = "";
            this.lecture_module_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lecture_module_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lecture_module_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lecture_module_textbox.DisabledState.Parent = this.lecture_module_textbox;
            this.lecture_module_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lecture_module_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lecture_module_textbox.FocusedState.Parent = this.lecture_module_textbox;
            this.lecture_module_textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecture_module_textbox.ForeColor = System.Drawing.Color.Black;
            this.lecture_module_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lecture_module_textbox.HoverState.Parent = this.lecture_module_textbox;
            this.lecture_module_textbox.Location = new System.Drawing.Point(23, 132);
            this.lecture_module_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lecture_module_textbox.Name = "lecture_module_textbox";
            this.lecture_module_textbox.PasswordChar = '\0';
            this.lecture_module_textbox.PlaceholderText = "";
            this.lecture_module_textbox.SelectedText = "";
            this.lecture_module_textbox.ShadowDecoration.Parent = this.lecture_module_textbox;
            this.lecture_module_textbox.Size = new System.Drawing.Size(396, 24);
            this.lecture_module_textbox.TabIndex = 5;
            // 
            // select_sem_combo
            // 
            this.select_sem_combo.BackColor = System.Drawing.Color.Transparent;
            this.select_sem_combo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.select_sem_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.select_sem_combo.FocusedColor = System.Drawing.Color.Empty;
            this.select_sem_combo.FocusedState.Parent = this.select_sem_combo;
            this.select_sem_combo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_sem_combo.ForeColor = System.Drawing.Color.DimGray;
            this.select_sem_combo.FormattingEnabled = true;
            this.select_sem_combo.HoverState.Parent = this.select_sem_combo;
            this.select_sem_combo.ItemHeight = 16;
            this.select_sem_combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.select_sem_combo.ItemsAppearance.Parent = this.select_sem_combo;
            this.select_sem_combo.Location = new System.Drawing.Point(291, 204);
            this.select_sem_combo.Name = "select_sem_combo";
            this.select_sem_combo.ShadowDecoration.Parent = this.select_sem_combo;
            this.select_sem_combo.Size = new System.Drawing.Size(128, 22);
            this.select_sem_combo.TabIndex = 43;
            // 
            // credit_val
            // 
            this.credit_val.BackColor = System.Drawing.Color.Transparent;
            this.credit_val.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.credit_val.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.credit_val.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.credit_val.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.credit_val.DisabledState.Parent = this.credit_val;
            this.credit_val.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.credit_val.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.credit_val.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.credit_val.FocusedState.Parent = this.credit_val;
            this.credit_val.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_val.ForeColor = System.Drawing.Color.Black;
            this.credit_val.Location = new System.Drawing.Point(157, 204);
            this.credit_val.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.credit_val.Name = "credit_val";
            this.credit_val.ShadowDecoration.Parent = this.credit_val;
            this.credit_val.Size = new System.Drawing.Size(99, 24);
            this.credit_val.TabIndex = 9;
            this.credit_val.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.credit_val.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // credit_lb
            // 
            this.credit_lb.BackColor = System.Drawing.Color.Transparent;
            this.credit_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_lb.ForeColor = System.Drawing.Color.DimGray;
            this.credit_lb.Location = new System.Drawing.Point(157, 181);
            this.credit_lb.Name = "credit_lb";
            this.credit_lb.Size = new System.Drawing.Size(35, 17);
            this.credit_lb.TabIndex = 10;
            this.credit_lb.Text = "Credit";
            // 
            // Add_Update_Module
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(443, 521);
            this.Controls.Add(this.white_panel_back);
            this.Controls.Add(this.blue_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Update_Module";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add / Update Module";
            this.Load += new System.EventHandler(this.Add_Module_Form_Load);
            this.blue_panel.ResumeLayout(false);
            this.white_panel_back.ResumeLayout(false);
            this.white_panel_back.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.message_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.credit_val)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI2.WinForms.Guna2HtmlLabel add_update_lb;
        private Guna.UI2.WinForms.Guna2Panel blue_panel;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel white_panel_back;
        private Guna.UI2.WinForms.Guna2HtmlLabel module_short_lb;
        private Guna.UI2.WinForms.Guna2Panel message_panel;
        private Guna.UI2.WinForms.Guna2HtmlLabel message_label;
        public Guna.UI2.WinForms.Guna2Button add_module_btn;
        public Guna.UI2.WinForms.Guna2Button update_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel select_degree_prog_lb;
        public Guna.UI2.WinForms.Guna2ComboBox select_degree_programme;
        private Guna.UI2.WinForms.Guna2HtmlLabel lecture_code_lb;
        public Guna.UI2.WinForms.Guna2TextBox abbr;
        public Guna.UI2.WinForms.Guna2TextBox lecture_code_textbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel lecture_module_lb;
        private Guna.UI2.WinForms.Guna2HtmlLabel semester_lb;
        public Guna.UI2.WinForms.Guna2TextBox lecture_module_textbox;
        public Guna.UI2.WinForms.Guna2ComboBox select_sem_combo;
        public Guna.UI2.WinForms.Guna2NumericUpDown credit_val;
        private Guna.UI2.WinForms.Guna2HtmlLabel credit_lb;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        public Guna.UI2.WinForms.Guna2Button elective_btn;
        public Guna.UI2.WinForms.Guna2Button compulsory_btn;
        public Guna.UI2.WinForms.Guna2Button ngpa_btn;
        public Guna.UI2.WinForms.Guna2Button gpa_btn;
        public Guna.UI2.WinForms.Guna2Button mgpa_btn;
        private Guna.UI2.WinForms.Guna2ComboBox lecturer_combo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}