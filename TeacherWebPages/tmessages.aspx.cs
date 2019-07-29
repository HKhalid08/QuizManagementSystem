using System;
using System.Collections.Generic;
using System.IO;
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
        LoadQuizzes();
        LoadAssignments();
    }

    public void LoadQuizzes()
    {
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Course_code = cbcourses.SelectedItem.Value.ToString();
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();
        objlist = objbll.Selectsubjectiveanswer(objbll);
        if (objlist.Count > 0)
        {
            dgquiz.DataSource = objlist;
            dgquiz.DataBind();
        }
    }

    public void LoadAssignments()
    {
        BLLAssignment objbll = new BLLAssignment();
        objbll.Course_code = cbcourses.SelectedItem.Value.ToString();
        List<BLLAssignment> objlist = new List<BLLAssignment>();
        objlist = objbll.SelectAssignmentSolution(objbll);
        if (objlist.Count > 0)
        {
            dgassignment.DataSource = objlist;
            dgassignment.DataBind();
        }
    }

    protected void AssignDownload_Click(object sender, EventArgs e)
    {
        string filePath = (sender as LinkButton).CommandArgument;
        Response.ContentType = ContentType;
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
        Response.Redirect("../StudentWebPages/" + filePath);
        //Response.BinaryWrite((byte[])[filePath]);
        Response.End();
    }
}