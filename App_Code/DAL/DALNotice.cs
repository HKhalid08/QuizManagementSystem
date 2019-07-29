using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALNotice
/// </summary>
public class DALNotice
{
	public DALNotice()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertNotice(BLLNotice objbll)
    {
        SqlParameter[] param = new SqlParameter[8];

        param[0] = new SqlParameter("@notice_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Notice_id;

        param[1] = new SqlParameter("@title", SqlDbType.NVarChar);
        param[1].Value = objbll.Title;

        param[2] = new SqlParameter("@description", SqlDbType.NVarChar);
        param[2].Value = objbll.Description;

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
        int a = objcon.sqlcmdInsert("sp_insertnotice", param);
        objcon.CloseConnection();
        return a;
    }

    public int InsertNotification(BLLNotice objbll)
    {
        SqlParameter[] param = new SqlParameter[8];

        param[0] = new SqlParameter("@notification_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Notification_id;

        param[1] = new SqlParameter("@title", SqlDbType.NVarChar);
        param[1].Value = objbll.Title;

        param[2] = new SqlParameter("@description", SqlDbType.NVarChar);
        param[2].Value = objbll.Description;

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
        int a = objcon.sqlcmdInsert("sp_insertnotification", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLNotice> SelectNotice()
    {
        List<BLLNotice> objlist = new List<BLLNotice>();
        BLLNotice objbll = new BLLNotice();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectnotice");
        while (dr.Read())
        {
            objbll = new BLLNotice();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Notice_id = dr["notice_id"].ToString();
            objbll.Title = dr["title"].ToString();
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

    public List<BLLNotice> SelectNotification()
    {
        List<BLLNotice> objlist = new List<BLLNotice>();
        BLLNotice objbll = new BLLNotice();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectnotification");
        while (dr.Read())
        {
            objbll = new BLLNotice();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Notification_id = dr["notification_id"].ToString();
            objbll.Title = dr["title"].ToString();
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

    public List<BLLNotice> SelectNoticebyid(BLLNotice objbll)
    {
        List<BLLNotice> objlist = new List<BLLNotice>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@notice_id", SqlDbType.NVarChar);
        param.Value = objbll.Notice_id;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectnoticebyid", param);
        while (dr.Read())
        {
            objbll = new BLLNotice();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Notice_id = dr["notice_id"].ToString();
            objbll.Title = dr["title"].ToString();
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

    public int UpdateNotice(BLLNotice objbll)
    {
        SqlParameter[] param = new SqlParameter[5];

        param[0] = new SqlParameter("@notice_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Notice_id;

        param[1] = new SqlParameter("@title", SqlDbType.NVarChar);
        param[1].Value = objbll.Title;

        param[2] = new SqlParameter("@description", SqlDbType.NVarChar);
        param[2].Value = objbll.Description;

        param[3] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[3].Value = objbll.Modifiedby;

        param[4] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[4].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updatenotice", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLNotice> SelectNotificationbyid(BLLNotice objbll)
    {
        List<BLLNotice> objlist = new List<BLLNotice>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@notification_id", SqlDbType.NVarChar);
        param.Value = objbll.Notification_id;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectnotificationbyid", param);
        while (dr.Read())
        {
            objbll = new BLLNotice();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Notification_id = dr["notification_id"].ToString();
            objbll.Title = dr["title"].ToString();
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

    public int UpdateNotification(BLLNotice objbll)
    {
        SqlParameter[] param = new SqlParameter[5];

        param[0] = new SqlParameter("@notification_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Notification_id;

        param[1] = new SqlParameter("@title", SqlDbType.NVarChar);
        param[1].Value = objbll.Title;

        param[2] = new SqlParameter("@description", SqlDbType.NVarChar);
        param[2].Value = objbll.Description;

        param[3] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[3].Value = objbll.Modifiedby;

        param[4] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[4].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updatenotification", param);
        objcon.CloseConnection();
        return a;
    }

    public int DeleteNotice(BLLNotice objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@notice_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Notice_id;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deletenotice", param);
        objcon.CloseConnection();
        return a;
    }

    public int DeleteNotification(BLLNotice objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@notification_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Notification_id;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deletenotification", param);
        objcon.CloseConnection();
        return a;
    }
}