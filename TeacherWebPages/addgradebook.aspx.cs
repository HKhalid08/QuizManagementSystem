using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Pages_PortoQuiz_Home : System.Web.UI.Page
{
    private string user;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty((string)Session["teacher"]))
        {
            user = (string)Session["teacher"];
        }
        else
        {
            Response.Redirect("../Login/Login.aspx");
        }

        lblAdmin_USername.Text = (string)Session["name"];
        lblAccountUsername.Text = (string)Session["name"];
        lblDesignation.Text = (string)Session["des_id"];
        imgUser.ImageUrl = (string)Session["pic_name"];
        lblSignIn_Time.Text = (string)Session["signin"];

        LoadCourses();

        if (!IsPostBack)
        {
            ASPxPopupControl1.ShowOnPageLoad = false;
        }
    }

    public void LoadCourses()
    {
        BLLTeacherEnrollment objbll = new BLLTeacherEnrollment();
        objbll.Emp_code = user;
        List<BLLTeacherEnrollment> objlist = new List<BLLTeacherEnrollment>();
        objlist = objbll.Selectassigncoursebyteacher(objbll);
        if (objlist.Count > 0)
        {
            cbcourses.DataSource = objlist;
            cbcourses.ValueField = "course_code";
            cbcourses.TextField = "course";
            cbcourses.DataBind();
        }
    }

    public void LoadQuizName()
    {
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Course_code = cbcourses.SelectedItem.ToString();
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();
        objlist = objbll.SelectQuizNamebycode(objbll);
        if (objlist.Count > 0)
        {
            cbname.DataSource = objlist;
            cbname.ValueField = "quiz_name";
            cbname.TextField = "quiz_name";
            cbname.DataBind();
        }
    }

    public void LoadAssignmentName()
    {
        BLLAssignment objbll = new BLLAssignment();
        objbll.Course_code = cbcourses.SelectedItem.ToString();
        List<BLLAssignment> objlist = new List<BLLAssignment>();
        objlist = objbll.SelectAssignmentNamebycode(objbll);
        if (objlist.Count > 0)
        {
            cbname.DataSource = objlist;
            cbname.ValueField = "title";
            cbname.TextField = "title";
            cbname.DataBind();
        }
    }

    protected void cbcourses_SelectedIndexChanged(object sender, EventArgs e)
    {
        string val = cbmarks.SelectedItem.ToString();
        if (val == "Quiz")
        {
            LoadQuizName();
        }
        else
        {
            LoadAssignmentName();
        }
    }

    protected void cbmarks_SelectedIndexChanged(object sender, EventArgs e)
    {
        string val = cbmarks.SelectedItem.ToString();
        if (val == "Quiz")
        {
            LoadQuizName();
        }
        else
        {
            LoadAssignmentName();
        }
    }

    public void LoadStudent()
    {
        string val = "0";
        string marksfor = cbmarks.SelectedItem.ToString();
        if (marksfor == "Quiz")
        {
            val = "0";
        }
        else
        {
            val = "1";
        }
        BLLEnrollment objbll = new BLLEnrollment();
        objbll.Quiz_name = cbname.SelectedItem.ToString();
        objbll.Course_code = cbcourses.SelectedItem.ToString();
        objbll.Course = val;
        List<BLLEnrollment> objlist = new List<BLLEnrollment>();
        objlist = objbll.Selectstudentforgradebook(objbll);
        if (objlist.Count > 0)
        {
            dggradebook.DataSource = objlist;
            dggradebook.DataBind();
        }
    }
    protected void cbname_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadStudent();
    }

    public void InsertGradeBook()
    {
        int b = 0;
        for (int a = 0; a < dggradebook.Rows.Count; a++)
        {
            BLLGradeBook objbll = new BLLGradeBook();
            objbll.Rollno = dggradebook.Rows[a].Cells[0].Text.ToString();
            objbll.Course_code = cbcourses.Value.ToString();
            objbll.Name = cbname.SelectedItem.ToString();
            objbll.Quiz_type = "Subjective";
            objbll.Quiz_level = " ";
            objbll.No_of_question = dggradebook.Rows[a].Cells[2].Text.ToString();
            objbll.Attempt_question = ((TextBox)(dggradebook.Rows[a].FindControl("txtattemptquestion"))).Text;
            objbll.Total_marks = dggradebook.Rows[a].Cells[3].Text.ToString();
            objbll.Obtained_mark = ((TextBox)(dggradebook.Rows[a].FindControl("txtobtainedmarks"))).Text;
            objbll.Quiz_date = System.DateTime.Now;
            objbll.Createdby = user;
            objbll.Modifiedby = user;
            b = objbll.InsertGradeBook(objbll);
        }
        if (b == 1)
        {
            ASPxPopupControl1.ShowOnPageLoad = true;
        }
    }
    protected void btnsave_Click(object sender, EventArgs e)
    {
        InsertGradeBook();
    }

    protected void popupokbutton_Click(object sender, EventArgs e)
    {
        Response.Redirect("gradebook.aspx");
    }
    protected void linkProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
    }
    protected void linkChangePassword_Click(object sender, EventArgs e)
    {
        Session["username"] = user;
        Response.Redirect("../Login/ChangePasword.aspx");
    }
    protected void linkSignOut_Click(object sender, EventArgs e)
    {
        try
        {
            Session["teacher"] = null;
            Session.Abandon();
            Response.Redirect("../Login/Login.aspx");
        }
        catch
        {

        }
    }
}