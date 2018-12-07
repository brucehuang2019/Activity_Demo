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
    }
}
