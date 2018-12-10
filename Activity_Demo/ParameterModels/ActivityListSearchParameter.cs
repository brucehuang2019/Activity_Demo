using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Activity_Demo.ParameterModels
{
    public class ActivityListSearchParameter : BaseParameter
    {
        public NewsRealTimeUncategoryParams param { get; set; }
    }

    public class NewsRealTimeUncategoryParams
    {
        /// <summary>
        /// 要求筆數
        /// </summary>
        public int? Request_Count { get; set; }
        /// <summary>
        /// 分頁號碼
        /// </summary>
        public int? Paging { get; set; }
    }
}
