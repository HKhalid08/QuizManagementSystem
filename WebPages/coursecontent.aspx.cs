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
        if (!string.IsNullOrEmpty((string)Session["user"]))
        {
            user = (string)Session["user"];
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
        SelectRight();

        LoadCourses();
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        InsertCourseContent();
    }

    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
        txtcontent.Focus();
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    public void Clear()
    {
        txtcontent.Text = string.Empty;
        txtlearning.Text = string.Empty;
        txtsynopsis.Text = string.Empty;
        lblresult.Text = string.Empty;
    }

    public void LoadCourses()
    {
        List<BLLCourses> objlist = new List<BLLCourses>();
        BLLCourses objbll = new BLLCourses();
        objlist = objbll.SelectCourses();
        if (objlist.Count > 0)
        {
            cbcourses.DataSource = objlist;
            cbcourses.ValueField = "course_code";
            cbcourses.TextField = "course_title";
            cbcourses.DataBind();
        }
    }

    public void SelectContentbycourse()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_code = cbcourses.SelectedItem.Value.ToString();
        List<BLLCourses> objlist = new List<BLLCourses>();
        objlist = objbll.Selectcontentbycourse(objbll);
        if (objlist.Count > 0)
        {
            
            txtcontent.Text = objlist[0].Course_content;
            txtsynopsis.Text = objlist[0].Course_synopsis;
            txtlearning.Text = objlist[0].Learning_outcomes;
        }
    }
    protected void cbcourses_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectContentbycourse();
    }

    public void InsertCourseContent()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_code = cbcourses.SelectedItem.Value.ToString();
        objbll.Course_content = txtcontent.Text;
        objbll.Course_synopsis = txtsynopsis.Text;
        objbll.Learning_outcomes = txtlearning.Text;
        int a = objbll.InsertCourseContent(objbll);
        if (a == 1)
        {
            lblresult.Text = "Course Content Save Successfully";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
    protected void linkProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
    }
    protected void linkChangePassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Login/ChangePasword.aspx");
    }
    protected void linkSignOut_Click(object sender, EventArgs e)
    {
        try
        {
            Session["user"] = null;
            Session.Abandon();
            Response.Redirect("../Login/Login.aspx");
        }
        catch
        {

        }
    }
    public void SelectRight()
    {
        List<BLLUserRights> objlist = new List<BLLUserRights>();
        BLLUserRights objbll = new BLLUserRights();
        objbll.Emp_code = user; ;
        objbll.App_detail = "CourseContents";
        objlist = objbll.Selectuserrights(objbll);
        if (objlist.Count > 0)
        {
            string r_add = objlist[0].Rr_add;

            if (r_add == "1")
            {
                BtnSave.Enabled = true;
                BtnClear.Enabled = true;
                BtnNew.Enabled = false;
            }

            else
            {
                Response.Redirect("norights.aspx");
            }
        }
        else
        {
            Response.Redirect("norights.aspx");
        }
    }
}