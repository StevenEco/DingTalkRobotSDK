using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalkRobotSDK.Models
{
    public class SignModel
    {
        public SignModel()
        {

        }
        public SignModel(string timeStamp, string sign)
        {
            TimeStamp = timeStamp;
            Sign = sign;
        }
        public string TimeStamp { get; set; }
        public string Sign { get; set; }

        public override string ToString()
        {
            return @$"&timestamp={TimeStamp}&sign={Sign}";
        }
    }
}
