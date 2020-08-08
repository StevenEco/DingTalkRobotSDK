using DingTalkRobotSDK.Models;
using System;
using System.Security.Cryptography;

namespace DingTalkRobotSDK.Helper
{
    public class SignHelper
    {
        public static long GetTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }

        public static SignModel GetSign(string secret)
        {
            var timeStamp = GetTimeStamp().ToString();
            var encoding = new System.Text.ASCIIEncoding();
            byte[] keyByte = encoding.GetBytes(secret);
            byte[] timeStampBytes = encoding.GetBytes(timeStamp); 
            using (var hmacsha256 = new HMACSHA256(keyByte))
            {
                byte[] hashmessage = hmacsha256.ComputeHash(timeStampBytes);
                return new SignModel(timeStamp, Convert.ToBase64String(hashmessage));
            }
        }
    }
}
