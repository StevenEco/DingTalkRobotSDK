using DingTalkRobotSDK.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DingTalkRobotSDK
{
    public abstract class DingTalkContext
    {
        private string accessToken;
        private HttpClient httpClient;
        private DingTalkOptions options;
        protected string AccessToken { set { accessToken = value; } }
        public DingTalkOptions Options { set { options = value; } }
        public DingTalkContext()
        {
        }
        public DingTalkContext(string secret)
        {
            this.accessToken = secret;
            Configure(options);
        }
        public DingTalkContext(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            Configure(options);
        }
        public DingTalkContext(HttpClient httpClient, string secret)
        {
            this.accessToken = secret;
            this.httpClient = httpClient;
            Configure(options);
        }
        protected virtual void Configure(DingTalkOptions options)
        {
            this.options = options;
            accessToken = options.AccessToken;
            foreach (var item in options.HttpHeader)
            {
                httpClient.DefaultRequestHeaders.Add(item.Key, item.Value);
            }
        }

        public virtual async Task<ResponseMessage> Excute<T>(T model) where T:RequestMessage
        {
            var url = $"{Config.WebHook}{accessToken}";
            var data = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8);
            data.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var result = await this.httpClient.PostAsync($"{Config.WebHook}{accessToken}",data);
            return JsonConvert.DeserializeObject<ResponseMessage>(await result.Content.ReadAsStringAsync());
        }

    }
}