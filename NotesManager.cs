using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Globalization;

namespace WindowsFormsApp2
{
    public class NotesManager
    {
        // Tüm notların tutulduğu liste
        private List<Note> noteList;

        // Bir sonraki notun ID'si için sayaç
        private int nextAvailableId;

        public NotesManager()
        {
            noteList = new List<Note>();
            nextAvailableId = 1; // Başlangıç ID değeri
        }

        // Yeni bir not ekler
        public void InsertNote(string noteContent)
        {
            var currentNote = new Note(nextAvailableId, noteContent);
            noteList.Add(currentNote);
            nextAvailableId++; // ID değerini bir artır
        }

        // Belirli bir ID'ye sahip notu düzenler
        public void EditNote(int id, string newContent)
        {
            var note = noteList.FirstOrDefault(n => n.NoteId == id);
            if (note != null)
            {
                note.UpdateContent(newContent);
            }
            else
            {
                throw new Exception("Not bulunamadı.");
            }
        }

        // Belirli bir ID'ye sahip notu siler
        public void DeleteNote(int id)
        {
            var note = noteList.FirstOrDefault(n => n.NoteId == id);
            if (note != null)
            {
                noteList.Remove(note);
            }
            else
            {
                throw new Exception("Not bulunamadı.");
            }
        }

        // Tüm notların listesini döndürür
        public List<Note> GetNotesList()
        {
            return noteList;
        }

        // Belirli bir ID ile notu getirir
        public Note GetNoteById(int id)
        {
            var note = noteList.FirstOrDefault(n => n.NoteId == id);
            if (note != null)
            {
                return note;
            }
            else
            {
                throw new Exception("Not bulunamadı.");
            }
        }

        // Tüm notları bir Excel dosyasına yazar
        public void WriteNotesToExcelFile(string userName)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Notes");

                // Başlık hücreleri
                worksheet.Cell("A1").Value = "ID";
                worksheet.Cell("B1").Value = "Content";
                worksheet.Cell("C1").Value = "Timestamp";

                // Notları hücrelere yaz
                for (int i = 0; i < noteList.Count; i++)
                {
                    var note = noteList[i];
                    worksheet.Cell(i + 2, 1).Value = note.NoteId;
                    worksheet.Cell(i + 2, 2).Value = note.NoteContent;
                    worksheet.Cell(i + 2, 3).Value = note.Timestamp.ToString("yyyy-MM-dd HH:mm:ss");
                }

                // Dosya ismini kullanıcı adına göre belirle
                string fileName = $"{userName}_Notes.xlsx";

                // Otomatik sütun genişliği ayarı
                worksheet.Columns().AdjustToContents();

                // Excel dosyasını kaydet
                workbook.SaveAs(fileName);
            }
        }

        // Excel dosyasından notları içeri aktarır
        public void LoadNotesFromExcel(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed().Skip(1); // Başlık satırını atla

                    foreach (var row in rows)
                    {
                        try
                        {
                            var id = row.Cell(1).GetValue<int>();
                            var content = row.Cell(2).GetValue<string>();
                            var timestampString = row.Cell(3).GetValue<string>(); // Zamanı string olarak al

                            DateTime timestamp;
                            // Tarih formatını doğru şekilde ayrıştır
                            if (DateTime.TryParseExact(timestampString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out timestamp))
                            {
                                var note = new Note(id, content, timestamp);
                                noteList.Add(note);

                                // ID değeri güncellenir
                                if (id >= nextAvailableId)
                                {
                                    nextAvailableId = id + 1;
                                }
                            }
                            else
                            {
                                throw new Exception($"Geçersiz tarih formatı: {timestampString}");
                            }
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine($"İlgili satır işlenirken bir hata oluştu: {row.RowNumber()}: {exception.Message}");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Dosya mevcut değil.");
            }
        }
    }
}
