using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLEnrollment
/// </summary>
public class BLLEnrollment
{
	public BLLEnrollment()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string rollno;

    public string Rollno
    {
        get { return rollno; }
        set { rollno = value; }
    }
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string session_id;

    public string Session_id
    {
        get { return session_id; }
        set { session_id = value; }
    }
    private string course;

    public string Course
    {
        get { return course; }
        set { course = value; }
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

    private string course_code;

    public string Course_code
    {
        get { return course_code; }
        set { course_code = value; }
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

    public void Initialize()
    {
        id = 0;
        rollno = string.Empty;
        name = string.Empty;
        session_id = string.Empty;
        course = string.Empty;
        course_code = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        quiz_name = string.Empty;
        no_of_question = string.Empty;
        total_marks = string.Empty;
    }

    public int InsertStudentEnrollment(BLLEnrollment objbll)
    {
        DALEnrollment objdal = new DALEnrollment();
        return objdal.InsertStudentEnrollment(objbll);
    }

    public List<BLLEnrollment> SelectStudentEnrollment()
    {
        DALEnrollment objdal = new DALEnrollment();
        return objdal.SelectStudentEnrollment();
    }

    public List<BLLEnrollment> Selectenrollcoursebyrollno(BLLEnrollment objbll)
    {
        DALEnrollment objdal = new DALEnrollment();
        return objdal.Selectenrollcoursebyrollno(objbll);
    }

    public List<BLLEnrollment> Selectstudentforgradebook(BLLEnrollment objbll)
    {
        DALEnrollment objdal = new DALEnrollment();
        return objdal.Selectstudentforgradebook(objbll);
    }
}