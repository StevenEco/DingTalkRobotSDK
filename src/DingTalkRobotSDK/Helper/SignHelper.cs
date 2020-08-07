using DingTalkRobotSDK.Models;
using System;

namespace DingTalkRobotSDK.Helper
{
    public class SignHelper
    {
        public static long GetTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds);
        }

        public static SignModel GetSign()
        {

        }

    }
}
