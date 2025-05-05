namespace WindowsFormsApp2
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.notesButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.phoneBookButton = new System.Windows.Forms.Button();
            this.reminderButton = new System.Windows.Forms.Button();
            this.salaryButton = new System.Windows.Forms.Button();
            this.userManagementButton = new System.Windows.Forms.Button();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(650, 40);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMenu_MouseUp);
            // 
            // lblAppName
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appNameLabel.ForeColor = System.Drawing.Color.White;
            this.appNameLabel.Location = new System.Drawing.Point(45, 10);
            this.appNameLabel.Name = "lblAppName";
            this.appNameLabel.Size = new System.Drawing.Size(209, 21);
            this.appNameLabel.TabIndex = 15;
            this.appNameLabel.Text = "Kullanıcı Yönetim Sistemi";
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
            this.btnAlt.Location = new System.Drawing.Point(570, 0);
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
            this.closeButton.Location = new System.Drawing.Point(610, 0);
            this.closeButton.Name = "btnClose";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblWelcome
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.BackColor = System.Drawing.Color.Transparent;
            this.greetingLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.greetingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.greetingLabel.Location = new System.Drawing.Point(235, 60);
            this.greetingLabel.Name = "lblWelcome";
            this.greetingLabel.Size = new System.Drawing.Size(185, 37);
            this.greetingLabel.TabIndex = 16;
            this.greetingLabel.Text = "Hoş Geldiniz!";
            this.greetingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserInfo
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.BackColor = System.Drawing.Color.Transparent;
            this.userInfoLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userInfoLabel.Location = new System.Drawing.Point(237, 97);
            this.userInfoLabel.Name = "lblUserInfo";
            this.userInfoLabel.Size = new System.Drawing.Size(134, 25);
            this.userInfoLabel.TabIndex = 17;
            this.userInfoLabel.Text = "Kullanıcı Bilgisi";
            this.userInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNotes
            // 
            this.notesButton.BackColor = System.Drawing.Color.White;
            this.notesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notesButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.notesButton.FlatAppearance.BorderSize = 1;
            this.notesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.notesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.notesButton.Location = new System.Drawing.Point(70, 160);
            this.notesButton.Name = "btnNotes";
            this.notesButton.Size = new System.Drawing.Size(150, 70);
            this.notesButton.TabIndex = 18;
            this.notesButton.Text = "📝  Notlar";
            this.notesButton.UseVisualStyleBackColor = false;
            this.notesButton.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnProfile
            // 
            this.profileButton.BackColor = System.Drawing.Color.White;
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.profileButton.FlatAppearance.BorderSize = 1;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.profileButton.Location = new System.Drawing.Point(250, 160);
            this.profileButton.Name = "btnProfile";
            this.profileButton.Size = new System.Drawing.Size(150, 70);
            this.profileButton.TabIndex = 19;
            this.profileButton.Text = "👤  Profil";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.btnOpenProfile_Click);
            // 
            // btnPhoneBook
            // 
            this.phoneBookButton.BackColor = System.Drawing.Color.White;
            this.phoneBookButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.phoneBookButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phoneBookButton.FlatAppearance.BorderSize = 1;
            this.phoneBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.phoneBookButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneBookButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phoneBookButton.Location = new System.Drawing.Point(430, 160);
            this.phoneBookButton.Name = "btnPhoneBook";
            this.phoneBookButton.Size = new System.Drawing.Size(150, 70);
            this.phoneBookButton.TabIndex = 20;
            this.phoneBookButton.Text = "📞  Telefon";
            this.phoneBookButton.UseVisualStyleBackColor = false;
            this.phoneBookButton.Click += new System.EventHandler(this.btnPhoneBook_Click_2);
            // 
            // btnReminder
            // 
            this.reminderButton.BackColor = System.Drawing.Color.White;
            this.reminderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reminderButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reminderButton.FlatAppearance.BorderSize = 1;
            this.reminderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reminderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.reminderButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reminderButton.Location = new System.Drawing.Point(70, 270);
            this.reminderButton.Name = "btnReminder";
            this.reminderButton.Size = new System.Drawing.Size(150, 70);
            this.reminderButton.TabIndex = 21;
            this.reminderButton.Text = "⏰  Anımsatıcı";
            this.reminderButton.UseVisualStyleBackColor = false;
            this.reminderButton.Click += new System.EventHandler(this.btnReminder_Click);
            // 
            // btnSalary
            // 
            this.salaryButton.BackColor = System.Drawing.Color.White;
            this.salaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.salaryButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.salaryButton.FlatAppearance.BorderSize = 1;
            this.salaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salaryButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salaryButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.salaryButton.Location = new System.Drawing.Point(250, 270);
            this.salaryButton.Name = "btnSalary";
            this.salaryButton.Size = new System.Drawing.Size(150, 70);
            this.salaryButton.TabIndex = 22;
            this.salaryButton.Text = "💰  Maaş";
            this.salaryButton.UseVisualStyleBackColor = false;
            this.salaryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUserManagement
            // 
            this.userManagementButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userManagementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userManagementButton.FlatAppearance.BorderSize = 0;
            this.userManagementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.userManagementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userManagementButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userManagementButton.ForeColor = System.Drawing.Color.White;
            this.userManagementButton.Location = new System.Drawing.Point(430, 270);
            this.userManagementButton.Name = "btnUserManagement";
            this.userManagementButton.Size = new System.Drawing.Size(150, 70);
            this.userManagementButton.TabIndex = 23;
            this.userManagementButton.Text = "🔐  Admin";
            this.userManagementButton.UseVisualStyleBackColor = false;
            this.userManagementButton.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.userManagementButton);
            this.Controls.Add(this.salaryButton);
            this.Controls.Add(this.reminderButton);
            this.Controls.Add(this.phoneBookButton);
            this.Controls.Add(this.profileButton);
            this.Controls.Add(this.notesButton);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.greetingLabel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Button notesButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button phoneBookButton;
        private System.Windows.Forms.Button reminderButton;
        private System.Windows.Forms.Button salaryButton;
        private System.Windows.Forms.Button userManagementButton;
    }
}