using System;
using System.Collections.Generic;
using System.Text;

namespace DingTalkRobotSDK.Enums
{
    public enum ErrorCode
    {
        /// <summary>
        /// 系统繁忙
        /// </summary>
        SystemBusy = -1,
        /// <summary>
        /// 成功
        /// </summary>
        Successful = 0,
        /// <summary>
        /// 鉴权失败
        /// </summary>
        AuthorizeError = 88,
        /// <summary>
        /// 未找到Url
        /// </summary>
        NotFound = 404
    }
}
