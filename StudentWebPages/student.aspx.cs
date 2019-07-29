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
        if (!string.IsNullOrEmpty((string)Session["student"]))
        {
            user = (string)Session["student"];
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

        SelectAssignCourses();
    }

    protected void linkChangePassword_Click(object sender, EventArgs e)
    {
        Session["username"] = user;
        Response.Redirect("../Login/ChangePasword.aspx");
    }

    public void SelectAssignCourses()
    {
        BLLEnrollment objbll = new BLLEnrollment();
        objbll.Rollno = user;
        List<BLLEnrollment> objlist = new List<BLLEnrollment>();
        objlist = objbll.Selectenrollcoursebyrollno(objbll);
        if (objlist.Count > 0)
        {
            dgassigncourses.DataSource = objlist;
            dgassigncourses.DataBind();
        }
    }

    protected void linkProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
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

    protected void btnquiz_Click(object sender, EventArgs e)
    {
        string[] arg = new string[2];
        LinkButton obj = (LinkButton)(sender);
        arg = obj.CommandArgument.ToString().Split(';');
        Session["course_code"] = arg[0];
        Session["course_title"] = arg[1];
        Response.Redirect("quizess.aspx");
    }

    protected void btnassignment_Click(object sender, EventArgs e)
    {
        string[] arg = new string[2];
        LinkButton obj = (LinkButton)(sender);
        arg = obj.CommandArgument.ToString().Split(';');
        Session["course_code"] = arg[0];
        Session["course_title"] = arg[1];
        Response.Redirect("assignments.aspx");
    }

    protected void btncoursewebsite_Click(object sender, EventArgs e)
    {
        string[] arg = new string[2];
        LinkButton obj = (LinkButton)(sender);
        arg = obj.CommandArgument.ToString().Split(';');
        Session["course_code"] = arg[0];
        Session["course_title"] = arg[1];
        Response.Redirect("coursewebsite.aspx");
    }
}