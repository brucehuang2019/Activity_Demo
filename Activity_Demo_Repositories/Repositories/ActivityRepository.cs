using Activity_Demo_Repositories.Interfaces;
using CoreProfiler;
using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Activity_Demo_Common.DataTransferObjects;
using Activity_Demo_Common.ParameterDTOs;

namespace Activity_Demo_Repositories.Repositories
{
    public class ActivityRepository : IActivityRepository
    {
        private IDatabaseHelper _databaseHelper;

        public ActivityRepository(IDatabaseHelper databaseHelper)
        {
            this._databaseHelper = databaseHelper;
        }

        /// <summary>
        /// 取得活動內容
        /// </summary>
        /// <param name="activity_id">活動ID</param>
        /// <returns>活動內容</returns>
        public ActivityContentDto GetActivityContent(int activity_id)
        {
            using (ProfilingSession.Current.Step($"ActivityRepository-GetActivityContent"))
            {
                string connInfo = this._databaseHelper.GetConnection();

                var profiledDbConnection =
                    this._databaseHelper.GetProfiledConnection(connInfo, ProfilingSession.Current);

                var dynamicParams = new DynamicParameters();

                string sql = $@"SELECT 
                                        ActivityID
                                        ActivityCode
                                        ActivityName
                                        BeginDate
                                        EndDate
                                        ActivityAddress
                                        RelatedLink
                                        Tags
                                        ActivityContent
                                        CreateDate
                                FROM
                                        Activity WITH (NOLOCK)
                                WHERE
                                        ActivityID=@ActivityID
                            ";

                dynamicParams.Add("ActivityID", activity_id);

                using (var conn = profiledDbConnection)
                {
                    conn.Open();

                    var dto = conn.Query<ActivityContentDto>(sql, dynamicParams).SingleOrDefault();

                    if (dto == null)
                    {
                        return new ActivityContentDto();
                    }

                    return dto;
                }
            }
        }

        /// <summary>
        /// 取得活動列表
        /// </summary>
        /// <param name="parameterDto">活動列表搜尋參數</param>
        /// <returns>活動列表</returns>
        public List<ActivityListDto> GetActivityList(ActivityListSearchParameterDto parameterDto)
        {
            using (ProfilingSession.Current.Step($"ActivityRepository-GetActivityList"))
            {
                string connInfo = this._databaseHelper.GetConnection();

                var profiledDbConnection =
                    this._databaseHelper.GetProfiledConnection(connInfo, ProfilingSession.Current);

                var dynamicParams = new DynamicParameters();

                string sql = $@"SELECT 
                                        ActivityID,
                                        ActivityCode,
                                        ActivityName,
                                        BeginDate,
                                        ClickCount,
                                        CollectionCount
                                FROM
                                        Activity WITH (NOLOCK)
                                ORDER BY
                                        BeginDate DESC
                                OFFSET @OFFSET
                                ROWS FETCH NEXT @REQUEST_COUNT
                                ROWS ONLY
                            ";

                using (var conn = profiledDbConnection)
                {
                    conn.Open();

                    var listDtos = conn.Query<ActivityListDto>(sql, dynamicParams).ToList();

                    if (listDtos == null)
                    {
                        return new List<ActivityListDto>();
                    }

                    return listDtos;
                }
            }
        }
    }
}
