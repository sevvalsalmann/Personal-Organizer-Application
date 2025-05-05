using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class UserManager
    {
        // Kullanıcı listesi
        private List<User> userList = new List<User>();

        // Yeni kullanıcı ekleme metodu
        public void AddUser(string username, string name, string surname, string email, string password, string phoneNumber, string addressDescription, double salary, string photoPath)
        {
            // Aynı kullanıcı adıyla kayıt kontrolü
            if (userList.Any(u => u.Username.Equals(username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Aynı kullanıcı adına sahip bir kullanıcı zaten mevcut.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kullanıcı tipi belirleme (ilk kullanıcı Admin, diğerleri User)
            UserType type = UserType.User;
            if (!userList.Any())
            {
                type = UserType.Admin;
            }

            // Yeni kullanıcı oluşturma ve doğrulama
            string errorMessage;
            User newUser = new User(username, name, surname, email, password, type, phoneNumber, addressDescription, salary, photoPath, out errorMessage);

            if (string.IsNullOrEmpty(errorMessage))
            {
                userList.Add(newUser);
                MessageBox.Show("Kayıt Başarılı!");
            }
            else
            {
                MessageBox.Show(errorMessage, "Input Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hazır kullanıcı nesnesini ekleme metodu
        public void AddUser(User user)
        {
            // Aynı kullanıcı adıyla kayıt kontrolü
            if (userList.Any(u => u.Username.Equals(user.Username, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Aynı kullanıcı adına sahip bir kullanıcı zaten mevcut.", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userList.Add(user);
        }

        // Kullanıcıları Excel dosyasına aktarma
        public void ExportUsersToExcel(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var sheet = workbook.Worksheets.Add("Users");

                    // Başlık satırı oluşturma
                    sheet.Cell(1, 1).Value = "Username";
                    sheet.Cell(1, 2).Value = "Name";
                    sheet.Cell(1, 3).Value = "Surname";
                    sheet.Cell(1, 4).Value = "Email";
                    sheet.Cell(1, 5).Value = "Password";
                    sheet.Cell(1, 6).Value = "Type";
                    sheet.Cell(1, 7).Value = "PhoneNumber";
                    sheet.Cell(1, 8).Value = "AddressDescription";
                    sheet.Cell(1, 9).Value = "Salary";
                    sheet.Cell(1, 10).Value = "PhotoPath";
                    sheet.Cell(1, 11).Value = "PhotoBase64";
                    
                    // Kullanıcı verilerini Excel'e yazma
                    int row = 2;
                    foreach (User user in userList)
                    {
                        sheet.Cell(row, 1).SetValue(user.Username);
                        sheet.Cell(row, 2).SetValue(user.Name);
                        sheet.Cell(row, 3).SetValue(user.Surname);
                        sheet.Cell(row, 4).SetValue(user.EmailAddress);
                        sheet.Cell(row, 5).SetValue(user.UserPassword);
                        sheet.Cell(row, 6).SetValue(user.Type.ToString());
                        sheet.Cell(row, 7).SetValue(user.ContactNumber);
                        sheet.Cell(row, 8).SetValue(user.AddressDescription);
                        sheet.Cell(row, 9).SetValue(user.UserSalary);
                        sheet.Cell(row, 10).SetValue(user.ProfilePhotoPath);
                        sheet.Cell(row, 11).SetValue(user.ProfilePhotoBase64);

                        row++;
                    }

                    // Sütun genişliklerini içeriğe göre ayarla
                    sheet.Columns().AdjustToContents();

                    workbook.SaveAs(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcıları dışa aktarırken bir hata oluştu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Excel dosyasından kullanıcıları içe aktarma
        public void ImportUsersFromExcel(string filePath)
        {
            try
            {
                using (var workbook = new XLWorkbook(filePath))
                {
                    var worksheet = workbook.Worksheet(1);
                    var rows = worksheet.RangeUsed().RowsUsed().Skip(1); // Başlık satırını atla

                    foreach (var row in rows)
                    {
                        // Excel satırından kullanıcı bilgilerini oku
                        string UserManagerUsername = row.Cell(1).GetValue<string>();
                        string UserManagerName = row.Cell(2).GetValue<string>();
                        string UserManagerSurname = row.Cell(3).GetValue<string>();
                        string UserManagerEmail = row.Cell(4).GetValue<string>();
                        string UserManagerPassword = row.Cell(5).GetValue<string>();
                        UserType type = (UserType)Enum.Parse(typeof(UserType), row.Cell(6).GetValue<string>());
                        string UserManagerPhoneNumber = row.Cell(7).GetValue<string>();
                        string UserManagerAddressDescription = row.Cell(8).GetValue<string>();
                        double UserManagerSalary = row.Cell(9).GetValue<double>();
                        string UserManagerPhotoPath = row.Cell(10).GetValue<string>();

                        // Kullanıcı nesnesi oluştur ve doğrula
                        string errorMessage;
                        User newUser = new User(UserManagerUsername, UserManagerName, UserManagerSurname, UserManagerEmail, UserManagerPassword, type, UserManagerPhoneNumber, UserManagerAddressDescription, UserManagerSalary, UserManagerPhotoPath, out errorMessage);

                        if (string.IsNullOrEmpty(errorMessage))
                        {
                            // Eğer PhotoBase64 sütunu varsa oku
                            if (worksheet.ColumnsUsed().Count() >= 11)
                            {
                                newUser.ProfilePhotoBase64 = row.Cell(11).GetValue<string>();
                            }
                            
                            userList.Add(newUser);
                        }
                        else
                        {
                            MessageBox.Show(errorMessage, "Error Importing User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcıları içe aktarırken bir hata oluştu: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Tüm kullanıcı detaylarını metin formatında alma
        public string GetAllUserDetails()
        {
            StringBuilder userDetails = new StringBuilder();
            foreach (User user in userList)
            {
                userDetails.AppendLine($"Username: {user.Username}, Name: {user.Name}, Surname: {user.Surname}, Email: {user.EmailAddress}, Type: {user.Type}, Password: {user.UserPassword}, PhoneNumber: {user.ContactNumber}, Address: {user.AddressDescription}");
            }
            return userDetails.ToString();
        }

        // Kullanıcı giriş doğrulama
        public bool LoginUser(string username, string password)
        {
            foreach (User user in userList)
            {
                if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.UserPassword == password)
                {
                    return true;
                }
            }
            return false;
        }

        // Aktif kullanıcıyı bilgileriyle getirme
        public User GetCurrentUser(string username, string password)
        {
            foreach (User user in userList)
            {
                if (user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) && user.UserPassword == password)
                {
                    return user;
                }
            }
            return null;
        }

        // Kullanıcı silme
        public void DeleteUser(string username)
        {
            userList.RemoveAll(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase));
        }

        // Tüm kullanıcıları getirme
        public List<User> GetUsers()
        {
            return userList;
        }
    }
}
