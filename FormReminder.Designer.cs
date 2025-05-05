namespace WindowsFormsApp2
{
    partial class FormReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReminder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.remainderTabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.remindersDataGridView = new System.Windows.Forms.DataGridView();
            this.DateTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SummaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateReminderButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.reminderTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.summaryTextBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.addReminderButton = new System.Windows.Forms.Button();
            this.deleteReminderButton = new System.Windows.Forms.Button();
            this.summaryLinePanel = new System.Windows.Forms.Panel();
            this.descriptionLinePanel = new System.Windows.Forms.Panel();
            this.reminderTypeLinePanel = new System.Windows.Forms.Panel();
            this.dataTimeLinePanel = new System.Windows.Forms.Panel();
            this.dateTimeLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.remainderTabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.remindersDataGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.headerPanel.Controls.Add(this.appNameLabel);
            this.headerPanel.Controls.Add(this.backButton);
            this.headerPanel.Controls.Add(this.btnAlt);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "panelTop";
            this.headerPanel.Size = new System.Drawing.Size(761, 40);
            this.headerPanel.TabIndex = 28;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormReminder_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormReminder_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormReminder_MouseUp);
            // 
            // lblAppName
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appNameLabel.ForeColor = System.Drawing.Color.White;
            this.appNameLabel.Location = new System.Drawing.Point(45, 10);
            this.appNameLabel.Name = "lblAppName";
            this.appNameLabel.Size = new System.Drawing.Size(102, 21);
            this.appNameLabel.TabIndex = 15;
            this.appNameLabel.Text = "Anımsatıcı";
            // 
            // btnBack
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "btnBack";
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnAlt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlt.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAlt.FlatAppearance.BorderSize = 0;
            this.btnAlt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(142)))), ((int)(((byte)(210)))));
            this.btnAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlt.ForeColor = System.Drawing.Color.White;
            this.btnAlt.Location = new System.Drawing.Point(681, 0);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(40, 40);
            this.btnAlt.TabIndex = 13;
            this.btnAlt.Text = "−";
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnClose
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(721, 0);
            this.closeButton.Name = "btnClose";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControl1
            // 
            this.remainderTabControl1.Controls.Add(this.tabPage2);
            this.remainderTabControl1.Controls.Add(this.tabPage1);
            this.remainderTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remainderTabControl1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.remainderTabControl1.Location = new System.Drawing.Point(0, 40);
            this.remainderTabControl1.Name = "tabControl1";
            this.remainderTabControl1.SelectedIndex = 0;
            this.remainderTabControl1.Size = new System.Drawing.Size(761, 404);
            this.remainderTabControl1.TabIndex = 37;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.tabPage2.Controls.Add(this.remindersDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(753, 368);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Anımsatıcı Listesi";
            // 
            // dataGridView1
            // 
            this.remindersDataGridView.AllowUserToAddRows = false;
            this.remindersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.remindersDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.remindersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remindersDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.remindersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.remindersDataGridView.ColumnHeadersHeight = 35;
            this.remindersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.remindersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTimeColumn,
            this.SummaryColumn,
            this.DescriptionColumn});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.remindersDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.remindersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remindersDataGridView.EnableHeadersVisualStyles = false;
            this.remindersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.remindersDataGridView.Location = new System.Drawing.Point(3, 3);
            this.remindersDataGridView.Name = "dataGridView1";
            this.remindersDataGridView.ReadOnly = true;
            this.remindersDataGridView.RowHeadersVisible = false;
            this.remindersDataGridView.RowHeadersWidth = 51;
            this.remindersDataGridView.RowTemplate.Height = 25;
            this.remindersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.remindersDataGridView.Size = new System.Drawing.Size(747, 362);
            this.remindersDataGridView.TabIndex = 22;
            this.remindersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Zaman
            // 
            this.DateTimeColumn.HeaderText = "Zaman";
            this.DateTimeColumn.MinimumWidth = 6;
            this.DateTimeColumn.Name = "Zaman";
            this.DateTimeColumn.ReadOnly = true;
            // 
            // Özet
            // 
            this.SummaryColumn.HeaderText = "Özet";
            this.SummaryColumn.MinimumWidth = 6;
            this.SummaryColumn.Name = "Özet";
            this.SummaryColumn.ReadOnly = true;
            // 
            // Açıklama
            // 
            this.DescriptionColumn.HeaderText = "Açıklama";
            this.DescriptionColumn.MinimumWidth = 6;
            this.DescriptionColumn.Name = "Açıklama";
            this.DescriptionColumn.ReadOnly = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.tabPage1.Controls.Add(this.dateTimeLabel);
            this.tabPage1.Controls.Add(this.dataTimeLinePanel);
            this.tabPage1.Controls.Add(this.reminderTypeLinePanel);
            this.tabPage1.Controls.Add(this.summaryLinePanel);
            this.tabPage1.Controls.Add(this.descriptionLinePanel);
            this.tabPage1.Controls.Add(this.updateReminderButton);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.descriptionTextBox);
            this.tabPage1.Controls.Add(this.reminderTypeComboBox);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.summaryTextBox);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.addReminderButton);
            this.tabPage1.Controls.Add(this.deleteReminderButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(753, 368);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Anımsatıcı Ekle";
            // 
            // txtSummary
            // 
            this.summaryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.summaryTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.summaryTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.summaryTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.summaryTextBox.Location = new System.Drawing.Point(50, 85);
            this.summaryTextBox.Name = "txtSummary";
            this.summaryTextBox.Size = new System.Drawing.Size(280, 24);
            this.summaryTextBox.TabIndex = 38;
            // 
            // txtDescription
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.descriptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.descriptionTextBox.Location = new System.Drawing.Point(50, 160);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "txtDescription";
            this.descriptionTextBox.Size = new System.Drawing.Size(280, 100);
            this.descriptionTextBox.TabIndex = 47;
            // 
            // cmbReminderType
            // 
            this.reminderTypeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.reminderTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminderTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reminderTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reminderTypeComboBox.FormattingEnabled = true;
            this.reminderTypeComboBox.Location = new System.Drawing.Point(380, 85);
            this.reminderTypeComboBox.Name = "cmbReminderType";
            this.reminderTypeComboBox.Size = new System.Drawing.Size(280, 33);
            this.reminderTypeComboBox.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(50, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Özet:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(380, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Anımsatıcı Tipi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(50, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Açıklama:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Location = new System.Drawing.Point(380, 160);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(280, 31);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // btnAddReminder
            // 
            this.addReminderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addReminderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addReminderButton.FlatAppearance.BorderSize = 0;
            this.addReminderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addReminderButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.addReminderButton.ForeColor = System.Drawing.Color.White;
            this.addReminderButton.Location = new System.Drawing.Point(380, 220);
            this.addReminderButton.Name = "btnAddReminder";
            this.addReminderButton.Size = new System.Drawing.Size(130, 40);
            this.addReminderButton.TabIndex = 39;
            this.addReminderButton.Text = "Ekle";
            this.addReminderButton.UseVisualStyleBackColor = false;
            this.addReminderButton.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // btnDeleteReminder
            // 
            this.deleteReminderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(75)))), ((int)(((byte)(57)))));
            this.deleteReminderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteReminderButton.FlatAppearance.BorderSize = 0;
            this.deleteReminderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteReminderButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.deleteReminderButton.ForeColor = System.Drawing.Color.White;
            this.deleteReminderButton.Location = new System.Drawing.Point(530, 220);
            this.deleteReminderButton.Name = "btnDeleteReminder";
            this.deleteReminderButton.Size = new System.Drawing.Size(130, 40);
            this.deleteReminderButton.TabIndex = 41;
            this.deleteReminderButton.Text = "Sil";
            this.deleteReminderButton.UseVisualStyleBackColor = false;
            this.deleteReminderButton.Click += new System.EventHandler(this.btnDeleteReminder_Click);
            // 
            // btnUpdateReminder
            // 
            this.updateReminderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(166)))), ((int)(((byte)(90)))));
            this.updateReminderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateReminderButton.FlatAppearance.BorderSize = 0;
            this.updateReminderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateReminderButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.updateReminderButton.ForeColor = System.Drawing.Color.White;
            this.updateReminderButton.Location = new System.Drawing.Point(455, 280);
            this.updateReminderButton.Name = "btnUpdateReminder";
            this.updateReminderButton.Size = new System.Drawing.Size(130, 40);
            this.updateReminderButton.TabIndex = 50;
            this.updateReminderButton.Text = "Güncelle";
            this.updateReminderButton.UseVisualStyleBackColor = false;
            this.updateReminderButton.Click += new System.EventHandler(this.btnUpdateReminder_Click);
            // 
            // panelLineSummary
            // 
            this.summaryLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.summaryLinePanel.Location = new System.Drawing.Point(50, 109);
            this.summaryLinePanel.Name = "panelLineSummary";
            this.summaryLinePanel.Size = new System.Drawing.Size(280, 2);
            this.summaryLinePanel.TabIndex = 51;
            // 
            // panelLineDescription
            // 
            this.descriptionLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.descriptionLinePanel.Location = new System.Drawing.Point(50, 260);
            this.descriptionLinePanel.Name = "panelLineDescription";
            this.descriptionLinePanel.Size = new System.Drawing.Size(280, 2);
            this.descriptionLinePanel.TabIndex = 52;
            // 
            // panelLineReminderType
            // 
            this.reminderTypeLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reminderTypeLinePanel.Location = new System.Drawing.Point(380, 118);
            this.reminderTypeLinePanel.Name = "panelLineReminderType";
            this.reminderTypeLinePanel.Size = new System.Drawing.Size(280, 2);
            this.reminderTypeLinePanel.TabIndex = 53;
            // 
            // panelLineDateTime
            // 
            this.dataTimeLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dataTimeLinePanel.Location = new System.Drawing.Point(380, 191);
            this.dataTimeLinePanel.Name = "panelLineDateTime";
            this.dataTimeLinePanel.Size = new System.Drawing.Size(280, 2);
            this.dataTimeLinePanel.TabIndex = 54;
            // 
            // lblDateTime
            // 
            this.dateTimeLabel.AutoSize = true;
            this.dateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dateTimeLabel.Location = new System.Drawing.Point(380, 137);
            this.dateTimeLabel.Name = "lblDateTime";
            this.dateTimeLabel.Size = new System.Drawing.Size(101, 20);
            this.dateTimeLabel.TabIndex = 55;
            this.dateTimeLabel.Text = "Tarih ve Saat:";
            // 
            // FormReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(761, 444);
            this.Controls.Add(this.remainderTabControl1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormReminder";
            this.Text = "Anımsatıcı";
            this.Load += new System.EventHandler(this.FormReminder_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormReminder_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormReminder_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormReminder_MouseUp);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.remainderTabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.remindersDataGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TabControl remainderTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView remindersDataGridView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button deleteReminderButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button addReminderButton;
        private System.Windows.Forms.ComboBox reminderTypeComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox summaryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button updateReminderButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SummaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescriptionColumn;
        private System.Windows.Forms.Panel summaryLinePanel;
        private System.Windows.Forms.Panel descriptionLinePanel;
        private System.Windows.Forms.Panel reminderTypeLinePanel;
        private System.Windows.Forms.Panel dataTimeLinePanel;
        private System.Windows.Forms.Label dateTimeLabel;
    }
}