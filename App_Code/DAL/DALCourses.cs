using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALCourses
/// </summary>
public class DALCourses
{
	public DALCourses()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertCourses(BLLCourses objbll)
    {
        SqlParameter[] param = new SqlParameter[10];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_title;

        param[2] = new SqlParameter("@short_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Short_name;

        param[3] = new SqlParameter("@credit_hours", SqlDbType.NVarChar);
        param[3].Value = objbll.Credit_hours;

        param[4] = new SqlParameter("@cetegory", SqlDbType.NVarChar);
        param[4].Value = objbll.Cetegory;

        param[5] = new SqlParameter("@status", SqlDbType.Bit);
        param[5].Value = objbll.Status;

        param[6] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[6].Value = objbll.Createdby;

        param[7] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[7].Value = objbll.Modifiedby;

        param[8] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[8].Value = objbll.Insert_date;

        param[9] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[9].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertcourses", param);
        objcon.CloseConnection();
        return a;
    }

    public int InsertCourseContent(BLLCourses objbll)
    {
        SqlParameter[] param = new SqlParameter[4];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@course_content", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_content;

        param[2] = new SqlParameter("@course_synopsis", SqlDbType.NVarChar);
        param[2].Value = objbll.Course_synopsis;

        param[3] = new SqlParameter("@learning_outcomes", SqlDbType.NVarChar);
        param[3].Value = objbll.Learning_outcomes;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertcoursecontent", param);
        objcon.CloseConnection();
        return a;
    }

    public int InsertCourseCalendar(BLLCourses objbll)
    {
        SqlParameter[] param = new SqlParameter[4];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@topic", SqlDbType.NVarChar);
        param[1].Value = objbll.Topic;

        param[2] = new SqlParameter("@lecture", SqlDbType.NVarChar);
        param[2].Value = objbll.Lecture;

        param[3] = new SqlParameter("@resource", SqlDbType.NVarChar);
        param[3].Value = objbll.Resource;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertcoursecalendar", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLCourses> SelectCourses()
    {
        List<BLLCourses> objlist = new List<BLLCourses>();
        BLLCourses objbll = new BLLCourses();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectcourses");
        while (dr.Read())
        {
            objbll = new BLLCourses();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Short_name = dr["short_name"].ToString();
            objbll.Credit_hours = dr["credit_hours"].ToString();
            objbll.Cetegory = dr["cetegory"].ToString();
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

    public List<BLLCourses> Selectcoursecodeebyname(BLLCourses objbll)
    {
        List<BLLCourses> objlist = new List<BLLCourses>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param.Value = objbll.Course_title;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectcoursecodebyname", param);
        while (dr.Read())
        {
            objbll = new BLLCourses();
            objbll.Course_code = dr["course_code"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLCourses> Selectcontentbycourse(BLLCourses objbll)
    {
        List<BLLCourses> objlist = new List<BLLCourses>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param.Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectcoursecontents", param);
        while (dr.Read())
        {
            objbll = new BLLCourses();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_content = dr["course_content"].ToString();
            objbll.Course_synopsis = dr["course_synopsis"].ToString();
            objbll.Learning_outcomes = dr["learning_outcomes"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLCourses> Selectcalenderbycourse(BLLCourses objbll)
    {
        List<BLLCourses> objlist = new List<BLLCourses>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param.Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectcoursecalender", param);
        while (dr.Read())
        {
            objbll = new BLLCourses();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Topic = dr["topic"].ToString();
            objbll.Lecture = dr["lecture"].ToString();
            objbll.Resource = dr["resource"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLCourses> Selectcoursewebsite(BLLCourses objbll)
    {
        List<BLLCourses> objlist = new List<BLLCourses>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_title;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectcoursewebsite", param);
        while (dr.Read())
        {
            objbll = new BLLCourses();
            objbll.Emp_code = dr["emp_code"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Email = dr["email"].ToString();
            objbll.About = dr["about"].ToString();
            objbll.Pic_name = dr["pic_name"].ToString();
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Credit_hours = dr["credit_hours"].ToString();
            objbll.Cetegory = dr["cetegory"].ToString();
            objbll.Course_content = dr["course_content"].ToString();
            objbll.Course_synopsis = dr["course_synopsis"].ToString();
            objbll.Learning_outcomes = dr["learning_outcomes"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLCourses> Selectcoursewebsitecalender(BLLCourses objbll)
    {
        List<BLLCourses> objlist = new List<BLLCourses>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param.Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectcoursewebsitecalender", param);
        while (dr.Read())
        {
            objbll = new BLLCourses();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Topic = dr["topic"].ToString();
            objbll.Lecture = dr["lecture"].ToString();
            objbll.Resource = dr["resource"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLCourses> SelectCoursesbyid(BLLCourses objbll)
    {
        List<BLLCourses> objlist = new List<BLLCourses>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param.Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectcoursesbyid", param);
        while (dr.Read())
        {
            objbll = new BLLCourses();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Short_name = dr["short_name"].ToString();
            objbll.Credit_hours = dr["credit_hours"].ToString();
            objbll.Cetegory = dr["cetegory"].ToString();
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

    public int UpdateCourses(BLLCourses objbll)
    {
        SqlParameter[] param = new SqlParameter[7];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_title;

        param[2] = new SqlParameter("@short_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Short_name;

        param[3] = new SqlParameter("@credit_hours", SqlDbType.NVarChar);
        param[3].Value = objbll.Credit_hours;

        param[4] = new SqlParameter("@cetegory", SqlDbType.NVarChar);
        param[4].Value = objbll.Cetegory;

        param[5] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[5].Value = objbll.Modifiedby;

        param[6] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[6].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updatecourses", param);
        objcon.CloseConnection();
        return a;
    }

    public int DeleteCourse(BLLCourses objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deletecourse", param);
        objcon.CloseConnection();
        return a;
    }
}