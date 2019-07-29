using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALQuizSetting
/// </summary>
public class DALQuizSetting
{
	public DALQuizSetting()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertQuizSetting(BLLQuizSetting objbll)
    {
        SqlParameter[] param = new SqlParameter[18];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_title;

        param[2] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Quiz_name;

        param[3] = new SqlParameter("@no_of_question", SqlDbType.NVarChar);
        param[3].Value = objbll.No_of_question;

        param[4] = new SqlParameter("@total_marks", SqlDbType.NVarChar);
        param[4].Value = objbll.Total_marks;

        param[5] = new SqlParameter("@passing_marks", SqlDbType.NVarChar);
        param[5].Value = objbll.Passing_marks;

        param[6] = new SqlParameter("@quiz_time", SqlDbType.NVarChar);
        param[6].Value = objbll.Quiz_time;

        param[7] = new SqlParameter("@quiz_type", SqlDbType.NVarChar);
        param[7].Value = objbll.Quiz_type;

        param[8] = new SqlParameter("@quiz_start_date", SqlDbType.NVarChar);
        param[8].Value = objbll.Quiz_start_date;

        param[9] = new SqlParameter("@quiz_end_date", SqlDbType.NVarChar);
        param[9].Value = objbll.Quiz_end_date;

        param[10] = new SqlParameter("@status", SqlDbType.Bit);
        param[10].Value = objbll.Status;

        param[11] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[11].Value = objbll.Createdby;

        param[12] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[12].Value = objbll.Modifiedby;

        param[13] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[13].Value = objbll.Insert_date;

        param[14] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[14].Value = objbll.Update_date;

        param[15] = new SqlParameter("@topic", SqlDbType.NVarChar);
        param[15].Value = objbll.Topic;

        param[16] = new SqlParameter("@quiz_level", SqlDbType.NVarChar);
        param[16].Value = objbll.Quiz_level;

        param[17] = new SqlParameter("@quiz_status", SqlDbType.Bit);
        param[17].Value = objbll.Quiz_status;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertquizsetting", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLQuizSetting> SelectQuiz(BLLQuizSetting objbll)
    {
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectquizsetting", param);
        while (dr.Read())
        {
            objbll = new BLLQuizSetting();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Quiz_name = dr["quiz_name"].ToString();
            objbll.Quiz_type = dr["quiz_type"].ToString();
            objbll.Quiz_start_date = Convert.ToDateTime(dr["quiz_start_date"].ToString());
            objbll.Quiz_end_date = Convert.ToDateTime(dr["quiz_end_date"].ToString());
            objbll.Quiz_status = Convert.ToBoolean(dr["quiz_status"].ToString());
            objbll.Topic = dr["topic"].ToString();
            objbll.Quiz_level = dr["quiz_level"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLQuizSetting> SelecttakeQuiz(BLLQuizSetting objbll)
    {
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@id", SqlDbType.Int);
        param[0].Value = objbll.Id;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selecttakequiz", param);
        while (dr.Read())
        {
            objbll = new BLLQuizSetting();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Quiz_name = dr["quiz_name"].ToString();
            objbll.No_of_question = dr["no_of_question"].ToString();
            objbll.Total_marks = dr["total_marks"].ToString();
            objbll.Passing_marks = dr["passing_marks"].ToString();
            objbll.Quiz_time = dr["quiz_time"].ToString();
            objbll.Quiz_type = dr["quiz_type"].ToString();
            objbll.Quiz_start_date = Convert.ToDateTime(dr["quiz_start_date"].ToString());
            objbll.Quiz_end_date = Convert.ToDateTime(dr["quiz_end_date"].ToString());
            objbll.Status = Convert.ToBoolean(dr["status"].ToString());
            objbll.Createdby = dr["createdby"].ToString();
            objbll.Modifiedby = dr["modifiedby"].ToString();
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objbll.Update_date = Convert.ToDateTime(dr["update_date"].ToString());
            objbll.Topic = dr["topic"].ToString();
            objbll.Quiz_level = dr["quiz_level"].ToString();
            objbll.Quiz_status = Convert.ToBoolean(dr["quiz_status"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public int InsertQuizAnswer(BLLQuizSetting objbll)
    {
        SqlParameter[] param = new SqlParameter[8];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        param[2] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Quiz_name;

        param[3] = new SqlParameter("@question_id", SqlDbType.NVarChar);
        param[3].Value = objbll.Id;

        param[4] = new SqlParameter("@question", SqlDbType.NVarChar);
        param[4].Value = objbll.Question;

        param[5] = new SqlParameter("@correct_answer", SqlDbType.NVarChar);
        param[5].Value = objbll.Correct_answer;

        param[6] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[6].Value = objbll.Insert_date;

        param[7] = new SqlParameter("@answer_status", SqlDbType.Bit);
        param[7].Value = objbll.Answer_status;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertquizanswer", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLQuizSetting> SelectQuizNameforCheck(BLLQuizSetting objbll)
    {
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();

        SqlParameter[] param = new SqlParameter[3];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        param[2] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Quiz_name;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectquiznameforcheck", param);
        while (dr.Read())
        {
            objbll = new BLLQuizSetting();
            objbll.Quiz_name = dr["quiz_name"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLQuizSetting> SelectQuizNameSubjectiveforCheck(BLLQuizSetting objbll)
    {
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();

        SqlParameter[] param = new SqlParameter[3];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        param[2] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Quiz_name;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectquiznamesubjectiveforcheck", param);
        while (dr.Read())
        {
            objbll = new BLLQuizSetting();
            objbll.Quiz_name = dr["quiz_name"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLQuizSetting> SelectQuizNamebycode(BLLQuizSetting objbll)
    {
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectquiznamebycode", param);
        while (dr.Read())
        {
            objbll = new BLLQuizSetting();
            objbll.Quiz_name = dr["quiz_name"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public int InsertQuizAnswerSubjective(BLLQuizSetting objbll)
    {
        SqlParameter[] param = new SqlParameter[7];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        param[2] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Quiz_name;

        param[3] = new SqlParameter("@question_id", SqlDbType.NVarChar);
        param[3].Value = objbll.Id;

        param[4] = new SqlParameter("@question", SqlDbType.NVarChar);
        param[4].Value = objbll.Question;

        param[5] = new SqlParameter("@correct_answer", SqlDbType.NVarChar);
        param[5].Value = objbll.Correct_answer;

        param[6] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[6].Value = objbll.Insert_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertquizanswersubjective", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLQuizSetting> Selectsubjectiveanswer(BLLQuizSetting objbll)
    {
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();

        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectsubjectiveanswer", param);
        while (dr.Read())
        {
            objbll = new BLLQuizSetting();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Quiz_name = dr["quiz_name"].ToString();
            objbll.Quiz_level = dr["question_id"].ToString();
            objbll.Question = dr["question"].ToString();
            objbll.Correct_answer = dr["correct_answer"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }
}