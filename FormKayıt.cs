using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class formKayıt : Form 
    {
        // Form taşıma için gerekli değişkenler
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);

        private UserManager userManager;

        public formKayıt(UserManager sharedUserManager)
        {
            InitializeComponent();
            userManager = sharedUserManager;
            
            // Form yüklendiğinde başlangıç ayarları
            // lblTitle.Text = "Kullanıcı Kaydı";
            // lblTitle.ForeColor = System.Drawing.Color.White;
            // lblTitle.Location = new Point(12, 5);
            // lblTitle.Font = new System.Drawing.Font("Segoe UI", 12, FontStyle.Bold);
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string photoPath = SaveImageFromPictureBox(userPhotoPictureBox, @"Photos", userNameTextBox.Text + "_photo.jpg");
            userManager.AddUser(userNameTextBox.Text, nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text, passwordTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text,0,photoPath);
            
            userManager.ExportUsersToExcel("User.xlsx");
            MessageBox.Show("Kullanıcı başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // Anasayfa formuna geri dön
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (cikis == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Form taşıma işlemleri için mouse olayları
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
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
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void formKayıt_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void formKayıt_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void formKayıt_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        
        private void btnAddPhoto_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    if (File.Exists(filePath))
                    {
                        userPhotoPictureBox.Image = Image.FromFile(filePath);
                    }
                    else
                    {
                        MessageBox.Show("Görüntü dosyası bulunamadı!");
                    }
                }
            }
        }

        private string SaveImageFromPictureBox(PictureBox pictureBox, string directoryPath, string newFileName)
        {
            if (pictureBox.Image != null)
            {
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }
                string newFilePath = Path.Combine(directoryPath, newFileName);
                pictureBox.Image.Save(newFilePath);
                return newFilePath;
            }
            else
            {
                MessageBox.Show("Kaydedilecek fotoğraf yok.");
                return null;
            }
        }

      
    }
}
