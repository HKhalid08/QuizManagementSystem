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
            SelectEmpcode();
            SelectCoursetitle();
            SelectSession();
        }
    }
    protected void BtnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    public void Clear()
    { 
    
    }

    public void SelectSession()
    {
        List<BLLSession> objlist = new List<BLLSession>();
        BLLSession objbll = new BLLSession();
        objlist = objbll.SelectSession();
        if (objlist.Count > 0)
        {
            cbsession.DataSource = objlist;
            cbsession.ValueField = "session_id";
            cbsession.TextField = "description";
            cbsession.DataBind();
        }
    }

    public void SelectEmpcode()
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();
        objlist = objbll.SelectEmployeeInfo();
        if (objlist.Count > 0)
        {
            cbemployeecode.DataSource = objlist;
            cbemployeecode.ValueField = "emp_code";
            cbemployeecode.TextField = "emp_code";
            cbemployeecode.DataBind();
        }
    }

    public void SelectEmpnamebycode()
    {
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();
        objbll.Emp_code = cbemployeecode.SelectedItem.Value.ToString();
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        objlist = objbll.SelectEmpnamebycode(objbll);
        if (objlist.Count > 0)
        {
            txtname.Text = objlist[0].Name;
        }
    }

    public void SelectCoursetitle()
    {
        List<BLLCourses> objlist = new List<BLLCourses>();
        BLLCourses objbll = new BLLCourses();
        objlist = objbll.SelectCourses();
        if (objlist.Count > 0)
        {
            cbcoursename.DataSource = objlist;
            cbcoursename.ValueField = "course_title";
            cbcoursename.TextField = "course_title";
            cbcoursename.DataBind();
        }
    }

    public void Selectcoursecodebyname()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_title = cbcoursename.SelectedItem.Value.ToString();
        List<BLLCourses> objlist = new List<BLLCourses>();
        objlist = objbll.Selectcoursecodeebyname(objbll);
        if (objlist.Count > 0)
        {
            txtcoursecode.Text = objlist[0].Course_code;
        }
    }

    protected void cbemployeecode_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectEmpnamebycode();
    }

    protected void cbcoursename_SelectedIndexChanged(object sender, EventArgs e)
    {
        Selectcoursecodebyname();
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        InsertSchedule();
    }

    public void InsertSchedule()
    {
        BLLSchedule objbll = new BLLSchedule();
        objbll.Session_id = cbsession.SelectedItem.Value.ToString();
        objbll.Emp_code = cbemployeecode.SelectedItem.Value.ToString();
        objbll.Name = txtname.Text;
        objbll.Course_title = cbcoursename.SelectedItem.Value.ToString();
        objbll.Course_code = txtcoursecode.Text;
        objbll.Day = cbday.SelectedItem.ToString();
        objbll.Time_from = timefrom.Text;
        objbll.Time_to = timeto.Text;
        objbll.Createdby = user;
        objbll.Modifiedby = user;
        int a = objbll.InsertSchedule(objbll);
        if (a == 1)
        {
            lblresult.Text = "Lecutre Time Assign Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
        else
        {
            lblresult.Text = "Lecutre Time Already Assign....";
        }
    }
    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        lblresult.Text = string.Empty;
        txtname.Text = string.Empty;
        txtcoursecode.Text = string.Empty;
    }
    protected void linkProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
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
    protected void linkChangePassword_Click(object sender, EventArgs e)
    {
        Response.Redirect("../Login/ChangePasword.aspx");
    }

    public void SelectRight()
    {
        List<BLLUserRights> objlist = new List<BLLUserRights>();
        BLLUserRights objbll = new BLLUserRights();
        objbll.Emp_code = user;
        objbll.App_detail = "Schedule";
        objlist = objbll.Selectuserrights(objbll);
        if (objlist.Count > 0)
        {
            string r_add = objlist[0].Rr_add;

            if (r_add == "1")
            {
                BtnSave.Enabled = true;
                
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