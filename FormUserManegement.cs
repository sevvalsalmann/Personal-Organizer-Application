using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Vml.Office;
using System.Net.Mail;
using System.Net;

namespace WindowsFormsApp2
{
    public partial class FormUserManegement : Form, IReminderObserver
    {
        private UserManager userManager;
        private int selectedRowIndex = -1;

        List<User> users = new List<User>();
        User selectedUser;
        string userType;

        private Point originalPosition;
        
        // Form taşıma işlemleri için mouse olayları
        private bool dragging = false;
        private Point startPoint;
        
        public FormUserManegement(UserManager userManager)
        {
            InitializeComponent();
            this.userManager = userManager;
            users = userManager.GetUsers();

            foreach (User user in users)
            {
                if (user.Type.ToString() == "Admin")
                { 
                
                    user.TaskReminderManager.RegisterObserver(this);
                    originalPosition = this.Location;
                }
            }
            
            // Panel fare olaylarını ekle
            headerPanel.MouseDown += PanelTop_MouseDown;
            headerPanel.MouseMove += PanelTop_MouseMove;
            headerPanel.MouseUp += PanelTop_MouseUp;
        }
        
        // Form taşıma işlemleri için mouse olayları
        private void PanelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void PanelTop_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void PanelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
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


        private void FormUserManegement_Load(object sender, EventArgs e)
        {
            // excel dosyasındaki kullanıcıları gridView'da gösterme
            usersDataGridView.DataSource = users;
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            usersDataGridView.Columns["NotesManager"].Visible = false;
            usersDataGridView.Columns["PhoneBook"].Visible = false;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Silmek İçin Kullanıcı Seçin!");
                return;
            }
            DialogResult silme = MessageBox.Show("Kullanıcıyı ve Kullanıcıya Ait Tüm Bilgileri Silmek İstediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (silme == DialogResult.Cancel)
            {
                return;
            }
            // Admin üzerinde işlem yapılamaz!
            if (selectedUser.Type.ToString() == "Admin")
            {
                MessageBox.Show("Admin üzerinde işlem yapılamaz!");
                return;
            }
            string usernameToDelete = userNameTextBox.Text;
            userManager.DeleteUser(usernameToDelete);
            users.RemoveAll(u => u.Username == usernameToDelete); // Remove user from local list

            // Update the DataGridView
            usersDataGridView.DataSource = null; // Clear the DataSource
            usersDataGridView.DataSource = users; // Rebind the DataGridView
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            usersDataGridView.Columns["NotesManager"].Visible = false;
            usersDataGridView.Columns["PhoneBook"].Visible = false;

            userManager.ExportUsersToExcel("User.xlsx");
            MessageBox.Show("Kullanıcı başarıyla silindi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (File.Exists($"{usernameToDelete}_PhoneBook.xlsx"))
            {
                File.Delete($"{usernameToDelete}_PhoneBook.xlsx");
            }

            if (File.Exists($"{usernameToDelete}_Notes.xlsx"))
            {
                File.Delete($"{usernameToDelete}_Notes.xlsx");
            }

            if (File.Exists($"{usernameToDelete}_Reminder.xlsx"))
            {
                File.Delete($"{usernameToDelete}_Reminder.xlsx");
            }

            userNameTextBox.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";
            partTimeUserRadioButton.Checked = false;
            userRadioButton.Checked = false;
            mainTabControl.SelectedTab = tabPage1;
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "")
            {
                MessageBox.Show("Güncellemek İçin Bir Kullanıcı Seçin");
                return;
            }
            // Admin üzerinde işlem yapılamaz!
            if (selectedUser.Type.ToString() == "Admin")
            {
                MessageBox.Show("Admin üzerinde işlem yapılamaz!");
                return;
            }

            if (partTimeUserRadioButton.Checked)
            {
                userType = partTimeUserRadioButton.Text;
            }
            else if (userRadioButton.Checked)
            {
                userType = userRadioButton.Text;
            }

            if (selectedRowIndex >= 0)
            {
                // Update the selected row's cells with the values from the text boxes
                usersDataGridView.Rows[selectedRowIndex].Cells["Username"].Value = userNameTextBox.Text;
                usersDataGridView.Rows[selectedRowIndex].Cells["Name"].Value = nameTextBox.Text;
                usersDataGridView.Rows[selectedRowIndex].Cells["Surname"].Value = surnameTextBox.Text;
                usersDataGridView.Rows[selectedRowIndex].Cells["Email"].Value = emailTextBox.Text;
                usersDataGridView.Rows[selectedRowIndex].Cells["Password"].Value = passwordTextBox.Text;
                usersDataGridView.Rows[selectedRowIndex].Cells["PhoneNumber"].Value = phoneNumberTextBox.Text;
                usersDataGridView.Rows[selectedRowIndex].Cells["AddressDescription"].Value = addressTextBox.Text;

                if (!isValidEmail(emailTextBox.Text))
                {
                    MessageBox.Show("Geçersiz e-posta adresi.");
                    return;
                }

                if (!isValidPhoneNumber(phoneNumberTextBox.Text))
                {
                    MessageBox.Show("Geçersiz telefon numarası. Telefon numarası (555) 555 55 55 formatında olmalıdır.");
                    return;
                }

                // Update the corresponding entry in the user's PhoneBook
                selectedUser.Username = userNameTextBox.Text;
                selectedUser.Name = nameTextBox.Text;
                selectedUser.Surname = surnameTextBox.Text;
                selectedUser.EmailAddress = emailTextBox.Text.TrimEnd();
                selectedUser.UserPassword = passwordTextBox.Text;
                selectedUser.ContactNumber = phoneNumberTextBox.Text.TrimEnd();
                selectedUser.AddressDescription = addressTextBox.Text;
                selectedUser.Type = (UserType)Enum.Parse(typeof(UserType), userType);

                userManager.ExportUsersToExcel("User.xlsx");

                userNameTextBox.Text = "";
                nameTextBox.Text = "";
                surnameTextBox.Text = "";
                emailTextBox.Text = "";
                passwordTextBox.Text = "";
                phoneNumberTextBox.Text = "";
                addressTextBox.Text = "";
                partTimeUserRadioButton.Checked = false;
                userRadioButton.Checked = false;
                mainTabControl.SelectedTab = tabPage1;

                // Reset the selected row index
                selectedRowIndex = -1;

                MessageBox.Show("Giriş başarıyla güncellendi.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Güncellemek için lütfen bir satır seçin.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
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
            }
            else { return; }
        }

        private async void btnSendMail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                MessageBox.Show("Lütfen önce bir kullanıcı seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string email = emailTextBox.Text;
            if (IsValidEmail(email))
            {
                mailProgressBar.Value = 10;
                string sifre = passwordTextBox.Text;
                if (string.IsNullOrEmpty(sifre))
                {
                    MessageBox.Show("Kullanıcının şifresi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mailProgressBar.Value = 0;
                    return;
                }

                try
                {
                    mailProgressBar.Value = 30;
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    
                    // E-posta gönderme ayarları
                    String mailadresi = "personalorgoop@gmail.com"; // Gmail hesabınızı buraya girin
                    String mailfresifre = "vmnf mwjl rafa xyyr"; // Google hesabınızdan aldığınız 16 haneli uygulama şifresini buraya girin
                    String smtpsrvr = "smtp.gmail.com"; // Gmail için SMTP sunucusu
                    
                    String konu = "Kullanıcı Şifre Bilgilendirmesi";
                    string yaz = $"Sayın {nameTextBox.Text} {surnameTextBox.Text},\n\n{tarih} tarihinde yönetici tarafından gönderilen şifre bilgileriniz: {sifre}\n\nGüvenlik için lütfen giriş yaptıktan sonra şifrenizi değiştirin.\n\nBu otomatik bir e-postadır, lütfen yanıtlamayınız.";

                    smtpserver.Credentials = new NetworkCredential(mailadresi, mailfresifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;

                    mail.From = new MailAddress(mailadresi);
                    mail.To.Add(email);
                    mail.Subject = konu;
                    mail.Body = yaz;

                    mailProgressBar.Value = 60;
                    await Task.Run(() => smtpserver.Send(mail));
                    mailProgressBar.Value = 100;
                    MessageBox.Show("E-posta başarıyla gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show($"E-posta gönderiminde hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mailProgressBar.Value = 0;
                }
            }
            else
            {
                MessageBox.Show("Geçersiz bir e-posta adresi girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mailProgressBar.Value = 0;
            }
        }
        
        private bool IsValidEmail(string email)
        {
            // E-posta doğrulama regex'i
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < usersDataGridView.Rows.Count)
            {
                // Set the selected row index
                selectedRowIndex = e.RowIndex;
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = usersDataGridView.Rows[e.RowIndex];
                userNameTextBox.Text = selectedRow.Cells["Username"].Value.ToString();
                nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                surnameTextBox.Text = selectedRow.Cells["Surname"].Value.ToString();
                emailTextBox.Text = selectedRow.Cells["Email"].Value.ToString();
                passwordTextBox.Text = selectedRow.Cells["Password"].Value.ToString();
                phoneNumberTextBox.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                addressTextBox.Text = selectedRow.Cells["AddressDescription"].Value.ToString();
                userType = selectedRow.Cells["Type"].Value.ToString();

                if (userType == userRadioButton.Text)
                {
                    userRadioButton.Checked = true;
                }
                else if (userType == partTimeUserRadioButton.Text)
                {
                    partTimeUserRadioButton.Checked = true;
                }
                else if (userType == "Admin")
                {
                    userRadioButton.Checked = false;
                    partTimeUserRadioButton.Checked = false;
                }

                foreach (var user in users)
                {
                    if (user.Name == nameTextBox.Text)
                    {
                        selectedUser = user;
                    }
                }

                mainTabControl.SelectedTab = tabPage1;
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            // Önce alanları temizle
            if (string.IsNullOrEmpty(userNameTextBox.Text) &&
                string.IsNullOrEmpty(nameTextBox.Text) &&
                string.IsNullOrEmpty(surnameTextBox.Text) &&
                string.IsNullOrEmpty(emailTextBox.Text) &&
                string.IsNullOrEmpty(passwordTextBox.Text) &&
                string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                // Tüm alanlar boşsa, yeni kullanıcı eklemeye hazırlanıyoruz
                mainTabControl.SelectedTab = tabPage1; // Kayıt sekmesine git
                return;
            }
            
            // Boş alan kontrolü
            if (string.IsNullOrEmpty(userNameTextBox.Text) || 
                string.IsNullOrEmpty(nameTextBox.Text) || 
                string.IsNullOrEmpty(surnameTextBox.Text) || 
                string.IsNullOrEmpty(emailTextBox.Text) || 
                string.IsNullOrEmpty(passwordTextBox.Text) || 
                string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            // E-posta ve telefon doğrulama
            if (!isValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Geçersiz e-posta adresi.");
                return;
            }

            if (!isValidPhoneNumber(phoneNumberTextBox.Text))
            {
                MessageBox.Show("Geçersiz telefon numarası. Telefon numarası (555) 555 55 55 formatında olmalıdır.");
                return;
            }
            
            // Kullanıcı tipi kontrolü
            if (!userRadioButton.Checked && !partTimeUserRadioButton.Checked)
            {
                MessageBox.Show("Lütfen kullanıcı tipini seçin.");
                return;
            }
            
            string userType;
            if (partTimeUserRadioButton.Checked)
            {
                userType = partTimeUserRadioButton.Text;
            }
            else
            {
                userType = userRadioButton.Text;
            }

            // Kullanıcı adının benzersiz olduğunu kontrol et
            if (users.Any(u => u.Username == userNameTextBox.Text))
            {
                MessageBox.Show("Bu kullanıcı adı zaten kullanılıyor. Lütfen başka bir kullanıcı adı seçin.");
                return;
            }

            // Yeni kullanıcı oluştur
            string errorMessage;
            double salary = 0; // Varsayılan maaş değeri
            User newUser = new User(
                userNameTextBox.Text,
                nameTextBox.Text,
                surnameTextBox.Text,
                emailTextBox.Text,
                passwordTextBox.Text,
                (UserType)Enum.Parse(typeof(UserType), userType),
                phoneNumberTextBox.Text,
                addressTextBox.Text,
                salary,
                "", // photoPath parametresi, boş olarak gönderiyoruz
                out errorMessage
            );
            
            if (!string.IsNullOrEmpty(errorMessage))
            {
                MessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            // Kullanıcıyı UserManager üzerinden ekle - bu zaten listeyi günceller
            userManager.AddUser(newUser);
            
            // Users listesini UserManager'dan güncelleyerek al
            users = userManager.GetUsers();
            
            // DataGridView'u güncelle
            usersDataGridView.DataSource = null;
            usersDataGridView.DataSource = users;
            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            usersDataGridView.Columns["NotesManager"].Visible = false;
            usersDataGridView.Columns["PhoneBook"].Visible = false;
            
            // Excel'e aktar - UserManager.AddUser içinde zaten yapılmış olmalı, 
            // ancak emin olmak için burada da çağırıyoruz
            userManager.ExportUsersToExcel("User.xlsx");
            
            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Alanları temizle
            userNameTextBox.Text = "";
            nameTextBox.Text = "";
            surnameTextBox.Text = "";
            emailTextBox.Text = "";
            passwordTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";
            partTimeUserRadioButton.Checked = false;
            userRadioButton.Checked = false;
            mainTabControl.SelectedTab = tabPage1;
        }

        bool isValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new System.Globalization.IdnMapping();
                    var domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (Exception)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+\s*$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        bool isValidPhoneNumber(string phoneNumber)
        {
            // Sadece rakamları al
            string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");
            
            // 10 haneli telefon numarası kontrolü (örn: 5551112233)
            if (digitsOnly.Length != 10)
                return false;
            
            // Formatlama otomatik olarak yapılacak
            return true;
        }

        // Telefon numarası alanı değiştiğinde otomatik format ekleme
        private void txt_phone_TextChanged(object sender, EventArgs e)
        {
            // Cursor pozisyonunu hatırla
            int cursorPosition = phoneNumberTextBox.SelectionStart;
            
            // Şu anki metin uzunluğunu hatırla
            int currentLength = phoneNumberTextBox.Text.Length;
            
            // Metni formatla
            phoneNumberTextBox.Text = User.ApplyPhoneNumberFormat(phoneNumberTextBox.Text);
            
            // Yeni metin uzunluğu
            int newLength = phoneNumberTextBox.Text.Length;
            
            // Cursor pozisyonunu ayarla (format değişikliğinden etkilenmemesi için)
            phoneNumberTextBox.SelectionStart = Math.Min(cursorPosition + (newLength - currentLength), phoneNumberTextBox.Text.Length);
        }
    }
}