using System;
using System.Windows.Forms;
using WindowsFormsApp2;
using System.Drawing;

namespace salary_calculate
{
    public partial class FormSalaryCalculator : Form, IReminderObserver
    {
        private const double base_min_salary = 22104.67 * 2; // Base salary (Asgari Ücret * 2)
        private User currentUser;
        private UserManager userManager;

        private Point orgPosition;
        
        // Form taşıma işlemleri için mouse olayları
        private bool dragging = false;
        private Point initialPoint;

        public FormSalaryCalculator(User currentUser,UserManager userManager)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.userManager = userManager;

            currentUser.TaskReminderManager.RegisterObserver(this);
            orgPosition = this.Location;
        }

        // Form taşıma işlemleri için mouse olayları
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            initialPoint = new Point(e.X, e.Y);
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - initialPoint.X, p.Y - initialPoint.Y);
            }
        }

        public void RefreshHeader(string summary)
        {
            GlobalSettings.UpdateHeader(this, summary);
        }

        public void ShakeWindow()
        {
            GlobalSettings.ShakeWindow(this);
        }

        // Event handler for calculate button click
        private void button1_Click(object sender, EventArgs e)
        {
            double baseSalary = base_min_salary;
            double calculatedSalary = CalculateMinimumSalary(baseSalary, userTypeComboBox.SelectedItem.ToString());
            calculatedSalaryLabel.Text = "Hesaplanan Maaş: " + calculatedSalary.ToString("C2");
            currentUser.UserSalary = calculatedSalary;
            userManager.ExportUsersToExcel("User.xlsx");
        }
        private double CalculateMinimumSalary(double baseSalary, string userType)
        {
            double minSalary = baseSalary;
            double coefSum = 0;

            if (userType == "Part-time")
            {
                minSalary *= 0.5;
            }

            // Experience years coefficient
            int experienceYears = (int)experienceNumericUpDown.Value;
            coefSum += GetExperienceCoefficient(experienceYears);

            // City group coefficient
            string cityGroup = cityGroupComboBox.SelectedItem.ToString();
            coefSum += GetCityGroupCoefficient(cityGroup);

            // Academic degree coefficient
            string academicDegree = academicDegreeComboBox.SelectedItem.ToString();
            coefSum += GetAcademicDegreeCoefficient(academicDegree);

            // Language proficiency coefficient
            coefSum += GetLanguageCoefficient();

            // Management role coefficient
            string managementRole = managementRoleComboBox.SelectedItem.ToString();
            coefSum += GetManagementRoleCoefficient(managementRole);

            // Family status coefficient
            coefSum += GetFamilyStatusCoefficient();

            // Calculate and return the minimum salary
            return minSalary * (1 + coefSum);
        }

        // Method to get experience coefficient
        private double GetExperienceCoefficient(int years)
        {
            if (years >= 2 && years <= 4) return 0.60;
            if (years >= 5 && years <= 9) return 1.00;
            if (years >= 10 && years <= 14) return 1.20;
            if (years >= 15 && years <= 20) return 1.35;
            if (years > 20) return 1.50;
            return 0.00;
        }

        // Method to get city group coefficient
        private double GetCityGroupCoefficient(string cityGroup)
        {
            switch (cityGroup)
            {
                case "TR10: İstanbul": return 0.30;
                case "TR51: Ankara": return 0.20;
                case "TR31: İzmir": return 0.20;
                case "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova": return 0.10;
                case "TR21: Edirne, Kırklareli, Tekirdağ": return 0.10;
                case "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane": return 0.05;
                case "TR41: Bursa, Eskişehir, Bilecik": return 0.05;
                case "TR32: Aydın, Denizli, Muğla": return 0.05;
                case "TR62: Adana, Mersin": return 0.05;
                case "TR22: Balıkesir, Çanakkale": return 0.05;
                case "TR61: Antalya, Isparta, Burdur": return 0.05;
                case "Diğer İller": return 0.00;
                default: return 0.00;
            }
        }

        // Method to get academic degree coefficient
        private double GetAcademicDegreeCoefficient(string degree)
        {
            switch (degree)
            {
                case "Meslek alanı ile ilgili yüksek lisans": return 0.10;
                case "Meslek alanı ile ilgili doktora": return 0.30;
                case "Meslek alanı ile ilgili doçentlik": return 0.35;
                case "Meslek alanı ile ilgili olmayan yüksek lisans": return 0.05;
                case "Meslek alanı ile ilgili olmayan doktora/doçentlik": return 0.15;
                default: return 0.00;
            }
        }

        // Method to get language proficiency coefficient
        private double GetLanguageCoefficient()
        {
            double coef = 0;
            if (englishCertifiedCheckBox.Checked) coef += 0.20;
            if (englishEducatedCheckBox.Checked) coef += 0.20;

            int otherLanguages;
            if (int.TryParse(otherLanguagesTextBox.Text, out otherLanguages))
                coef += otherLanguages * 0.05;

            return coef;
        }

        // Method to get management role coefficient
        private double GetManagementRoleCoefficient(string role)
        {
            switch (role)
            {
                case "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı": return 0.50;
                case "Proje Yöneticisi": return 0.75;
                case "Direktör/Projeler Yöneticisi": return 0.85;
                case "CTO/Genel Müdür": return 1.00;
                case "Bilgi İşlem Sorumlusu/Müdürü (en çok 5 bilişim personeli)": return 0.40;
                case "Bilgi İşlem Sorumlusu/Müdürü (5'ten çok bilişim personeli)": return 0.60;
                default: return 0.00;
            }
        }

        // Method to get family status coefficient
        private double GetFamilyStatusCoefficient()
        {
            double coefficient = 0;
            if (spouseNotWorkingCheckBox.Checked) coefficient += 0.20;

            int numChildren;
            if (int.TryParse(numChildrenTextBox.Text, out numChildren))
            {
                if (childUnder6CheckBox.Checked) coefficient += 0.20;
                if (child7to18CheckBox.Checked) coefficient += 0.30;
                if (childOver18CheckBox.Checked) coefficient += 0.40;
            }

            return coefficient;
        }

        // Event handler to enable/disable children-related fields based on checkbox state
        private void checkBoxHasChildren_CheckedChanged(object sender, EventArgs e)
        {
            bool hasChildren = hasChildrenCheckBox.Checked;
            numChildrenTextBox.Enabled = hasChildren;
            childUnder6CheckBox.Enabled = hasChildren;
            child7to18CheckBox.Enabled = hasChildren;
            childOver18CheckBox.Enabled = hasChildren;
        }

        // Event handler for form load
        private void FormSalaryCalculator_Load(object sender, EventArgs e)
        {
            // Initialize combo box values
            userTypeComboBox.Items.Add("Full-time");
            userTypeComboBox.Items.Add("Part-time");
            cityGroupComboBox.Items.AddRange(new string[]
            {
                "TR10: İstanbul",
                "TR51: Ankara",
                "TR31: İzmir",
                "TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova",
                "TR21: Edirne, Kırklareli, Tekirdağ",
                "TR90: Trabzon, Ordu, Giresun, Rize, Artvin, Gümüşhane",
                "TR41: Bursa, Eskişehir, Bilecik",
                "TR32: Aydın, Denizli, Muğla",
                "TR62: Adana, Mersin",
                "TR22: Balıkesir, Çanakkale",
                "TR61: Antalya, Isparta, Burdur",
                "Diğer İller"
            });
            academicDegreeComboBox.Items.AddRange(new string[]
            {
                "Meslek alanı ile ilgili yüksek lisans",
                "Meslek alanı ile ilgili doktora",
                "Meslek alanı ile ilgili doçentlik",
                "Meslek alanı ile ilgili olmayan yüksek lisans",
                "Meslek alanı ile ilgili olmayan doktora/doçentlik",
                "Yok"
            });
            managementRoleComboBox.Items.AddRange(new string[]
            {
                "Takım Lideri/Grup Yöneticisi/Teknik Yönetici/Yazılım Mimarı",
                "Proje Yöneticisi",
                "Direktör/Projeler Yöneticisi",
                "CTO/Genel Müdür",
                "Bilgi İşlem Sorumlusu/Müdürü (en çok 5 bilişim personeli)",
                "Bilgi İşlem Sorumlusu/Müdürü (5'ten çok bilişim personeli)",
                "Yok"
            });

            // Set default selected values
            userTypeComboBox.SelectedIndex = 0;
            academicDegreeComboBox.SelectedIndex = 5;
            cityGroupComboBox.SelectedIndex = 0;
            managementRoleComboBox.SelectedIndex = 6;
            
            // Combobox'ların görünümünü geliştir
            StilComboBoxAyarla(userTypeComboBox);
            StilComboBoxAyarla(cityGroupComboBox);
            StilComboBoxAyarla(academicDegreeComboBox);
            StilComboBoxAyarla(managementRoleComboBox);
            
            // Açılır liste davranışı ve stilini ayarla
            userTypeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            cityGroupComboBox.DrawMode = DrawMode.OwnerDrawFixed;  
            academicDegreeComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            managementRoleComboBox.DrawMode = DrawMode.OwnerDrawFixed;
            
            userTypeComboBox.DrawItem += ComboBox_DrawItem;
            cityGroupComboBox.DrawItem += ComboBox_DrawItem;
            academicDegreeComboBox.DrawItem += ComboBox_DrawItem;
            managementRoleComboBox.DrawItem += ComboBox_DrawItem;
        }
        
        // Combobox'ların stilini ayarlayan metod
        private void StilComboBoxAyarla(ComboBox comboBox)
        {
            comboBox.BackColor = Color.White;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            
            // Kenarlık için panel ekleme
            Panel p = new Panel();
            p.BackColor = Color.FromArgb(41, 128, 185); // Form rengine uygun kenarlık rengi
            p.Height = 2;
            p.Dock = DockStyle.Bottom;
            
            // Combobox'un ebeveyn kontrolü
            Control parent = comboBox.Parent;
            
            // Paneli combobox'un altına ekleme
            int panelIndex = parent.Controls.IndexOf(comboBox);
            p.Location = new Point(comboBox.Location.X, comboBox.Location.Y + comboBox.Height + 1);
            p.Width = comboBox.Width;
            parent.Controls.Add(p);
            
            // Paneli combobox'un arkasında konumlandırma
            parent.Controls.SetChildIndex(p, panelIndex + 1);
        }

        // ComboBox öğelerinin çizim stilini özelleştiren metod
        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            
            ComboBox combo = sender as ComboBox;
            
            // Öğe seçili veya üzerinde mi kontrol et
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;
            
            // Arka plan rengini ayarla
            e.Graphics.FillRectangle(
                new SolidBrush(isSelected ? Color.FromArgb(213, 233, 249) : Color.White),
                e.Bounds
            );
            
            // Metin rengini ayarla
            using (SolidBrush textBrush = new SolidBrush(Color.FromArgb(41, 128, 185)))
            {
                // Metni çiz
                e.Graphics.DrawString(
                    combo.Items[e.Index].ToString(),
                    e.Font,
                    textBrush,
                    new Rectangle(e.Bounds.X + 3, e.Bounds.Y + 2, e.Bounds.Width - 6, e.Bounds.Height - 4)
                );
            }
            
            // Kenar çizgisini çiz
            if (isSelected)
            {
                e.Graphics.DrawRectangle(
                    new Pen(Color.FromArgb(41, 128, 185)),
                    new Rectangle(e.Bounds.X, e.Bounds.Y, e.Bounds.Width - 1, e.Bounds.Height - 1)
                );
            }
            
            e.DrawFocusRectangle();
        }

        // Event handlers for form controls (minimize, close)
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (cikis == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
            else { return; }
        }

       
    }
}
