namespace WindowsFormsApp2
{
    partial class FormProfile
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
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeUserInfoButton = new System.Windows.Forms.Button();
            this.userPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.usernameLinePanel = new System.Windows.Forms.Panel();
            this.nameLinePanel = new System.Windows.Forms.Panel();
            this.surnameLinePanel = new System.Windows.Forms.Panel();
            this.emailLinePanel = new System.Windows.Forms.Panel();
            this.passwordLinePanel = new System.Windows.Forms.Panel();
            this.phoneLinePanel = new System.Windows.Forms.Panel();
            this.addressLinePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoPictureBox)).BeginInit();
            this.headerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAdress
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addressTextBox.Location = new System.Drawing.Point(280, 290);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "txtAdress";
            this.addressTextBox.Size = new System.Drawing.Size(300, 65);
            this.addressTextBox.TabIndex = 34;
            this.addressTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdress_KeyDown);
            this.addressTextBox.TextChanged += new System.EventHandler(this.txtAdress_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(280, 234);
            this.phoneNumberTextBox.Name = "txtPhoneNumber";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(200, 24);
            this.phoneNumberTextBox.TabIndex = 33;
            this.phoneNumberTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneNumber_KeyDown);
            this.phoneNumberTextBox.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(276, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Adres:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(274, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Telefon No:";
            // 
            // txtUserName
            // 
            this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.usernameTextBox.Location = new System.Drawing.Point(280, 68);
            this.usernameTextBox.Name = "txtUserName";
            this.usernameTextBox.Size = new System.Drawing.Size(200, 24);
            this.usernameTextBox.TabIndex = 30;
            this.usernameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUserName_KeyDown);
            this.usernameTextBox.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(276, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "Kullanıcı Adı:";
            // 
            // txtName
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.nameTextBox.Location = new System.Drawing.Point(280, 120);
            this.nameTextBox.Name = "txtName";
            this.nameTextBox.Size = new System.Drawing.Size(140, 24);
            this.nameTextBox.TabIndex = 28;
            this.nameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            this.nameTextBox.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(276, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Ad:";
            // 
            // txtPassword
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.passwordTextBox.Location = new System.Drawing.Point(443, 178);
            this.passwordTextBox.Name = "txtPassword";
            this.passwordTextBox.Size = new System.Drawing.Size(140, 24);
            this.passwordTextBox.TabIndex = 26;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.passwordTextBox.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtEmail
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.emailTextBox.Location = new System.Drawing.Point(280, 178);
            this.emailTextBox.Name = "txtEmail";
            this.emailTextBox.Size = new System.Drawing.Size(140, 24);
            this.emailTextBox.TabIndex = 25;
            this.emailTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            this.emailTextBox.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtSurname
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.surnameTextBox.Location = new System.Drawing.Point(443, 120);
            this.surnameTextBox.Name = "txtSurname";
            this.surnameTextBox.Size = new System.Drawing.Size(140, 24);
            this.surnameTextBox.TabIndex = 24;
            this.surnameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSurname_KeyDown);
            this.surnameTextBox.TextChanged += new System.EventHandler(this.txtSurname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(439, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(276, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(439, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Soyad:";
            // 
            // btnChangeUserİnfo
            // 
            this.changeUserInfoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.changeUserInfoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeUserInfoButton.FlatAppearance.BorderSize = 0;
            this.changeUserInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUserInfoButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.changeUserInfoButton.ForeColor = System.Drawing.Color.White;
            this.changeUserInfoButton.Location = new System.Drawing.Point(280, 370);
            this.changeUserInfoButton.Name = "btnChangeUserİnfo";
            this.changeUserInfoButton.Size = new System.Drawing.Size(200, 40);
            this.changeUserInfoButton.TabIndex = 20;
            this.changeUserInfoButton.Text = "Bilgileri Güncelle";
            this.changeUserInfoButton.UseVisualStyleBackColor = false;
            this.changeUserInfoButton.Click += new System.EventHandler(this.btnChangeUserİnfo_Click);
            // 
            // pbPhoto
            // 
            this.userPhotoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.userPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPhotoPictureBox.Location = new System.Drawing.Point(61, 68);
            this.userPhotoPictureBox.Name = "pbPhoto";
            this.userPhotoPictureBox.Size = new System.Drawing.Size(160, 160);
            this.userPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPhotoPictureBox.TabIndex = 19;
            this.userPhotoPictureBox.TabStop = false;
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
            this.headerPanel.TabIndex = 35;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormProfile_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormProfile_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormProfile_MouseUp);
            // 
            // lblAppName
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appNameLabel.ForeColor = System.Drawing.Color.White;
            this.appNameLabel.Location = new System.Drawing.Point(45, 10);
            this.appNameLabel.Name = "lblAppName";
            this.appNameLabel.Size = new System.Drawing.Size(64, 28);
            this.appNameLabel.TabIndex = 15;
            this.appNameLabel.Text = "Profil";
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
            // lblSalary
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.salaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.salaryLabel.Location = new System.Drawing.Point(61, 290);
            this.salaryLabel.Name = "lblSalary";
            this.salaryLabel.Size = new System.Drawing.Size(56, 23);
            this.salaryLabel.TabIndex = 35;
            this.salaryLabel.Text = "Maaş:";
            // 
            // btnAddPhoto
            // 
            this.addPhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addPhotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPhotoButton.FlatAppearance.BorderSize = 0;
            this.addPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPhotoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPhotoButton.ForeColor = System.Drawing.Color.White;
            this.addPhotoButton.Location = new System.Drawing.Point(61, 243);
            this.addPhotoButton.Name = "btnAddPhoto";
            this.addPhotoButton.Size = new System.Drawing.Size(160, 30);
            this.addPhotoButton.TabIndex = 36;
            this.addPhotoButton.Text = "Fotoğraf Ekle";
            this.addPhotoButton.UseVisualStyleBackColor = false;
            this.addPhotoButton.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // panelLineUserName
            // 
            this.usernameLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.usernameLinePanel.Location = new System.Drawing.Point(280, 93);
            this.usernameLinePanel.Name = "panelLineUserName";
            this.usernameLinePanel.Size = new System.Drawing.Size(200, 2);
            this.usernameLinePanel.TabIndex = 37;
            // 
            // panelLineName
            // 
            this.nameLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.nameLinePanel.Location = new System.Drawing.Point(280, 145);
            this.nameLinePanel.Name = "panelLineName";
            this.nameLinePanel.Size = new System.Drawing.Size(140, 2);
            this.nameLinePanel.TabIndex = 38;
            // 
            // panelLineSurname
            // 
            this.surnameLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.surnameLinePanel.Location = new System.Drawing.Point(443, 145);
            this.surnameLinePanel.Name = "panelLineSurname";
            this.surnameLinePanel.Size = new System.Drawing.Size(140, 2);
            this.surnameLinePanel.TabIndex = 39;
            // 
            // panelLineEmail
            // 
            this.emailLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.emailLinePanel.Location = new System.Drawing.Point(280, 203);
            this.emailLinePanel.Name = "panelLineEmail";
            this.emailLinePanel.Size = new System.Drawing.Size(140, 2);
            this.emailLinePanel.TabIndex = 40;
            // 
            // panelLinePassword
            // 
            this.passwordLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.passwordLinePanel.Location = new System.Drawing.Point(443, 203);
            this.passwordLinePanel.Name = "panelLinePassword";
            this.passwordLinePanel.Size = new System.Drawing.Size(140, 2);
            this.passwordLinePanel.TabIndex = 41;
            // 
            // panelLinePhone
            // 
            this.phoneLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phoneLinePanel.Location = new System.Drawing.Point(280, 259);
            this.phoneLinePanel.Name = "panelLinePhone";
            this.phoneLinePanel.Size = new System.Drawing.Size(200, 2);
            this.phoneLinePanel.TabIndex = 42;
            // 
            // panelLineAddress
            // 
            this.addressLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addressLinePanel.Location = new System.Drawing.Point(280, 356);
            this.addressLinePanel.Name = "panelLineAddress";
            this.addressLinePanel.Size = new System.Drawing.Size(300, 2);
            this.addressLinePanel.TabIndex = 43;
            // 
            // FormProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(650, 435);
            this.Controls.Add(this.addPhotoButton);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.changeUserInfoButton);
            this.Controls.Add(this.userPhotoPictureBox);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.usernameLinePanel);
            this.Controls.Add(this.nameLinePanel);
            this.Controls.Add(this.surnameLinePanel);
            this.Controls.Add(this.emailLinePanel);
            this.Controls.Add(this.passwordLinePanel);
            this.Controls.Add(this.phoneLinePanel);
            this.Controls.Add(this.addressLinePanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProfile";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormProfile_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormProfile_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormProfile_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoPictureBox)).EndInit();
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeUserInfoButton;
        private System.Windows.Forms.PictureBox userPhotoPictureBox;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Button addPhotoButton;
        private System.Windows.Forms.Panel usernameLinePanel;
        private System.Windows.Forms.Panel nameLinePanel;
        private System.Windows.Forms.Panel surnameLinePanel;
        private System.Windows.Forms.Panel emailLinePanel;
        private System.Windows.Forms.Panel passwordLinePanel;
        private System.Windows.Forms.Panel phoneLinePanel;
        private System.Windows.Forms.Panel addressLinePanel;
    }
}