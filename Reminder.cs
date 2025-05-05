using ClosedXML.Excel; // Excel dosyası oluşturmak ve okumak için
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers; // Zamanlayıcı kullanımı için
using System.Windows.Forms;
using System.IO;
using DocumentFormat.OpenXml.Spreadsheet;

namespace WindowsFormsApp2
{
    // Observer (gözlemci) arayüzü - UI'yi bilgilendirmek için kullanılır
    public interface IReminderObserver
    {
        void RefreshHeader(string summary); // Başlık güncellemesi
        void ShakeWindow(); // Pencereyi titretme efekti
    }

    // Hatırlatıcıların temel sınıfı
    public abstract class Reminder
    {
        public DateTime ReminderDate { get; set; } // Hatırlatma zamanı
        public string Summary { get; set; } // Kısa açıklama
        public string FullDescription { get; set; } // Detaylı açıklama
        public bool IsTriggered { get; set; } // Hatırlatmanın tetiklenip tetiklenmediği

        // Hatırlatıcı türünü döndürür (override edilecek)
        public virtual string GetReminderType()
        {
            return "Reminder";
        }

        // Tetiklendiğinde yapılacak işlem
        public abstract void Notify();
    }

    // Toplantı hatırlatıcısı sınıfı
    public class MeetingReminder : Reminder
    {
        public override void Notify()
        {
            Console.WriteLine("Meeting Reminder: " + Summary);
        }

        public override string GetReminderType()
        {
            return "Meeting Reminder";
        }
    }

    // Görev hatırlatıcısı sınıfı
    public class TaskReminder : Reminder
    {
        public override void Notify()
        {
            Console.WriteLine("Task Reminder: " + Summary);
        }

        public override string GetReminderType()
        {
            return "Task Reminder";
        }
    }

    // Hatırlatıcı üretim (Factory) sınıfı
    public abstract class ReminderFactory
    {
        public abstract Reminder CreateReminder();
    }

    // Toplantı hatırlatıcısı üreticisi
    public class MeetingReminderFactory : ReminderFactory
    {
        public override Reminder CreateReminder()
        {
            return new MeetingReminder();
        }
    }

    // Görev hatırlatıcısı üreticisi
    public class TaskReminderFactory : ReminderFactory
    {
        public override Reminder CreateReminder()
        {
            return new TaskReminder();
        }
    }

    // Hatırlatıcı yöneticisi - tüm işlemleri kontrol eder
    public class ReminderManager
    {
        private List<Reminder> reminders = new List<Reminder>(); // Tüm hatırlatıcıları tutar
        private List<IReminderObserver> observers = new List<IReminderObserver>(); // UI gözlemcilerini tutar
        private System.Timers.Timer checkTimer; // Periyodik olarak kontrol eden zamanlayıcı

        public ReminderManager()
        {
            checkTimer = new System.Timers.Timer(3000); // 3 saniyede bir kontrol
            checkTimer.Elapsed += HandleTimerElapsed;
            checkTimer.Start();
        }

        // Yeni hatırlatıcı ekleme
        public void InsertReminder(Reminder reminder)
        {
            reminders.Add(reminder);
            NotifyObservers(reminder.Summary); // UI'ye bildir
        }

        // Var olan hatırlatıcıyı düzenleme
        public void EditReminder(int index, Reminder reminder)
        {
            if (index >= 0 && index < reminders.Count)
            {
                var oldReminder = reminders[index];
                reminders[index] = reminder;

                // Önceden tetiklenmişse ve yeni tarih geçmişteyse tekrar tetikle
                if (oldReminder.IsTriggered && reminder.ReminderDate <= DateTime.Now)
                {
                    NotifyShake(reminder);
                }

                NotifyObservers(reminder.Summary); // UI'yi güncelle
            }
        }

        // Hatırlatıcı silme
        public void DeleteReminder(int index)
        {
            if (index >= 0 && index < reminders.Count)
            {
                reminders.RemoveAt(index);
            }
        }

        // Tüm hatırlatıcıları getir
        public List<Reminder> GetReminders()
        {
            return reminders;
        }

        // Tüm hatırlatıcıları temizle
        public void RemoveAllReminders()
        {
            reminders.Clear();
        }

        // Yeni liste olarak hatırlatıcıları döndür
        public List<Reminder> ListReminders()
        {
            return new List<Reminder>(reminders);
        }

        // Gözlemci ekle
        public void RegisterObserver(IReminderObserver observer)
        {
            observers.Add(observer);
        }

        // Gözlemci çıkar
        public void UnregisterObserver(IReminderObserver observer)
        {
            observers.Remove(observer);
        }

        // UI'deki başlığı güncelle
        private void NotifyObservers(string summary)
        {
            foreach (var observer in observers)
            {
                observer.RefreshHeader(summary);
            }
        }

        // Hatırlatmayı titretme ve mesaj gösterme
        private void NotifyShake(Reminder reminder)
        {
            if (Application.OpenForms[0].InvokeRequired)
            {
                // UI thread'ine geç
                Application.OpenForms[0].Invoke(new Action(() =>
                {
                    foreach (var observer in observers)
                    {
                        observer.ShakeWindow(); // Pencereyi titret
                    }
                    MessageBox.Show($"{reminder.GetReminderType()}: {reminder.Summary}", "Reminder Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }));
            }
            else
            {
                foreach (var observer in observers)
                {
                    observer.ShakeWindow();
                }
                MessageBox.Show($"{reminder.GetReminderType()}: {reminder.Summary}", "Reminder Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Zamanlayıcı her çalıştığında hatırlatıcıları kontrol eder
        private void HandleTimerElapsed(object sender, ElapsedEventArgs e)
        {
            var current = DateTime.Now;
            var timeWindow = TimeSpan.FromMinutes(1); // 1 dakikalık pencere

            foreach (var reminder in reminders.Where(r => !r.IsTriggered && r.ReminderDate <= current && (current - r.ReminderDate) <= timeWindow))
            {
                reminder.IsTriggered = true;
                NotifyShake(reminder);
            }
        }

        // Hatırlatıcıları Excel dosyasına aktarır
        public void ExportRemindersToExcel(string userName)
        {
            using (var workbook = new XLWorkbook())
            {
                var sheet = workbook.Worksheets.Add("Reminders");

                // Başlıklar
                sheet.Cell(1, 1).Value = "Date";
                sheet.Cell(1, 2).Value = "Summary";
                sheet.Cell(1, 3).Value = "Description";
                sheet.Cell(1, 4).Value = "Type";

                // Veriler
                for (int i = 0; i < reminders.Count; i++)
                {
                    var reminder = reminders[i];
                    sheet.Cell(i + 2, 1).Value = reminder.ReminderDate;
                    sheet.Cell(i + 2, 2).Value = reminder.Summary;
                    sheet.Cell(i + 2, 3).Value = reminder.FullDescription;
                    sheet.Cell(i + 2, 4).Value = reminder.GetReminderType();
                }

                string fileName = $"{userName}_Reminder.xlsx";
                workbook.SaveAs(fileName); // Dosyayı kaydet
            }
        }

        // Excel dosyasından hatırlatıcıları içeri aktarır
        public void ImportRemindersFromExcel(string filePath, out string errMassage)
        {
            errMassage = string.Empty;

            if (!File.Exists(filePath))
            {
                errMassage = "Dosya mevcut değil.";
                return;
            }

            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RowsUsed();

                    foreach (var row in rows)
                    {
                        if (row.RowNumber() == 1) continue; // Başlık satırını atla

                        var dateTime = row.Cell(1).GetDateTime();
                        var summary = row.Cell(2).GetString();
                        var description = row.Cell(3).GetString();
                        var type = row.Cell(4).GetString();

                        Reminder reminder;

                        if (type == "Meeting Reminder")
                        {
                            reminder = new MeetingReminder();
                        }
                        else if (type == "Task Reminder")
                        {
                            reminder = new TaskReminder();
                        }
                        else
                        {
                            errMassage = $"Bilinmeyen hatırlatıcı(reminder) türü: {type}";
                            return;
                        }

                        reminder.ReminderDate = dateTime;
                        reminder.Summary = summary;
                        reminder.FullDescription = description;
                        reminder.IsTriggered = dateTime <= DateTime.Now;

                        reminders.Add(reminder);
                    }
                }
            }
            catch (Exception ex)
            {
                errMassage = $"Dosya içe aktarılırken bir hata oluştu: {ex.Message}";
            }
        }
    }
}
