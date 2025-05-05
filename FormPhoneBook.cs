using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp2
{
    public partial class FormPhoneBook : Form, IReminderObserver
    {
        private User currentUser;
        private int selectedRowIndex = -1;

        private Point originalPosition;

        // Form taşıma işlemleri için mouse olayları
        private bool dragging = false;
        private Point startPoint;

        public FormPhoneBook(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Surname", "Surname");
            dataGridView1.Columns.Add("PhoneNumber", "Phone Number");
            dataGridView1.Columns.Add("Address", "Address");
            dataGridView1.Columns.Add("Description", "Description");
            dataGridView1.Columns.Add("Email", "Email");

            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

            currentUser.TaskReminderManager.RegisterObserver(this);
            originalPosition = this.Location;
        }

        public void RefreshHeader(string summary)
        {
            GlobalSettings.UpdateHeader(this, summary);
        }

        public void ShakeWindow()
        {
            GlobalSettings.ShakeWindow(this);
        }

        private void FormPhoneBook_Load(object sender, EventArgs e)
        {
            currentUser.ContactBook.ImportFromExcel($"{currentUser.Username}_PhoneBook.xlsx", out string errorMessage);
            var entries = currentUser.ContactBook.GetEntries();
            foreach (var entry in entries)
            {
                dataGridView1.Rows.Add(entry.PhoneBookName, entry.PhoneBookSurname, entry.PhoneBookPhoneNumber, entry.PhoneBookAddress, entry.PhoneBookDescription, entry.PhoneBookEmail);
            }
        }

        private void btnKayıtOluştur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextBox.Text) || string.IsNullOrWhiteSpace(surnameTextBox.Text) ||
                string.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || string.IsNullOrWhiteSpace(addressTextBox.Text) ||
                string.IsNullOrWhiteSpace(descriptionTextBox.Text) || string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string errorMessage;
            currentUser.ContactBook.newEntry(nameTextBox.Text, surnameTextBox.Text, phoneNumberTextBox.Text, addressTextBox.Text, descriptionTextBox.Text, emailTextBox.Text, out errorMessage);
            currentUser.ContactBook.ExportToExcel(Convert.ToString(currentUser.Username));
            // Check if there's no error message before updating the DataGridView
            if (string.IsNullOrEmpty(errorMessage))
            {
                // Clear existing rows in the DataGridView
                dataGridView1.Rows.Clear();

                // Get the updated entries from the PhoneBook
                var entries = currentUser.ContactBook.GetEntries();

                // Add each entry to the DataGridView
                foreach (var entry in entries)
                {
                    dataGridView1.Rows.Add(entry.PhoneBookName, entry.PhoneBookSurname, entry.PhoneBookPhoneNumber, entry.PhoneBookAddress, entry.PhoneBookDescription, entry.PhoneBookEmail);
                }

                // Clear TextBoxes after adding entry
                nameTextBox.Clear();
                surnameTextBox.Clear();
                phoneNumberTextBox.Clear();
                addressTextBox.Clear();
                descriptionTextBox.Clear();
                emailTextBox.Clear();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Set the selected row index
                selectedRowIndex = e.RowIndex;
                // Retrieve data from the selected row
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                nameTextBox.Text = selectedRow.Cells["Name"].Value.ToString();
                surnameTextBox.Text = selectedRow.Cells["Surname"].Value.ToString();
                phoneNumberTextBox.Text = selectedRow.Cells["PhoneNumber"].Value.ToString();
                addressTextBox.Text = selectedRow.Cells["Address"].Value.ToString();
                descriptionTextBox.Text = selectedRow.Cells["Description"].Value.ToString();
                emailTextBox.Text = selectedRow.Cells["Email"].Value.ToString();
                tabControl1.SelectedTab=tabPage1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                // Update the selected row's cells with the values from the text boxes
                dataGridView1.Rows[selectedRowIndex].Cells["Name"].Value = nameTextBox.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Surname"].Value = surnameTextBox.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["PhoneNumber"].Value = phoneNumberTextBox.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Address"].Value = addressTextBox.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Description"].Value = descriptionTextBox.Text;
                dataGridView1.Rows[selectedRowIndex].Cells["Email"].Value = emailTextBox.Text;

                // Update the corresponding entry in the user's PhoneBook
                var updatedEntry = currentUser.ContactBook.GetEntries()[selectedRowIndex];
                updatedEntry.PhoneBookName = nameTextBox.Text;
                updatedEntry.PhoneBookSurname = surnameTextBox.Text;
                updatedEntry.PhoneBookPhoneNumber = phoneNumberTextBox.Text;
                updatedEntry.PhoneBookAddress = addressTextBox.Text;
                updatedEntry.PhoneBookDescription = descriptionTextBox.Text;
                updatedEntry.PhoneBookEmail = emailTextBox.Text;

                currentUser.ContactBook.ExportToExcel(Convert.ToString(currentUser.Username));
                // Clear the text boxes after updating
                nameTextBox.Clear();
                surnameTextBox.Clear();
                phoneNumberTextBox.Clear();
                addressTextBox.Clear();
                descriptionTextBox.Clear();
                emailTextBox.Clear();

                // Reset the selected row index
                selectedRowIndex = -1;

                MessageBox.Show("Giriş başarıyla güncellendi.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Güncellemek için lütfen bir satır seçin.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex >= 0)
            {
                // Remove the selected row from the DataGridView
                dataGridView1.Rows.RemoveAt(selectedRowIndex);

                // Remove the corresponding entry from the PhoneBook
                currentUser.ContactBook.RemoveEntryAt(selectedRowIndex);

                // Clear the text boxes after deletion
                nameTextBox.Clear();
                surnameTextBox.Clear();
                phoneNumberTextBox.Clear();
                addressTextBox.Clear();
                descriptionTextBox.Clear();
                emailTextBox.Clear();

                currentUser.ContactBook.ExportToExcel(Convert.ToString(currentUser.Username));

                // Reset the selected row index
                selectedRowIndex = -1;

                MessageBox.Show("Giriş başarıyla silindi.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silmek için lütfen bir satır seçin.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            currentUser.ContactBook.ClearEntries();
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
        
        // Telefon numarası alanı değiştiğinde otomatik format ekleme
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
        }
    }
}
