using System.Net.Http;

namespace DingTalkRobotSDK
{
    public class DingTalkContext
    {
        private string secret;
        public string Secret { set { secret = value; } }
        private HttpClient httpClient;
        public DingTalkContext()
        {
        }
        public DingTalkContext(string secret)
        {

        }
        public DingTalkContext(HttpClient httpClient, string secret)
        {
            this.secret = secret;
            this.httpClient = httpClient;
        }
    }
}
