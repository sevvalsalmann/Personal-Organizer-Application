using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Web.Caching;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormProfile : Form, IReminderObserver
    {
        private bool mouseDown;
        private Point lastLocation;

        private User currentUser;
        private UserManager userManager;

        private string newFilePath;

        // Her alan için ayrı bir Originator ve Caretaker
        private Originator userNameOriginator = new Originator();
        private Caretaker userNameCaretaker = new Caretaker();
        
        private Originator nameOriginator = new Originator();
        private Caretaker nameCaretaker = new Caretaker();
        
        private Originator surnameOriginator = new Originator();
        private Caretaker surnameCaretaker = new Caretaker();
        
        private Originator emailOriginator = new Originator();
        private Caretaker emailCaretaker = new Caretaker();
        
        private Originator passwordOriginator = new Originator();
        private Caretaker passwordCaretaker = new Caretaker();
        
        private Originator phoneNumberOriginator = new Originator();
        private Caretaker phoneNumberCaretaker = new Caretaker();
        
        private Originator addressOriginator = new Originator();
        private Caretaker addressCaretaker = new Caretaker();

        private Point originalPosition;

        public FormProfile(User currentUser, UserManager userManager)
        {
            InitializeComponent();
            
            currentUser.TaskReminderManager.RegisterObserver(this);
            originalPosition = this.Location;
            this.currentUser = currentUser;
            this.userManager = userManager;

            // Load user data into form fields
            usernameTextBox.Text = currentUser.Username;
            nameTextBox.Text = currentUser.Name;
            surnameTextBox.Text = currentUser.Surname;
            emailTextBox.Text = currentUser.EmailAddress;
            passwordTextBox.Text = currentUser.UserPassword;
            phoneNumberTextBox.Text = currentUser.ContactNumber;
            addressTextBox.Text = currentUser.AddressDescription;
            salaryLabel.Text = "Maaş: " + currentUser.UserSalary;
            
            // Önce Base64 formatındaki resmi yüklemeyi dene, yoksa dosya yolunu dene
            Image profileImage = null;
            
            if (!string.IsNullOrEmpty(currentUser.ProfilePhotoBase64))
            {
                profileImage = ConvertBase64ToImage(currentUser.ProfilePhotoBase64);
            }
            
            // Base64'ten yüklenemezse, dosya yolundan yüklemeyi dene
            if (profileImage == null && File.Exists(currentUser.ProfilePhotoPath))
            {
                try
                {
                    profileImage = Image.FromFile(currentUser.ProfilePhotoPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading user photo from file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
            if (profileImage != null)
            {
                userPhotoPictureBox.Image = profileImage;
            }
            else if (!string.IsNullOrEmpty(currentUser.ProfilePhotoPath))
            {
                MessageBox.Show("User photo not found at the specified path: " + currentUser.ProfilePhotoPath, "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Her alan için başlangıç değerlerini kaydet
            userNameOriginator.State = usernameTextBox.Text;
            userNameCaretaker.SaveState(userNameOriginator.SaveState());
            
            nameOriginator.State = nameTextBox.Text;
            nameCaretaker.SaveState(nameOriginator.SaveState());
            
            surnameOriginator.State = surnameTextBox.Text;
            surnameCaretaker.SaveState(surnameOriginator.SaveState());
            
            emailOriginator.State = emailTextBox.Text;
            emailCaretaker.SaveState(emailOriginator.SaveState());
            
            passwordOriginator.State = passwordTextBox.Text;
            passwordCaretaker.SaveState(passwordOriginator.SaveState());
            
            phoneNumberOriginator.State = phoneNumberTextBox.Text;
            phoneNumberCaretaker.SaveState(phoneNumberOriginator.SaveState());
            
            addressOriginator.State = addressTextBox.Text;
            addressCaretaker.SaveState(addressOriginator.SaveState());
        }

        public void RefreshHeader(string summary)
        {
            GlobalSettings.UpdateHeader(this, summary);
        }

        public void ShakeWindow()
        {
            GlobalSettings.ShakeWindow(this);
        }

        private void btnChangeUserİnfo_Click(object sender, EventArgs e)
        {
            string newPhotoPath = SavePictureBoxImage(userPhotoPictureBox);
            string photoBase64 = ConvertPictureBoxImageToBase64(userPhotoPictureBox);
            
            string errorMessage = currentUser.UpdateUserInfo(
                usernameTextBox.Text, nameTextBox.Text, surnameTextBox.Text, emailTextBox.Text,
                passwordTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text, newPhotoPath, photoBase64);

            // Her alan için durumu kaydet
            userNameOriginator.State = usernameTextBox.Text;
            userNameCaretaker.SaveState(userNameOriginator.SaveState());
            
            nameOriginator.State = nameTextBox.Text;
            nameCaretaker.SaveState(nameOriginator.SaveState());
            
            surnameOriginator.State = surnameTextBox.Text;
            surnameCaretaker.SaveState(surnameOriginator.SaveState());
            
            emailOriginator.State = emailTextBox.Text;
            emailCaretaker.SaveState(emailOriginator.SaveState());
            
            passwordOriginator.State = passwordTextBox.Text;
            passwordCaretaker.SaveState(passwordOriginator.SaveState());
            
            phoneNumberOriginator.State = phoneNumberTextBox.Text;
            phoneNumberCaretaker.SaveState(phoneNumberOriginator.SaveState());
            
            addressOriginator.State = addressTextBox.Text;
            addressCaretaker.SaveState(addressOriginator.SaveState());

            if (string.IsNullOrEmpty(errorMessage))
            {
                userManager.ExportUsersToExcel("User.xlsx");
                MessageBox.Show("Kullanıcı bilgileri başarıyla güncellendi.", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(errorMessage, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormProfile_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void FormProfile_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
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

        public static string SavePictureBoxImage(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                try
                {
                    string directoryPath = "Photos";
                    if (!Directory.Exists(directoryPath))
                    {
                        Directory.CreateDirectory(directoryPath);
                    }
                    string fileName = Guid.NewGuid().ToString() + ".jpg";

                    string filePath = Path.Combine(directoryPath, fileName);

                    pictureBox.Image.Save(filePath);

                    return filePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Görüntü kaydedilirken bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("Kaydedilecek görüntü yok.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static string ConvertPictureBoxImageToBase64(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        byte[] imageBytes = ms.ToArray();
                        return Convert.ToBase64String(imageBytes);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Görüntü Base64'e dönüştürülürken bir hata oluştu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return string.Empty;
                }
            }
            else
            {
                return string.Empty;
            }
        }
        
        public static Image ConvertBase64ToImage(string base64String)
        {
            if (string.IsNullOrEmpty(base64String))
                return null;
                
            try
            {
                byte[] imageBytes = Convert.FromBase64String(base64String);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    return Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Base64'ten görüntüye dönüştürme hatası: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                var memento = userNameCaretaker.Undo();
                if (memento != null)
                {
                    userNameOriginator.RestoreState(memento);
                    usernameTextBox.Text = userNameOriginator.State;
                }
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                var memento = userNameCaretaker.Redo();
                if (memento != null)
                {
                    userNameOriginator.RestoreState(memento);
                    usernameTextBox.Text = userNameOriginator.State;
                }
            }
        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                var memento = nameCaretaker.Undo();
                if (memento != null)
                {
                    nameOriginator.RestoreState(memento);
                    nameTextBox.Text = nameOriginator.State;
                }
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                var memento = nameCaretaker.Redo();
                if (memento != null)
                {
                    nameOriginator.RestoreState(memento);
                    nameTextBox.Text = nameOriginator.State;
                }
            }
        }

        private void txtSurname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                var memento = surnameCaretaker.Undo();
                if (memento != null)
                {
                    surnameOriginator.RestoreState(memento);
                    surnameTextBox.Text = surnameOriginator.State;
                }
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                var memento = surnameCaretaker.Redo();
                if (memento != null)
                {
                    surnameOriginator.RestoreState(memento);
                    surnameTextBox.Text = surnameOriginator.State;
                }
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                var memento = emailCaretaker.Undo();
                if (memento != null)
                {
                    emailOriginator.RestoreState(memento);
                    emailTextBox.Text = emailOriginator.State;
                }
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                var memento = emailCaretaker.Redo();
                if (memento != null)
                {
                    emailOriginator.RestoreState(memento);
                    emailTextBox.Text = emailOriginator.State;
                }
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                var memento = passwordCaretaker.Undo();
                if (memento != null)
                {
                    passwordOriginator.RestoreState(memento);
                    passwordTextBox.Text = passwordOriginator.State;
                }
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                var memento = passwordCaretaker.Redo();
                if (memento != null)
                {
                    passwordOriginator.RestoreState(memento);
                    passwordTextBox.Text = passwordOriginator.State;
                }
            }
        }

        private void txtPhoneNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                var memento = phoneNumberCaretaker.Undo();
                if (memento != null)
                {
                    phoneNumberOriginator.RestoreState(memento);
                    phoneNumberTextBox.Text = phoneNumberOriginator.State;
                }
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                var memento = phoneNumberCaretaker.Redo();
                if (memento != null)
                {
                    phoneNumberOriginator.RestoreState(memento);
                    phoneNumberTextBox.Text = phoneNumberOriginator.State;
                }
            }
        }

        private void txtAdress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.Z)
            {
                var memento = addressCaretaker.Undo();
                if (memento != null)
                {
                    addressOriginator.RestoreState(memento);
                    addressTextBox.Text = addressOriginator.State;
                }
            }
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                var memento = addressCaretaker.Redo();
                if (memento != null)
                {
                    addressOriginator.RestoreState(memento);
                    addressTextBox.Text = addressOriginator.State;
                }
            }
        }
        
        // Her alan için değişiklikleri kaydetmek için TextChanged olaylarını ekleyelim
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            userNameOriginator.State = usernameTextBox.Text;
            userNameCaretaker.SaveState(userNameOriginator.SaveState());
        }
        
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            nameOriginator.State = nameTextBox.Text;
            nameCaretaker.SaveState(nameOriginator.SaveState());
        }
        
        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            surnameOriginator.State = surnameTextBox.Text;
            surnameCaretaker.SaveState(surnameOriginator.SaveState());
        }
        
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            emailOriginator.State = emailTextBox.Text;
            emailCaretaker.SaveState(emailOriginator.SaveState());
        }
        
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            passwordOriginator.State = passwordTextBox.Text;
            passwordCaretaker.SaveState(passwordOriginator.SaveState());
        }
        
        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
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
            
            // Memento için durumu kaydet
            phoneNumberOriginator.State = phoneNumberTextBox.Text;
            phoneNumberCaretaker.SaveState(phoneNumberOriginator.SaveState());
        }
        
        private void txtAdress_TextChanged(object sender, EventArgs e)
        {
            addressOriginator.State = addressTextBox.Text;
            addressCaretaker.SaveState(addressOriginator.SaveState());
        }
    }
}
/* Memento sınıfı, tek bir String değerin durumunu saklamak için kullanılır */
public class Memento
{
    public string State { get; }
    
    public Memento(string state)
    {
        State = state;
    }
}

/* Originator sınıfı, durumu saklama ve geri yüklemede kullanılır */
public class Originator
{
    // Originator'un şu anki durumu
    public string State { get; set; }
    
    // Mevcut durumu bir Memento nesnesi olarak kaydet
    public Memento SaveState()
    {
        return new Memento(State);
    }
    
    // Verilen Memento nesnesinden durumu geri yükle
    public void RestoreState(Memento memento)
    {
        State = memento.State;
    }
}

/* Caretaker sınıfı, 'undo' ve 'redo' işlemleri için kullanılır */
public class Caretaker
{
    // Geri alma (undo) işlemleri için stack
    private readonly Stack<Memento> _undoStack = new Stack<Memento>();
    
    // İleri alma (redo) işlemleri için stack
    private readonly Stack<Memento> _redoStack = new Stack<Memento>();
    
    // Durumu sakla ve redo stack'ini temizle
    public void SaveState(Memento memento)
    {
        _undoStack.Push(memento);
        _redoStack.Clear(); // Yeni bir işlem yapıldığında redo stack temizlenir
    }
    
    // Geri alma işlemi gerçekleştir
    public Memento Undo()
    {
        if (_undoStack.Count > 1) // En az bir önceki durum olmalı
        {
            var currentState = _undoStack.Pop();
            _redoStack.Push(currentState);
            return _undoStack.Peek(); // Bir önceki durumu döndür ama stack'ten çıkarma
        }
        return null;
    }
    
    // İleri alma işlemi gerçekleştir
    public Memento Redo()
    {
        if (_redoStack.Count > 0)
        {
            var memento = _redoStack.Pop();
            _undoStack.Push(memento);
            return memento;
        }
        return null;
    }
}