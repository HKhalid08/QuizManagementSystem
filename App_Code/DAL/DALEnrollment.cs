using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALEnrollment
/// </summary>
public class DALEnrollment
{
	public DALEnrollment()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertStudentEnrollment(BLLEnrollment objbll)
    {
        SqlParameter[] param = new SqlParameter[9];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

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
        int a = objcon.sqlcmdInsert("sp_insertstuenrollment", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLEnrollment> SelectStudentEnrollment()
    {
        List<BLLEnrollment> objlist = new List<BLLEnrollment>();
        BLLEnrollment objbll = new BLLEnrollment();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectstuenrollment");
        while (dr.Read())
        {
            objbll = new BLLEnrollment();
            //objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Session_id = dr["session"].ToString();
            //objbll.Course = dr["course_title"].ToString();
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

    public List<BLLEnrollment> Selectenrollcoursebyrollno(BLLEnrollment objbll)
    {
        List<BLLEnrollment> objlist = new List<BLLEnrollment>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param.Value = objbll.Rollno;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectstuenrollmentbyrollno", param);
        while (dr.Read())
        {
            objbll = new BLLEnrollment();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Session_id = dr["description"].ToString();
            objbll.Course = dr["course_title"].ToString();
            objbll.Course_code = dr["course_code"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLEnrollment> Selectstudentforgradebook(BLLEnrollment objbll)
    {
        List<BLLEnrollment> objlist = new List<BLLEnrollment>();

        SqlParameter[] param = new SqlParameter[3];

        param[0] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[0].Value = objbll.Quiz_name;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        param[2] = new SqlParameter("@type", SqlDbType.NVarChar);
        param[2].Value = objbll.Course;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectstudentforgradebook", param);
        while (dr.Read())
        {
            objbll = new BLLEnrollment();
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.No_of_question = dr["no_of_question"].ToString();
            objbll.Total_marks = dr["total_marks"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }
}