using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALDepartmentDesignation
/// </summary>
public class DALDepartmentDesignation
{
	public DALDepartmentDesignation()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertDepartment(BLLDepartmentDesignation objbll)
    {
        SqlParameter[] param = new SqlParameter[7];

        param[0] = new SqlParameter("@dep_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Dep_id;

        param[1] = new SqlParameter("@dep_name", SqlDbType.NVarChar);
        param[1].Value = objbll.Dep_name;

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
        int a = objcon.sqlcmdInsert("sp_insertdepartment", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLDepartmentDesignation> SelectDepartment()
    {
        List<BLLDepartmentDesignation> objlist = new List<BLLDepartmentDesignation>();
        BLLDepartmentDesignation objbll = new BLLDepartmentDesignation();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectdepartment");
        while (dr.Read())
        {
            objbll = new BLLDepartmentDesignation();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Dep_id = dr["dep_id"].ToString();
            objbll.Dep_name = dr["dep_name"].ToString();
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

    public int InsertDesignation(BLLDepartmentDesignation objbll)
    {
        SqlParameter[] param = new SqlParameter[7];

        param[0] = new SqlParameter("@des_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Des_id;

        param[1] = new SqlParameter("@des_name", SqlDbType.NVarChar);
        param[1].Value = objbll.Des_name;

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
        int a = objcon.sqlcmdInsert("sp_insertdesignation", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLDepartmentDesignation> SelectDesignation()
    {
        List<BLLDepartmentDesignation> objlist = new List<BLLDepartmentDesignation>();
        BLLDepartmentDesignation objbll = new BLLDepartmentDesignation();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectdesignation");
        while (dr.Read())
        {
            objbll = new BLLDepartmentDesignation();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Des_id = dr["des_id"].ToString();
            objbll.Des_name = dr["des_name"].ToString();
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

    public int DeleteDepartment(BLLDepartmentDesignation objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@dep_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Dep_id;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deletedepartment", param);
        objcon.CloseConnection();
        return a;
    }

    public int DeleteDesignation(BLLDepartmentDesignation objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@des_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Des_id;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deletedesignation", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLDepartmentDesignation> SelectDepartmentbyid(BLLDepartmentDesignation objbll)
    {
        List<BLLDepartmentDesignation> objlist = new List<BLLDepartmentDesignation>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@dep_id", SqlDbType.NVarChar);
        param.Value = objbll.Dep_id;
        
        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectdepartmentbyid", param);
        while (dr.Read())
        {
            objbll = new BLLDepartmentDesignation();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Dep_id = dr["dep_id"].ToString();
            objbll.Dep_name = dr["dep_name"].ToString();
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

    public List<BLLDepartmentDesignation> SelectDesignationbyid(BLLDepartmentDesignation objbll)
    {
        List<BLLDepartmentDesignation> objlist = new List<BLLDepartmentDesignation>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@des_id", SqlDbType.NVarChar);
        param.Value = objbll.Des_id;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectdesignationbyid", param);
        while (dr.Read())
        {
            objbll = new BLLDepartmentDesignation();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Des_id = dr["des_id"].ToString();
            objbll.Des_name = dr["des_name"].ToString();
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

    public int UpdateDepartment(BLLDepartmentDesignation objbll)
    {
        SqlParameter[] param = new SqlParameter[4];

        param[0] = new SqlParameter("@dep_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Dep_id;

        param[1] = new SqlParameter("@dep_name", SqlDbType.NVarChar);
        param[1].Value = objbll.Dep_name;        

        param[2] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[2].Value = objbll.Modifiedby;

        param[3] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[3].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updatedepartment", param);
        objcon.CloseConnection();
        return a;
    }

    public int UpdateDesignation(BLLDepartmentDesignation objbll)
    {
        SqlParameter[] param = new SqlParameter[4];

        param[0] = new SqlParameter("@des_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Des_id;

        param[1] = new SqlParameter("@des_name", SqlDbType.NVarChar);
        param[1].Value = objbll.Des_name;        

        param[2] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[2].Value = objbll.Modifiedby;

        param[3] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[3].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updatedesignation", param);
        objcon.CloseConnection();
        return a;
    }
}