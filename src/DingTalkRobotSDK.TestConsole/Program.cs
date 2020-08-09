using DingTalkRobotSDK.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DingTalkRobotSDK.TestConsole
{
    public class Context : DingTalkContext
    {
        public Context(HttpClient client) :base(client)
        {

        }
        protected override void Configure(DingTalkOptions options)
        {
            options = new DingTalkOptions();
            options.AccessToken = "d35a2b8d18fb5baa8d71baae8b72be56eccab7eb1ce24e1557f7ff13a84fd2ce";
            base.Configure(options);
        }
    }
    class Program
    {
        static async Task Main(string[] args)
        {
            Context context = new Context(new HttpClient());
            var rs = await context.Excute<RequestMessage>(new RequestMessage() { msgtype = "text", text = new Text() { content = "我牛逼" } });
            Console.WriteLine(rs.Body);
            Console.WriteLine(rs.IsError);
        }
    }
}
