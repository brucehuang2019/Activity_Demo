using Activity_Demo_Common.DataTransferObjects;
using Activity_Demo_Common.ParameterDTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Demo_Service.Interfaces
{
    public interface IActivityService
    {
        /// <summary>
        /// 取得活動內容
        /// </summary>
        /// <param name="activity_id">活動ID</param>
        /// <returns>活動內容</returns>
        ActivityContentDto GetActivityContent(int activity_id);
        
        /// <summary>
        /// 取得活動列表
        /// </summary>
        /// <param name="parameterDto">活動列表搜尋參數</param>
        /// <returns>活動列表</returns>
        List<ActivityListDto> GetActivityList(ActivityListSearchParameterDto parameterDto);
    }
}
