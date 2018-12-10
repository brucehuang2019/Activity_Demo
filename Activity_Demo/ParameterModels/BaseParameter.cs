using Activity_Demo_Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity_Demo.ParameterModels
{
    public class BaseParameter
    {
        /// <summary>
        /// api名稱
        /// </summary>
        public string request { get; set; }
        /// <summary>
        /// 平台 
        /// </summary>
        public string platform { get; set; }
        /// <summary>
        /// 來源IP
        /// </summary>
        public string ip_address { get; set; }
        /// <summary>
        /// 語系
        /// </summary>
        public LanguageEnum? language { get; set; }
    }
}
