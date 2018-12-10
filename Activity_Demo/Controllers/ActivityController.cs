using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Activity_Demo.ParameterModels;
using Activity_Demo.ViewModels;
using Activity_Demo_Common;
using Activity_Demo_Common.DataTransferObjects;
using Activity_Demo_Common.ParameterDTOs;
using Activity_Demo_Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Activity_Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActivityController : ControllerBase
    {
        private IActivityService _activityService;
        private ILogService _logService;
        private string _succesStatusName = ProjectConstants.ResultStatus.SuccessName;
        private string _failedStatusName = ProjectConstants.ResultStatus.FailedName;

        public ActivityController(IActivityService activityService,
                                  ILogService logService)
        {
            this._activityService = activityService;
            this._logService = logService;
        }

        /// <summary>
        /// 活動列表資料
        /// </summary>
        /// <param name="parameter">活動列表搜尋參數</param>
        /// <returns>活動列表資料</returns>
        [Route("activity_list")]
        [HttpPost]
        public ActivityListViewModel ActivityList(ActivityListSearchParameter parameter)
        {
            try
            {
                int paging = parameter.param.Paging.HasValue ? parameter.param.Paging.Value : 1;
                int requestCount = parameter.param.Request_Count.HasValue ? parameter.param.Request_Count.Value : 10;
                int startAt = requestCount * (paging - 1);

                var parameterDto = new ActivityListSearchParameterDto()
                {
                    RequestCount = requestCount,
                    Start = startAt
                };

                var listDtos = this._activityService.GetActivityList(parameterDto);

                var viewModel = new ActivityListViewModel()
                {
                    data = listDtos,
                    message = string.Empty,
                    platform = parameter.platform,
                    response = parameter.request,
                    result = _succesStatusName
                };

                return viewModel;
            }
            catch (Exception ex)
            {
                this._logService.WriteErrorLog("activity_list");
                
                this._logService.WriteErrorLog(ex.Message);

                return new ActivityListViewModel()
                {
                    data = new List<ActivityListDto>(),
                    message = string.Empty,
                    platform = parameter.platform,
                    response = parameter.request,
                    result = _failedStatusName
                };
            }
        }
    }
}