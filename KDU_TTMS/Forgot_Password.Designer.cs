namespace KDU_Time_Table_Management_System
{
    partial class Forgot_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forgot_Password));
            this.email_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.reset_password_btn = new Guna.UI2.WinForms.Guna2Button();
            this.go_back_link = new System.Windows.Forms.LinkLabel();
            this.email_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.dscpLabel2 = new System.Windows.Forms.Label();
            this.dscpLabel1 = new System.Windows.Forms.Label();
            this.frgtpassLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.email_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // email_textbox
            // 
            this.email_textbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.email_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email_textbox.DefaultText = "";
            this.email_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_textbox.DisabledState.Parent = this.email_textbox;
            this.email_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_textbox.FocusedState.Parent = this.email_textbox;
            this.email_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email_textbox.HoverState.Parent = this.email_textbox;
            this.email_textbox.Location = new System.Drawing.Point(41, 151);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.PasswordChar = '\0';
            this.email_textbox.PlaceholderText = "index@kdu.ac.lk";
            this.email_textbox.SelectedText = "";
            this.email_textbox.ShadowDecoration.Parent = this.email_textbox;
            this.email_textbox.Size = new System.Drawing.Size(260, 30);
            this.email_textbox.TabIndex = 1;
            // 
            // reset_password_btn
            // 
            this.reset_password_btn.BorderRadius = 5;
            this.reset_password_btn.CheckedState.Parent = this.reset_password_btn;
            this.reset_password_btn.CustomImages.Parent = this.reset_password_btn;
            this.reset_password_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.reset_password_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.reset_password_btn.ForeColor = System.Drawing.Color.White;
            this.reset_password_btn.HoverState.Parent = this.reset_password_btn;
            this.reset_password_btn.Location = new System.Drawing.Point(41, 190);
            this.reset_password_btn.Name = "reset_password_btn";
            this.reset_password_btn.ShadowDecoration.Parent = this.reset_password_btn;
            this.reset_password_btn.Size = new System.Drawing.Size(260, 36);
            this.reset_password_btn.TabIndex = 53;
            this.reset_password_btn.Text = "Reset password";
            this.reset_password_btn.Click += new System.EventHandler(this.reset_password_btn_Click);
            // 
            // go_back_link
            // 
            this.go_back_link.AutoSize = true;
            this.go_back_link.Location = new System.Drawing.Point(260, 287);
            this.go_back_link.Name = "go_back_link";
            this.go_back_link.Size = new System.Drawing.Size(48, 13);
            this.go_back_link.TabIndex = 56;
            this.go_back_link.TabStop = true;
            this.go_back_link.Text = "Go back";
            this.go_back_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.go_back_link_LinkClicked);
            // 
            // email_errorProvider
            // 
            this.email_errorProvider.ContainerControl = this;
            // 
            // dscpLabel2
            // 
            this.dscpLabel2.AutoSize = true;
            this.dscpLabel2.BackColor = System.Drawing.Color.White;
            this.dscpLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dscpLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dscpLabel2.Location = new System.Drawing.Point(41, 103);
            this.dscpLabel2.Name = "dscpLabel2";
            this.dscpLabel2.Size = new System.Drawing.Size(176, 15);
            this.dscpLabel2.TabIndex = 58;
            this.dscpLabel2.Text = "send you a generated password.";
            // 
            // dscpLabel1
            // 
            this.dscpLabel1.AutoSize = true;
            this.dscpLabel1.BackColor = System.Drawing.Color.White;
            this.dscpLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dscpLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(86)))), ((int)(((byte)(117)))));
            this.dscpLabel1.Location = new System.Drawing.Point(41, 79);
            this.dscpLabel1.Name = "dscpLabel1";
            this.dscpLabel1.Size = new System.Drawing.Size(270, 15);
            this.dscpLabel1.TabIndex = 57;
            this.dscpLabel1.Text = "Don\'t worry! enter your email address and we will ";
            // 
            // frgtpassLabel
            // 
            this.frgtpassLabel.AutoSize = true;
            this.frgtpassLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frgtpassLabel.ForeColor = System.Drawing.Color.Black;
            this.frgtpassLabel.Location = new System.Drawing.Point(39, 45);
            this.frgtpassLabel.Name = "frgtpassLabel";
            this.frgtpassLabel.Size = new System.Drawing.Size(163, 25);
            this.frgtpassLabel.TabIndex = 59;
            this.frgtpassLabel.Text = "Forgot password";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.Black;
            this.emailLabel.Location = new System.Drawing.Point(41, 127);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(36, 15);
            this.emailLabel.TabIndex = 60;
            this.emailLabel.Text = "Email";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.Location = new System.Drawing.Point(305, -1);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 61;
            // 
            // Forgot_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(350, 270);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.frgtpassLabel);
            this.Controls.Add(this.dscpLabel2);
            this.Controls.Add(this.dscpLabel1);
            this.Controls.Add(this.go_back_link);
            this.Controls.Add(this.reset_password_btn);
            this.Controls.Add(this.email_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 270);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 270);
            this.Name = "Forgot_Password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "     ";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.email_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox email_textbox;
        private Guna.UI2.WinForms.Guna2Button reset_password_btn;
        private System.Windows.Forms.LinkLabel go_back_link;
        private System.Windows.Forms.ErrorProvider email_errorProvider;
        private System.Windows.Forms.Label dscpLabel2;
        private System.Windows.Forms.Label dscpLabel1;
        private System.Windows.Forms.Label frgtpassLabel;
        private System.Windows.Forms.Label emailLabel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}