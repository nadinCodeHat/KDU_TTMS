namespace KDU_Time_Table_Management_System
{
    partial class Send_Messages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Send_Messages));
            this.message_listbox = new System.Windows.Forms.ListBox();
            this.send_message_text = new Guna.UI2.WinForms.Guna2TextBox();
            this.send_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // message_listbox
            // 
            this.message_listbox.BackColor = System.Drawing.Color.White;
            this.message_listbox.FormattingEnabled = true;
            this.message_listbox.Location = new System.Drawing.Point(12, 12);
            this.message_listbox.Name = "message_listbox";
            this.message_listbox.Size = new System.Drawing.Size(335, 225);
            this.message_listbox.TabIndex = 1;
            // 
            // send_message_text
            // 
            this.send_message_text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.send_message_text.DefaultText = "";
            this.send_message_text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.send_message_text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.send_message_text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.send_message_text.DisabledState.Parent = this.send_message_text;
            this.send_message_text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.send_message_text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.send_message_text.FocusedState.Parent = this.send_message_text;
            this.send_message_text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.send_message_text.HoverState.Parent = this.send_message_text;
            this.send_message_text.Location = new System.Drawing.Point(12, 243);
            this.send_message_text.Name = "send_message_text";
            this.send_message_text.PasswordChar = '\0';
            this.send_message_text.PlaceholderText = "";
            this.send_message_text.SelectedText = "";
            this.send_message_text.ShadowDecoration.Parent = this.send_message_text;
            this.send_message_text.Size = new System.Drawing.Size(335, 24);
            this.send_message_text.TabIndex = 2;
            // 
            // send_btn
            // 
            this.send_btn.CheckedState.Parent = this.send_btn;
            this.send_btn.CustomImages.Parent = this.send_btn;
            this.send_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.send_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.send_btn.ForeColor = System.Drawing.Color.White;
            this.send_btn.HoverState.Parent = this.send_btn;
            this.send_btn.Location = new System.Drawing.Point(353, 243);
            this.send_btn.Name = "send_btn";
            this.send_btn.ShadowDecoration.Parent = this.send_btn;
            this.send_btn.Size = new System.Drawing.Size(100, 24);
            this.send_btn.TabIndex = 3;
            this.send_btn.Text = "Send";
            this.send_btn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.guna2Panel1.Location = new System.Drawing.Point(353, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(15, 15);
            this.guna2Panel1.TabIndex = 4;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(374, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(55, 15);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Connected";
            // 
            // Send_Messages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(461, 287);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.send_message_text);
            this.Controls.Add(this.message_listbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Send_Messages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messaging";
            this.Load += new System.EventHandler(this.Send_Messages_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox send_message_text;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        public System.Windows.Forms.ListBox message_listbox;
        public Guna.UI2.WinForms.Guna2Button send_btn;
    }
}