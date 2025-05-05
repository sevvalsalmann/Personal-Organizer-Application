using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;

namespace WindowsFormsApp2
{
    public partial class FormNotes : Form, IReminderObserver
    {
        private User currentUser; // Şu anki oturum açmış kullanıcı
        private Point originalPosition; // Pencerenin orijinal konumu (titretme için)

        public FormNotes(User currentUser)
        {
            InitializeComponent();
            this.currentUser = currentUser;

            // DataGridView kolonlarını ekle
            notesDataGridView.Columns.Add("Id", "Id");
            notesDataGridView.Columns.Add("Timestamp", "Timestamp");

            // DataGridView ayarları
            notesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            notesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Notları Excel'den yükle
            currentUser.NotesManager.LoadNotesFromExcel($"{currentUser.Username}_Notes.xlsx");

            // Notları tabloya yükle
            LoadNotes();

            // Hatırlatma sistemi için observer kaydı yap
            currentUser.TaskReminderManager.RegisterObserver(this);

            // Orijinal pozisyonu sakla (shake effect için)
            originalPosition = this.Location;
        }

        // Başlık güncelleme işlemi (diğer sınıflarla entegre)
        public void RefreshHeader(string summary)
        {
            GlobalSettings.UpdateHeader(this, summary);
        }

        // Pencereyi sallamak için (hatırlatma geldiğinde)
        public void ShakeWindow()
        {
            GlobalSettings.ShakeWindow(this);
        }

        // Form yüklendiğinde çalışacak olay (şu an boş)
        private void FormNotes_Load(object sender, EventArgs e)
        {

        }

        // Notları tabloya yükler
        private void LoadNotes()
        {
            notesDataGridView.Rows.Clear(); // Önceki satırları temizle
            var notes = currentUser.NotesManager.GetNotesList(); // Tüm notları al

            // Her not için tabloya satır ekle
            foreach (var note in notes)
            {
                bool exists = false;
                foreach (DataGridViewRow row in notesDataGridView.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == note.NoteId.ToString())
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    notesDataGridView.Rows.Add(note.NoteId, note.Timestamp);
                }
            }
        }

        // Yeni not ekleme butonu
        private void btnAddNote_Click(object sender, EventArgs e)
        {
            string noteContent = noteContentTextBox.Text; // Not içeriğini al
            if (!string.IsNullOrEmpty(noteContent))
            {
                currentUser.NotesManager.InsertNote(noteContent); // Yeni not ekle
                noteContentTextBox.Clear(); // Textbox'ı temizle
                LoadNotes(); // Tabloda güncelle
                currentUser.NotesManager.WriteNotesToExcelFile(Convert.ToString(currentUser.Username)); // Excel'e kaydet
            }
            else
            {
                MessageBox.Show("Not içeriği boş olamaz.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Not güncelleme butonu
        private void btnUpdateNote_Click(object sender, EventArgs e)
        {
            if (notesDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = notesDataGridView.SelectedRows[0];

                int selectedNoteId = Convert.ToInt32(selectedRow.Cells[0].Value);
                string updatedContent = noteContentTextBox.Text;

                try
                {
                    currentUser.NotesManager.EditNote(selectedNoteId, updatedContent); // Notu güncelle
                    LoadNotes(); // Tabloda yenile
                    currentUser.NotesManager.WriteNotesToExcelFile(currentUser.Username); // Excel'e yaz
                    MessageBox.Show("Not başarıyla güncellendi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Not güncellenemedi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellemek için lütfen bir not seçin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Not silme butonu
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (notesDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = notesDataGridView.SelectedRows[0];

                int selectedNoteId = Convert.ToInt32(selectedRow.Cells[0].Value);

                try
                {
                    currentUser.NotesManager.DeleteNote(selectedNoteId); // Notu sil
                    LoadNotes(); // Tabloda yenile
                    currentUser.NotesManager.WriteNotesToExcelFile(currentUser.Username); // Excel'e yaz
                    MessageBox.Show("Not başarıyla silindi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Not silinemedi: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Silmek için lütfen bir not seçin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Geri butonu (formu kapat)
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Pencereyi simge durumuna küçült
        private void btnAlt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // Uygulamadan çıkma butonu
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult cikis = MessageBox.Show("Uygulamadan çıkış yapmak istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.OKCancel);
            if (cikis == DialogResult.OK)
            {
                this.Close();
                Application.Exit(); // Tüm uygulamayı kapat
            }
            else { return; }
        }

        // DataGridView'de bir hücreye tıklanınca not içeriğini textbox'a yükle
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < notesDataGridView.Rows.Count)
            {
                DataGridViewRow row = notesDataGridView.Rows[e.RowIndex];
                if (row.Cells[0].Value != null) // Hücre değeri boş değilse
                {
                    int selectedNoteId = Convert.ToInt32(row.Cells[0].Value); // Not ID'sini al
                    var selectedNote = currentUser.NotesManager.GetNoteById(selectedNoteId); // Note nesnesini getir
                    noteContentTextBox.Text = selectedNote.NoteContent; // Textbox'a içeriği yaz
                }
            }
        }
    }
}
