using Activity_Demo_Common;
using Activity_Demo_Repositories.Interfaces;
using CoreProfiler;
using CoreProfiler.Data;
using System.Data;
using System.Data.SqlClient;

namespace Activity_Demo_Repositories.Helper
{
    public class DatabaseHelper : IDatabaseHelper
    {
        /// <summary>
        /// Gets the profiled connection (with NanoProfiler).
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="currentSession">The current session.</param>
        /// <returns>IDbConnection.</returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public IDbConnection GetProfiledConnection(
            string connectionString, ProfilingSession currentSession)
        {
            var profiler = GetProfiler(ProfilingSession.Current);
            var conn = this.GetConnection(connectionString, profiler);
            return conn;
        }

        /// <summary>
        /// 取得資料庫連線資訊
        /// </summary>
        /// <returns>資料庫連線資訊</returns>
        public string GetConnection()
        {
            return ProjectConstants.DB.Activity;
        }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="profiler">The profiler.</param>
        /// <returns>IDbConnection.</returns>
        private IDbConnection GetConnection(string connectionString, IProfiler profiler = null)
        {
            var conn = new SqlConnection(connectionString);
            if (profiler == null)
            {
                return conn;
            }
            var dbProfiler = new DbProfiler(profiler);
            return new ProfiledDbConnection(conn, dbProfiler);
        }

        /// <summary>
        /// Gets the profiler.
        /// </summary>
        /// <param name="currentSession">The current session.</param>
        /// <returns>IProfiler.</returns>
        private static IProfiler GetProfiler(ProfilingSession currentSession)
        {
            IProfiler profiler = currentSession == null
                                 ? null
                                 : currentSession.Profiler;

            return profiler;
        }
    }
}
