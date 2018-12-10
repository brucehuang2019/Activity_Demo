using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity_Demo.ViewModels
{
    public class BaseViewModel<T>
    {
        /// <summary>
        /// API回應
        /// </summary>
        public string response { get; set; }
        /// <summary>
        /// 使用平台
        /// </summary>
        public string platform { get; set; }
        /// <summary>
        /// 結果
        /// </summary>
        public string result { get; set; }
        /// <summary>
        /// 訊息
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 資料
        /// </summary>
        public T data { get; set; }
    }
}
