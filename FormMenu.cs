using salary_calculate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FormMenu : Form, IReminderObserver
    {
        private bool mouseDown;
        private Point lastLocation;

        private User currentUser;
        private UserManager userManager;

        // EKLEME
        private Point originalPosition;
        //
        public FormMenu(User currentUser, UserManager userManager)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.userManager = userManager;

            InitializeUserManagementButton();
            currentUser.TaskReminderManager.ImportRemindersFromExcel($"{currentUser.Username}_Reminder.xlsx", out string errorMessage);
            // EKLEME
            currentUser.TaskReminderManager.RegisterObserver(this);
            originalPosition = this.Location;
            
            // Kullanıcı bilgisini göster
            UpdateUserInfo();
        }

        private void UpdateUserInfo()
        {
            userInfoLabel.Text = $"Kullanıcı: {currentUser.Username}";
            greetingLabel.Text = $"Hoş Geldiniz!";
        }

        public void RefreshHeader(string summary)
        {
            GlobalSettings.UpdateHeader(this, summary);
        }

        public void ShakeWindow()
        {
            GlobalSettings.ShakeWindow(this);
        }

        private void InitializeUserManagementButton()
        {
            if (currentUser.Type.ToString() != "Admin")
            {
                userManagementButton.Visible = false;
                userManagementButton.Enabled = false;
            }
            else
            {
                userManagementButton.Visible = true;
                userManagementButton.Enabled = true;
            }
        }
        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNotes form = new FormNotes(currentUser);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Hesaptan çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (cikis == DialogResult.OK)
            {
                currentUser.TaskReminderManager.RemoveAllReminders();
                this.Close();
            }
            else { return; }
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
                Application.Exit();
            }
            else { return; }
        }

        private void FormMenu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void FormMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void FormMenu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnPhoneBook_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            FormPhoneBook form = new FormPhoneBook(currentUser);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnOpenProfile_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormProfile form = new FormProfile(currentUser, userManager);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnReminder_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormReminder form = new FormReminder(currentUser, userManager);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }

        private void btnUserManagement_Click(object sender, EventArgs e)
        {
            if (currentUser.Type.ToString() != "Admin")
            {
                MessageBox.Show("Sadece Admin Bu Sekmeye Erişebilir!");
            }
            else
            {
                this.Hide();
                FormUserManegement form = new FormUserManegement(userManager);
                form.FormClosed += Form_FormClosed;
                form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSalaryCalculator form = new FormSalaryCalculator(currentUser,userManager);
            form.FormClosed += Form_FormClosed;
            form.ShowDialog();
        }
    }
    public static class GlobalSettings
    {
        public static int shakeIntensity { get; set; } = 5;
        public static int shakeDuration { get; set; } = 1000;

        public static void ShakeWindow(Form form)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new Action(() => ShakeWindow(form)));
            }
            else
            {
                Random random = new Random();
                int shakeIterations = shakeDuration / 5; // Shake faster by reducing iterations
                Point originalPosition = form.Location; // Ensure originalPosition is set correctly

                for (int i = 0; i < shakeIterations; i++)
                {
                    int offsetX = random.Next(-shakeIntensity, shakeIntensity + 1);
                    int offsetY = random.Next(-shakeIntensity, shakeIntensity + 1);
                    form.Location = new Point(originalPosition.X + offsetX, originalPosition.Y + offsetY);
                    System.Threading.Thread.Sleep(5); // Shake faster by reducing sleep duration
                    form.Location = originalPosition; // Reset to original position after each shake iteration
                }

                form.Location = originalPosition; // Ensure the form is in its original position at the end
            }
        }

        public static void UpdateHeader(Form form, string summary)
        {
            if (form.InvokeRequired)
            {
                form.Invoke(new Action(() => UpdateHeader(form, summary)));
            }
            else
            {
                form.Text = summary;
            }
        }
    }
}

