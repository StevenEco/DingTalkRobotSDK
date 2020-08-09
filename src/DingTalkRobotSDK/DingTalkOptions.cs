using System.Collections.Generic;

namespace DingTalkRobotSDK
{
    public class DingTalkOptions
    {
        /// <summary>
        /// 仅仅是设置HttpClient的请求头，和数据无关
        /// </summary>
        public Dictionary<string, string> HttpHeader { get; set; } = new Dictionary<string, string>()
        {
            { "Accept", "application/json" }
        };
        public string AccessToken { get; set; }
    }
}

