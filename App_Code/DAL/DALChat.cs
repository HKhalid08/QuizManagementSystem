using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALChat
/// </summary>
public class DALChat
{
	public DALChat()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertChat(BLLChat objbll)
    {
        SqlParameter[] param = new SqlParameter[5];

        param[0] = new SqlParameter("@message", SqlDbType.NVarChar);
        param[0].Value = objbll.Message;

        param[1] = new SqlParameter("@message_to", SqlDbType.NVarChar);
        param[1].Value = objbll.Message_to;

        param[2] = new SqlParameter("@message_from", SqlDbType.NVarChar);
        param[2].Value = objbll.Message_from;

        param[3] = new SqlParameter("@message_status", SqlDbType.NVarChar);
        param[3].Value = objbll.Message_status;

        param[4] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[4].Value = objbll.Insert_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertchat", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLChat> SelectMessage(BLLChat objbll)
    {
        List<BLLChat> objlist = new List<BLLChat>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@message_from", SqlDbType.NVarChar);
        param[0].Value = objbll.Message_from;

        param[1] = new SqlParameter("@message_to", SqlDbType.NVarChar);
        param[1].Value = objbll.Message_to;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectmessage", param);
        while (dr.Read())
        {
            objbll = new BLLChat();
            objbll.Message = dr["message"].ToString();
            objbll.Message_from = dr["message_from"].ToString();
            objbll.Message_to = dr["message_to"].ToString();
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }
}