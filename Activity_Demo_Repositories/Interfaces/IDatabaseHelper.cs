using CoreProfiler;
using System.Data;

namespace Activity_Demo_Repositories.Interfaces
{
    public interface IDatabaseHelper
    {
        /// <summary>
        /// Gets the profiled connection (with NanoProfiler).
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="currentSession">The current session.</param>
        /// <returns>IDbConnection.</returns>
        IDbConnection GetProfiledConnection(
            string connectionString, ProfilingSession currentSession);

        /// <summary>
        /// 取得資料庫連線資訊
        /// </summary>
        /// <returns>資料庫連線資訊</returns>
        string GetConnection();
    }
}
