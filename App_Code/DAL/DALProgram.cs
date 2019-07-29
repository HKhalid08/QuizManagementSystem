using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALProgram
/// </summary>
public class DALProgram
{
    public DALProgram()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    ConnectionClass objcon = new ConnectionClass();

    public int InsertProgram(BLLProgram objbll)
    {
        SqlParameter[] param = new SqlParameter[8];

        param[0] = new SqlParameter("@program_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Program_id;

        param[1] = new SqlParameter("@program_name", SqlDbType.NVarChar);
        param[1].Value = objbll.Program_name;

        param[2] = new SqlParameter("@credit_hours", SqlDbType.NVarChar);
        param[2].Value = objbll.Credit_hours;

        param[3] = new SqlParameter("@status", SqlDbType.Bit);
        param[3].Value = objbll.Status;

        param[4] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[4].Value = objbll.Createdby;

        param[5] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[5].Value = objbll.Modifiedby;

        param[6] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[6].Value = objbll.Insert_date;

        param[7] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[7].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertprogram", param);
        objcon.CloseConnection();
        return a;
    }

     public List<BLLProgram> SelectProgram()
    {
        List<BLLProgram> objlist = new List<BLLProgram>();
        BLLProgram objbll = new BLLProgram();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectprogram");
        while (dr.Read())
        {
            objbll = new BLLProgram();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Program_id = dr["program_id"].ToString();
            objbll.Program_name = dr["program_name"].ToString();
            objbll.Credit_hours = dr["credit_hours"].ToString();
            objbll.Status = Convert.ToBoolean(dr["status"].ToString());
            objbll.Createdby = dr["createdby"].ToString();
            objbll.Modifiedby = dr["modifiedby"].ToString();
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objbll.Update_date = Convert.ToDateTime(dr["update_date"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

     public int DeleteProgram(BLLProgram objbll)
     {
         SqlParameter[] param = new SqlParameter[1];

         param[0] = new SqlParameter("@program_id", SqlDbType.NVarChar);
         param[0].Value = objbll.Program_id;

         objcon.OpenConnection();
         int a = objcon.sqlcmdUpdateById("sp_deleteprogram", param);
         objcon.CloseConnection();
         return a;
     }

     public List<BLLProgram> SelectProgrambyid(BLLProgram objbll)
     {
         List<BLLProgram> objlist = new List<BLLProgram>();

         SqlParameter param = new SqlParameter();

         param = new SqlParameter("@program_id", SqlDbType.NVarChar);
         param.Value = objbll.Program_id;

         SqlDataReader dr;
         objcon.OpenConnection();
         dr = objcon.sqlcmdSelectById("sp_selectprogrambyid", param);
         while (dr.Read())
         {
             objbll = new BLLProgram();
             objbll.Id = Convert.ToInt32(dr["id"].ToString());
             objbll.Program_id = dr["program_id"].ToString();
             objbll.Program_name = dr["program_name"].ToString();
             objbll.Credit_hours = dr["credit_hours"].ToString();
             objbll.Status = Convert.ToBoolean(dr["status"].ToString());
             objbll.Createdby = dr["createdby"].ToString();
             objbll.Modifiedby = dr["modifiedby"].ToString();
             objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
             objbll.Update_date = Convert.ToDateTime(dr["update_date"].ToString());
             objlist.Add(objbll);
         }
         objcon.CloseConnection();
         return objlist;
     }

     public int UpdateProgram(BLLProgram objbll)
     {
         SqlParameter[] param = new SqlParameter[5];

         param[0] = new SqlParameter("@program_id", SqlDbType.NVarChar);
         param[0].Value = objbll.Program_id;

         param[1] = new SqlParameter("@program_name", SqlDbType.NVarChar);
         param[1].Value = objbll.Program_name;

         param[2] = new SqlParameter("@credit_hours", SqlDbType.NVarChar);
         param[2].Value = objbll.Credit_hours;

         param[3] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
         param[3].Value = objbll.Modifiedby;

         param[4] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
         param[4].Value = objbll.Update_date;

         objcon.OpenConnection();
         int a = objcon.sqlcmdUpdateById("sp_updateprogram", param);
         objcon.CloseConnection();
         return a;
     }
}