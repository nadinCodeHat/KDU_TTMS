namespace KDU_Time_Table_Management_System
{
    partial class Manage_LectureHalls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_LectureHalls));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lecturehallinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet_getLectureHallInfo = new KDU_Time_Table_Management_System.DataSet_getLectureHallInfo();
            this.lecture_hall_infoTableAdapter = new KDU_Time_Table_Management_System.DataSet_getLectureHallInfoTableAdapters.lecture_hall_infoTableAdapter();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.refresh_btn = new Guna.UI2.WinForms.Guna2Button();
            this.add_btn = new Guna.UI2.WinForms.Guna2Button();
            this.lecturehall_info_table = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lecturehallDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availabilityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete_btn = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lecture_hall_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.availability = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lecture_name = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.hall_capacity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel13 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel14 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.leture_timeslot = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel16 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lecturer_name = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.lecturehallinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_getLectureHallInfo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturehall_info_table)).BeginInit();
            this.guna2Panel4.SuspendLayout();
            this.guna2Panel6.SuspendLayout();
            this.guna2Panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lecturehallinfoBindingSource
            // 
            this.lecturehallinfoBindingSource.DataMember = "lecture_hall_info";
            this.lecturehallinfoBindingSource.DataSource = this.dataSet_getLectureHallInfo;
            // 
            // dataSet_getLectureHallInfo
            // 
            this.dataSet_getLectureHallInfo.DataSetName = "DataSet_getLectureHallInfo";
            this.dataSet_getLectureHallInfo.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lecture_hall_infoTableAdapter
            // 
            this.lecture_hall_infoTableAdapter.ClearBeforeFill = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel1);
            this.flowLayoutPanel1.Controls.Add(this.guna2Panel4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1180, 680);
            this.flowLayoutPanel1.TabIndex = 113;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1153, 378);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.guna2Panel3);
            this.guna2Panel2.Controls.Add(this.lecturehall_info_table);
            this.guna2Panel2.FillColor = System.Drawing.Color.White;
            this.guna2Panel2.Location = new System.Drawing.Point(28, 18);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1111, 354);
            this.guna2Panel2.TabIndex = 114;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.White;
            this.guna2Panel3.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel3.Controls.Add(this.refresh_btn);
            this.guna2Panel3.Controls.Add(this.add_btn);
            this.guna2Panel3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.White;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(1111, 43);
            this.guna2Panel3.TabIndex = 109;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(133, 19);
            this.guna2HtmlLabel5.TabIndex = 2;
            this.guna2HtmlLabel5.Text = "Manage Lecture Halls";
            // 
            // refresh_btn
            // 
            this.refresh_btn.CheckedState.Parent = this.refresh_btn;
            this.refresh_btn.CustomImages.Parent = this.refresh_btn;
            this.refresh_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.refresh_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.refresh_btn.ForeColor = System.Drawing.Color.White;
            this.refresh_btn.HoverState.Parent = this.refresh_btn;
            this.refresh_btn.Location = new System.Drawing.Point(1021, 9);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.ShadowDecoration.Parent = this.refresh_btn;
            this.refresh_btn.Size = new System.Drawing.Size(80, 24);
            this.refresh_btn.TabIndex = 98;
            this.refresh_btn.Text = "Refresh";
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
            this.add_btn.Location = new System.Drawing.Point(868, 9);
            this.add_btn.Name = "add_btn";
            this.add_btn.ShadowDecoration.Parent = this.add_btn;
            this.add_btn.Size = new System.Drawing.Size(147, 24);
            this.add_btn.TabIndex = 96;
            this.add_btn.Text = "Add New Lecture Hall";
            // 
            // lecturehall_info_table
            // 
            this.lecturehall_info_table.AllowUserToAddRows = false;
            this.lecturehall_info_table.AllowUserToDeleteRows = false;
            this.lecturehall_info_table.AllowUserToResizeColumns = false;
            this.lecturehall_info_table.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturehall_info_table.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.lecturehall_info_table.AutoGenerateColumns = false;
            this.lecturehall_info_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lecturehall_info_table.BackgroundColor = System.Drawing.Color.White;
            this.lecturehall_info_table.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lecturehall_info_table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lecturehall_info_table.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.lecturehall_info_table.ColumnHeadersHeight = 40;
            this.lecturehall_info_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.lecturehallDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.availabilityDataGridViewTextBoxColumn,
            this.edit_btn,
            this.delete_btn});
            this.lecturehall_info_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lecturehall_info_table.DataSource = this.lecturehallinfoBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lecturehall_info_table.DefaultCellStyle = dataGridViewCellStyle8;
            this.lecturehall_info_table.EnableHeadersVisualStyles = false;
            this.lecturehall_info_table.GridColor = System.Drawing.Color.Silver;
            this.lecturehall_info_table.Location = new System.Drawing.Point(10, 58);
            this.lecturehall_info_table.MultiSelect = false;
            this.lecturehall_info_table.Name = "lecturehall_info_table";
            this.lecturehall_info_table.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lecturehall_info_table.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.lecturehall_info_table.RowHeadersVisible = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturehall_info_table.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.lecturehall_info_table.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturehall_info_table.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lecturehall_info_table.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lecturehall_info_table.RowTemplate.DividerHeight = 1;
            this.lecturehall_info_table.RowTemplate.Height = 30;
            this.lecturehall_info_table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lecturehall_info_table.Size = new System.Drawing.Size(1091, 284);
            this.lecturehall_info_table.TabIndex = 103;
            this.lecturehall_info_table.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.lecturehall_info_table.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.Empty;
            this.lecturehall_info_table.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturehall_info_table.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.lecturehall_info_table.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.lecturehall_info_table.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.lecturehall_info_table.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.lecturehall_info_table.ThemeStyle.GridColor = System.Drawing.Color.Silver;
            this.lecturehall_info_table.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.lecturehall_info_table.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.lecturehall_info_table.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturehall_info_table.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.lecturehall_info_table.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.lecturehall_info_table.ThemeStyle.HeaderStyle.Height = 40;
            this.lecturehall_info_table.ThemeStyle.ReadOnly = true;
            this.lecturehall_info_table.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.lecturehall_info_table.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.lecturehall_info_table.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lecturehall_info_table.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lecturehall_info_table.ThemeStyle.RowsStyle.Height = 30;
            this.lecturehall_info_table.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.lecturehall_info_table.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.lecturehall_info_table.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lecturehall_info_table_CellClick);
            // 
            // lecturehallDataGridViewTextBoxColumn
            // 
            this.lecturehallDataGridViewTextBoxColumn.DataPropertyName = "lecture_hall";
            this.lecturehallDataGridViewTextBoxColumn.HeaderText = "Lecture Hall";
            this.lecturehallDataGridViewTextBoxColumn.Name = "lecturehallDataGridViewTextBoxColumn";
            this.lecturehallDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "capacity";
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // availabilityDataGridViewTextBoxColumn
            // 
            this.availabilityDataGridViewTextBoxColumn.DataPropertyName = "availability";
            this.availabilityDataGridViewTextBoxColumn.HeaderText = "Availability";
            this.availabilityDataGridViewTextBoxColumn.Name = "availabilityDataGridViewTextBoxColumn";
            this.availabilityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // edit_btn
            // 
            this.edit_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.edit_btn.HeaderText = "";
            this.edit_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.edit_btn;
            this.edit_btn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.ReadOnly = true;
            this.edit_btn.Width = 50;
            // 
            // delete_btn
            // 
            this.delete_btn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete_btn.HeaderText = "";
            this.delete_btn.Image = global::KDU_Time_Table_Management_System.Properties.Resources.delete;
            this.delete_btn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.ReadOnly = true;
            this.delete_btn.Width = 50;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.guna2Panel6);
            this.guna2Panel4.Location = new System.Drawing.Point(3, 387);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(1153, 323);
            this.guna2Panel4.TabIndex = 1;
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.BackColor = System.Drawing.Color.White;
            this.guna2Panel6.Controls.Add(this.guna2Panel5);
            this.guna2Panel6.Controls.Add(this.lecture_hall_name);
            this.guna2Panel6.Controls.Add(this.guna2Separator3);
            this.guna2Panel6.Controls.Add(this.guna2Button5);
            this.guna2Panel6.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2Panel6.Controls.Add(this.availability);
            this.guna2Panel6.Controls.Add(this.groupBox1);
            this.guna2Panel6.FillColor = System.Drawing.Color.White;
            this.guna2Panel6.Location = new System.Drawing.Point(28, 8);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.BorderRadius = 0;
            this.guna2Panel6.ShadowDecoration.Depth = 5;
            this.guna2Panel6.ShadowDecoration.Enabled = true;
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(1111, 290);
            this.guna2Panel6.TabIndex = 110;
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.White;
            this.guna2Panel5.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel5.FillColor = System.Drawing.Color.White;
            this.guna2Panel5.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(1111, 43);
            this.guna2Panel5.TabIndex = 110;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(133, 19);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "Manage Lecture Halls";
            // 
            // lecture_hall_name
            // 
            this.lecture_hall_name.BackColor = System.Drawing.Color.Transparent;
            this.lecture_hall_name.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.lecture_hall_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lecture_hall_name.Location = new System.Drawing.Point(42, 75);
            this.lecture_hall_name.Name = "lecture_hall_name";
            this.lecture_hall_name.Size = new System.Drawing.Size(200, 34);
            this.lecture_hall_name.TabIndex = 37;
            this.lecture_hall_name.Text = "Select Lecture Hall";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Location = new System.Drawing.Point(42, 115);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(200, 10);
            this.guna2Separator3.TabIndex = 42;
            // 
            // guna2Button5
            // 
            this.guna2Button5.CheckedState.Parent = this.guna2Button5;
            this.guna2Button5.CustomImages.Parent = this.guna2Button5;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(54)))), ((int)(((byte)(233)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.HoverState.Parent = this.guna2Button5;
            this.guna2Button5.Location = new System.Drawing.Point(133, 181);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.ShadowDecoration.Parent = this.guna2Button5;
            this.guna2Button5.Size = new System.Drawing.Size(100, 24);
            this.guna2Button5.TabIndex = 45;
            this.guna2Button5.Text = "New";
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::KDU_Time_Table_Management_System.Properties.Resources.available;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(42, 145);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.ShadowDecoration.Parent = this.guna2CirclePictureBox1;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(65, 60);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 43;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // availability
            // 
            this.availability.BackColor = System.Drawing.Color.Transparent;
            this.availability.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.availability.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.availability.Location = new System.Drawing.Point(133, 145);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(55, 19);
            this.availability.TabIndex = 44;
            this.availability.Text = "Available";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lecture_name);
            this.groupBox1.Controls.Add(this.hall_capacity);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel13);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel12);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel14);
            this.groupBox1.Controls.Add(this.leture_timeslot);
            this.groupBox1.Controls.Add(this.guna2HtmlLabel16);
            this.groupBox1.Controls.Add(this.lecturer_name);
            this.groupBox1.Location = new System.Drawing.Point(438, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 133);
            this.groupBox1.TabIndex = 111;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lecture";
            // 
            // lecture_name
            // 
            this.lecture_name.BackColor = System.Drawing.Color.Transparent;
            this.lecture_name.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lecture_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lecture_name.Location = new System.Drawing.Point(100, 40);
            this.lecture_name.Name = "lecture_name";
            this.lecture_name.Size = new System.Drawing.Size(80, 19);
            this.lecture_name.TabIndex = 48;
            this.lecture_name.Text = "LectureName";
            // 
            // hall_capacity
            // 
            this.hall_capacity.BackColor = System.Drawing.Color.Transparent;
            this.hall_capacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.hall_capacity.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hall_capacity.Location = new System.Drawing.Point(327, 40);
            this.hall_capacity.Name = "hall_capacity";
            this.hall_capacity.Size = new System.Drawing.Size(52, 19);
            this.hall_capacity.TabIndex = 50;
            this.hall_capacity.Text = "Capacity";
            // 
            // guna2HtmlLabel13
            // 
            this.guna2HtmlLabel13.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel13.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel13.Location = new System.Drawing.Point(49, 40);
            this.guna2HtmlLabel13.Name = "guna2HtmlLabel13";
            this.guna2HtmlLabel13.Size = new System.Drawing.Size(45, 19);
            this.guna2HtmlLabel13.TabIndex = 39;
            this.guna2HtmlLabel13.Text = "Lecture";
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(269, 40);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(52, 19);
            this.guna2HtmlLabel12.TabIndex = 49;
            this.guna2HtmlLabel12.Text = "Capacity";
            // 
            // guna2HtmlLabel14
            // 
            this.guna2HtmlLabel14.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel14.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel14.Location = new System.Drawing.Point(271, 75);
            this.guna2HtmlLabel14.Name = "guna2HtmlLabel14";
            this.guna2HtmlLabel14.Size = new System.Drawing.Size(57, 19);
            this.guna2HtmlLabel14.TabIndex = 38;
            this.guna2HtmlLabel14.Text = "Time Slot";
            // 
            // leture_timeslot
            // 
            this.leture_timeslot.BackColor = System.Drawing.Color.Transparent;
            this.leture_timeslot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.leture_timeslot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.leture_timeslot.FocusedColor = System.Drawing.Color.Empty;
            this.leture_timeslot.FocusedState.Parent = this.leture_timeslot;
            this.leture_timeslot.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.leture_timeslot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.leture_timeslot.FormattingEnabled = true;
            this.leture_timeslot.HoverState.Parent = this.leture_timeslot;
            this.leture_timeslot.ItemHeight = 16;
            this.leture_timeslot.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.leture_timeslot.ItemsAppearance.Parent = this.leture_timeslot;
            this.leture_timeslot.Location = new System.Drawing.Point(334, 75);
            this.leture_timeslot.Name = "leture_timeslot";
            this.leture_timeslot.ShadowDecoration.Parent = this.leture_timeslot;
            this.leture_timeslot.Size = new System.Drawing.Size(117, 22);
            this.leture_timeslot.TabIndex = 36;
            // 
            // guna2HtmlLabel16
            // 
            this.guna2HtmlLabel16.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel16.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2HtmlLabel16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel16.Location = new System.Drawing.Point(49, 79);
            this.guna2HtmlLabel16.Name = "guna2HtmlLabel16";
            this.guna2HtmlLabel16.Size = new System.Drawing.Size(50, 19);
            this.guna2HtmlLabel16.TabIndex = 46;
            this.guna2HtmlLabel16.Text = "Lecturer";
            // 
            // lecturer_name
            // 
            this.lecturer_name.AutoSize = true;
            this.lecturer_name.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lecturer_name.Location = new System.Drawing.Point(105, 83);
            this.lecturer_name.Name = "lecturer_name";
            this.lecturer_name.Size = new System.Drawing.Size(80, 15);
            this.lecturer_name.TabIndex = 47;
            this.lecturer_name.TabStop = true;
            this.lecturer_name.Text = "lecturer name";
            this.lecturer_name.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Manage_LectureHalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1180, 680);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_LectureHalls";
            this.Text = "LectureHall_Management_Form";
            this.Load += new System.EventHandler(this.LectureHall_Management_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturehallinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet_getLectureHallInfo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lecturehall_info_table)).EndInit();
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel6.ResumeLayout(false);
            this.guna2Panel6.PerformLayout();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataSet_getLectureHallInfo dataSet_getLectureHallInfo;
        private System.Windows.Forms.BindingSource lecturehallinfoBindingSource;
        private DataSet_getLectureHallInfoTableAdapters.lecture_hall_infoTableAdapter lecture_hall_infoTableAdapter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button refresh_btn;
        private Guna.UI2.WinForms.Guna2Button add_btn;
        private Guna.UI2.WinForms.Guna2DataGridView lecturehall_info_table;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel hall_capacity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lecture_hall_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel13;
        private Guna.UI2.WinForms.Guna2HtmlLabel lecture_name;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel14;
        private System.Windows.Forms.LinkLabel lecturer_name;
        private Guna.UI2.WinForms.Guna2ComboBox leture_timeslot;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel16;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel availability;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn lecturehallDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availabilityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn edit_btn;
        private System.Windows.Forms.DataGridViewImageColumn delete_btn;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}