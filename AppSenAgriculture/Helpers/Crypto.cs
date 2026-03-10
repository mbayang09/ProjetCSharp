using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Security.Cryptography;
using System.Text;

namespace AppSenAgriculture.Helpers
{
    public class Crypto
    {
        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Convertir le texte en bytes
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Créer un StringBuilder pour construire le hash
            StringBuilder sBuilder = new StringBuilder();

            // Convertir les bytes en hexadécimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }


        // Vérifier si le mot de passe correspond au hash
        public static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (comparer.Compare(hashOfInput, hash) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
