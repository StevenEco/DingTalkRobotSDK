using DingTalkRobotSDK.Enums;

namespace DingTalkRobotSDK.Models
{
    public class ResponseMessage
    {
        /// <summary>
        /// 错误码
        /// </summary>
        public ErrorCode? ErrCode { get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrMsg { get; set; }

        /// <summary>
        /// 子错误码
        /// </summary>
        public ErrorCode? SubErrCode { get; set; }

        /// <summary>
        /// 子错误信息
        /// </summary>
        public string SubErrMsg { get; set; }

        /// <summary>
        /// TOP请求唯一标识符
        /// </summary>
        public string RequestId { get; set; }

        /// <summary>
        /// 响应原始内容
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// 响应结果是否错误
        /// </summary>
        public bool IsError
        {
            get
            {
                return ErrCode != null || SubErrCode != null;
            }
        }
    }
}
