using System;
using System.Text;
using System.Security.Cryptography;

namespace vnyi.Utility.RES
{
    public class clsSecurity
    {
        public static string EncryptMD5(string flatString)
        {
            UnicodeEncoding arrayHash = new UnicodeEncoding();
            byte[] arrayHashed = null;
            MD5CryptoServiceProvider md5hash = new MD5CryptoServiceProvider();

            arrayHashed = md5hash.ComputeHash(arrayHash.GetBytes(flatString));

            return ByteArrayToString(arrayHashed);
        }

        private static string ByteArrayToString(byte[] arrInput)
        {
            int i = 0;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }
    }
}
