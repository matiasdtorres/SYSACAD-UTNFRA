using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace biblioteca
{
    public class Hash
    {
        public static string GetHash(string password)
        {
            var hash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 8);

            return hash;
        }

        public static bool ValidatePassword(string password, string correctHash)
        {
            return BCrypt.Net.BCrypt.EnhancedVerify(password, correctHash);
        }
    }
}
