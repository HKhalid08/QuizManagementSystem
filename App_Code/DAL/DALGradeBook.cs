using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALGradeBook
/// </summary>
public class DALGradeBook
{
	public DALGradeBook()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertGradeBook(BLLGradeBook objbll)
    {
        SqlParameter[] param = new SqlParameter[14];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
        param[1].Value = objbll.Name;

        param[2] = new SqlParameter("@quiz_type", SqlDbType.NVarChar);
        param[2].Value = objbll.Quiz_type;

        param[3] = new SqlParameter("@quiz_level", SqlDbType.NVarChar);
        param[3].Value = objbll.Quiz_level;

        param[4] = new SqlParameter("@no_of_question", SqlDbType.NVarChar);
        param[4].Value = objbll.No_of_question;

        param[5] = new SqlParameter("@attempt_question", SqlDbType.NVarChar);
        param[5].Value = objbll.Attempt_question;

        param[6] = new SqlParameter("@total_marks", SqlDbType.NVarChar);
        param[6].Value = objbll.Total_marks;

        param[7] = new SqlParameter("@obtained_marks", SqlDbType.NVarChar);
        param[7].Value = objbll.Obtained_mark;

        param[8] = new SqlParameter("@quiz_date", SqlDbType.DateTime);
        param[8].Value = objbll.Quiz_date;

        param[9] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[9].Value = objbll.Createdby;

        param[10] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[10].Value = objbll.Modifiedby;

        param[11] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[11].Value = objbll.Insert_date;

        param[12] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[12].Value = objbll.Update_date;

        param[13] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[13].Value = objbll.Rollno;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertgradebook", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLGradeBook> Selectanswerfromquiz(BLLGradeBook objbll)
    {
        List<BLLGradeBook> objlist = new List<BLLGradeBook>();

        SqlParameter[] param = new SqlParameter[3];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        param[2] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Name;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectanswerfromquizanswer", param);
        while (dr.Read())
        {
            objbll = new BLLGradeBook();
            objbll.Attempt_question = dr["attempt_question"].ToString();
            objbll.Obtained_mark = dr["obtained_marks"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLGradeBook> Selectmarksbycourseforstu(BLLGradeBook objbll)
    {
        List<BLLGradeBook> objlist = new List<BLLGradeBook>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectmarksbycoursecode", param);
        while (dr.Read())
        {
            objbll = new BLLGradeBook();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_title"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Quiz_type = dr["quiz_type"].ToString();
            objbll.Quiz_level = dr["quiz_level"].ToString();
            objbll.No_of_question = dr["no_of_question"].ToString();
            objbll.Attempt_question = dr["attemp_question"].ToString();
            objbll.Total_marks = dr["total_marks"].ToString();
            objbll.Obtained_mark = dr["obtained_marks"].ToString();
            objbll.Quiz_date = Convert.ToDateTime(dr["quiz_date"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLGradeBook> Selectmarksbycourseforteacher(BLLGradeBook objbll)
    {
        List<BLLGradeBook> objlist = new List<BLLGradeBook>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectmarksbycourseforteacher", param);
        while (dr.Read())
        {
            objbll = new BLLGradeBook();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_title"].ToString();
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Quiz_type = dr["quiz_type"].ToString();
            objbll.Quiz_level = dr["quiz_level"].ToString();
            objbll.No_of_question = dr["no_of_question"].ToString();
            objbll.Attempt_question = dr["attemp_question"].ToString();
            objbll.Total_marks = dr["total_marks"].ToString();
            objbll.Obtained_mark = dr["obtained_marks"].ToString();
            objbll.Quiz_date = Convert.ToDateTime(dr["quiz_date"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLGradeBook> Selectstudentforgradebook(BLLGradeBook objbll)
    {
        List<BLLGradeBook> objlist = new List<BLLGradeBook>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectmarksbycourseforteacher", param);
        while (dr.Read())
        {
            objbll = new BLLGradeBook();
            objbll.Course_code = dr["course_title"].ToString();
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Quiz_type = dr["quiz_type"].ToString();
            objbll.Quiz_level = dr["quiz_level"].ToString();
            objbll.No_of_question = dr["no_of_question"].ToString();
            objbll.Attempt_question = dr["attempt_question"].ToString();
            objbll.Total_marks = dr["total_marks"].ToString();
            objbll.Obtained_mark = dr["obtained_marks"].ToString();
            objbll.Quiz_date = Convert.ToDateTime(dr["quiz_date"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }
}