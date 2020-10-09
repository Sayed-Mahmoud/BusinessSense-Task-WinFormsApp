using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BusinessSense_Task
{
    public static class MyFunctions
    {
        public static string MyConnection
        {
            get
            {
                return BusinessSense_Task.Properties.Settings.Default.Task_DB;
            }
        }

        public static object GetScalar(string sql, object parameters = null, CommandType CType = CommandType.Text)
        {
            using (SqlConnection connection = new SqlConnection(MyConnection))
            {
                using (SqlCommand command = new SqlCommand())
                {
                    command.Connection = connection;
#pragma warning disable CA2100 // Review SQL queries for security vulnerabilities
                    command.CommandText = sql;
#pragma warning restore CA2100 // Review SQL queries for security vulnerabilities
                    command.CommandType = CType;
                    if (parameters != null)
                    {
                        if (parameters is SqlParameter[] v)
                            command.Parameters.AddRange(values: v);
                        else if (parameters is SqlParameter parameter)
                            command.Parameters.Add(value: parameter);
                    }
                    connection.Open();
                    try
                    {
                        return command.ExecuteScalar();
                    }
                    catch (SystemException se) when (se is SqlException)
                    {
                        return null;
                    }
                }
            }
        }
    }
}
