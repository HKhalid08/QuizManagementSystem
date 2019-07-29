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

        SelectTeacherInfo();
    }

    public void SelectTeacherInfo()
    {
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();
        objbll.Emp_code = user;
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        objlist = objbll.SelectEmpinfobycode(objbll);
        if (objlist.Count > 0)
        {
            dgprofile.DataSource = objlist;
            dgprofile.DataBind();
        }
    }
}