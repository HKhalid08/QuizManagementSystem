using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Pages_PortoQuiz_Home : System.Web.UI.Page
{
    public string user;
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
        txtcoursecode.Text = (string)Session["course_code"];
        txtcoursetitle.Text = (string)Session["course_title"];

        LoadGrid();
    }

    public void LoadGrid()
    {
        BLLQuestion objbll = new BLLQuestion();
        objbll.Course_code = txtcoursecode.Text;
        List<BLLQuestion> objlist = new List<BLLQuestion>();
        objlist = objbll.Selectquestionbycourse(objbll);
        if (objlist.Count > 0)
        {
            dgquestion.DataSource = objlist;
            dgquestion.DataBind();
        }
    }

    protected void dgquestion_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        //dgquestion.PageIndex = e.NewPageIndex;
        //LoadGrid();
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

    protected void btnupdate_Click(object sender, EventArgs e)
    {
        LinkButton obj = (LinkButton)(sender);
        Session["ques_update"] = Convert.ToInt32(obj.CommandArgument.ToString());
        Session["mode"] = "ed";
        Response.Redirect("addquestion.aspx");
    }

    protected void btndelete_Click(object sender, EventArgs e)
    {
        LinkButton obj = (LinkButton)(sender);
        string val = obj.CommandArgument.ToString();

        BLLQuestion objbll = new BLLQuestion();
        objbll.Id = Convert.ToInt32(val);
        int a = objbll.DeleteQuestion(objbll);

        LoadGrid();
    }
}