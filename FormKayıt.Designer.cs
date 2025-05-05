namespace WindowsFormsApp2
{
    partial class formKayıt
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
            this.headerPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.mainContentPanel = new System.Windows.Forms.Panel();
            this.addressUnderlinePanel = new System.Windows.Forms.Panel();
            this.userNameUnderlinePanel = new System.Windows.Forms.Panel();
            this.passwordUnderlinePanel = new System.Windows.Forms.Panel();
            this.nameUnderlinePanel = new System.Windows.Forms.Panel();
            this.surnameUnderlinePanel = new System.Windows.Forms.Panel();
            this.phoneNumberUnderlinePanel = new System.Windows.Forms.Panel();
            this.emailUnderlinePanel = new System.Windows.Forms.Panel();
            this.userPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.addPhotoButton = new System.Windows.Forms.Button();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.mainContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.headerPanel.Controls.Add(this.backButton);
            this.headerPanel.Controls.Add(this.btnAlt);
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "panelTop";
            this.headerPanel.Size = new System.Drawing.Size(500, 40);
            this.headerPanel.TabIndex = 22;
            this.headerPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.headerPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.headerPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
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
            this.backButton.Click += new System.EventHandler(this.button1_Click);
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
            this.btnAlt.Location = new System.Drawing.Point(420, 0);
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
            this.closeButton.Location = new System.Drawing.Point(460, 0);
            this.closeButton.Name = "btnClose";
            this.closeButton.Size = new System.Drawing.Size(40, 40);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelMain
            // 
            this.mainContentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.mainContentPanel.Controls.Add(this.addressUnderlinePanel);
            this.mainContentPanel.Controls.Add(this.userNameUnderlinePanel);
            this.mainContentPanel.Controls.Add(this.passwordUnderlinePanel);
            this.mainContentPanel.Controls.Add(this.nameUnderlinePanel);
            this.mainContentPanel.Controls.Add(this.surnameUnderlinePanel);
            this.mainContentPanel.Controls.Add(this.phoneNumberUnderlinePanel);
            this.mainContentPanel.Controls.Add(this.emailUnderlinePanel);
            this.mainContentPanel.Controls.Add(this.userPhotoPictureBox);
            this.mainContentPanel.Controls.Add(this.addPhotoButton);
            this.mainContentPanel.Controls.Add(this.emailTextBox);
            this.mainContentPanel.Controls.Add(this.surnameTextBox);
            this.mainContentPanel.Controls.Add(this.passwordTextBox);
            this.mainContentPanel.Controls.Add(this.label3);
            this.mainContentPanel.Controls.Add(this.label2);
            this.mainContentPanel.Controls.Add(this.label4);
            this.mainContentPanel.Controls.Add(this.addressTextBox);
            this.mainContentPanel.Controls.Add(this.label8);
            this.mainContentPanel.Controls.Add(this.phoneNumberTextBox);
            this.mainContentPanel.Controls.Add(this.label7);
            this.mainContentPanel.Controls.Add(this.nameTextBox);
            this.mainContentPanel.Controls.Add(this.label5);
            this.mainContentPanel.Controls.Add(this.userNameTextBox);
            this.mainContentPanel.Controls.Add(this.label6);
            this.mainContentPanel.Controls.Add(this.registerButton);
            this.mainContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainContentPanel.Location = new System.Drawing.Point(0, 40);
            this.mainContentPanel.Name = "panelMain";
            this.mainContentPanel.Size = new System.Drawing.Size(500, 510);
            this.mainContentPanel.TabIndex = 23;
            // 
            // panelLineAddress
            // 
            this.addressUnderlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addressUnderlinePanel.Location = new System.Drawing.Point(60, 430);
            this.addressUnderlinePanel.Name = "panelLineAddress";
            this.addressUnderlinePanel.Size = new System.Drawing.Size(331, 2);
            this.addressUnderlinePanel.TabIndex = 26;
            // 
            // panelLineUsername
            // 
            this.userNameUnderlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userNameUnderlinePanel.Location = new System.Drawing.Point(60, 245);
            this.userNameUnderlinePanel.Name = "panelLineUsername";
            this.userNameUnderlinePanel.Size = new System.Drawing.Size(149, 2);
            this.userNameUnderlinePanel.TabIndex = 20;
            // 
            // panelLinePassword
            // 
            this.passwordUnderlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.passwordUnderlinePanel.Location = new System.Drawing.Point(242, 245);
            this.passwordUnderlinePanel.Name = "panelLinePassword";
            this.passwordUnderlinePanel.Size = new System.Drawing.Size(149, 2);
            this.passwordUnderlinePanel.TabIndex = 21;
            // 
            // panelLineName
            // 
            this.nameUnderlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.nameUnderlinePanel.Location = new System.Drawing.Point(60, 295);
            this.nameUnderlinePanel.Name = "panelLineName";
            this.nameUnderlinePanel.Size = new System.Drawing.Size(149, 2);
            this.nameUnderlinePanel.TabIndex = 22;
            // 
            // panelLineSurname
            // 
            this.surnameUnderlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.surnameUnderlinePanel.Location = new System.Drawing.Point(242, 295);
            this.surnameUnderlinePanel.Name = "panelLineSurname";
            this.surnameUnderlinePanel.Size = new System.Drawing.Size(149, 2);
            this.surnameUnderlinePanel.TabIndex = 23;
            // 
            // panelLinePhone
            // 
            this.phoneNumberUnderlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phoneNumberUnderlinePanel.Location = new System.Drawing.Point(60, 345);
            this.phoneNumberUnderlinePanel.Name = "panelLinePhone";
            this.phoneNumberUnderlinePanel.Size = new System.Drawing.Size(149, 2);
            this.phoneNumberUnderlinePanel.TabIndex = 24;
            // 
            // panelLineEmail
            // 
            this.emailUnderlinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.emailUnderlinePanel.Location = new System.Drawing.Point(242, 345);
            this.emailUnderlinePanel.Name = "panelLineEmail";
            this.emailUnderlinePanel.Size = new System.Drawing.Size(149, 2);
            this.emailUnderlinePanel.TabIndex = 25;
            // 
            // pbPhoto
            // 
            this.userPhotoPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.userPhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPhotoPictureBox.Location = new System.Drawing.Point(173, 23);
            this.userPhotoPictureBox.Name = "pbPhoto";
            this.userPhotoPictureBox.Size = new System.Drawing.Size(120, 120);
            this.userPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPhotoPictureBox.TabIndex = 8;
            this.userPhotoPictureBox.TabStop = false;
            // 
            // btnAddPhoto
            // 
            this.addPhotoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addPhotoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPhotoButton.FlatAppearance.BorderSize = 0;
            this.addPhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPhotoButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPhotoButton.ForeColor = System.Drawing.Color.White;
            this.addPhotoButton.Location = new System.Drawing.Point(173, 148);
            this.addPhotoButton.Name = "btnAddPhoto";
            this.addPhotoButton.Size = new System.Drawing.Size(120, 30);
            this.addPhotoButton.TabIndex = 19;
            this.addPhotoButton.Text = "Fotoğraf Ekle";
            this.addPhotoButton.UseVisualStyleBackColor = false;
            this.addPhotoButton.Click += new System.EventHandler(this.btnAddPhoto_Click_1);
            // 
            // txtEmail
            // 
            this.emailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.emailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.emailTextBox.Location = new System.Drawing.Point(242, 320);
            this.emailTextBox.Name = "txtEmail";
            this.emailTextBox.Size = new System.Drawing.Size(149, 24);
            this.emailTextBox.TabIndex = 5;
            // 
            // txtSurname
            // 
            this.surnameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.surnameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surnameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.surnameTextBox.Location = new System.Drawing.Point(242, 270);
            this.surnameTextBox.Name = "txtSurname";
            this.surnameTextBox.Size = new System.Drawing.Size(149, 24);
            this.surnameTextBox.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.passwordTextBox.Location = new System.Drawing.Point(242, 220);
            this.passwordTextBox.Name = "txtPassword";
            this.passwordTextBox.Size = new System.Drawing.Size(149, 24);
            this.passwordTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(242, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "E-mail:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(242, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(242, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Soyad:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdress
            // 
            this.addressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.addressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addressTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.addressTextBox.Location = new System.Drawing.Point(60, 370);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "txtAdress";
            this.addressTextBox.Size = new System.Drawing.Size(331, 60);
            this.addressTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(60, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Adres:";
            // 
            // txtPhoneNumber
            // 
            this.phoneNumberTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.phoneNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneNumberTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.phoneNumberTextBox.Location = new System.Drawing.Point(60, 320);
            this.phoneNumberTextBox.Name = "txtPhoneNumber";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(149, 24);
            this.phoneNumberTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(60, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Telefon No:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.nameTextBox.Location = new System.Drawing.Point(60, 270);
            this.nameTextBox.Name = "txtName";
            this.nameTextBox.Size = new System.Drawing.Size(149, 24);
            this.nameTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(60, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUserName
            // 
            this.userNameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.userNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userNameTextBox.Location = new System.Drawing.Point(60, 220);
            this.userNameTextBox.Name = "txtUserName";
            this.userNameTextBox.Size = new System.Drawing.Size(149, 24);
            this.userNameTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(60, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kullanıcı Adı:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerButton.ForeColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(170, 450);
            this.registerButton.Name = "btnSave";
            this.registerButton.Size = new System.Drawing.Size(120, 40);
            this.registerButton.TabIndex = 18;
            this.registerButton.Text = "Kayıt Ol";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // formKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(500, 550);
            this.Controls.Add(this.mainContentPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcı Kaydı";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formKayıt_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.formKayıt_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.formKayıt_MouseUp);
            this.headerPanel.ResumeLayout(false);
            this.mainContentPanel.ResumeLayout(false);
            this.mainContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel headerPanel; // Panel for the form's header bar
        private System.Windows.Forms.Button backButton; // Button to go back
        private System.Windows.Forms.Button btnAlt; // Button to minimize the window
        private System.Windows.Forms.Button closeButton; // Button to close the window
        private System.Windows.Forms.Panel mainContentPanel; // Panel for the form's main content
        private System.Windows.Forms.Panel addressUnderlinePanel; // Underline panel for the Address TextBox
        private System.Windows.Forms.Panel userNameUnderlinePanel; // Underline panel for the Username TextBox
        private System.Windows.Forms.Panel passwordUnderlinePanel; // Underline panel for the Password TextBox
        private System.Windows.Forms.Panel nameUnderlinePanel; // Underline panel for the Name TextBox
        private System.Windows.Forms.Panel surnameUnderlinePanel; // Underline panel for the Surname TextBox
        private System.Windows.Forms.Panel phoneNumberUnderlinePanel; // Underline panel for the Phone Number TextBox
        private System.Windows.Forms.Panel emailUnderlinePanel; // Underline panel for the Email TextBox
        private System.Windows.Forms.PictureBox userPhotoPictureBox; // PictureBox to display the user's photo
        private System.Windows.Forms.Button addPhotoButton; // Button to add a photo
        private System.Windows.Forms.TextBox emailTextBox; // TextBox for email input
        private System.Windows.Forms.TextBox surnameTextBox; // TextBox for surname input
        private System.Windows.Forms.TextBox passwordTextBox; // TextBox for password input
        private System.Windows.Forms.Label label3; // Label for Email
        private System.Windows.Forms.Label label2; // Label for Password
        private System.Windows.Forms.Label label4; // Label for Surname
        private System.Windows.Forms.TextBox addressTextBox; // TextBox for address input
        private System.Windows.Forms.Label label8; // Label for Address
        private System.Windows.Forms.TextBox phoneNumberTextBox; // TextBox for phone number input
        private System.Windows.Forms.Label label7; // Label for Phone Number
        private System.Windows.Forms.TextBox nameTextBox; // TextBox for name input
        private System.Windows.Forms.Label label5; // Label for Name
        private System.Windows.Forms.TextBox userNameTextBox; // TextBox for username input
        private System.Windows.Forms.Label label6; // Label for Username
        private System.Windows.Forms.Button registerButton; // Button to register
    }
}