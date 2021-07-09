using System;
using System.Security.Cryptography;
using System.IO;

using Error003EncryptionSdk;

namespace AES_Encryption
{
    public class AES : IAddon
    {
        public AES()
        {
            name = "AES";
        }

        public string name { get; set; }

        static byte[] GenerateRandomSalt()
        {
            byte[] data = new byte[32];

            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < 10; i++)
                {
                    rng.GetBytes(data);
                }
            }
            return data;
        }

        public void FileEncrypt(string filePath, string password)
        { 
        
        }

        public void FileDecrypt(string filePath, string password)
        { 
        
        }

        /*public void FileEncrypt(string filePath, string password)
        {
            byte[] salt = GenerateRandomSalt();
            FileStream outputFile = new FileStream(filePath + ".aes", FileMode.Create);
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            
            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;
            AES.Padding = PaddingMode.PKCS7;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);

            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Mode = CipherMode.CFB;

            outputFile.Write(salt, 0, salt.Length);

            CryptoStream cryptoFile = new CryptoStream(outputFile, AES.CreateEncryptor(), CryptoStreamMode.Write);
            FileStream fileInput = new FileStream(filePath, FileMode.Open);

            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = fileInput.Read(buffer, 0, buffer.Length)) > 0)
                {
                    cryptoFile.Write(buffer, 0, read);
                }

                fileInput.Close();
            }
            catch (Exception ex)
            {
                StreamWriter LogWriter = new StreamWriter("logs/logs.txt");
                LogWriter.Write(ex.Message);
            }
            finally
            {
                cryptoFile.Close();
                outputFile.Close();
            }
        }*/

        /*public void FileDecrypt(string filePath, string password)
        {
            byte[] passwordBytes = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] salt = new byte[32];

            FileStream inputFile = new FileStream(filePath, FileMode.Open);
            inputFile.Read(salt, 0, salt.Length);

            RijndaelManaged AES = new RijndaelManaged();
            AES.KeySize = 256;
            AES.BlockSize = 128;

            var key = new Rfc2898DeriveBytes(passwordBytes, salt, 50000);
            AES.Key = key.GetBytes(AES.KeySize / 8);
            AES.IV = key.GetBytes(AES.BlockSize / 8);
            AES.Padding = PaddingMode.PKCS7;
            AES.Mode = CipherMode.CFB;

            CryptoStream cryptoFile = new CryptoStream(inputFile, AES.CreateDecryptor(), CryptoStreamMode.Read);
            FileStream outputFile = new FileStream(filePath.Replace(".aes", ""), FileMode.Create);

            byte[] buffer = new byte[1048576];
            int read;

            try
            {
                while ((read = cryptoFile.Read(buffer, 0, buffer.Length)) > 0)
                {
                    outputFile.Write(buffer, 0, read);
                }
            }
            catch (Exception ex)
            {
                StreamWriter LogWriter = new StreamWriter("logs/logs.txt");
                LogWriter.Write(ex.Message);
            }

            try
            {
                cryptoFile.Close();
            }
            catch (Exception ex)
            {
                StreamWriter LogWriter = new StreamWriter("logs/logs.txt");
                LogWriter.Write(ex.Message);
            }
            finally
            {
                outputFile.Close();
                cryptoFile.Close();
            }
        }*/
    }
}
