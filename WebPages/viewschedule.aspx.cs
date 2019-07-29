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
        SelectSchedule();
    }

    public void SelectSchedule()
    {
        List<BLLSchedule> objlist = new List<BLLSchedule>();
        BLLSchedule objbll = new BLLSchedule();
        objlist = objbll.SelectSchedule();
        if (objlist.Count > 0)
        {
            dgschedule.DataSource = objlist;
            dgschedule.DataBind();
            for (int i = 0; i <= dgschedule.Rows.Count - 1; i++)
            {
                string update = (string)Session["update"];
                string delete = (string)Session["delete"];
                if (update == "yes")
                {
                    dgschedule.Rows[i].Cells[2].Enabled = true;
                }
                else
                {
                    dgschedule.Rows[i].Cells[2].Enabled = false;
                }
                if (delete == "yes")
                {
                    dgschedule.Rows[i].Cells[3].Enabled = true;
                }
                else
                {
                    dgschedule.Rows[i].Cells[3].Enabled = false;
                }
            }
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
    protected void btnupdate_Click(object sender, EventArgs e)
    {

    }
    protected void btndelete_Click(object sender, EventArgs e)
    {

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
            string r_visible = objlist[0].Rr_visible;
            string r_edit = objlist[0].Rr_edit;
            string r_delete = objlist[0].Rr_delete;

            if (r_edit == "1")
            {
                Session["update"] = "yes";
            }
            if (r_delete == "1")
            {
                Session["delete"] = "yes";
            }
            if (r_visible == "1")
            {
                SelectSchedule();
            }
        }
        else
        {
            Response.Redirect("norights.aspx");
        }

    }
}