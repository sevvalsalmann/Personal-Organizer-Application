using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    // Kullanıcı tiplerini tanımlayan enum
    public enum UserType
    {
        Admin,        // Yönetici - tüm yetkilere sahip
        User,         // Normal kullanıcı
        PartTimeUser  // Yarı zamanlı kullanıcı
    }
}
