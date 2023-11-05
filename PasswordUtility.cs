using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingatlan
{
    static class PasswordUtility
    {
        static int workFactor = 10;
        public static string GetHash(string passwd)
        {
            return BCrypt.Net.BCrypt.EnhancedHashPassword(passwd, workFactor);
        }

        public static bool Validate(string passwd, string hash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(passwd, hash);
        }

    }
}
