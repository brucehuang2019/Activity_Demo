using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Demo_Common.ParameterDTOs
{
    public class ActivityListSearchParameterDto
    {
        /// <summary>
        /// 要求筆數
        /// </summary>
        public int? RequestCount { get; set; }
        /// <summary>
        /// 分頁號碼
        /// </summary>
        public int Start { get; set; }
    }
}
