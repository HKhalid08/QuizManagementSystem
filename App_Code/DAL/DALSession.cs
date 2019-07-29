using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALSession
/// </summary>
public class DALSession
{
	public DALSession()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertSession(BLLSession objbll)
    {
        SqlParameter[] param = new SqlParameter[7];

        param[0] = new SqlParameter("@session_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Session_id;

        param[1] = new SqlParameter("@description", SqlDbType.NVarChar);
        param[1].Value = objbll.Description;

        param[2] = new SqlParameter("@status", SqlDbType.Bit);
        param[2].Value = objbll.Status;

        param[3] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[3].Value = objbll.Createdby;

        param[4] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[4].Value = objbll.Modifiedby;

        param[5] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[5].Value = objbll.Insert_date;

        param[6] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[6].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertsession", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLSession> SelectSession()
    {
        List<BLLSession> objlist = new List<BLLSession>();
        BLLSession objbll = new BLLSession();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectsession");
        while (dr.Read())
        {
            objbll = new BLLSession();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Session_id = dr["session_id"].ToString();
            objbll.Description = dr["description"].ToString();
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

    public int DeleteSession(BLLSession objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@session_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Session_id;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deletesession", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLSession> SelectSessionbyid(BLLSession objbll)
    {
        List<BLLSession> objlist = new List<BLLSession>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@session_id", SqlDbType.NVarChar);
        param.Value = objbll.Session_id;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectsessionbyid", param);
        while (dr.Read())
        {
            objbll = new BLLSession();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Session_id = dr["session_id"].ToString();
            objbll.Description = dr["description"].ToString();
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

    public int UpdateSession(BLLSession objbll)
    {
        SqlParameter[] param = new SqlParameter[4];

        param[0] = new SqlParameter("@session_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Session_id;

        param[1] = new SqlParameter("@description", SqlDbType.NVarChar);
        param[1].Value = objbll.Description;        

        param[2] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[2].Value = objbll.Modifiedby;        

        param[3] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[3].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updatesession", param);
        objcon.CloseConnection();
        return a;
    }
}