using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace WindowsFormsApp2
{
    public partial class FormForgetPassword : Form
    {
        // Form taşıma için gerekli değişkenler
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        public FormForgetPassword()
        {
            InitializeComponent();
        }

        // Şifre hatırlatma e-postası gönderme butonu
        private async void btnSendMail_Click(object sender, EventArgs e)
        {
            string email = txtSendMail.Text;
            if (IsValidEmail(email))
            {
                // İlerleme durumunu göster
                progressStatus.Value = 10;
                statusLabel.Text = "Şifreniz kontrol ediliyor...";
                
                // Excel dosyasından şifreyi kontrol et
                string sifreniz = ImportPassFromExcel("User.xlsx");
                if (sifreniz.StartsWith("Hata"))
                {
                    MessageBox.Show(sifreniz, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressStatus.Value = 0;
                    statusLabel.Text = "Şifrenizi sıfırlamak için e-posta adresinizi girin.";
                    return;
                }

                try
                {
                    // E-posta gönderme hazırlıkları
                    progressStatus.Value = 30;
                    statusLabel.Text = "E-posta gönderiliyor...";
                    SmtpClient smtpserver = new SmtpClient();
                    MailMessage mail = new MailMessage();
                    String tarih = DateTime.Now.ToLongDateString();
                    
                    // ÖNEMLİ: E-posta hesap bilgileri
                    String mailadresi = "personalorgoop@gmail.com"; // Gmail hesabınızı buraya girin
                    String sifre = "vmnf mwjl rafa xyyr"; // Google hesabınızdan aldığınız 16 haneli uygulama şifresini buraya girin
                    String smtpsrvr = "smtp.gmail.com"; // Gmail için SMTP sunucusu
                    
                    // E-posta içeriği ayarları
                    String konu = "Şifre Hatırlatma Maili";
                    string yaz = $"{tarih} Tarihinde şifre hatırlatma talebinde bulundunuz. Şifreniz: {sifreniz}";

                    // SMTP sunucu yapılandırması
                    smtpserver.Credentials = new NetworkCredential(mailadresi, sifre);
                    smtpserver.Port = 587;
                    smtpserver.Host = smtpsrvr;
                    smtpserver.EnableSsl = true;

                    // E-posta ayarları
                    mail.From = new MailAddress(mailadresi);
                    mail.To.Add(email);
                    mail.Subject = konu;
                    mail.Body = yaz;

                    // E-postayı arka planda gönder
                    progressStatus.Value = 60;
                    statusLabel.Text = "E-posta gönderiliyor, lütfen bekleyin...";
                    await Task.Run(() => smtpserver.Send(mail));
                    progressStatus.Value = 100;
                    statusLabel.Text = "E-posta başarıyla gönderildi!";
                    MessageBox.Show("E-posta başarıyla gönderildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (SmtpException ex)
                {
                    MessageBox.Show($"E-posta gönderiminde hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressStatus.Value = 0;
                    statusLabel.Text = "E-posta gönderiminde hata oluştu!";
                }
            }
            else
            {
                MessageBox.Show("Geçersiz bir e-posta adresi girdiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                progressStatus.Value = 0;
                statusLabel.Text = "Lütfen geçerli bir e-posta adresi girin.";
            }
        }
       
        // E-posta formatını doğrulama
        private bool IsValidEmail(string email)
        {
            // E-posta doğrulama regex'i
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }

        // Form yüklendiğinde çalışacak kod
        private void FormForgetPassword_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde başlangıç ayarları
            progressStatus.Value = 0;
            statusLabel.Text = "Şifrenizi sıfırlamak için e-posta adresinizi girin.";
        }
        
        // Excel dosyasından şifre getirme
        public string ImportPassFromExcel(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RangeUsed().RowsUsed().Skip(1);

                    // E-posta adresini Excel'de ara
                    foreach (var row in rows)
                    {
                        string email = row.Cell(4).GetValue<string>();
                        if (txtSendMail.Text == email)
                        {
                            string password = row.Cell(5).GetValue<string>();
                            return password;
                        }
                    }

                    // Eğer döngüden hiç bir e-posta eşleşmesi olmadan çıkarsa, hata mesajı döndür
                    return "Hata: Eşleşen e-posta adresi bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                return $"Hata: {ex.Message}";
            }
        }
        
        // Rastgele şifre oluşturma
        static string GenerateRandomPassword()
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            char[] password = new char[6];
            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                password[i] = validChars[random.Next(validChars.Length)];
            }

            return new string(password);
        }
        
        private void txtSendMail_TextChanged(object sender, EventArgs e)
        {
            // E-posta girişinde yapılacak işlemler
        }

        // Form taşıma işlemleri için mouse olayları
        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        // Çıkış butonu
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (cikis == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Simge durumuna küçültme butonu
        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Geri dönme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
