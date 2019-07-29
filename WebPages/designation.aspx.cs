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
        BtnNew.Enabled = false;
        
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
        txtdesignationid.Text = string.Empty;
        txtdesignationname.Text = string.Empty;
        lblresult.Text = string.Empty;
    }
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string mod = (string)Session["mode"];
        if (mod == "ed")
        {
            UpdateDesignation();
        }
        else
        {
            InsertDesignation();
        }
    }

    public void InsertDesignation()
    {
        BLLDepartmentDesignation objbll = new BLLDepartmentDesignation();
        objbll.Des_id= txtdesignationid.Text;
        objbll.Des_name = txtdesignationname.Text;
        objbll.Createdby = user;
        objbll.Modifiedby = user;
        int a = objbll.InsertDesignation(objbll);
        if (a == 1)
        {
            lblresult.Text = "Designation Save Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
        txtdesignationid.Focus();
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
        objbll.App_detail = "Designation";
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
        BLLDepartmentDesignation objbll = new BLLDepartmentDesignation();
        objbll.Des_id = (string)Session["des_update"];
        List<BLLDepartmentDesignation> objlist = new List<BLLDepartmentDesignation>();
        objlist = objbll.SelectDesignationbyid(objbll);
        if (objlist.Count > 0)
        {
            txtdesignationid.Text = objlist[0].Des_id;
            txtdesignationname.Text = objlist[0].Des_name;
        }
    }

    public void UpdateDesignation()
    {
        BLLDepartmentDesignation objbll = new BLLDepartmentDesignation();
        objbll.Des_id = (string)Session["des_update"];
        objbll.Des_name = txtdesignationname.Text;
        objbll.Modifiedby = user;
        int a = objbll.UpdateDesignation(objbll);
        if (a == 1)
        {
            lblresult.Text = "Designation Update Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
}