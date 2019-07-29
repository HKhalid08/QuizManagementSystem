using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;

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
            SelectSession();
            SelectRollno();
            SelectCourses();
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
            cmbsession.DataSource = objlist;
            cmbsession.ValueField = "session_id";
            cmbsession.TextField = "description";
            cmbsession.DataBind();
        }
    }

    public void SelectRollno()
    {
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();
        BLLStudentInfo objbll = new BLLStudentInfo();
        objlist = objbll.SelectStudentInfo();
        if (objlist.Count > 0)
        {
            cbrollno.DataSource = objlist;
            cbrollno.ValueField = "rollno";
            cbrollno.TextField = "rollno";
            cbrollno.DataBind();
        }
    }

    public void Selectstunamebyrollno()
    {
        BLLStudentInfo objbll = new BLLStudentInfo();
        objbll.Rollno = cbrollno.SelectedItem.Value.ToString();
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();
        objlist = objbll.Selectstunamebyrollno(objbll);
        if (objlist.Count > 0)
        {
            txtname.Text = objlist[0].Name;
        }
    }

    public void SelectCourses()
    {
        List<BLLCourses> objlist = new List<BLLCourses>();
        BLLCourses objbll = new BLLCourses();
        objlist = objbll.SelectCourses();
        if (objlist.Count > 0)
        {
            lbcourses.DataSource = objlist;
            lbcourses.ValueField = "course_code";
            lbcourses.TextField = "course_title";
            lbcourses.DataBind();
        }
    }
    protected void cbrollno_SelectedIndexChanged(object sender, EventArgs e)
    {
        Selectstunamebyrollno();
    }

     protected void BtnRight_Click1(object sender, EventArgs e)
    {
        for (int i = lbcourses.Items.Count - 1; i >= 0; i--)
        {
            if (lbcourses.Items[i].Selected)
            {
                lbassigncourses.Items.Add(lbcourses.Items[i]);
                //lbcourses.Items.Remove(lbcourses.Items[i]);
            }
        }
    }

        protected void BtnLeft_Click1(object sender, EventArgs e)
    {
        for (int i = lbassigncourses.Items.Count - 1; i >= 0; i--)
        {
            if (lbassigncourses.Items[i].Selected)
            {
                lbcourses.Items.Add(lbassigncourses.Items[i]);
                //lbassigncourses.Items.Remove(lbassigncourses.Items[i]);
            }
        }
    }

    public void InsertStudentEnroll()
    {
        int a = 0;
        BLLEnrollment objbll = new BLLEnrollment();

        foreach (ListEditItem item in lbassigncourses.Items.Cast<ListEditItem>().ToList())
        {
            objbll.Rollno = cbrollno.SelectedItem.Value.ToString();
            objbll.Name = txtname.Text;
            objbll.Session_id = cmbsession.SelectedItem.Value.ToString();
            objbll.Course = item.Value.ToString();
            objbll.Createdby = user;
            objbll.Modifiedby = user;
            a = objbll.InsertStudentEnrollment(objbll);
        }

        if (a > 0)
        {
            lblresult.Text = "Courses Assign Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        lbassigncourses.Items.Clear();
        SelectCourses();
        lblresult.Text = string.Empty;
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        InsertStudentEnroll();
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
        objbll.App_detail = "StudentEnrollment";
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