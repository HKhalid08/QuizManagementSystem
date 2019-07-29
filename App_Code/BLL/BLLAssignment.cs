using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLAssignment
/// </summary>
public class BLLAssignment
{
	public BLLAssignment()
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
    private string title;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    private string lesson;

    public string Lesson
    {
        get { return lesson; }
        set { lesson = value; }
    }
    private string assignment_name;

    public string Assignment_name
    {
        get { return assignment_name; }
        set { assignment_name = value; }
    }
    private string assignment_path;

    public string Assignment_path
    {
        get { return assignment_path; }
        set { assignment_path = value; }
    }
    private string total_marks;

    public string Total_marks
    {
        get { return total_marks; }
        set { total_marks = value; }
    }
    private DateTime due_date;

    public DateTime Due_date
    {
        get { return due_date; }
        set { due_date = value; }
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
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void Initialize()
    {
        id = 0;
        course_code = string.Empty;
        course_title = string.Empty;
        title = string.Empty;
        lesson = string.Empty;
        assignment_name = string.Empty;
        assignment_path = string.Empty;
        total_marks = string.Empty;
        due_date = System.DateTime.Now;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        rollno = string.Empty;
        name = string.Empty;
    }

    public int InsertAssignment(BLLAssignment objbll)
    {
        DALAssignment objdal = new DALAssignment();
        return objdal.InsertAssignment(objbll);
    }

    public List<BLLAssignment> SelectAssignment(BLLAssignment objbll)
    {
        DALAssignment objdal = new DALAssignment();
        return objdal.SelectAssignment(objbll);
    }

    public int InsertAssignmentSolution(BLLAssignment objbll)
    {
        DALAssignment objdal = new DALAssignment();
        return objdal.InsertAssignmentSolution(objbll);
    }

    public List<BLLAssignment> SelectAssignmentNamebycode(BLLAssignment objbll)
    {
        DALAssignment objdal = new DALAssignment();
        return objdal.SelectAssignmentNamebycode(objbll);
    }

    public List<BLLAssignment> SelectAssignmentSolution(BLLAssignment objbll)
    {
        DALAssignment objdal = new DALAssignment();
        return objdal.SelectAssignmentSolution(objbll);
    }
}