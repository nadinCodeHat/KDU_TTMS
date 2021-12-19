namespace KDU_Time_Table_Management_System
{
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.email_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.invalid_login_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.email_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.password_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.caps_lb = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.password_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.invalid_login_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.loginBackground = new System.Windows.Forms.PictureBox();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lgnWEmailLabel = new System.Windows.Forms.Label();
            this.loginDspLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.checkRemember = new Guna.UI2.WinForms.Guna2CheckBox();
            this.forgot_password = new System.Windows.Forms.LinkLabel();
            this.rightsLabel = new System.Windows.Forms.Label();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.email_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_errorProvider)).BeginInit();
            this.invalid_login_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // email_textbox
            // 
            this.email_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email_textbox.Animated = true;
            this.email_textbox.BackColor = System.Drawing.Color.White;
            this.email_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.email_textbox.BorderRadius = 5;
            this.email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_textbox.DefaultText = "";
            this.email_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_textbox.DisabledState.Parent = this.email_textbox;
            this.email_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_textbox.FocusedState.Parent = this.email_textbox;
            this.email_textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_textbox.HoverState.Parent = this.email_textbox;
            this.email_textbox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.email_textbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.email_textbox.Location = new System.Drawing.Point(96, 247);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.PasswordChar = '\0';
            this.email_textbox.PlaceholderText = "index@kdu.ac.lk";
            this.email_textbox.SelectedText = "";
            this.email_textbox.ShadowDecoration.BorderRadius = 1;
            this.email_textbox.ShadowDecoration.Parent = this.email_textbox;
            this.email_textbox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.email_textbox.Size = new System.Drawing.Size(260, 30);
            this.email_textbox.TabIndex = 31;
            this.email_textbox.Leave += new System.EventHandler(this.email_textbox_Leave);
            // 
            // invalid_login_lb
            // 
            this.invalid_login_lb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.invalid_login_lb.BackColor = System.Drawing.Color.Transparent;
            this.invalid_login_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalid_login_lb.ForeColor = System.Drawing.Color.White;
            this.invalid_login_lb.Location = new System.Drawing.Point(44, 7);
            this.invalid_login_lb.Name = "invalid_login_lb";
            this.invalid_login_lb.Size = new System.Drawing.Size(173, 17);
            this.invalid_login_lb.TabIndex = 43;
            this.invalid_login_lb.Text = "Invalid login, Please check again";
            // 
            // login_btn
            // 
            this.login_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_btn.BackColor = System.Drawing.Color.White;
            this.login_btn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.login_btn.BorderRadius = 5;
            this.login_btn.BorderThickness = 1;
            this.login_btn.CheckedState.Parent = this.login_btn;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.CustomImages.Parent = this.login_btn;
            this.login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.login_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_btn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_btn.HoverState.ForeColor = System.Drawing.Color.White;
            this.login_btn.HoverState.Parent = this.login_btn;
            this.login_btn.ImageSize = new System.Drawing.Size(24, 24);
            this.login_btn.Location = new System.Drawing.Point(96, 398);
            this.login_btn.Name = "login_btn";
            this.login_btn.ShadowDecoration.BorderRadius = 20;
            this.login_btn.ShadowDecoration.Color = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.login_btn.ShadowDecoration.Depth = 20;
            this.login_btn.ShadowDecoration.Parent = this.login_btn;
            this.login_btn.Size = new System.Drawing.Size(260, 36);
            this.login_btn.TabIndex = 33;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // email_errorProvider
            // 
            this.email_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.email_errorProvider.ContainerControl = this;
            this.email_errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("email_errorProvider.Icon")));
            // 
            // password_errorProvider
            // 
            this.password_errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.password_errorProvider.ContainerControl = this;
            this.password_errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("password_errorProvider.Icon")));
            // 
            // caps_lb
            // 
            this.caps_lb.BackColor = System.Drawing.Color.White;
            this.caps_lb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caps_lb.ForeColor = System.Drawing.Color.Orange;
            this.caps_lb.Location = new System.Drawing.Point(139, 223);
            this.caps_lb.Name = "caps_lb";
            this.caps_lb.Size = new System.Drawing.Size(86, 17);
            this.caps_lb.TabIndex = 57;
            this.caps_lb.Text = "Capslock is ON!";
            this.caps_lb.Visible = false;
            // 
            // password_textbox
            // 
            this.password_textbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password_textbox.Animated = true;
            this.password_textbox.BackColor = System.Drawing.Color.White;
            this.password_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.password_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox.DefaultText = "";
            this.password_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textbox.DisabledState.Parent = this.password_textbox;
            this.password_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_textbox.FocusedState.Parent = this.password_textbox;
            this.password_textbox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_textbox.HoverState.Parent = this.password_textbox;
            this.password_textbox.HoverState.PlaceholderForeColor = System.Drawing.Color.Black;
            this.password_textbox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textbox.IconRight = global::KDU_Time_Table_Management_System.Properties.Resources.not_show_pass;
            this.password_textbox.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.password_textbox.IconRightOffset = new System.Drawing.Point(5, 0);
            this.password_textbox.IconRightSize = new System.Drawing.Size(15, 15);
            this.password_textbox.Location = new System.Drawing.Point(96, 308);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.PasswordChar = '*';
            this.password_textbox.PlaceholderText = "*****************";
            this.password_textbox.SelectedText = "";
            this.password_textbox.ShadowDecoration.BorderRadius = 1;
            this.password_textbox.ShadowDecoration.Parent = this.password_textbox;
            this.password_textbox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 1, 1);
            this.password_textbox.ShortcutsEnabled = false;
            this.password_textbox.Size = new System.Drawing.Size(260, 30);
            this.password_textbox.TabIndex = 32;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.IconRightClick += new System.EventHandler(this.password_textbox_IconRightClick);
            this.password_textbox.Leave += new System.EventHandler(this.password_textbox_Leave);
            // 
            // invalid_login_panel
            // 
            this.invalid_login_panel.Controls.Add(this.invalid_login_lb);
            this.invalid_login_panel.FillColor = System.Drawing.Color.Tomato;
            this.invalid_login_panel.Location = new System.Drawing.Point(97, 444);
            this.invalid_login_panel.Name = "invalid_login_panel";
            this.invalid_login_panel.ShadowDecoration.Parent = this.invalid_login_panel;
            this.invalid_login_panel.Size = new System.Drawing.Size(260, 30);
            this.invalid_login_panel.TabIndex = 53;
            this.invalid_login_panel.Visible = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // loginBackground
            // 
            this.loginBackground.Dock = System.Windows.Forms.DockStyle.Left;
            this.loginBackground.Image = global::KDU_Time_Table_Management_System.Properties.Resources.login_background;
            this.loginBackground.Location = new System.Drawing.Point(0, 0);
            this.loginBackground.Name = "loginBackground";
            this.loginBackground.Size = new System.Drawing.Size(450, 550);
            this.loginBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginBackground.TabIndex = 58;
            this.loginBackground.TabStop = false;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Location = new System.Drawing.Point(99, 187);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(69, 10);
            this.guna2Separator2.TabIndex = 64;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Location = new System.Drawing.Point(274, 187);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(69, 10);
            this.guna2Separator1.TabIndex = 63;
            // 
            // lgnWEmailLabel
            // 
            this.lgnWEmailLabel.AutoSize = true;
            this.lgnWEmailLabel.BackColor = System.Drawing.Color.White;
            this.lgnWEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lgnWEmailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.lgnWEmailLabel.Location = new System.Drawing.Point(177, 186);
            this.lgnWEmailLabel.Name = "lgnWEmailLabel";
            this.lgnWEmailLabel.Size = new System.Drawing.Size(95, 15);
            this.lgnWEmailLabel.TabIndex = 61;
            this.lgnWEmailLabel.Text = "Login with Email";
            // 
            // loginDspLabel
            // 
            this.loginDspLabel.AutoSize = true;
            this.loginDspLabel.BackColor = System.Drawing.SystemColors.Window;
            this.loginDspLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.loginDspLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.loginDspLabel.Location = new System.Drawing.Point(96, 137);
            this.loginDspLabel.Name = "loginDspLabel";
            this.loginDspLabel.Size = new System.Drawing.Size(158, 15);
            this.loginDspLabel.TabIndex = 60;
            this.loginDspLabel.Text = "Welcome, Login to continue";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.Black;
            this.loginLabel.Location = new System.Drawing.Point(94, 104);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(63, 25);
            this.loginLabel.TabIndex = 59;
            this.loginLabel.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::KDU_Time_Table_Management_System.Properties.Resources.kdu_logo_new;
            this.pictureBox1.Location = new System.Drawing.Point(96, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Controls.Add(this.rightsLabel);
            this.panel1.Controls.Add(this.forgot_password);
            this.panel1.Controls.Add(this.checkRemember);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.guna2Separator1);
            this.panel1.Controls.Add(this.emailLabel);
            this.panel1.Controls.Add(this.lgnWEmailLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2Separator2);
            this.panel1.Controls.Add(this.loginDspLabel);
            this.panel1.Controls.Add(this.invalid_login_panel);
            this.panel1.Controls.Add(this.loginLabel);
            this.panel1.Controls.Add(this.caps_lb);
            this.panel1.Controls.Add(this.email_textbox);
            this.panel1.Controls.Add(this.login_btn);
            this.panel1.Controls.Add(this.password_textbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(450, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 550);
            this.panel1.TabIndex = 66;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(97, 225);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 66;
            this.emailLabel.Text = "Email";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.Window;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Black;
            this.passwordLabel.Location = new System.Drawing.Point(96, 285);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(57, 15);
            this.passwordLabel.TabIndex = 67;
            this.passwordLabel.Text = "Password";
            // 
            // checkRemember
            // 
            this.checkRemember.AutoSize = true;
            this.checkRemember.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.checkRemember.CheckedState.BorderRadius = 2;
            this.checkRemember.CheckedState.BorderThickness = 0;
            this.checkRemember.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.checkRemember.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkRemember.ForeColor = System.Drawing.Color.Black;
            this.checkRemember.Location = new System.Drawing.Point(96, 358);
            this.checkRemember.Name = "checkRemember";
            this.checkRemember.Size = new System.Drawing.Size(104, 19);
            this.checkRemember.TabIndex = 68;
            this.checkRemember.Text = "Remember me";
            this.checkRemember.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.checkRemember.UncheckedState.BorderRadius = 2;
            this.checkRemember.UncheckedState.BorderThickness = 0;
            this.checkRemember.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.checkRemember.UseVisualStyleBackColor = true;
            // 
            // forgot_password
            // 
            this.forgot_password.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.forgot_password.AutoSize = true;
            this.forgot_password.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.forgot_password.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.forgot_password.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.forgot_password.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.forgot_password.Location = new System.Drawing.Point(257, 359);
            this.forgot_password.Name = "forgot_password";
            this.forgot_password.Size = new System.Drawing.Size(100, 15);
            this.forgot_password.TabIndex = 69;
            this.forgot_password.TabStop = true;
            this.forgot_password.Text = "Forgot password?";
            this.forgot_password.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            // 
            // rightsLabel
            // 
            this.rightsLabel.AutoSize = true;
            this.rightsLabel.BackColor = System.Drawing.Color.White;
            this.rightsLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rightsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.rightsLabel.Location = new System.Drawing.Point(127, 506);
            this.rightsLabel.Name = "rightsLabel";
            this.rightsLabel.Size = new System.Drawing.Size(197, 15);
            this.rightsLabel.TabIndex = 70;
            this.rightsLabel.Text = "©2020 KDUTTMS All rights reserved.";
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox2.Location = new System.Drawing.Point(357, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 72;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(405, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 71;
            // 
            // Login_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 550);
            this.Controls.Add(this.loginBackground);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time Table Management System 1.0.1 - Login";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_Form_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.email_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.password_errorProvider)).EndInit();
            this.invalid_login_panel.ResumeLayout(false);
            this.invalid_login_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox email_textbox;
        private Guna.UI2.WinForms.Guna2TextBox password_textbox;
        private Guna.UI2.WinForms.Guna2HtmlLabel invalid_login_lb;
        private Guna.UI2.WinForms.Guna2Button login_btn;
        private System.Windows.Forms.ErrorProvider email_errorProvider;
        private System.Windows.Forms.ErrorProvider password_errorProvider;
        private Guna.UI2.WinForms.Guna2HtmlLabel caps_lb;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Panel invalid_login_panel;
        private System.Windows.Forms.PictureBox loginBackground;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lgnWEmailLabel;
        private System.Windows.Forms.Label loginDspLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.LinkLabel forgot_password;
        private Guna.UI2.WinForms.Guna2CheckBox checkRemember;
        private System.Windows.Forms.Label rightsLabel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}