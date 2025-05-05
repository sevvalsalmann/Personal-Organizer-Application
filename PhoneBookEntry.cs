using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class PhoneBookEntry
    {
        public string PhoneBookName { get; set; }
        public string PhoneBookSurname { get; set; }
        public string PhoneBookPhoneNumber { get; set; }
        public string PhoneBookAddress { get; set; }
        public string PhoneBookDescription { get; set; }
        public string PhoneBookEmail { get; set; }

        public PhoneBookEntry(string name, string surname, string phoneNumber, string address, string description, string email, out string errorMessage)
        {
            errorMessage = "";

            // Telefon numarasını formatla
            phoneNumber = User.ApplyPhoneNumberFormat(phoneNumber);

            if (!IsNameOrSurnameValid(name))
            {
                errorMessage += "Geçersiz isim. İsim, Türkçe ve İngilizce harfler ve boşluklar içerebilir ve 1 ile 50 karakter arasında olmalıdır.\n";
            }
            if (!IsNameOrSurnameValid(surname))
            {
                errorMessage += "Geçersiz soyad. Soyad, Türkçe ve İngilizce harfler ve boşluklar içerebilir ve 1 ile 50 karakter arasında olmalıdır.\n";
            }
            if (!IsPhoneNumberValid(phoneNumber))
            {
                errorMessage += "Geçersiz telefon numarası. Telefon numarası (555) 555 55 55 formatında olmalıdır.\n";
            }
            if (!IsEmailValid(email))
            {
                errorMessage += "Geçersiz e-posta adresi.\n";
            }

            if (string.IsNullOrEmpty(errorMessage))
            {
                PhoneBookName = name;
                PhoneBookSurname = surname;
                PhoneBookPhoneNumber = phoneNumber.TrimEnd();
                PhoneBookAddress = address;
                PhoneBookDescription = description;
                PhoneBookEmail = email.TrimEnd();
            }
        }

        private bool IsNameOrSurnameValid(string nameOrSurname)
        {
            return Regex.IsMatch(nameOrSurname, @"^[a-zA-ZğüşöçİĞÜŞÖÇı ]{1,50}$");
        }

        private bool IsEmailValid(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper, RegexOptions.None, TimeSpan.FromMilliseconds(200));
                string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();
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

    }
}