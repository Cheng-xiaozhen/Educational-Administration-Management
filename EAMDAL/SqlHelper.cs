using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAM.DAL
{
    public static class SqlHelper
    {
        private static readonly string conStr = ConfigurationManager.ConnectionStrings["mssql"].ConnectionString;


        public static int ExecuteNonquery(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = cmdType;
                    if (pms != null)
                    {
                        com.Parameters.AddRange(pms);
                    }
                    con.Open();
                    try
                    {
                        return com.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {

                        return 0;
                    }
                }
            }

        }

        public static object ExecuteScalar(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    com.CommandType = cmdType;
                    if (pms != null)
                    {
                        com.Parameters.AddRange(pms);
                    }
                    con.Open();
                    return com.ExecuteScalar();
                }
            }
        }

        public static SqlDataReader ExecuteReader(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            SqlConnection con = new SqlConnection(conStr);
            using (SqlCommand com = new SqlCommand(sql, con))
            {
                com.CommandType = cmdType;
                if (pms != null)
                {
                    com.Parameters.AddRange(pms);
                }
                try
                {
                    con.Open();
                    return com.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                }
                catch
                {
                    con.Close();
                    con.Dispose();
                    throw;
                }
            }
        }

        public static DataTable ExecuteDataTable(string sql, CommandType cmdType, params SqlParameter[] pms)
        {
            DataTable dt = new DataTable();
            using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conStr))
            {
                adapter.SelectCommand.CommandType = cmdType;
                if (pms != null)
                {
                    adapter.SelectCommand.Parameters.AddRange(pms);
                }
                try
                {
                    adapter.Fill(dt);
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return dt;
        }
    }
}
