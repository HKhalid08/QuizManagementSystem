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
        if (!IsPostBack)
        {
            string mode = (string)Session["mode"];
            if (mode == "ed")
            {
                LoadForm();
            }
        }
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    public void Clear()
    {
        txtcoursecode.Text = string.Empty;
        txtcoursetitle.Text = string.Empty;
        txtshortname.Text = string.Empty;
        txtcredithours.Text = string.Empty;
        txtcetegory.Text = string.Empty;
        lblresult.Text = string.Empty;
    }


    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string mod = (string)Session["mode"];
        if (mod == "ed")
        {
            UpdateCourses();
        }
        else
        {
            InsertCourses();
        }
    }

    public void InsertCourses()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_code = txtcoursecode.Text;
        objbll.Course_title = txtcoursetitle.Text;
        objbll.Short_name = txtshortname.Text;
        objbll.Credit_hours = txtcredithours.Text;
        objbll.Cetegory = txtcetegory.Text;
        objbll.Createdby = user;
        objbll.Modifiedby = user;

        int a = objbll.InsertCourses(objbll);
        if (a == 3)
        {
            lblresult.Text = "Courses Information Save Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
        txtcoursecode.Focus();
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
        objbll.App_detail = "Courses";
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

    public void LoadForm()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_code = (string)Session["course_update"];
        List<BLLCourses> objlist = new List<BLLCourses>();
        objlist = objbll.SelectCoursesbyid(objbll);
        if (objlist.Count > 0)
        {
            txtcoursecode.Text = objlist[0].Course_code;
            txtcoursetitle.Text = objlist[0].Course_title;
            txtshortname.Text = objlist[0].Short_name;
            txtcredithours.Text = objlist[0].Credit_hours;
            txtcetegory.Text = objlist[0].Cetegory;

        }
    }
    public void UpdateCourses()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_code = (string)Session["course_update"];
        objbll.Course_title = txtcoursetitle.Text;
        objbll.Short_name = txtshortname.Text;
        objbll.Credit_hours = txtcredithours.Text;
        objbll.Cetegory = txtcetegory.Text;
        objbll.Modifiedby = user;
        int a = objbll.UpdateCourses(objbll);
        if (a == 1)
        {
            lblresult.Text = "Course Update Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            Session["mode"] = null;
        }
    }
}