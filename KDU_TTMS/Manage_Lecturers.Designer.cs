namespace KDU_Time_Table_Management_System
{
    partial class Manage_Lecturers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_Lecturers));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.search_textbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.refresh_btn = new Guna.UI2.WinForms.Guna2Button();
            this.add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.no_rec_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.try_search_again_label = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lecturer_info_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lectureridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lecturermobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.lecturerinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ttms_dbDataSet1 = new KDU_Time_Table_Management_System.ttms_dbDataSet1();
            this.lecturer_infoTableAdapter = new KDU_Time_Table_Management_System.ttms_dbDataSet1TableAdapters.lecturer_infoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturer_info_table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttms_dbDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_textbox
            // 
            this.search_textbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_textbox.DefaultText = "";
            this.search_textbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_textbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_textbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_textbox.DisabledState.Parent = this.search_textbox;
            this.search_textbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_textbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_textbox.FocusedState.Parent = this.search_textbox;
            this.search_textbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_textbox.HoverState.Parent = this.search_textbox;
            this.search_textbox.Location = new System.Drawing.Point(762, 9);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.PasswordChar = '\0';
            this.search_textbox.PlaceholderText = "";
            this.search_textbox.SelectedText = "";
            this.search_textbox.ShadowDecoration.Parent = this.search_textbox;
            this.search_textbox.Size = new System.Drawing.Size(267, 24);
            this.search_textbox.TabIndex = 103;
            this.search_textbox.TextChanged += new System.EventHandler(this.search_textbox_TextChanged);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::KDU_Time_Table_Management_System.Properties.Resources.search;
            this.guna2PictureBox2.Location = new System.Drawing.Point(738, 9);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(24, 24);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 100;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(632, 9);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(100, 24);
            this.guna2Button1.TabIndex = 99;
            this.guna2Button1.Text = "Export";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // refresh_btn
            // 
            this.refresh_btn.CheckedState.Parent = this.refresh_btn;
            this.refresh_btn.CustomImages.Parent = this.refresh_btn;
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.HoverState.Parent = this.refresh_btn;
            this.refresh_btn.Location = new System.Drawing.Point(1035, 9);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.ShadowDecoration.Parent = this.refresh_btn;
            this.refresh_btn.Size = new System.Drawing.Size(80, 24);
            this.refresh_btn.TabIndex = 98;
            this.refresh_btn.Text = "Refresh";
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.CheckedState.Parent = this.add_btn;
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add_btn.CustomImages.Parent = this.add_btn;
            this.add_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.add_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.HoverState.Parent = this.add_btn;
            this.add_btn.Image = ((System.Drawing.Image)(resources.GetObject("add_btn.Image")));
            this.add_btn.ImageSize = new System.Drawing.Size(18, 18);
            this.add_btn.Location = new System.Drawing.Point(479, 9);
            this.add_btn.Name = "add_btn";
            this.add_btn.ShadowDecoration.Parent = this.add_btn;
            this.add_btn.Size = new System.Drawing.Size(147, 24);
            this.add_btn.TabIndex = 96;
            this.add_btn.Text = "Add New Lecturer";
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // no_rec_label
            // 
            this.no_rec_label.BackColor = System.Drawing.Color.White;
            this.no_rec_label.Enabled = false;
            this.no_rec_label.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.no_rec_label.ForeColor = System.Drawing.Color.Red;
            this.no_rec_label.Location = new System.Drawing.Point(510, 240);
            this.no_rec_label.Name = "no_rec_label";
            this.no_rec_label.Size = new System.Drawing.Size(105, 17);
            this.no_rec_label.TabIndex = 107;
            this.no_rec_label.Text = "No matches found.";
            this.no_rec_label.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.no_rec_label.Visible = false;
            // 
            // try_search_again_label
            // 
            this.try_search_again_label.BackColor = System.Drawing.Color.White;
            this.try_search_again_label.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.try_search_again_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.try_search_again_label.Location = new System.Drawing.Point(474, 263);
            this.try_search_again_label.Name = "try_search_again_label";
            this.try_search_again_label.Size = new System.Drawing.Size(176, 27);
            this.try_search_again_label.TabIndex = 108;
            this.try_search_again_label.Text = "Try searching again";
            this.try_search_again_label.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.no_rec_label);
            this.guna2Panel1.Controls.Add(this.try_search_again_label);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.lecturer_info_table);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(28, 18);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1125, 644);
            this.guna2Panel1.TabIndex = 110;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Controls.Add(this.refresh_btn);
            this.guna2Panel2.Controls.Add(this.search_textbox);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.Controls.Add(this.add_btn);
            this.guna2Panel2.Controls.Add(this.guna2Button1);
            this.guna2Panel2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1125, 43);
            this.guna2Panel2.TabIndex = 109;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(111, 19);
            this.guna2HtmlLabel5.TabIndex = 2;
            this.guna2HtmlLabel5.Text = "Manage Lecturers";
            // 
            // lecturer_info_table
            // 
            this.lecturer_info_table.AllowUserToAddRows = false;
            this.lecturer_info_table.AllowUserToDeleteRows = false;
            this.lecturer_info_table.AllowUserToResizeColumns = false;
            this.lecturer_info_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturer_info_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.lecturer_info_table.AutoGenerateColumns = false;
            this.lecturer_info_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lecturer_info_table.BackgroundColor = System.Drawing.Color.White;
            this.lecturer_info_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lecturer_info_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lecturer_info_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.lecturer_info_table.ColumnHeadersHeight = 40;
            this.lecturer_info_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lectureridDataGridViewTextBoxColumn,
            this.lecturernameDataGridViewTextBoxColumn,
            this.lectureremailDataGridViewTextBoxColumn,
            this.lecturermobileDataGridViewTextBoxColumn,
            this.edit_btn,
            this.delete_btn});
            this.lecturer_info_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lecturer_info_table.DataSource = this.lecturerinfoBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lecturer_info_table.DefaultCellStyle = dataGridViewCellStyle5;
            this.lecturer_info_table.EnableHeadersVisualStyles = false;
            this.lecturer_info_table.GridColor = System.Drawing.Color.Silver;
            this.lecturer_info_table.Location = new System.Drawing.Point(10, 58);
            this.lecturer_info_table.MultiSelect = false;
            this.lecturer_info_table.Name = "lecturer_info_table";
            this.lecturer_info_table.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lecturer_info_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.lecturer_info_table.RowHeadersVisible = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturer_info_table.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.lecturer_info_table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturer_info_table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lecturer_info_table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lecturer_info_table.RowTemplate.DividerHeight = 1;
            this.lecturer_info_table.RowTemplate.Height = 30;
            this.lecturer_info_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lecturer_info_table.Size = new System.Drawing.Size(1105, 580);
            this.lecturer_info_table.TabIndex = 103;
            this.lecturer_info_table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.lecturer_info_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.lecturer_info_table.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturer_info_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.lecturer_info_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.lecturer_info_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.lecturer_info_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.lecturer_info_table.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.lecturer_info_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.lecturer_info_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lecturer_info_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturer_info_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.lecturer_info_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.lecturer_info_table.ThemeStyle.HeaderStyle.Height = 40;
            this.lecturer_info_table.ThemeStyle.ReadOnly = true;
            this.lecturer_info_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.lecturer_info_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.lecturer_info_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturer_info_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lecturer_info_table.ThemeStyle.RowsStyle.Height = 30;
            this.lecturer_info_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lecturer_info_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lecturer_info_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecturer_info_table_CellClick);
            // 
            // lectureridDataGridViewTextBoxColumn
            // 
            this.lectureridDataGridViewTextBoxColumn.DataPropertyName = "lecturer_id";
            this.lectureridDataGridViewTextBoxColumn.HeaderText = "Lecturer ID";
            this.lectureridDataGridViewTextBoxColumn.Name = "lectureridDataGridViewTextBoxColumn";
            this.lectureridDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturernameDataGridViewTextBoxColumn
            // 
            this.lecturernameDataGridViewTextBoxColumn.DataPropertyName = "lecturer_name";
            this.lecturernameDataGridViewTextBoxColumn.HeaderText = "Lecturer Name";
            this.lecturernameDataGridViewTextBoxColumn.Name = "lecturernameDataGridViewTextBoxColumn";
            this.lecturernameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lectureremailDataGridViewTextBoxColumn
            // 
            this.lectureremailDataGridViewTextBoxColumn.DataPropertyName = "lecturer_email";
            this.lectureremailDataGridViewTextBoxColumn.HeaderText = "Lecturer Email";
            this.lectureremailDataGridViewTextBoxColumn.Name = "lectureremailDataGridViewTextBoxColumn";
            this.lectureremailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lecturermobileDataGridViewTextBoxColumn
            // 
            this.lecturermobileDataGridViewTextBoxColumn.DataPropertyName = "lecturer_mobile";
            this.lecturermobileDataGridViewTextBoxColumn.HeaderText = "Lecturer Mobile";
            this.lecturermobileDataGridViewTextBoxColumn.Name = "lecturermobileDataGridViewTextBoxColumn";
            this.lecturermobileDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edit_btn
            // 
            this.edit_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle3.NullValue")));
            this.edit_btn.DefaultCellStyle = dataGridViewCellStyle3;
            this.edit_btn.HeaderText = "";
            this.edit_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.edit_btn;
            this.edit_btn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.ReadOnly = true;
            this.edit_btn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.edit_btn.Width = 50;
            // 
            // delete_btn
            // 
            this.delete_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle4.NullValue")));
            this.delete_btn.DefaultCellStyle = dataGridViewCellStyle4;
            this.delete_btn.HeaderText = "";
            this.delete_btn.Image = ((System.Drawing.Image)(resources.GetObject("delete_btn.Image")));
            this.delete_btn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.ReadOnly = true;
            this.delete_btn.Width = 50;
            // 
            // lecturerinfoBindingSource
            // 
            this.lecturerinfoBindingSource.DataMember = "lecturer_info";
            this.lecturerinfoBindingSource.DataSource = this.ttms_dbDataSet1;
            // 
            // ttms_dbDataSet1
            // 
            this.ttms_dbDataSet1.DataSetName = "ttms_dbDataSet1";
            this.ttms_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecturer_infoTableAdapter
            // 
            this.lecturer_infoTableAdapter.ClearBeforeFill = true;
            // 
            // Manage_Lecturers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_Lecturers";
            this.Text = "Manage_lects";
            this.Load += new System.EventHandler(this.Manage_lects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturer_info_table)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lecturerinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ttms_dbDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox search_textbox;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button refresh_btn;
        private Guna.UI2.WinForms.Guna2Button add_btn;
        private Guna.UI2.WinForms.Guna2HtmlLabel no_rec_label;
        private Guna.UI2.WinForms.Guna2HtmlLabel try_search_again_label;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView lecturer_info_table;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturerregnoDataGridViewTextBoxColumn;
        private ttms_dbDataSet1 ttms_dbDataSet1;
        private System.Windows.Forms.BindingSource lecturerinfoBindingSource;
        private ttms_dbDataSet1TableAdapters.lecturer_infoTableAdapter lecturer_infoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturermobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn edit_btn;
        private System.Windows.Forms.DataGridViewImageColumn delete_btn;
    }
}