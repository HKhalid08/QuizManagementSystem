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
            LoadAppDetail();
            BtnNew.Enabled = false;
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

    protected void BtnClear_Click(object sender, EventArgs e)
    {

    }

    public void SelectEmpcode()
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();
        objlist = objbll.SelectEmployeeAdmincode();
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

    protected void cbemployeecode_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectEmpnamebycode();
    }

    public void LoadAppDetail()
    {
        BLLUserRights objbll = new BLLUserRights();
        List<BLLUserRights> objlist = new List<BLLUserRights>();
        objlist = objbll.SelectApplicationDetail();
        if (objlist.Count > 0)
        {
            dgrights.DataSource = objlist;
            dgrights.DataBind();
        }
    }

    public void Insert()
    {
        int b = 0;
        for (int a = 0; a < dgrights.Rows.Count; a++)
        {
            string app_detail = dgrights.Rows[a].Cells[0].Text.ToString();
            bool r_rights = ((CheckBox)dgrights.Rows[a].Cells[1].FindControl("chrights")).Checked;
            bool r_add = ((CheckBox)dgrights.Rows[a].Cells[2].FindControl("chadd")).Checked;
            bool r_visible = ((CheckBox)dgrights.Rows[a].Cells[3].FindControl("chvisible")).Checked;
            bool r_edit = ((CheckBox)dgrights.Rows[a].Cells[4].FindControl("chupdate")).Checked;
            bool r_delete = ((CheckBox)dgrights.Rows[a].Cells[5].FindControl("chdelete")).Checked;

            if (r_rights == true)
            {
                BLLUserRights objbll = new BLLUserRights();
                objbll.Emp_code = cbemployeecode.SelectedItem.ToString();
                objbll.Name = txtname.Text;
                objbll.App_detail = app_detail;
                objbll.Rights = r_rights;
                objbll.R_add = r_add;
                objbll.R_visible = r_visible;
                objbll.R_edit = r_edit;
                objbll.R_delete = r_delete;
                b = objbll.Insertuserrights(objbll);
            }
        }
        if (b == 1)
        {
            lblresult.Text = "Rights Assign Successfully..";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
        else
        {
            lblresult.Text = "Rights Not-Assign Successfully..";
        }
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        Insert();
    }

    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        BtnNew.Enabled = false;
        LoadAppDetail();
        lblresult.Text = string.Empty;
    }

    public void SelectRight()
    {
        List<BLLUserRights> objlist = new List<BLLUserRights>();
        BLLUserRights objbll = new BLLUserRights();
        objbll.Emp_code = user; ;
        objbll.App_detail = "UserRights";
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