using Activity_Demo_Common.DataTransferObjects;
using Activity_Demo_Common.ParameterDTOs;
using Activity_Demo_Repositories.Interfaces;
using Activity_Demo_Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Activity_Demo_Service.Services
{
    public class ActivityService : IActivityService
    {
        private IActivityRepository _activityRepository;

        public ActivityService(IActivityRepository activityRepository)

        {
            this._activityRepository = activityRepository;
        }

        /// <summary>
        /// 取得活動內容
        /// </summary>
        /// <param name="activity_id">活動ID</param>
        /// <returns>活動內容</returns>
        public ActivityContentDto GetActivityContent(int activity_id)
        {
            return this.GetActivityContent(activity_id);
        }

        /// <summary>
        /// 取得活動列表
        /// </summary>
        /// <param name="parameterDto">活動列表搜尋參數</param>
        /// <returns>活動列表</returns>
        public List<ActivityListDto> GetActivityList(ActivityListSearchParameterDto parameterDto)
        {
            return this.GetActivityList(parameterDto);
        }
    }
}
