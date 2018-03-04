using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRONGER.COMMON.SQL
{
    public class SQLHelper
    {
        /// <summary>
        /// 数据库连接串
        /// </summary>
        private static readonly string connectionStringDev = ConfigurationManager.ConnectionStrings["sqlconnstr"].ToString();

        public static string ConnectionString
        {
            get
            {
                return connectionStringDev;
            }
        }

        private static SqlConnection CreateConnection(string connectionString = "")
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                connectionString = ConnectionString;
            }

            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            return conn;
        }

        public static Task<int> ExecuteNonQueryAsync(SqlConnection conn, string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            if (conn == null)
            {
                return Task.Run<int>(() => { return -1; });
            }

            using (SqlCommand cmd = conn.CreateCommand())
            {
                if (string.IsNullOrEmpty(cmdStr))
                {
                    return Task.Run<int>(() => { return -2; });
                }

                cmd.CommandText = cmdStr;
                if (isProc)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }

                if (timeout != null)
                {
                    cmd.CommandTimeout = timeout.Value;
                }

                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed) conn.Open();
                return cmd.ExecuteNonQueryAsync();
            }
        }

        public static Task<int> ExecuteNonQueryAsync(string connectionString, string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            return ExecuteNonQueryAsync(CreateConnection(connectionString), cmdStr, isProc, timeout, paras);
        }

        public static Task<int> ExecuteNonQueryAsync(string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            return ExecuteNonQueryAsync(CreateConnection(ConnectionString), cmdStr, isProc, timeout, paras);
        }

        /// <summary>
        /// 执行ExecuteNonQuery查询，返回影响行数
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdStr"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns>如果连接对象为空，则返回-1；如果执行命令字符串为空则返回-2；否则返回执行结果</returns>
        public static int ExecuteNonQuery(SqlConnection conn, string cmdStr, bool isProc = false, params SqlParameter[] paras)
        {
            if (conn == null)
            {
                return -1;
            }

            using (SqlCommand cmd = conn.CreateCommand())
            {
                if (string.IsNullOrEmpty(cmdStr))
                {
                    return -2;
                }

                cmd.CommandText = cmdStr;
                if (isProc)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }

                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Broken) conn.Open();
                return cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 通过执行拼接完成后字符串大量插入数据，内部有事务
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdStr"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(SqlConnection conn, string cmdStr, int? timeout = null)
        {
            if (conn == null)
            {
                return -1;
            }

            using (SqlCommand cmd = conn.CreateCommand())
            {
                if (string.IsNullOrEmpty(cmdStr))
                {
                    return -2;
                }

                cmd.CommandText = cmdStr;

                if (timeout != null)
                {
                    cmd.CommandTimeout = timeout.Value;
                }

                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Closed) conn.Open();
                SqlTransaction transaction;
                transaction = conn.BeginTransaction("Transaction");
                cmd.Transaction = transaction;
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    transaction.Commit();
                    return i;
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    return -3;
                }
            }
        }

        /// <summary>
        /// 通过执行拼接完成后字符串大量插入数据，内部有事务
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdStr"></param>
        /// <param name="timeout"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string connectionString, string cmdStr, int? timeout = null)
        {
            return ExecuteNonQuery(CreateConnection(connectionString), cmdStr, timeout);
        }

        public static int ExecuteNonQuery(string connectionString, string cmdStr, bool isProc = false, params SqlParameter[] paras)
        {
            return ExecuteNonQuery(CreateConnection(connectionString), cmdStr, isProc, paras);
        }

        public static int ExecuteNonQuery(string cmdStr, bool isProc = false, params SqlParameter[] paras)
        {
            return ExecuteNonQuery(CreateConnection(ConnectionString), cmdStr, isProc, paras);
        }

        /// <summary>
        /// 执行ExecuteScalar查询，返回首行首列值
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="cmdStr"></param>
        /// <param name="isProc"></param>
        /// <param name="paras"></param>
        /// <returns>如果连接对象为空，则返回-1；如果执行命令字符串为空则返回-2；否则返回执行结果</returns>
        public static object ExecuteScalar(SqlConnection conn, string cmdStr, bool isProc = false, params SqlParameter[] paras)
        {
            if (conn == null)
            {
                return -1;
            }

            using (SqlCommand cmd = conn.CreateCommand())
            {
                if (string.IsNullOrEmpty(cmdStr))
                {
                    return -2;
                }

                cmd.CommandText = cmdStr;
                if (isProc)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }

                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Broken) conn.Open();
                return cmd.ExecuteScalar();
            }
        }

        public static object ExecuteScalar(string connectionString, string cmdStr, bool isProc = false, params SqlParameter[] paras)
        {
            return ExecuteScalar(CreateConnection(connectionString), cmdStr, isProc, paras);
        }

        public static object ExecuteScalar(string cmdStr, bool isProc = false, params SqlParameter[] paras)
        {
            return ExecuteScalar(CreateConnection(ConnectionString), cmdStr, isProc, paras);
        }

        public static Task<object> ExecuteScalarAsync(SqlConnection conn, string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            if (conn == null)
            {
                return Task.Run(() => { return (object)(-1); });
            }

            using (SqlCommand cmd = conn.CreateCommand())
            {
                if (string.IsNullOrEmpty(cmdStr))
                {
                    return Task.Run(() => { return (object)(-2); });
                }

                cmd.CommandText = cmdStr;
                if (isProc)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }

                if (timeout != null)
                {
                    cmd.CommandTimeout = timeout.Value;
                }

                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Broken) conn.Open();
                return cmd.ExecuteScalarAsync();
            }
        }

        public static Task<object> ExecuteScalarAsync(string connectionString, string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            return ExecuteScalarAsync(CreateConnection(connectionString), cmdStr, isProc, timeout, paras);
        }

        public static Task<object> ExecuteScalarAsync(string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            return ExecuteScalarAsync(CreateConnection(ConnectionString), cmdStr, isProc, timeout, paras);
        }

        public static Task<SQLDataResult<DataTable>> ExecuteQueryAsync(SqlConnection conn, string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            return Task.Run(() =>
            {
                SQLDataResult<DataTable> res = new SQLDataResult<DataTable>();
                if (conn == null)
                {
                    res.DataList = null;
                    res.Status = false;
                    res.IsSuccess = ExeSQLResult.NoConnection;
                    return res;
                }

                using (SqlCommand cmd = conn.CreateCommand())
                {
                    if (string.IsNullOrEmpty(cmdStr))
                    {
                        res.DataList = null;
                        res.Status = false;
                        res.IsSuccess = ExeSQLResult.NullCommandString;
                        return res;
                    }

                    cmd.CommandText = cmdStr;
                    if (isProc)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    else
                    {
                        cmd.CommandType = CommandType.Text;
                    }

                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }

                    if (timeout != null)
                    {
                        cmd.CommandTimeout = timeout.Value;
                    }

                    if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Broken) conn.Open();
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    {
                        DataSet set = new DataSet();
                        dataAdapter.Fill(set);
                        if (set.Tables.Count > 0)
                        {
                            res.DataList = new List<DataTable>();
                            for (int i = 0; i < set.Tables.Count; i++)
                            {
                                res.DataList.Add(set.Tables[i]);
                            }
                        }
                        else
                        {
                            res.Status = false;
                            res.IsSuccess = ExeSQLResult.NoResult;
                            res.DataList = null;
                        }
                        return res;
                    }
                }
            });
        }

        public static Task<SQLDataResult<DataTable>> ExecuteQueryAsync(string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            return ExecuteQueryAsync(CreateConnection(ConnectionString), cmdStr, isProc, timeout, paras);
        }

        public static Task<SQLDataResult<DataTable>> ExecuteQueryAsync(string connStr, string cmdStr, bool isProc = false, int? timeout = null, params SqlParameter[] paras)
        {
            return ExecuteQueryAsync(CreateConnection(connStr), cmdStr, isProc, timeout, paras);
        }

        public static SQLDataResult<DataTable> ExecuteQuery(SqlConnection conn, string cmdStr, bool isProc = false, params SqlParameter[] paras)
        {
            SQLDataResult<DataTable> res = new SQLDataResult<DataTable>();
            if (conn == null)
            {
                res.DataList = null;
                res.IsSuccess = ExeSQLResult.NoConnection;
                return res;
            }

            using (SqlCommand cmd = conn.CreateCommand())
            {
                if (string.IsNullOrEmpty(cmdStr))
                {
                    res.DataList = null;
                    res.IsSuccess = ExeSQLResult.NullCommandString;
                    return res;
                }

                cmd.CommandText = cmdStr;
                if (isProc)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd.CommandType = CommandType.Text;
                }

                if (paras != null)
                {
                    cmd.Parameters.AddRange(paras);
                }

                if (conn.State == ConnectionState.Broken || conn.State == ConnectionState.Broken) conn.Open();
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                {
                    DataSet set = new DataSet();
                    dataAdapter.Fill(set);
                    if (set.Tables.Count > 0)
                    {
                        res.DataList = new List<DataTable>();
                        for (int i = 0; i < set.Tables.Count; i++)
                        {
                            res.DataList.Add(set.Tables[i]);
                        }
                        res.IsSuccess = ExeSQLResult.Success;
                    }
                    else
                    {
                        res.IsSuccess = ExeSQLResult.NoResult;
                        res.DataList = null;
                    }
                    return res;
                }
            }
        }

        public static SQLDataResult<DataTable> ExecuteQuery(string cmdStr, bool isProc = false, params SqlParameter[] paras)
        {
            return ExecuteQuery(CreateConnection(ConnectionString), cmdStr, isProc, paras);
        }
    }
}
