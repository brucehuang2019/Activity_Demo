using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Demo_Service.Interfaces
{
    public interface ILogService
    {
        /// <summary>
        /// 寫下程式Error訊息
        /// </summary>
        /// <param name="errorMessage">程式Error訊息</param>
        void WriteErrorLog(string errorMessage);
        /// <summary>
        /// 寫下Log訊息
        /// </summary>
        /// <param name="message">Log訊息</param>
        void WriteLog(string message);
    }
}
