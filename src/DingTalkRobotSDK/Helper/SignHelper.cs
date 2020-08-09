using DingTalkRobotSDK.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace DingTalkRobotSDK.Helper
{
    public class SignHelper
    {
        private static byte[] GetHMAC(string message, string secret)
        {
            byte[] keyByte = Encoding.UTF8.GetBytes(secret);
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(messageBytes);
                return hashmessage;
            }
        }

        public static long GetTimeStamp()
        {
            var zts = TimeZoneInfo.Local.BaseUtcOffset;
            var yc = new DateTime(1970, 1, 1).Add(zts);
            return (long)(DateTime.Now - yc).TotalMilliseconds;
        }

        public static SignModel GetSign(string secret)
        {
            var timeStamp = GetTimeStamp().ToString();
            var stringToSign = $"{timeStamp}\n{secret}";
            var b64 = GetHMAC(stringToSign, secret);
            var sign = HttpUtility.UrlEncode(Convert.ToBase64String(b64));
            return new SignModel(timeStamp, sign);
        }
        public static SignModel GetSign(long timeStamp, string secret)
        {
            var stringToSign = $"{timeStamp.ToString()}\n{secret}";
            var b64 = GetHMAC(stringToSign, secret);
            var sign = HttpUtility.UrlEncode(Convert.ToBase64String(b64));
            return new SignModel(timeStamp.ToString(), sign);
        }
        public static SignModel GetSign(DateTime time, string secret)
        {
            TimeSpan ts = time - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return GetSign(Convert.ToInt64(ts.TotalSeconds), secret);
        }
    }
}
