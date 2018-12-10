using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Demo_Common.DataTransferObjects
{
    public class ActivityListDto
    {
        /// <summary>
        /// 活動ID
        /// </summary>
        public int ActivityID { get; set; }
        /// <summary>
        /// 活動代碼
        /// </summary>
        public string ActivityCode { get; set; }
        /// <summary>
        /// 活動名稱
        /// </summary>
        public string ActivityName { get; set; }
        /// <summary>
        /// 活動開始日期
        /// </summary>
        public DateTime BeginDate { get; set; }
        /// <summary>
        /// 活動點閱次數
        /// </summary>
        public int ClickCount { get; set; }
        /// <summary>
        /// 活動收藏次數
        /// </summary>
        public int CollectionCount { get; set; }
    }
}
