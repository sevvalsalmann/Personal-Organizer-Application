namespace salary_calculate
{
    partial class FormSalaryCalculator
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
            this.textBoxBaseSalary = new System.Windows.Forms.TextBox();
            this.userTypeComboBox = new System.Windows.Forms.ComboBox();
            this.calculateSalaryButton = new System.Windows.Forms.Button();
            this.calculatedSalaryLabel = new System.Windows.Forms.Label();
            this.hasChildrenCheckBox = new System.Windows.Forms.CheckBox();
            this.numChildrenTextBox = new System.Windows.Forms.TextBox();
            this.experienceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.cityGroupComboBox = new System.Windows.Forms.ComboBox();
            this.academicDegreeComboBox = new System.Windows.Forms.ComboBox();
            this.managementRoleComboBox = new System.Windows.Forms.ComboBox();
            this.englishCertifiedCheckBox = new System.Windows.Forms.CheckBox();
            this.englishEducatedCheckBox = new System.Windows.Forms.CheckBox();
            this.otherLanguagesTextBox = new System.Windows.Forms.TextBox();
            this.spouseNotWorkingCheckBox = new System.Windows.Forms.CheckBox();
            this.childOver18CheckBox = new System.Windows.Forms.CheckBox();
            this.childUnder6CheckBox = new System.Windows.Forms.CheckBox();
            this.child7to18CheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.otherLangLinePanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.experienceNumericUpDown)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxBaseSalary
            // 
            this.textBoxBaseSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.textBoxBaseSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBaseSalary.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBaseSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.textBoxBaseSalary.Location = new System.Drawing.Point(23, 66);
            this.textBoxBaseSalary.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.textBoxBaseSalary.Multiline = true;
            this.textBoxBaseSalary.Name = "textBoxBaseSalary";
            this.textBoxBaseSalary.ReadOnly = true;
            this.textBoxBaseSalary.Size = new System.Drawing.Size(348, 32);
            this.textBoxBaseSalary.TabIndex = 0;
            this.textBoxBaseSalary.Text = "Asgari Ücret: 22104.67";
            // 
            // comboBoxUserType
            // 
            this.userTypeComboBox.BackColor = System.Drawing.Color.White;
            this.userTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userTypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.userTypeComboBox.FormattingEnabled = true;
            this.userTypeComboBox.Location = new System.Drawing.Point(23, 131);
            this.userTypeComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.userTypeComboBox.Name = "comboBoxUserType";
            this.userTypeComboBox.Size = new System.Drawing.Size(366, 33);
            this.userTypeComboBox.TabIndex = 1;
            // 
            // buttonCalculateSalary
            // 
            this.calculateSalaryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.calculateSalaryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calculateSalaryButton.FlatAppearance.BorderSize = 0;
            this.calculateSalaryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateSalaryButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.calculateSalaryButton.ForeColor = System.Drawing.Color.White;
            this.calculateSalaryButton.Location = new System.Drawing.Point(250, 486);
            this.calculateSalaryButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.calculateSalaryButton.Name = "buttonCalculateSalary";
            this.calculateSalaryButton.Size = new System.Drawing.Size(180, 50);
            this.calculateSalaryButton.TabIndex = 2;
            this.calculateSalaryButton.Text = "Maaş Hesapla";
            this.calculateSalaryButton.UseVisualStyleBackColor = false;
            this.calculateSalaryButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCalculatedSalary
            // 
            this.calculatedSalaryLabel.AutoSize = true;
            this.calculatedSalaryLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.calculatedSalaryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.calculatedSalaryLabel.Location = new System.Drawing.Point(467, 486);
            this.calculatedSalaryLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.calculatedSalaryLabel.Name = "labelCalculatedSalary";
            this.calculatedSalaryLabel.Size = new System.Drawing.Size(178, 28);
            this.calculatedSalaryLabel.TabIndex = 3;
            this.calculatedSalaryLabel.Text = "Hesaplanan Maaş";
            // 
            // checkBoxHasChildren
            // 
            this.hasChildrenCheckBox.AutoSize = true;
            this.hasChildrenCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hasChildrenCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hasChildrenCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.hasChildrenCheckBox.Location = new System.Drawing.Point(443, 65);
            this.hasChildrenCheckBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.hasChildrenCheckBox.Name = "checkBoxHasChildren";
            this.hasChildrenCheckBox.Size = new System.Drawing.Size(109, 27);
            this.hasChildrenCheckBox.TabIndex = 4;
            this.hasChildrenCheckBox.Text = "Çocuk Var";
            this.hasChildrenCheckBox.UseVisualStyleBackColor = true;
            this.hasChildrenCheckBox.CheckedChanged += new System.EventHandler(this.checkBoxHasChildren_CheckedChanged);
            // 
            // textBoxNumChildren
            // 
            this.numChildrenTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.numChildrenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numChildrenTextBox.Enabled = false;
            this.numChildrenTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numChildrenTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.numChildrenTextBox.Location = new System.Drawing.Point(464, 99);
            this.numChildrenTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.numChildrenTextBox.Name = "textBoxNumChildren";
            this.numChildrenTextBox.Size = new System.Drawing.Size(115, 24);
            this.numChildrenTextBox.TabIndex = 5;
            // 
            // numericUpDownExperience
            // 
            this.experienceNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.experienceNumericUpDown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.experienceNumericUpDown.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.experienceNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.experienceNumericUpDown.Location = new System.Drawing.Point(26, 385);
            this.experienceNumericUpDown.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.experienceNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.experienceNumericUpDown.Name = "numericUpDownExperience";
            this.experienceNumericUpDown.Size = new System.Drawing.Size(136, 31);
            this.experienceNumericUpDown.TabIndex = 6;
            // 
            // comboBoxCityGroup
            // 
            this.cityGroupComboBox.BackColor = System.Drawing.Color.White;
            this.cityGroupComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cityGroupComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cityGroupComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityGroupComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.cityGroupComboBox.FormattingEnabled = true;
            this.cityGroupComboBox.Location = new System.Drawing.Point(23, 194);
            this.cityGroupComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cityGroupComboBox.Name = "comboBoxCityGroup";
            this.cityGroupComboBox.Size = new System.Drawing.Size(366, 33);
            this.cityGroupComboBox.TabIndex = 7;
            // 
            // comboBoxAcademicDegree
            // 
            this.academicDegreeComboBox.BackColor = System.Drawing.Color.White;
            this.academicDegreeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.academicDegreeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.academicDegreeComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.academicDegreeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.academicDegreeComboBox.FormattingEnabled = true;
            this.academicDegreeComboBox.Location = new System.Drawing.Point(23, 258);
            this.academicDegreeComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.academicDegreeComboBox.Name = "comboBoxAcademicDegree";
            this.academicDegreeComboBox.Size = new System.Drawing.Size(366, 33);
            this.academicDegreeComboBox.TabIndex = 8;
            // 
            // comboBoxManagementRole
            // 
            this.managementRoleComboBox.BackColor = System.Drawing.Color.White;
            this.managementRoleComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managementRoleComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managementRoleComboBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.managementRoleComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.managementRoleComboBox.FormattingEnabled = true;
            this.managementRoleComboBox.Location = new System.Drawing.Point(23, 320);
            this.managementRoleComboBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.managementRoleComboBox.Name = "comboBoxManagementRole";
            this.managementRoleComboBox.Size = new System.Drawing.Size(366, 33);
            this.managementRoleComboBox.TabIndex = 9;
            // 
            // checkBoxEnglishCertified
            // 
            this.englishCertifiedCheckBox.AutoSize = true;
            this.englishCertifiedCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.englishCertifiedCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.englishCertifiedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.englishCertifiedCheckBox.Location = new System.Drawing.Point(443, 324);
            this.englishCertifiedCheckBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.englishCertifiedCheckBox.Name = "checkBoxEnglishCertified";
            this.englishCertifiedCheckBox.Size = new System.Drawing.Size(266, 27);
            this.englishCertifiedCheckBox.TabIndex = 10;
            this.englishCertifiedCheckBox.Text = "Belgelendirilmiş İngilizce bilgisi";
            this.englishCertifiedCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxEnglishEducated
            // 
            this.englishEducatedCheckBox.AutoSize = true;
            this.englishEducatedCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.englishEducatedCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.englishEducatedCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.englishEducatedCheckBox.Location = new System.Drawing.Point(443, 364);
            this.englishEducatedCheckBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.englishEducatedCheckBox.Name = "checkBoxEnglishEducated";
            this.englishEducatedCheckBox.Size = new System.Drawing.Size(319, 27);
            this.englishEducatedCheckBox.TabIndex = 11;
            this.englishEducatedCheckBox.Text = "İngilizce eğitim veren okul mezuniyeti";
            this.englishEducatedCheckBox.UseVisualStyleBackColor = true;
            // 
            // textBoxOtherLanguages
            // 
            this.otherLanguagesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.otherLanguagesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.otherLanguagesTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otherLanguagesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.otherLanguagesTextBox.Location = new System.Drawing.Point(464, 436);
            this.otherLanguagesTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.otherLanguagesTextBox.Name = "textBoxOtherLanguages";
            this.otherLanguagesTextBox.Size = new System.Drawing.Size(118, 24);
            this.otherLanguagesTextBox.TabIndex = 12;
            // 
            // panelLineOtherLang
            // 
            this.otherLangLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.otherLangLinePanel.Location = new System.Drawing.Point(464, 460);
            this.otherLangLinePanel.Name = "panelLineOtherLang";
            this.otherLangLinePanel.Size = new System.Drawing.Size(118, 2);
            this.otherLangLinePanel.TabIndex = 29;
            // 
            // checkBoxSpouseNotWorking
            // 
            this.spouseNotWorkingCheckBox.AutoSize = true;
            this.spouseNotWorkingCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.spouseNotWorkingCheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.spouseNotWorkingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.spouseNotWorkingCheckBox.Location = new System.Drawing.Point(443, 235);
            this.spouseNotWorkingCheckBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.spouseNotWorkingCheckBox.Name = "checkBoxSpouseNotWorking";
            this.spouseNotWorkingCheckBox.Size = new System.Drawing.Size(184, 27);
            this.spouseNotWorkingCheckBox.TabIndex = 13;
            this.spouseNotWorkingCheckBox.Text = "Evli ve eşi çalışmıyor";
            this.spouseNotWorkingCheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxChildOver18
            // 
            this.childOver18CheckBox.AutoSize = true;
            this.childOver18CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childOver18CheckBox.Enabled = false;
            this.childOver18CheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.childOver18CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.childOver18CheckBox.Location = new System.Drawing.Point(443, 198);
            this.childOver18CheckBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.childOver18CheckBox.Name = "checkBoxChildOver18";
            this.childOver18CheckBox.Size = new System.Drawing.Size(166, 27);
            this.childOver18CheckBox.TabIndex = 14;
            this.childOver18CheckBox.Text = "18 yaş üstü çocuk";
            this.childOver18CheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxChildUnder6
            // 
            this.childUnder6CheckBox.AutoSize = true;
            this.childUnder6CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.childUnder6CheckBox.Enabled = false;
            this.childUnder6CheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.childUnder6CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.childUnder6CheckBox.Location = new System.Drawing.Point(443, 124);
            this.childUnder6CheckBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.childUnder6CheckBox.Name = "checkBoxChildUnder6";
            this.childUnder6CheckBox.Size = new System.Drawing.Size(175, 27);
            this.childUnder6CheckBox.TabIndex = 14;
            this.childUnder6CheckBox.Text = "0-6 yaş arası çocuk";
            this.childUnder6CheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBoxChild7to18
            // 
            this.child7to18CheckBox.AutoSize = true;
            this.child7to18CheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.child7to18CheckBox.Enabled = false;
            this.child7to18CheckBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.child7to18CheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.child7to18CheckBox.Location = new System.Drawing.Point(443, 161);
            this.child7to18CheckBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.child7to18CheckBox.Name = "checkBoxChild7to18";
            this.child7to18CheckBox.Size = new System.Drawing.Size(184, 27);
            this.child7to18CheckBox.TabIndex = 15;
            this.child7to18CheckBox.Text = "7-18 yaş arası çocuk";
            this.child7to18CheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Çalışma Şekli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(22, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 17;
            this.label2.Text = "Çalışma Süresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(19, 166);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 18;
            this.label3.Text = "Yaşadığı Şehir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(22, 230);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 19;
            this.label4.Text = "Akademik Derece";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(461, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 23);
            this.label5.TabIndex = 20;
            this.label5.Text = "Yabancı Dil Yetkinliği";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(460, 408);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "Başka Dillerin Sayısı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(22, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 23);
            this.label7.TabIndex = 22;
            this.label7.Text = "Yöneticilik Pozisyonu";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel1.Location = new System.Drawing.Point(465, 389);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 5);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Location = new System.Drawing.Point(465, 350);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(328, 5);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(465, 322);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(180, 5);
            this.panel3.TabIndex = 25;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel4.Location = new System.Drawing.Point(464, 149);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(175, 5);
            this.panel4.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel5.Location = new System.Drawing.Point(464, 187);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 5);
            this.panel5.TabIndex = 26;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel6.Location = new System.Drawing.Point(464, 224);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(175, 5);
            this.panel6.TabIndex = 27;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel7.Location = new System.Drawing.Point(464, 260);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 5);
            this.panel7.TabIndex = 28;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.Location = new System.Drawing.Point(464, 87);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 5);
            this.panel8.TabIndex = 26;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panelTop.Controls.Add(this.appNameLabel);
            this.panelTop.Controls.Add(this.backButton);
            this.panelTop.Controls.Add(this.btnAlt);
            this.panelTop.Controls.Add(this.CloseButton);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(761, 40);
            this.panelTop.TabIndex = 28;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // lblAppName
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.appNameLabel.ForeColor = System.Drawing.Color.White;
            this.appNameLabel.Location = new System.Drawing.Point(45, 10);
            this.appNameLabel.Name = "lblAppName";
            this.appNameLabel.Size = new System.Drawing.Size(164, 21);
            this.appNameLabel.TabIndex = 15;
            this.appNameLabel.Text = "Maaş Hesaplayıcı";
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
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(721, 0);
            this.CloseButton.Name = "btnClose";
            this.CloseButton.Size = new System.Drawing.Size(40, 40);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "✕";
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormSalaryCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(761, 560);
            this.Controls.Add(this.otherLangLinePanel);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.child7to18CheckBox);
            this.Controls.Add(this.childUnder6CheckBox);
            this.Controls.Add(this.childOver18CheckBox);
            this.Controls.Add(this.spouseNotWorkingCheckBox);
            this.Controls.Add(this.otherLanguagesTextBox);
            this.Controls.Add(this.englishEducatedCheckBox);
            this.Controls.Add(this.englishCertifiedCheckBox);
            this.Controls.Add(this.managementRoleComboBox);
            this.Controls.Add(this.academicDegreeComboBox);
            this.Controls.Add(this.cityGroupComboBox);
            this.Controls.Add(this.experienceNumericUpDown);
            this.Controls.Add(this.numChildrenTextBox);
            this.Controls.Add(this.hasChildrenCheckBox);
            this.Controls.Add(this.calculatedSalaryLabel);
            this.Controls.Add(this.calculateSalaryButton);
            this.Controls.Add(this.userTypeComboBox);
            this.Controls.Add(this.textBoxBaseSalary);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "FormSalaryCalculator";
            this.Text = "Maaş Hesaplayıcı";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormSalaryCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.experienceNumericUpDown)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxBaseSalary; // TextBox for entering the base salary
        private System.Windows.Forms.ComboBox userTypeComboBox; // ComboBox to select the user or employee type
        private System.Windows.Forms.Button calculateSalaryButton; // Button to trigger salary calculation
        private System.Windows.Forms.Label calculatedSalaryLabel; // Label to display the calculated salary
        private System.Windows.Forms.CheckBox hasChildrenCheckBox; // CheckBox to indicate if the user has children
        private System.Windows.Forms.TextBox numChildrenTextBox; // TextBox for the number of children (potentially conditional on hasChildrenCheckBox)
        private System.Windows.Forms.NumericUpDown experienceNumericUpDown; // NumericUpDown for entering years of experience
        private System.Windows.Forms.ComboBox cityGroupComboBox; // ComboBox to select the city or location group
        private System.Windows.Forms.ComboBox academicDegreeComboBox; // ComboBox to select the academic degree
        private System.Windows.Forms.ComboBox managementRoleComboBox; // ComboBox to select the management role
        private System.Windows.Forms.CheckBox englishCertifiedCheckBox; // CheckBox to indicate if the user has English certification
        private System.Windows.Forms.CheckBox englishEducatedCheckBox; // CheckBox to indicate if the user was educated in English
        private System.Windows.Forms.TextBox otherLanguagesTextBox; // TextBox for listing other languages
        private System.Windows.Forms.CheckBox spouseNotWorkingCheckBox; // CheckBox to indicate if the spouse is not working
        private System.Windows.Forms.CheckBox childOver18CheckBox; // CheckBox to indicate if there is a child over 18
        private System.Windows.Forms.CheckBox childUnder6CheckBox; // CheckBox to indicate if there is a child under 6
        private System.Windows.Forms.CheckBox child7to18CheckBox; // CheckBox to indicate if there is a child between 7 and 18
        private System.Windows.Forms.Label label1; // Generic label 1 (specific purpose needs context)
        private System.Windows.Forms.Label label2; // Generic label 2 (specific purpose needs context)
        private System.Windows.Forms.Label label3; // Generic label 3 (specific purpose needs context)
        private System.Windows.Forms.Label label4; // Generic label 4 (specific purpose needs context)
        private System.Windows.Forms.Label label5; // Generic label 5 (specific purpose needs context)
        private System.Windows.Forms.Label label6; // Generic label 6 (specific purpose needs context)
        private System.Windows.Forms.Label label7; // Generic label 7 (specific purpose needs context)
        private System.Windows.Forms.Panel panel1; // Generic panel 1 (specific purpose needs context)
        private System.Windows.Forms.Panel panel2; // Generic panel 2 (specific purpose needs context)
        private System.Windows.Forms.Panel panel3; // Generic panel 3 (specific purpose needs context)
        private System.Windows.Forms.Panel panel4; // Generic panel 4 (specific purpose needs context)
        private System.Windows.Forms.Panel panel5; // Generic panel 5 (specific purpose needs context)
        private System.Windows.Forms.Panel panel6; // Generic panel 6 (specific purpose needs context)
        private System.Windows.Forms.Panel panel7; // Generic panel 7 (specific purpose needs context)
        private System.Windows.Forms.Panel panel8; // Generic panel 8 (specific purpose needs context)
        private System.Windows.Forms.Panel panelTop; // Panel for the form's header bar
        private System.Windows.Forms.Label appNameLabel; // Label for the application name in the header
        private System.Windows.Forms.Button backButton; // Button to go back
        private System.Windows.Forms.Button btnAlt; // Button to minimize the window
        private System.Windows.Forms.Button CloseButton; // Button to close the window
        private System.Windows.Forms.Panel otherLangLinePanel; // Underline panel for the Other Languages TextBox
    }
}

