using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp2
{
    public class PhoneBook
    {
        private List<PhoneBookEntry> contactList;

        public PhoneBook()
        {
            contactList = new List<PhoneBookEntry>();
        }

        public void newEntry(string contactName, string contactSurname, string contactNumber, string contactAddress, string description, string email, out string errorMessage)
        {
            var entry = new PhoneBookEntry(contactName, contactSurname, contactNumber, contactAddress, description, email, out errorMessage);
            foreach (var existingEntry in contactList)
            {
                if (existingEntry.PhoneBookAddress == entry.PhoneBookAddress && existingEntry.PhoneBookEmail == entry.PhoneBookEmail && existingEntry.PhoneBookName == entry.PhoneBookName && existingEntry.PhoneBookPhoneNumber == entry.PhoneBookPhoneNumber && existingEntry.PhoneBookSurname == entry.PhoneBookSurname && existingEntry.PhoneBookDescription == entry.PhoneBookDescription)
                {
                    errorMessage = "Kullanıcı Zaten Ekli!";
                    return;
                }
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                contactList.Add(entry);
            }
        }
        public void RemoveEntryAt(int index)
        {
            if (index >= 0 && index < contactList.Count)
            {
                contactList.RemoveAt(index);
            }
        }

        public List<PhoneBookEntry> GetEntries()
        {
            return contactList;
        }

        public void ClearEntries()
        {
            contactList.Clear();
        }

        public void ExportToExcel(string userName)
        {
            // Create a new workbook and worksheet
            using (var workbook = new XLWorkbook())
            {
                var sheet = workbook.Worksheets.Add("PhoneBook");

                // Add headers
                sheet.Cell(1, 1).Value = "Name";
                sheet.Cell(1, 2).Value = "Surname";
                sheet.Cell(1, 3).Value = "Phone Number";
                sheet.Cell(1, 4).Value = "Address";
                sheet.Cell(1, 5).Value = "Description";
                sheet.Cell(1, 6).Value = "Email";

                // Add entries
                for (int i = 0; i < contactList.Count; i++)
                {
                    var entry = contactList[i];
                    sheet.Cell(i + 2, 1).Value = entry.PhoneBookName;
                    sheet.Cell(i + 2, 2).Value = entry.PhoneBookSurname;
                    sheet.Cell(i + 2, 3).Value = entry.PhoneBookPhoneNumber;
                    sheet.Cell(i + 2, 4).Value = entry.PhoneBookAddress;
                    sheet.Cell(i + 2, 5).Value = entry.PhoneBookDescription;
                    sheet.Cell(i + 2, 6).Value = entry.PhoneBookEmail;
                }

                // Save the workbook
                string fileName = $"{userName}_PhoneBook.xlsx";
                workbook.SaveAs(fileName);
            }
        }
        public void ImportFromExcel(string filePath, out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!File.Exists(filePath))
            {
                errorMessage = "Dosya mevcut değil.";
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
                        if (row.RowNumber() == 1) continue; 

                        var phoneBookName = row.Cell(1).GetValue<string>();
                        var phoneBookSurname = row.Cell(2).GetValue<string>();
                        var phoneBookPhoneNumber = row.Cell(3).GetValue<string>();
                        var phoneBookAddress = row.Cell(4).GetValue<string>();
                        var phoneBookDescription = row.Cell(5).GetValue<string>();
                        var phoneBookEmail = row.Cell(6).GetValue<string>();

                        newEntry(phoneBookName, phoneBookSurname, phoneBookPhoneNumber, phoneBookAddress, phoneBookDescription, phoneBookEmail, out errorMessage);
                        if (!string.IsNullOrEmpty(errorMessage))
                        {
                            break;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                errorMessage = $"Dosya içe aktarılırken bir hata oluştu.: {exception.Message}";
            }
        }

    }
}
