using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace MISC
{
   public class ConnectionClass
    {
       string sqlconn = ConfigurationSettings.AppSettings["Connection"];
       SqlConnection sqlcon = new SqlConnection();

       public SqlConnection OpenConnection()
       {
           sqlcon.ConnectionString = sqlconn;
           sqlcon.Open();
           return sqlcon;
       }
       public void CloseConnection()
       {
           sqlcon.Close();
       }
       public int sqlcmdInsert(string procedurename, SqlParameter[] param)
       {
           SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.CommandType = CommandType.StoredProcedure;
           sqlcmd.CommandText = procedurename;
           sqlcmd.Connection = sqlcon;
           for (int i = 0; i < param.Length; i++)
           {
               sqlcmd.Parameters.Add(param[i]);
           }
           int a = sqlcmd.ExecuteNonQuery();
           return a;
       }
       public SqlDataReader sqlcmdSelectAll(string procedurename)
       {
           SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.CommandType = CommandType.StoredProcedure;
           sqlcmd.CommandText = procedurename;
           sqlcmd.Connection = sqlcon;
           SqlDataReader dr;
           dr = sqlcmd.ExecuteReader();
           return dr;
       }
       public SqlDataReader sqlcmdSelectById(string procedurename, SqlParameter param)
       {
           SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.CommandType = CommandType.StoredProcedure;
           sqlcmd.CommandText = procedurename;
           sqlcmd.Connection = sqlcon;
           sqlcmd.Parameters.Add(param);
           SqlDataReader dr;
           dr = sqlcmd.ExecuteReader();
           return dr;
       }
       public int sqlcmdUpdateById(string procedurename, SqlParameter[] param)
       {
           SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.CommandType = CommandType.StoredProcedure;
           sqlcmd.CommandText = procedurename;
           sqlcmd.Connection = sqlcon;
           for (int i = 0; i < param.Length; i++)
           {
               sqlcmd.Parameters.Add(param[i]);
           }
           int a = sqlcmd.ExecuteNonQuery();
           return a;
       }
       public int sqlcmdDeleteById(string procedurename, SqlParameter[] param)
       {
           SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.CommandType = CommandType.StoredProcedure;
           sqlcmd.CommandText = procedurename;
           sqlcmd.Connection = sqlcon;
           for (int i = 0; i < param.Length; i++)
           {
               sqlcmd.Parameters.Add(param[i]);
           }
           int a = sqlcmd.ExecuteNonQuery();
           return a;
       }
       public SqlDataReader sqlcmdSelectByMultiprogram(string procedurename, SqlParameter param)
       {
           SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.CommandType = CommandType.StoredProcedure;
           sqlcmd.CommandText = procedurename;
           sqlcmd.Connection = sqlcon;
           sqlcmd.Parameters.Add(param);
           SqlDataReader dr;
           dr = sqlcmd.ExecuteReader();
           return dr;
       }
       public SqlDataReader sqlcmdSelectByMultimoreprogram(string procedurename, SqlParameter[] param)
       {
           SqlCommand sqlcmd = new SqlCommand();
           sqlcmd.CommandType = CommandType.StoredProcedure;
           sqlcmd.CommandText = procedurename;
           sqlcmd.Connection = sqlcon;
           for (int i = 0; i < param.Length; i++)
           {
               sqlcmd.Parameters.Add(param[i]);
           }
           SqlDataReader dr;
           dr = sqlcmd.ExecuteReader();
           return dr;
       }
    }
}
