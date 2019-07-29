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
        txtsessionid.Text = string.Empty;
        txtdescription.Text = string.Empty;
        lblresult.Text = string.Empty;
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string mod = (string)Session["mode"];
        if (mod == "ed")
        {
            UpdateSession();
        }
        else
        {
            InsertSession();
        }
    }

    public void InsertSession()
    {
        BLLSession objbll = new BLLSession();
        objbll.Session_id = txtsessionid.Text;
        objbll.Description = txtdescription.Text;
        objbll.Createdby =user;
        objbll.Modifiedby = user;
        int a = objbll.InsertSession(objbll);
        if (a == 1)
        {
            lblresult.Text = "Session Save Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
        txtsessionid.Focus();
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
        objbll.App_detail = "Session";
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
        BLLSession objbll = new BLLSession();
        objbll.Session_id = (string)Session["session_update"];
        List<BLLSession> objlist = new List<BLLSession>();
        objlist = objbll.SelectSessionbyid(objbll);
        if (objlist.Count > 0)
        {
            txtsessionid.Text = objlist[0].Session_id;
            txtdescription.Text = objlist[0].Description;
        }
    }

    public void UpdateSession()
    {
        BLLSession objbll = new BLLSession();
        objbll.Session_id = (string)Session["session_update"];
        objbll.Description = txtdescription.Text;        
        objbll.Modifiedby = user;
        int a = objbll.UpdateSession(objbll);
        if (a == 1)
        {
            lblresult.Text = "Session Update Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
}