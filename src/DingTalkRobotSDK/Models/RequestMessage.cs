using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalkRobotSDK.Models
{
    public class RequestMessage
    {
        public string msgtype { get; set; }
        public Text text { get; set; }
    }
    public class Text
    {
        public string content { get; set; }
    }
}
