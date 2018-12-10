using Activity_Demo_Service.Interfaces;
using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Demo_Service.Services
{
    public class LogService : ILogService
    {
        private Logger _logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// 寫下程式Error訊息
        /// </summary>
        /// <param name="errorMessage">程式Error訊息</param>
        public void WriteErrorLog(string errorMessage)
        {
            this._logger.Error(errorMessage);
        }

        /// <summary>
        /// 寫下Log訊息
        /// </summary>
        /// <param name="message">Log訊息</param>
        public void WriteLog(string message)
        {
            this._logger.Debug(message);
        }
    }
}
