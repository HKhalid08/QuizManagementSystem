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
    }

    public void LoadMarks()
    {
        BLLGradeBook objbll = new BLLGradeBook();
        objbll.Course_code = cbcourses.SelectedItem.ToString();
        List<BLLGradeBook> objlist = new List<BLLGradeBook>();
        objlist = objbll.Selectmarksbycourseforteacher(objbll);
        if (objlist.Count > 0)
        {
            dgmarks.DataSource = objlist;
            dgmarks.DataBind();
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
    protected void cbcourses_SelectedIndexChanged(object sender, EventArgs e)
    {
        LoadMarks();
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