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
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            var signModel = (SignModel)obj;
            return signModel.Sign == Sign && 
                Convert.ToInt64(signModel.TimeStamp) == Convert.ToInt64(TimeStamp);
        }
    }
}
