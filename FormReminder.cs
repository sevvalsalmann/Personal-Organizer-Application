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
    public partial class FormReminder : Form, IReminderObserver
    {
        private const int shakeIntensity = 5; // Pencere titremesi için şiddet değeri
        private const int shakeDuration = 1000; // Titreme süresi (ms)
        private Point originalPosition;

        // Form taşıma işlemleri için değişkenler
        private bool dragging = false;
        private Point startPoint;

        private User currentUser;
        private UserManager userManager;

        private int selectedRowIndex = -1;

        /// <summary>
        /// FormReminder başlatıcı. Kullanıcı ve kullanıcı yöneticisini alır.
        /// </summary>
        public FormReminder(User currentUser, UserManager userManager)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.userManager = userManager;
            currentUser.TaskReminderManager.RegisterObserver(this);
            UpdateReminderList();
            originalPosition = this.Location;

            // ComboBox varsayılan seçenekler
            reminderTypeComboBox.Items.Clear();
            reminderTypeComboBox.Items.Add("Task");
            reminderTypeComboBox.Items.Add("Meeting");
            reminderTypeComboBox.SelectedIndex = 0;
        }

        // Formun taşınabilmesi için mouse basıldığında
        private void FormReminder_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        // Mouse bırakıldığında taşıma işlemini bitir
        private void FormReminder_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        // Mouse hareket ettikçe formu taşı
        private void FormReminder_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void FormReminder_Load(object sender, EventArgs e)
        {
            UpdateReminderList();
        }

        // Kapatma butonu
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Uygulamayı Kapatmak İstediğinize Emin Misiniz??", "Uyarı", MessageBoxButtons.OKCancel);
            if (cikis == DialogResult.OK)
            {
                this.Close();
                Application.Exit();
            }
        }

        // Simge durumuna küçültme
        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Geri butonu
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Yeni hatırlatma ekler.
        /// </summary>
        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            ReminderFactory factory = reminderTypeComboBox.SelectedItem.ToString() == "Meeting"
                ? (ReminderFactory)new MeetingReminderFactory()
                : new TaskReminderFactory();

            Reminder reminder = factory.CreateReminder();
            reminder.ReminderDate = dateTimePicker1.Value;
            reminder.Summary = summaryTextBox.Text;
            reminder.FullDescription = descriptionTextBox.Text;

            reminder.IsTriggered = false;

            currentUser.TaskReminderManager.InsertReminder(reminder);
            UpdateReminderList();
            currentUser.TaskReminderManager.ExportRemindersToExcel(Convert.ToString(currentUser.Username));
            MessageBox.Show("Başarıyla Eklendi");
            descriptionTextBox.Text = "";
            summaryTextBox.Text = "";
            remindersDataGridView.ClearSelection();
        }

        /// <summary>
        /// Seçili hatırlatmayı günceller.
        /// </summary>
        private void btnUpdateReminder_Click(object sender, EventArgs e)
        {
            if (remindersDataGridView.SelectedRows.Count > 0)
            {
                int index = remindersDataGridView.SelectedRows[0].Index;
                Reminder reminder = currentUser.TaskReminderManager.ListReminders()[index];
                reminder.ReminderDate = dateTimePicker1.Value;
                reminder.Summary = summaryTextBox.Text;
                reminder.FullDescription = descriptionTextBox.Text;
                currentUser.TaskReminderManager.EditReminder(index, reminder);
                UpdateReminderList();
                currentUser.TaskReminderManager.ExportRemindersToExcel(Convert.ToString(currentUser.Username));
                MessageBox.Show("Baaşrıyla Güncellendi!");
                summaryTextBox.Text = "";
                descriptionTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Güncellenecek Bilgiyi Seçiniz");
            }
        }

        /// <summary>
        /// Seçili hatırlatmayı siler.
        /// </summary>
        private void btnDeleteReminder_Click(object sender, EventArgs e)
        {
            if (remindersDataGridView.SelectedRows.Count > 0)
            {
                int index = remindersDataGridView.SelectedRows[0].Index;
                currentUser.TaskReminderManager.DeleteReminder(index);
                UpdateReminderList();
                currentUser.TaskReminderManager.ExportRemindersToExcel(Convert.ToString(currentUser.Username));
                MessageBox.Show("Başarıyla Silindi");
                descriptionTextBox.Text = "";
                summaryTextBox.Text = "";
                remindersDataGridView.ClearSelection();
            }
            else
            {
                MessageBox.Show("Silinecek Bilgiyi Seçiniz");
            }
        }

        /// <summary>
        /// Hatırlatma listesini günceller (GridView'i doldurur).
        /// </summary>
        private void UpdateReminderList()
        {
            remindersDataGridView.Rows.Clear();
            foreach (Reminder reminder in currentUser.TaskReminderManager.ListReminders())
            {
                remindersDataGridView.Rows.Add(reminder.ReminderDate.ToString("dd.MM.yyyy HH:mm"), reminder.Summary, reminder.FullDescription);
            }
        }

        /// <summary>
        /// Başlığı günceller (observer metodudur).
        /// </summary>
        public void RefreshHeader(string summary)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<string>(RefreshHeader), summary);
            }
            else
            {
                this.Text = summary;
            }
        }

        /// <summary>
        /// Formu titretme animasyonu (observer metodudur).
        /// </summary>
        public void ShakeWindow()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(ShakeWindow));
            }
            else
            {
                Random random = new Random();
                int shakeIterations = shakeDuration / 5;
                Point originalPosition = this.Location;

                for (int i = 0; i < shakeIterations; i++)
                {
                    int offsetX = random.Next(-shakeIntensity, shakeIntensity + 1);
                    int offsetY = random.Next(-shakeIntensity, shakeIntensity + 1);
                    this.Location = new Point(originalPosition.X + offsetX, originalPosition.Y + offsetY);
                    System.Threading.Thread.Sleep(5);
                    this.Location = originalPosition;
                }

                this.Location = originalPosition;
            }
        }

        /// <summary>
        /// DataGridView'den tıklanan hücreyi alır, bilgileri form alanlarına yerleştirir.
        /// </summary>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < remindersDataGridView.Rows.Count)
            {
                selectedRowIndex = e.RowIndex;
                DataGridViewRow selectedRow = remindersDataGridView.Rows[e.RowIndex];
                summaryTextBox.Text = selectedRow.Cells["Özet"].Value.ToString();
                descriptionTextBox.Text = selectedRow.Cells["Açıklama"].Value.ToString();
                dateTimePicker1.Value = DateTime.ParseExact(selectedRow.Cells["Zaman"].Value.ToString(), "dd.MM.yyyy HH:mm", null);
                remainderTabControl1.SelectedTab = tabPage1;
            }
        }
    }
}
