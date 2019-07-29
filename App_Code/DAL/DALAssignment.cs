using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALAssignment
/// </summary>
public class DALAssignment
{
	public DALAssignment()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertAssignment(BLLAssignment objbll)
    {
        SqlParameter[] param = new SqlParameter[13];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_title;

        param[2] = new SqlParameter("@title", SqlDbType.NVarChar);
        param[2].Value = objbll.Title;

        param[3] = new SqlParameter("@lesson", SqlDbType.NVarChar);
        param[3].Value = objbll.Lesson;

        param[4] = new SqlParameter("@assignment_name", SqlDbType.NVarChar);
        param[4].Value = objbll.Assignment_name;

        param[5] = new SqlParameter("@assignment_path", SqlDbType.NVarChar);
        param[5].Value = objbll.Assignment_path;

        param[6] = new SqlParameter("@total_marks", SqlDbType.NVarChar);
        param[6].Value = objbll.Total_marks;

        param[7] = new SqlParameter("@due_date", SqlDbType.DateTime);
        param[7].Value = objbll.Due_date;

        param[8] = new SqlParameter("@status", SqlDbType.Bit);
        param[8].Value = objbll.Status;

        param[9] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[9].Value = objbll.Createdby;

        param[10] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[10].Value = objbll.Modifiedby;

        param[11] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[11].Value = objbll.Insert_date;

        param[12] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[12].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertassignment", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLAssignment> SelectAssignment(BLLAssignment objbll)
    {
        List<BLLAssignment> objlist = new List<BLLAssignment>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_title;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectassignment", param);
        while (dr.Read())
        {
            objbll = new BLLAssignment();
            objbll.Title = dr["title"].ToString();
            objbll.Lesson = dr["lesson"].ToString();
            objbll.Assignment_name = dr["assignment_name"].ToString();
            objbll.Assignment_path = dr["assignment_path"].ToString();
            objbll.Total_marks = dr["total_marks"].ToString();
            objbll.Due_date = Convert.ToDateTime(dr["due_date"].ToString());
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public int InsertAssignmentSolution(BLLAssignment objbll)
    {
        SqlParameter[] param = new SqlParameter[9];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
        param[1].Value = objbll.Name;

        param[2] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[2].Value = objbll.Course_code;

        param[3] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[3].Value = objbll.Course_title;

        param[4] = new SqlParameter("@topic", SqlDbType.NVarChar);
        param[4].Value = objbll.Title;

        param[5] = new SqlParameter("@total_marks", SqlDbType.NVarChar);
        param[5].Value = objbll.Total_marks;

        param[6] = new SqlParameter("@assignment_path", SqlDbType.NVarChar);
        param[6].Value = objbll.Assignment_path;

        param[7] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[7].Value = objbll.Insert_date;

        param[8] = new SqlParameter("@status", SqlDbType.Bit);
        param[8].Value = "False";

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertassignmentsolution", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLAssignment> SelectAssignmentNamebycode(BLLAssignment objbll)
    {
        List<BLLAssignment> objlist = new List<BLLAssignment>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectassignmentnamebycode", param);
        while (dr.Read())
        {
            objbll = new BLLAssignment();
            objbll.Title = dr["title"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLAssignment> SelectAssignmentSolution(BLLAssignment objbll)
    {
        List<BLLAssignment> objlist = new List<BLLAssignment>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectassignmentsolution", param);
        while (dr.Read())
        {
            objbll = new BLLAssignment();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Title = dr["topic"].ToString();
            objbll.Assignment_path = dr["assignment_path"].ToString();
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }
}