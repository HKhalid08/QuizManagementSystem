using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLQuestion
/// </summary>
public class BLLQuestion
{
	public BLLQuestion()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string course_code;

    public string Course_code
    {
        get { return course_code; }
        set { course_code = value; }
    }
    private string course_title;

    public string Course_title
    {
        get { return course_title; }
        set { course_title = value; }
    }
    private string answer_type;

    public string Answer_type
    {
        get { return answer_type; }
        set { answer_type = value; }
    }
    private string no_of_answer;

    public string No_of_answer
    {
        get { return no_of_answer; }
        set { no_of_answer = value; }
    }
    private string topic;

    public string Topic
    {
        get { return topic; }
        set { topic = value; }
    }
    private string question;

    public string Question
    {
        get { return question; }
        set { question = value; }
    }
    private string ques_level;

    public string Ques_level
    {
        get { return ques_level; }
        set { ques_level = value; }
    }
    private string answer_a;

    public string Answer_a
    {
        get { return answer_a; }
        set { answer_a = value; }
    }
    private string answer_b;

    public string Answer_b
    {
        get { return answer_b; }
        set { answer_b = value; }
    }
    private string answer_c;

    public string Answer_c
    {
        get { return answer_c; }
        set { answer_c = value; }
    }
    private string answer_d;

    public string Answer_d
    {
        get { return answer_d; }
        set { answer_d = value; }
    }
    private string correct_answer;

    public string Correct_answer
    {
        get { return correct_answer; }
        set { correct_answer = value; }
    }

    private bool status;

    public bool Status
    {
        get { return status; }
        set { status = value; }
    }
    private string createdby;

    public string Createdby
    {
        get { return createdby; }
        set { createdby = value; }
    }
    private string modifiedby;

    public string Modifiedby
    {
        get { return modifiedby; }
        set { modifiedby = value; }
    }
    private DateTime insert_date;

    public DateTime Insert_date
    {
        get { return insert_date; }
        set { insert_date = value; }
    }
    private DateTime update_date;

    public DateTime Update_date
    {
        get { return update_date; }
        set { update_date = value; }
    }

    private string quiz_name;

    public string Quiz_name
    {
        get { return quiz_name; }
        set { quiz_name = value; }
    }

    public void Initialize()
    {
        id = 0;
        course_code = string.Empty;
        course_title = string.Empty;
        answer_type = string.Empty;
        no_of_answer = string.Empty;
        topic = string.Empty;
        question = string.Empty;
        ques_level = string.Empty;
        answer_a = string.Empty;
        answer_b = string.Empty;
        answer_c = string.Empty;
        answer_d = string.Empty;
        correct_answer = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        quiz_name = string.Empty;
    }

    public int InsertQuestion(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.InsertQuestion(objbll);
    }

    public List<BLLQuestion> SelectQuestion()
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.SelectQuestion();
    }

    public List<BLLQuestion> Selectquestionbycourse(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.Selectquestionbycourse(objbll);
    }

    public List<BLLQuestion> Selectquestionforquiz(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.Selectquestionforquiz(objbll);
    }

    public List<BLLQuestion> Selectquestionforquizobjectivefull(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.Selectquestionforquizobjectivefull(objbll);
    }

    public List<BLLQuestion> Selectsubjectivequestionforquiz(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.Selectsubjectivequestionforquiz(objbll);
    }

    public List<BLLQuestion> Selectsubjectivequestionfullforquiz(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.Selectsubjectivequestionfullforquiz(objbll);
    }

    public int DeleteQuestion(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.DeleteQuestion(objbll);
    }

    public List<BLLQuestion> Selectquestionbyid(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.Selectquestionbyid(objbll);
    }

    public int UpdateQuestion(BLLQuestion objbll)
    {
        DALQuestion objdal = new DALQuestion();
        return objdal.UpdateQuestion(objbll);
    }
}