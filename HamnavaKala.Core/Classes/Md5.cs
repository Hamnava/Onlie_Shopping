using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HamnavaKala.Core.Classes
{
   public static class Md5
    {
        public static string EncodePasswordMd5(this string password)
        {
            Byte[] originalByte;
            Byte[] encodeBytes;
            MD5 md5;
            md5 = new MD5CryptoServiceProvider();
            originalByte = ASCIIEncoding.Default.GetBytes(password);
            encodeBytes = md5.ComputeHash(originalByte);
            return BitConverter.ToString(encodeBytes);
        }
    }
}
