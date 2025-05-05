using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{

    public partial class Anasayfa : Form
    {
        // Form taşıma değişkenleri
        private bool mouseDown;
        private Point lastLocation;

        private UserManager userManager;
        private User currentUser;

        public Anasayfa()
        {
            InitializeComponent();
            userManager = new UserManager();
            userManager.ImportUsersFromExcel("User.xlsx");
            
            // Metin kutuları için placeholder işlevselliği
            userNameTextBox.GotFocus += RemoveUsernamePlaceholder;
            userNameTextBox.LostFocus += AddUsernamePlaceholder;
            passwordTextBox.GotFocus += RemovePasswordPlaceholder;
            passwordTextBox.LostFocus += AddPasswordPlaceholder;
            
            // Enter tuşu ile giriş yapabilmek için KeyDown olayı
            passwordTextBox.KeyDown += TxtPassword_KeyDown;
            userNameTextBox.KeyDown += TxtUserName_KeyDown;
        }

        // TextChanged olayı için gerekli metot
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Bu metod boş olabilir, sadece Designer'daki referansı karşılamak için ekleniyor
        }

        // Şifre alanında Enter tuşuna basıldığında giriş yap
        private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuşunun ses çıkarmasını engeller
                e.Handled = true; // Enter tuşunun alt satıra geçişini engeller
                btnLogIn_Click(sender, e); // Giriş butonunun click olayını çağır
            }
        }

        // Kullanıcı adı placeholder kaldırma
        private void RemoveUsernamePlaceholder(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "Kullanıcı Adı")
            {
                userNameTextBox.Text = "";
                userNameTextBox.ForeColor = Color.Black;
            }
        }

        // Kullanıcı adı placeholder ekleme
        private void AddUsernamePlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(userNameTextBox.Text))
            {
                userNameTextBox.Text = "Kullanıcı Adı";
                userNameTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        // Şifre placeholder kaldırma
        private void RemovePasswordPlaceholder(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Şifre")
            {
                passwordTextBox.Text = "";
                passwordTextBox.PasswordChar = '*';
                passwordTextBox.ForeColor = Color.Black;
            }
        }

        // Şifre placeholder ekleme
        private void AddPasswordPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                passwordTextBox.PasswordChar = '\0';
                passwordTextBox.Text = "Şifre";
                passwordTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
        }

        // Alt form kapatıldığında ana formu tekrar gösterme
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        // Giriş butonu tıklama olayı - Login işlemi
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            // Placeholder metinlerini kontrol et
            if (userNameTextBox.Text == "Kullanıcı Adı" || passwordTextBox.Text == "Şifre")
            {
                MessageBox.Show("Lütfen kullanıcı adı ve şifrenizi giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı girişini doğrula
            bool check = userManager.LoginUser(userNameTextBox.Text, passwordTextBox.Text);
            if (check)
            {
                // Mevcut kullanıcıyı al ve ana menüye geç
                currentUser = userManager.GetCurrentUser(userNameTextBox.Text, passwordTextBox.Text);
                this.Hide();  // Hide Form1 when moving to FormMenu
                FormMenu form = new FormMenu(currentUser, userManager);

                // Handle the FormClosed event to show Form1 again when FormMenu is closed
                form.FormClosed += (s, args) => this.Show();

                form.ShowDialog();

                // Kullanıcı geri döndüğünde placeholder'leri eski haline getir
                userNameTextBox.Text = "Kullanıcı Adı";
                userNameTextBox.ForeColor = Color.FromArgb(64, 64, 64);
                passwordTextBox.Text = "Şifre";
                passwordTextBox.PasswordChar = '\0';
                passwordTextBox.ForeColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                MessageBox.Show("Giriş başarısız oldu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Kayıt butonu tıklama olayı
        private void btnKayıt_Click(object sender, EventArgs e)
        {
            this.Hide();
            formKayıt form = new formKayıt(userManager);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        // Kapat butonu tıklama olayı
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (cikis == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        // Form taşıma işlemleri için fare olayları
        private void Anasayfa_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Anasayfa_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Anasayfa_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // Simge durumuna küçültme butonu
        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Şifremi unuttum linkine tıklama olayı
        private void lblForgetPass_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormForgetPassword form = new FormForgetPassword();
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        // Kullanıcı adı alanında Enter tuşuna basıldığında işlemler
        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Enter tuşunun ses çıkarmasını engeller
                e.Handled = true; // Enter tuşunun işlenmesini engeller
                
                // Eğer şifre alanı boşsa veya placeholder ise şifre alanına geç
                if (passwordTextBox.Text == "Şifre" || string.IsNullOrEmpty(passwordTextBox.Text))
                {
                    passwordTextBox.Focus();
                }
                else
                {
                    // Şifre alanı doldurulmuşsa direkt giriş yap
                    btnLogIn_Click(sender, e);
                }
            }
        }

    }
}
