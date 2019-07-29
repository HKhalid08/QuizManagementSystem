using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLTeacherEnrollment
/// </summary>
public class BLLTeacherEnrollment
{
	public BLLTeacherEnrollment()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
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

    public void Initialize()
    {
        id = 0;
        emp_code = string.Empty;
        name = string.Empty;
        session_id = string.Empty;
        course = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        course_code = string.Empty;
    }

    public int InsertTeacherEnrollment(BLLTeacherEnrollment objbll)
    {
        DALTeacherEnrollment objdal = new DALTeacherEnrollment();
        return objdal.InsertTeacherEnrollment(objbll);
    }

    public List<BLLTeacherEnrollment> SelectTeachEnrollment()
    {
        DALTeacherEnrollment objdal = new DALTeacherEnrollment();
        return objdal.SelectTeachEnrollment();
    }

    public List<BLLTeacherEnrollment> Selectassigncoursebyteacher(BLLTeacherEnrollment objbll)
    {
        DALTeacherEnrollment objdal = new DALTeacherEnrollment();
        return objdal.Selectassigncoursebyteacher(objbll);
    }
}