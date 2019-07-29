using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLSchedule
/// </summary>
public class BLLSchedule
{
	public BLLSchedule()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string session_id;

    public string Session_id
    {
        get { return session_id; }
        set { session_id = value; }
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
    private string course_title;

    public string Course_title
    {
        get { return course_title; }
        set { course_title = value; }
    }
    private string course_code;

    public string Course_code
    {
        get { return course_code; }
        set { course_code = value; }
    }
    private string day;

    public string Day
    {
        get { return day; }
        set { day = value; }
    }
    private string time_from;

    public string Time_from
    {
        get { return time_from; }
        set { time_from = value; }
    }
    private string time_to;

    public string Time_to
    {
        get { return time_to; }
        set { time_to = value; }
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

    private string rollno;

    public string Rollno
    {
        get { return rollno; }
        set { rollno = value; }
    }

    public void Initialize()
    {
        id = 0;
        course_code = string.Empty;
        course_title = string.Empty;
        emp_code = string.Empty;
        name = string.Empty;
        rollno = string.Empty;
        day = string.Empty;
        session_id = string.Empty;
        time_from = string.Empty;
        time_to = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
    }

    public int InsertSchedule(BLLSchedule objbll)
    {
        DALSchedule objdal = new DALSchedule();
        return objdal.InsertSchedule(objbll);
    }

    public List<BLLSchedule> SelectSchedule()
    {
        DALSchedule objdal = new DALSchedule();
        return objdal.SelectSchedule();
    }

    public List<BLLSchedule> Selectschedulebyempcode(BLLSchedule objbll)
    {
        DALSchedule objdal = new DALSchedule();
        return objdal.Selectschedulebyempcode(objbll);
    }

    public List<BLLSchedule> Selectschedulebyrollno(BLLSchedule objbll)
    {
        DALSchedule objdal = new DALSchedule();
        return objdal.Selectschedulebyrollno(objbll);
    }
}