using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLGradeBook
/// </summary>
public class BLLGradeBook
{
	public BLLGradeBook()
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

    private string course_code;

    public string Course_code
    {
        get { return course_code; }
        set { course_code = value; }
    }
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string quiz_type;

    public string Quiz_type
    {
        get { return quiz_type; }
        set { quiz_type = value; }
    }
    private string quiz_level;

    public string Quiz_level
    {
        get { return quiz_level; }
        set { quiz_level = value; }
    }
    private string no_of_question;

    public string No_of_question
    {
        get { return no_of_question; }
        set { no_of_question = value; }
    }
    private string attempt_question;

    public string Attempt_question
    {
        get { return attempt_question; }
        set { attempt_question = value; }
    }
    private string total_marks;

    public string Total_marks
    {
        get { return total_marks; }
        set { total_marks = value; }
    }
    private string obtained_mark;

    public string Obtained_mark
    {
        get { return obtained_mark; }
        set { obtained_mark = value; }
    }
    private DateTime quiz_date;

    public DateTime Quiz_date
    {
        get { return quiz_date; }
        set { quiz_date = value; }
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

    public void Initialize()
    {
        id = 0;
        course_code = string.Empty;
        name = string.Empty;
        rollno = string.Empty;
        quiz_level = string.Empty;
        quiz_type = string.Empty;
        no_of_question = string.Empty;
        attempt_question = string.Empty;
        total_marks = string.Empty;
        obtained_mark = string.Empty;
        quiz_date = System.DateTime.Now.Date;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
    }

    public int InsertGradeBook(BLLGradeBook objbll)
    {
        DALGradeBook objdal = new DALGradeBook();
        return objdal.InsertGradeBook(objbll);
    }

    public List<BLLGradeBook> Selectanswerfromquiz(BLLGradeBook objbll)
    {
        DALGradeBook objdal = new DALGradeBook();
        return objdal.Selectanswerfromquiz(objbll);
    }

    public List<BLLGradeBook> Selectmarksbycourseforstu(BLLGradeBook objbll)
    {
        DALGradeBook objdal = new DALGradeBook();
        return objdal.Selectmarksbycourseforstu(objbll);
    }

    public List<BLLGradeBook> Selectmarksbycourseforteacher(BLLGradeBook objbll)
    {
        DALGradeBook objdal = new DALGradeBook();
        return objdal.Selectmarksbycourseforteacher(objbll);
    }
}