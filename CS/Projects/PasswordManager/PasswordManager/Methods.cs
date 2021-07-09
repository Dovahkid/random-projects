using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace PasswordManager
{
    class Methods
    {
        public static string hashPass(string password)
        {
            StringBuilder builder = new StringBuilder();
            byte[] bytes;

            using (SHA256 hash = SHA256.Create())
            {
                bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password)); // Creates the hash as a byte array

                for (int i = 0; i < bytes.Length; i++) // Converts byte array to string
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }

        public static bool isValidPassword(string pass, string repPass) // Needs to have rules checking for valid characters

        /*
            If a rule fails then it returns false. This means the user has done somethig invalid    
        */

        {
            if (pass != repPass) // Checks if the password and repeat password are the same
            {
                return false;
            }

            if (pass == "") // Checks if the password is blank
            {
                return false;
            }

            return true;
        }

        public static bool isValidUsername(string user)

        /*
            If a rule fails then it returns false. This means the user has done somethig invalid    
        */
        {

            if (File.Exists(user + ".xml")) // Checks if a user with that username already exists
            {
                return false;
            }

            if (user == "") // Checks if the username is blank
            {
                return false;
            }

            return true;

        }
    }
}
