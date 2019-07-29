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
        txtprogramid.Text = string.Empty;
        txtprogramname.Text = string.Empty;
        txtcredithours.Text = string.Empty;
        lblresult.Text = string.Empty;
        txtprogramid.Focus();
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string mod = (string)Session["mode"];
        if (mod == "ed")
        {
            UpdateProgram();
        }
        else
        {
            InsertProgram();
        }
    }

    public void InsertProgram()
    {
        BLLProgram objbll = new BLLProgram();
        objbll.Program_id = txtprogramid.Text;
        objbll.Program_name = txtprogramname.Text;
        objbll.Credit_hours = txtcredithours.Text;
        objbll.Createdby = user;
        objbll.Modifiedby = user;
        int a = objbll.InsertProgram(objbll);
        if (a == 1)
        {
            lblresult.Text = "Program Save Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
        txtprogramid.Focus();
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
        objbll.App_detail = "Program";
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
        BLLProgram objbll = new BLLProgram();
        objbll.Program_id = (string)Session["prg_update"];
        List<BLLProgram> objlist = new List<BLLProgram>();
        objlist = objbll.SelectProgrambyid(objbll);
        if (objlist.Count > 0)
        {
            txtprogramid.Text = objlist[0].Program_id;
            txtprogramname.Text = objlist[0].Program_name;
            txtcredithours.Text = objlist[0].Credit_hours;
        }
    }

    public void UpdateProgram()
    {
        BLLProgram objbll = new BLLProgram();
        objbll.Program_id = (string)Session["prg_update"];
        objbll.Program_name = txtprogramname.Text;
        objbll.Credit_hours = txtcredithours.Text;        
        objbll.Modifiedby = user;
        int a = objbll.UpdateProgram(objbll);
        if (a == 1)
        {
            lblresult.Text = "Program Update Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
}
