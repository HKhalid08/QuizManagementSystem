using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLCourses
/// </summary>
public class BLLCourses
{
	public BLLCourses()
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
    private string short_name;

    public string Short_name
    {
        get { return short_name; }
        set { short_name = value; }
    }
    private string credit_hours;

    public string Credit_hours
    {
        get { return credit_hours; }
        set { credit_hours = value; }
    }
    private string cetegory;

    public string Cetegory
    {
        get { return cetegory; }
        set { cetegory = value; }
    }
    private string course_content;

    public string Course_content
    {
        get { return course_content; }
        set { course_content = value; }
    }
    private string course_synopsis;

    public string Course_synopsis
    {
        get { return course_synopsis; }
        set { course_synopsis = value; }
    }
    private string learning_outcomes;

    public string Learning_outcomes
    {
        get { return learning_outcomes; }
        set { learning_outcomes = value; }
    }
    private string topic;

    public string Topic
    {
        get { return topic; }
        set { topic = value; }
    }
    private string lecture;

    public string Lecture
    {
        get { return lecture; }
        set { lecture = value; }
    }
    private string resource;

    public string Resource
    {
        get { return resource; }
        set { resource = value; }
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

    private string emp_code;

    public string Emp_code
    {
        get { return emp_code; }
        set { emp_code = value; }
    }
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string about;

    public string About
    {
        get { return about; }
        set { about = value; }
    }
    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    private string pic_name;

    public string Pic_name
    {
        get { return pic_name; }
        set { pic_name = value; }
    }

    public void Initialize()
    {
        id = 0;
        course_code = string.Empty;
        course_title = string.Empty;
        short_name = string.Empty;
        credit_hours = string.Empty;
        cetegory = string.Empty;
        course_synopsis = string.Empty;
        course_content = string.Empty;
        learning_outcomes = string.Empty;
        topic = string.Empty;
        lecture = string.Empty;
        resource = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        emp_code = string.Empty;
        name = string.Empty;
        email = string.Empty;
        about = string.Empty;
        pic_name = string.Empty;
    }

    public int InsertCourses(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.InsertCourses(objbll);
    }

    public int InsertCourseContent(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.InsertCourseContent(objbll);
    }

    public int InsertCourseCalendar(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.InsertCourseCalendar(objbll);
    }

    public List<BLLCourses> SelectCourses()
    {
        DALCourses objdal = new DALCourses();
        return objdal.SelectCourses();
    }

    public List<BLLCourses> Selectcoursecodeebyname(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.Selectcoursecodeebyname(objbll);
    }

    public List<BLLCourses> Selectcontentbycourse(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.Selectcontentbycourse(objbll);
    }

    public List<BLLCourses> Selectcalenderbycourse(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.Selectcalenderbycourse(objbll);
    }

    public List<BLLCourses> Selectcoursewebsite(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.Selectcoursewebsite(objbll);
    }

    public List<BLLCourses> Selectcoursewebsitecalender(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.Selectcoursewebsitecalender(objbll);
    }

    public List<BLLCourses> SelectCoursesbyid(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.SelectCoursesbyid(objbll);
    }

    public int UpdateCourses(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.UpdateCourses(objbll);
    }

    public int DeleteCourse(BLLCourses objbll)
    {
        DALCourses objdal = new DALCourses();
        return objdal.DeleteCourse(objbll);
    }
}