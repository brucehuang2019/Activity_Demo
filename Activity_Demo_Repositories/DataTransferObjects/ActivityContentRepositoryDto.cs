using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Demo_Repositories.DataTransferObjects
{
    public class ActivityContentRepositoryDto
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
        /// 活動結束日期
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// 活動地址
        /// </summary>
        public string ActivityAddress { get; set; }
        /// <summary>
        /// 相關連結
        /// </summary>
        public string RelatedLink { get; set; }
        /// <summary>
        /// 標籤
        /// </summary>
        public string Tags { get; set; }
        /// <summary>
        /// 活動內容
        /// </summary>
        public string ActivityContent { get; set; }
    }
}
