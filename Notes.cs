using System;

namespace WindowsFormsApp2
{
    public class Note
    {
        // Her not için benzersiz kimlik numarası
        public int NoteId { get; set; }

        // Notun içeriği
        public string NoteContent { get; set; }

        // Notun oluşturulma veya son güncellenme zamanı
        public DateTime Timestamp { get; set; }

        // Varsayılan yapıcı - yalnızca zaman bilgisini ayarlar
        public Note()
        {
            Timestamp = DateTime.Now;
        }

        // ID ve içerik ile not oluşturur, zaman otomatik atanır
        public Note(int id, string content) : this()
        {
            NoteId = id;
            NoteContent = content;
        }

        // ID, içerik ve özel bir zaman ile not oluşturur
        public Note(int ıd, string content, DateTime timestamp) : this(ıd, content)
        {
            Timestamp = timestamp;
        }

        // Notun içeriğini günceller ve zaman damgasını şimdiye çeker
        public void UpdateContent(string newContent)
        {
            NoteContent = newContent;
            Timestamp = DateTime.Now;
        }
    }
}
