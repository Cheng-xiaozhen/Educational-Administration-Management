using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EAM.BLL
{
    public class MD5Encode
    {
        public static string GetMd5(string str)
        {
            StringBuilder sb = new StringBuilder();
            using(MD5 md5=MD5.Create())
            {
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                byte[] bufferMd5 = md5.ComputeHash(buffer);
                for (int i=0;i<bufferMd5.Length;i++)
                {
                    sb.Append(bufferMd5[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
}
