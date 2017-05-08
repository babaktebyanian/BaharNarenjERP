using System;
using System.Security.Cryptography;
using System.Text;

namespace BaharNarenjERP
{
    static class Security
    {
        private static Random _rnd = new Random(Environment.TickCount);
        public static string Salt
        {
            get
            {
                char[] chars =
                {
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M',
                    'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
                    'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                    '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
                };
                var salt = "";
                for (var i = 0; i < 8; i++)
                {
                    salt += chars[_rnd.Next(0, 62)];
                }
                return salt;
            }
        }

        /// <summary>
        /// Computes a salted hash of the password with salt and returns as a base64 encoded string.
        /// </summary>
        /// <param name="password">The password to hash.</param>
        /// <param name="salt">Salt to add to the password.</param>
        public static string SaltedHash(string password, string salt)
        {
            // merge password and salt together
            var sHashWithSalt = password + salt;
            // convert this merged value to a byte array
            var saltedHashBytes = Encoding.UTF8.GetBytes(sHashWithSalt);
            // use hash algorithm to compute the hash
            HashAlgorithm algorithm = new SHA1CryptoServiceProvider();
            // convert merged bytes to a hash as byte array
            var hash = algorithm.ComputeHash(saltedHashBytes);
            // return the hash as a base 64 encoded string
            return Convert.ToBase64String(hash);
        }
    }
}
