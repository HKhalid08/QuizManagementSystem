using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Pages_PortoQuiz_Home : System.Web.UI.Page
{
    private string user,course_code,course_title;
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
        imgUser.ImageUrl = (string)Session["pic_name"];
        lblDesignation.Text = (string)Session["des_id"];
        lblSignIn_Time.Text = (string)Session["signin"];
        course_code = (string)Session["course_code"];
        course_title = (string)Session["course_title"];

        LoadCourseWebsite();
        LoadCourseWebsiteCalender();
    }

    public void LoadCourseWebsite()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_code = course_code;
        objbll.Course_title = course_title;
        List<BLLCourses> objlist = new List<BLLCourses>();
        objlist = objbll.Selectcoursewebsite(objbll);
        if (objlist.Count > 0)
        {
            lblcourse_id.Text = objlist[0].Course_code;
            lblcategory.Text = objlist[0].Cetegory;
            lblcourse_title.Text = objlist[0].Course_title;
            lblcourse_credithours.Text = objlist[0].Credit_hours;

            lblinstructorname.Text = objlist[0].Name;
            lblemail.Text = objlist[0].Email;
            lblinstructor_biogrpahy.Text = objlist[0].About;
            lblcourseContents.Text = objlist[0].Course_content;
            lblCourse_synopsis.Text = objlist[0].Course_synopsis;
            lblLearningoutcomes.Text = objlist[0].Learning_outcomes;
            Image1.ImageUrl = objlist[0].Pic_name;
        }
    }

    public void LoadCourseWebsiteCalender()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_code = course_code;
        List<BLLCourses> objlist = new List<BLLCourses>();
        objlist = objbll.Selectcoursewebsitecalender(objbll);
        if (objlist.Count > 0)
        {
            grdcoursecalender.DataSource = objlist;
            grdcoursecalender.DataBind();
        }
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