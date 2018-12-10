using Activity_Demo_Common.Enums;
using System;
using System.Configuration;

namespace Activity_Demo_Common
{
    public class ProjectConstants
    {
        public static class DB
        {
            /// <summary>
            /// 活動
            /// </summary>
            public static string Activity { get { return ConfigurationManager.ConnectionStrings["ConnectionStringActivity"].ConnectionString; } }
        }

        public static class Language
        {
            /// <summary>
            /// 取得語言
            /// </summary>
            /// <param name="languageEnum">語言參數</param>
            /// <returns>語言代碼</returns>
            public static LanguageEnum GetLanguage(LanguageEnum? languageEnum)
            {
                return languageEnum.HasValue ? languageEnum.Value : LanguageEnum.TW;
            }
        }

        public static class ResultStatus
        {
            /// <summary>
            /// API回應成功訊息名稱
            /// </summary>
            public static string SuccessName { get { return "success"; } }
            /// <summary>
            /// API回應失敗訊息名稱
            /// </summary>
            public static string FailedName { get { return "failed"; } }
        }
    }
}
