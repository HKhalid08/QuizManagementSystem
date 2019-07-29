using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALQuestion
/// </summary>
public class DALQuestion
{
	public DALQuestion()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertQuestion(BLLQuestion objbll)
    {
        SqlParameter[] param = new SqlParameter[17];

        param[0] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Course_code;

        param[1] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_title;

        param[2] = new SqlParameter("@answer_type", SqlDbType.NVarChar);
        param[2].Value = objbll.Answer_type;

        param[3] = new SqlParameter("@no_of_question", SqlDbType.NVarChar);
        param[3].Value = objbll.No_of_answer;

        param[4] = new SqlParameter("@topic", SqlDbType.NVarChar);
        param[4].Value = objbll.Topic;

        param[5] = new SqlParameter("@question", SqlDbType.NVarChar);
        param[5].Value = objbll.Question;

        param[6] = new SqlParameter("@ques_level", SqlDbType.NVarChar);
        param[6].Value = objbll.Ques_level;

        param[7] = new SqlParameter("@answer_a", SqlDbType.NVarChar);
        param[7].Value = objbll.Answer_a;

        param[8] = new SqlParameter("@answer_b", SqlDbType.NVarChar);
        param[8].Value = objbll.Answer_b;

        param[9] = new SqlParameter("@answer_c", SqlDbType.NVarChar);
        param[9].Value = objbll.Answer_c;

        param[10] = new SqlParameter("@answer_d", SqlDbType.NVarChar);
        param[10].Value = objbll.Answer_d;

        param[11] = new SqlParameter("@correct_answer", SqlDbType.NVarChar);
        param[11].Value = objbll.Correct_answer;

        param[12] = new SqlParameter("@status", SqlDbType.Bit);
        param[12].Value = objbll.Status;

        param[13] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[13].Value = objbll.Createdby;

        param[14] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[14].Value = objbll.Modifiedby;

        param[15] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[15].Value = objbll.Insert_date;

        param[16] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[16].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertquestion", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLQuestion> SelectQuestion()
    {
        List<BLLQuestion> objlist = new List<BLLQuestion>();
        BLLQuestion objbll = new BLLQuestion();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectquestion");
        while (dr.Read())
        {
            objbll = new BLLQuestion();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Answer_type = dr["answer_type"].ToString();
            objbll.No_of_answer = dr["no_of_question"].ToString();
            objbll.Topic = dr["topic"].ToString();
            objbll.Question = dr["question"].ToString();
            objbll.Ques_level = dr["ques_level"].ToString();
            objbll.Answer_a = dr["answer_a"].ToString();
            objbll.Answer_b = dr["answer_b"].ToString();
            objbll.Answer_c = dr["answer_c"].ToString();
            objbll.Answer_d = dr["answer_d"].ToString();
            objbll.Correct_answer = dr["correct_answer"].ToString();
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

    public List<BLLQuestion> Selectquestionbycourse(BLLQuestion objbll)
    {
        List<BLLQuestion> objlist = new List<BLLQuestion>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param.Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectquestionbycourse", param);
        while (dr.Read())
        {
            objbll = new BLLQuestion();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Answer_type = dr["answer_type"].ToString();
            objbll.No_of_answer = dr["no_of_question"].ToString();
            objbll.Topic = dr["topic"].ToString();
            objbll.Question = dr["question"].ToString();
            objbll.Ques_level = dr["ques_level"].ToString();
            objbll.Answer_a = dr["answer_a"].ToString();
            objbll.Answer_b = dr["answer_b"].ToString();
            objbll.Answer_c = dr["answer_c"].ToString();
            objbll.Answer_d = dr["answer_d"].ToString();
            objbll.Correct_answer = dr["correct_answer"].ToString();
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

    public List<BLLQuestion> Selectquestionforquiz(BLLQuestion objbll)
    {
        List<BLLQuestion> objlist = new List<BLLQuestion>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[0].Value = objbll.Quiz_name;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selecttakequizbjectivequestion", param);
        while (dr.Read())
        {
            objbll = new BLLQuestion();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Question = dr["question"].ToString();
            objbll.Answer_a = dr["answer_a"].ToString();
            objbll.Answer_b = dr["answer_b"].ToString();
            objbll.Answer_c = dr["answer_c"].ToString();
            objbll.Answer_d = dr["answer_d"].ToString();
            objbll.Correct_answer = dr["correct_answer"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLQuestion> Selectquestionforquizobjectivefull(BLLQuestion objbll)
    {
        List<BLLQuestion> objlist = new List<BLLQuestion>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@ques_level", SqlDbType.NVarChar);
        param[0].Value = objbll.Ques_level;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selecttakequizobjectivesubjectwise", param);
        while (dr.Read())
        {
            objbll = new BLLQuestion();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Question = dr["question"].ToString();
            objbll.Answer_a = dr["answer_a"].ToString();
            objbll.Answer_b = dr["answer_b"].ToString();
            objbll.Answer_c = dr["answer_c"].ToString();
            objbll.Answer_d = dr["answer_d"].ToString();
            objbll.Correct_answer = dr["correct_answer"].ToString();
            objbll.Ques_level = dr["ques_level"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLQuestion> Selectsubjectivequestionforquiz(BLLQuestion objbll)
    {
        List<BLLQuestion> objlist = new List<BLLQuestion>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[0].Value = objbll.Quiz_name;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selecttakequizsubjectivequestion", param);
        while (dr.Read())
        {
            objbll = new BLLQuestion();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Question = dr["question"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLQuestion> Selectsubjectivequestionfullforquiz(BLLQuestion objbll)
    {
        List<BLLQuestion> objlist = new List<BLLQuestion>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@quiz_name", SqlDbType.NVarChar);
        param[0].Value = objbll.Quiz_name;

        param[1] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Course_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selecttakequizsubjectivequestionsubjectwise", param);
        while (dr.Read())
        {
            objbll = new BLLQuestion();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Question = dr["question"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public int DeleteQuestion(BLLQuestion objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@id", SqlDbType.Int);
        param[0].Value = objbll.Id;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deletequestion", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLQuestion> Selectquestionbyid(BLLQuestion objbll)
    {
        List<BLLQuestion> objlist = new List<BLLQuestion>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@id", SqlDbType.Int);
        param.Value = objbll.Id;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectquestionbyid", param);
        while (dr.Read())
        {
            objbll = new BLLQuestion();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Answer_type = dr["answer_type"].ToString();
            objbll.No_of_answer = dr["no_of_question"].ToString();
            objbll.Topic = dr["topic"].ToString();
            objbll.Question = dr["question"].ToString();
            objbll.Ques_level = dr["ques_level"].ToString();
            objbll.Answer_a = dr["answer_a"].ToString();
            objbll.Answer_b = dr["answer_b"].ToString();
            objbll.Answer_c = dr["answer_c"].ToString();
            objbll.Answer_d = dr["answer_d"].ToString();
            objbll.Correct_answer = dr["correct_answer"].ToString();
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

    public int UpdateQuestion(BLLQuestion objbll)
    {
        SqlParameter[] param = new SqlParameter[13];

        param[0] = new SqlParameter("@answer_type", SqlDbType.NVarChar);
        param[0].Value = objbll.Answer_type;

        param[1] = new SqlParameter("@no_of_question", SqlDbType.NVarChar);
        param[1].Value = objbll.No_of_answer;

        param[2] = new SqlParameter("@topic", SqlDbType.NVarChar);
        param[2].Value = objbll.Topic;

        param[3] = new SqlParameter("@question", SqlDbType.NVarChar);
        param[3].Value = objbll.Question;

        param[4] = new SqlParameter("@ques_level", SqlDbType.NVarChar);
        param[4].Value = objbll.Ques_level;

        param[5] = new SqlParameter("@answer_a", SqlDbType.NVarChar);
        param[5].Value = objbll.Answer_a;

        param[6] = new SqlParameter("@answer_b", SqlDbType.NVarChar);
        param[6].Value = objbll.Answer_b;

        param[7] = new SqlParameter("@answer_c", SqlDbType.NVarChar);
        param[7].Value = objbll.Answer_c;

        param[8] = new SqlParameter("@answer_d", SqlDbType.NVarChar);
        param[8].Value = objbll.Answer_d;

        param[9] = new SqlParameter("@correct_answer", SqlDbType.NVarChar);
        param[9].Value = objbll.Correct_answer;

        param[10] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[10].Value = objbll.Modifiedby;

        param[11] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[11].Value = objbll.Update_date;

        param[12] = new SqlParameter("@id", SqlDbType.Int);
        param[12].Value = objbll.Id;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updatequestion", param);
        objcon.CloseConnection();
        return a;
    }
}