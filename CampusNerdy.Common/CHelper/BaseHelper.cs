using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace CampusNerdy.Common.CHelper
{
    public class BaseHelper
    {
        #region 得到加密信息
        /// <summary>
        /// 加密
        /// </summary>
        /// <param name="userPassword"></param>
        /// <param name="salt">lululu</param>
        /// <returns></returns>
        public static string getSHA2HashedPassword(string password, string salt)
        {
            byte[] strBytes = Encoding.UTF8.GetBytes((password + salt));
            SHA256Managed sha236M = new SHA256Managed();
            byte[] result = sha236M.ComputeHash(strBytes);
            return Convert.ToBase64String(result);
        }
        /// <summary>
        ///获取salt
        /// </summary>
        /// <param name="needLendth"></param>
        /// <returns></returns>
        public static string getSalt(int needLendth)
        {
            string[] strAssemble = { "0", "1", "1", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            Random random = new Random();
            string resultCode = "";
            for (int i = 0; i < needLendth; i++)
            {
                resultCode += strAssemble[random.Next(0, strAssemble.Length)];
            }
            return resultCode;

        }
        #endregion
        #region string转换
        public static string getStringFormGlobalString(global::System.String str)
        {
            return str;
        }

        #endregion

    }
}
