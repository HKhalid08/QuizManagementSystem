using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLQuizSetting
/// </summary>
public class BLLQuizSetting
{
	public BLLQuizSetting()
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
    private string quiz_name;

    public string Quiz_name
    {
        get { return quiz_name; }
        set { quiz_name = value; }
    }
    private string no_of_question;

    public string No_of_question
    {
        get { return no_of_question; }
        set { no_of_question = value; }
    }
    private string total_marks;

    public string Total_marks
    {
        get { return total_marks; }
        set { total_marks = value; }
    }
    private string passing_marks;

    public string Passing_marks
    {
        get { return passing_marks; }
        set { passing_marks = value; }
    }
    private string quiz_time;

    public string Quiz_time
    {
        get { return quiz_time; }
        set { quiz_time = value; }
    }
    private string quiz_type;

    public string Quiz_type
    {
        get { return quiz_type; }
        set { quiz_type = value; }
    }
    private DateTime quiz_start_date;

    public DateTime Quiz_start_date
    {
        get { return quiz_start_date; }
        set { quiz_start_date = value; }
    }
    private DateTime quiz_end_date;

    public DateTime Quiz_end_date
    {
        get { return quiz_end_date; }
        set { quiz_end_date = value; }
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

    private string quiz_level;

    public string Quiz_level
    {
        get { return quiz_level; }
        set { quiz_level = value; }
    }
    private string topic;

    public string Topic
    {
        get { return topic; }
        set { topic = value; }
    }
    private bool quiz_status;

    public bool Quiz_status
    {
        get { return quiz_status; }
        set { quiz_status = value; }
    }

    private string rollno;

    public string Rollno
    {
        get { return rollno; }
        set { rollno = value; }
    }
    private string question;

    public string Question
    {
        get { return question; }
        set { question = value; }
    }
    private string correct_answer;

    public string Correct_answer
    {
        get { return correct_answer; }
        set { correct_answer = value; }
    }
    private bool answer_status;

    public bool Answer_status
    {
        get { return answer_status; }
        set { answer_status = value; }
    }

    public void Initialize()
    {
        id = 0;
        course_code = string.Empty;
        course_title = string.Empty;
        quiz_name = string.Empty;
        no_of_question = string.Empty;
        total_marks = string.Empty;
        passing_marks = string.Empty;
        quiz_time = string.Empty;
        quiz_type = string.Empty;
        quiz_start_date = System.DateTime.Now.Date;
        quiz_end_date = System.DateTime.Now.Date;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        quiz_level = string.Empty;
        topic = string.Empty;
        quiz_status = false;
        rollno = string.Empty;
        question = string.Empty;
        correct_answer = string.Empty;
        answer_status = false;
    }

    public int InsertQuizSetting(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.InsertQuizSetting(objbll);
    }

    public List<BLLQuizSetting> SelectQuiz(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.SelectQuiz(objbll);
    }

    public List<BLLQuizSetting> SelecttakeQuiz(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.SelecttakeQuiz(objbll);
    }

    public int InsertQuizAnswer(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.InsertQuizAnswer(objbll);
    }

    public List<BLLQuizSetting> SelectQuizNameforCheck(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.SelectQuizNameforCheck(objbll);
    }

    public List<BLLQuizSetting> SelectQuizNamebycode(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.SelectQuizNamebycode(objbll);
    }
    public int InsertQuizAnswerSubjective(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.InsertQuizAnswerSubjective(objbll);
    }

    public List<BLLQuizSetting> SelectQuizNameSubjectiveforCheck(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.SelectQuizNameSubjectiveforCheck(objbll);
    }

    public List<BLLQuizSetting> Selectsubjectiveanswer(BLLQuizSetting objbll)
    {
        DALQuizSetting objdal = new DALQuizSetting();
        return objdal.Selectsubjectiveanswer(objbll);
    }
}