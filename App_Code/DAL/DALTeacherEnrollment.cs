using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALTeacherEnrollment
/// </summary>
public class DALTeacherEnrollment
{
	public DALTeacherEnrollment()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertTeacherEnrollment(BLLTeacherEnrollment objbll)
    {
        SqlParameter[] param = new SqlParameter[9];

        param[0] = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Emp_code;

        param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
        param[1].Value = objbll.Name;

        param[2] = new SqlParameter("@session_id", SqlDbType.NVarChar);
        param[2].Value = objbll.Session_id;

        param[3] = new SqlParameter("@course", SqlDbType.NVarChar);
        param[3].Value = objbll.Course;

        param[4] = new SqlParameter("@status", SqlDbType.Bit);
        param[4].Value = objbll.Status;

        param[5] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[5].Value = objbll.Createdby;

        param[6] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[6].Value = objbll.Modifiedby;

        param[7] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[7].Value = objbll.Insert_date;

        param[8] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[8].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertteachenrollment", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLTeacherEnrollment> SelectTeachEnrollment()
    {
        List<BLLTeacherEnrollment> objlist = new List<BLLTeacherEnrollment>();
        BLLTeacherEnrollment objbll = new BLLTeacherEnrollment();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectteachenrollment");
        while (dr.Read())
        {
            objbll = new BLLTeacherEnrollment();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Emp_code = dr["emp_code"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Session_id = dr["session"].ToString();
            objbll.Course = dr["course_title"].ToString();
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

    public List<BLLTeacherEnrollment> Selectassigncoursebyteacher(BLLTeacherEnrollment objbll)
    {
        List<BLLTeacherEnrollment> objlist = new List<BLLTeacherEnrollment>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param.Value = objbll.Emp_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectassgincoursebyteacher", param);
        while (dr.Read())
        {
            objbll = new BLLTeacherEnrollment();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Emp_code = dr["emp_code"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Session_id = dr["description"].ToString();
            objbll.Course = dr["course_title"].ToString();
            objbll.Course_code = dr["course_code"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    } 
}