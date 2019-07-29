using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALUserRights
/// </summary>
public class DALUserRights
{
	public DALUserRights()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public List<BLLUserRights> SelectApplicationDetail()
    {
        List<BLLUserRights> objlist = new List<BLLUserRights>();
        BLLUserRights objbll = new BLLUserRights();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectappdetail");
        while (dr.Read())
        {
            objbll = new BLLUserRights();
            objbll.App_detail = dr["app_detail"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public int Insertuserrights(BLLUserRights objbll)
    {
        SqlParameter[] param = new SqlParameter[11];

        param[0] = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Emp_code;

        param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
        param[1].Value = objbll.Name;

        param[2] = new SqlParameter("@app_detail", SqlDbType.NVarChar);
        param[2].Value = objbll.App_detail;

        param[3] = new SqlParameter("@rights", SqlDbType.Bit);
        param[3].Value = objbll.Rights;

        param[4] = new SqlParameter("@r_add", SqlDbType.Bit);
        param[4].Value = objbll.R_add;

        param[5] = new SqlParameter("@r_visible", SqlDbType.Bit);
        param[5].Value = objbll.R_visible;

        param[6] = new SqlParameter("@r_edit", SqlDbType.Bit);
        param[6].Value = objbll.R_edit;

        param[7] = new SqlParameter("@r_delete", SqlDbType.Bit);
        param[7].Value = objbll.R_delete;

        param[8] = new SqlParameter("@status", SqlDbType.Bit);
        param[8].Value = objbll.Status;

        param[9] = new SqlParameter("@insert_date", SqlDbType.DateTime);
        param[9].Value = objbll.Insert_date;

        param[10] = new SqlParameter("@update_date", SqlDbType.DateTime);
        param[10].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertuserrights", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLUserRights> Selectuserrights(BLLUserRights objbll)
    {
        List<BLLUserRights> objlist = new List<BLLUserRights>();
        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Emp_code;

        param[1] = new SqlParameter("@app_detail", SqlDbType.NVarChar);
        param[1].Value = objbll.App_detail;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectuserrights", param);
        while (dr.Read())
        {
            objbll = new BLLUserRights();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Emp_code = dr["emp_code"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.App_detail = dr["app_detail"].ToString();
            objbll.Rrights = (dr["rights"].ToString());
            objbll.Rr_add = (dr["r_add"].ToString());
            objbll.Rr_visible = (dr["r_visible"].ToString());
            objbll.Rr_edit = (dr["r_edit"].ToString());
            objbll.Rr_delete = (dr["r_delete"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }
}