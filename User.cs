using System;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Text;

namespace WindowsFormsApp2
{
    public class User
    {
        // Kullanıcı özellikleri
        public string Username { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string UserPassword { get; set; }
        public UserType Type { get; set; }
        public string ContactNumber { get; set; }
        public string AddressDescription { get; set; }
        public PhoneBook ContactBook { get; set; }
        public NotesManager NotesManager { get; set; }
        public ReminderManager TaskReminderManager { get; set; } 
        public double UserSalary { get; set; }
        
        public string ProfilePhotoPath { get; set; }
        public string ProfilePhotoBase64 { get; set; }
      
        // Kullanıcı bilgilerinin geçerliliğini kontrol eden yardımcı metod
        private string CheckUserInfoValidity(string username, string name, string surname, string email, string password, string phoneNumber)
        {
            StringBuilder errorMessage = new StringBuilder();

            if (!IsUsernameValid(username))
            {
                errorMessage.AppendLine("Geçersiz kullanıcı adı. Kullanıcı adı 3 ile 20 karakter arasında olmalı ve Türkçe ve İngilizce harfler, rakamlar ve alt çizgiler içerebilir.");
            }
            if (!IsNameOrSurnameValid(name))
            {
                errorMessage.AppendLine("Geçersiz isim. İsim, Türkçe ve İngilizce harfler ve boşluklar içerebilir ve 1 ile 50 karakter arasında olmalıdır.");
            }
            if (!IsNameOrSurnameValid(surname))
            {
                errorMessage.AppendLine("Geçersiz soyad. Soyadı, Türkçe ve İngilizce harfler, boşluklar içerebilir ve 1 ile 50 karakter arasında olmalıdır.");
            }
            if (!IsEmailValid(email))
            {
                errorMessage.AppendLine("Geçersiz e-posta adresi.");
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage.AppendLine("Şifre boş olamaz.");
            }
            if (!IsPhoneNumberValid(phoneNumber))
            {
                errorMessage.AppendLine("Geçersiz telefon numarası. Telefon numarası (555) 555 55 55 formatında olmalıdır.");
            }

            return errorMessage.ToString();
        }

        // Kullanıcı oluşturucu (constructor)
        public User(string username, string name, string surname, string email, string password, UserType type, string phoneNumber, string addressDescription,double salary,string photoPath, out string errorMessage)
        {
            // Telefon numarasını formatla
            phoneNumber = ApplyPhoneNumberFormat(phoneNumber);
            
            // Kullanıcı bilgilerinin doğrulamasını yap
            errorMessage = CheckUserInfoValidity(username, name, surname, email, password, phoneNumber);

            if (string.IsNullOrEmpty(errorMessage))
            {
                // Bilgiler geçerliyse kullanıcı özelliklerini ayarla
                Username = username;
                Name = name;
                Surname = surname;
                EmailAddress = email.TrimEnd();
                UserPassword = password;
                Type = type;
                ContactNumber = phoneNumber.TrimEnd();
                AddressDescription = addressDescription;
                ContactBook = new PhoneBook(); 
                NotesManager = new NotesManager();
                TaskReminderManager = new ReminderManager();
                UserSalary = salary;
                ProfilePhotoPath = photoPath;
                ProfilePhotoBase64 = string.Empty;
            }
        }

        // Kullanıcı bilgilerini güncelleme metodu
        public string UpdateUserInfo(string newUsername, string newName, string newSurname, string newEmail, string newPassword, string newPhoneNumber, string newAddressDescription, string photoPath, string photoBase64)
        {
            // Telefon numarasını formatla
            newPhoneNumber = ApplyPhoneNumberFormat(newPhoneNumber);
            
            // Yeni bilgilerin doğrulamasını yap
            string errorMessage = CheckUserInfoValidity(newUsername, newName, newSurname, newEmail, newPassword, newPhoneNumber);

            if (string.IsNullOrEmpty(errorMessage))
            {
                // Bilgiler geçerliyse kullanıcı özelliklerini güncelle
                Username = newUsername;
                Name = newName;
                Surname = newSurname;
                EmailAddress = newEmail;
                UserPassword = newPassword;
                ContactNumber = newPhoneNumber;
                AddressDescription = newAddressDescription;
                ProfilePhotoPath = photoPath;
                ProfilePhotoBase64 = photoBase64;
            }

            return errorMessage;
        }

        // Kullanıcı adı doğrulama
        private bool IsUsernameValid(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_ğüşöçİĞÜŞÖÇı]{3,20}$");
        }

        // İsim ve soyisim doğrulama
        private bool IsNameOrSurnameValid(string nameOrSurname)
        {
            return Regex.IsMatch(nameOrSurname, @"^[a-zA-ZğüşöçİĞÜŞÖÇı ]{1,50}$");
        }

        // E-posta doğrulama
        private bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Uluslararası domain adlarını destekleyen e-posta kontrolü
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new System.Globalization.IdnMapping();
                    var domainName = idn.GetAscii(match.Groups[2].Value);
                    return match.Groups[1].Value + domainName;
                }
            }
            catch (Exception)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+\s*$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        // Telefon numarası doğrulama
        private bool IsPhoneNumberValid(string phoneNumber)
        {
            // Sadece rakamları al
            string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");
            
            // 10 haneli telefon numarası kontrolü (örn: 5551112233)
            if (digitsOnly.Length != 10)
                return false;
            
            // Formatlama otomatik olarak yapılacak
            return true;
        }

        // Telefon numarasını (555) 555 55 55 formatına dönüştüren yardımcı metod
        public static string ApplyPhoneNumberFormat(string phoneNumber)
        {
            // Sadece rakamları al
            string digitsOnly = Regex.Replace(phoneNumber, @"[^\d]", "");
            
            // 10 rakam yoksa formatlamadan dön
            if (digitsOnly.Length != 10)
                return phoneNumber;
            
            // (555) 555 55 55 formatına dönüştür
            return $"({digitsOnly.Substring(0, 3)}) {digitsOnly.Substring(3, 3)} {digitsOnly.Substring(6, 2)} {digitsOnly.Substring(8, 2)}";
        }
    }
}
