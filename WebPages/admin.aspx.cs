using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Pages_PortoQuiz_Home : System.Web.UI.Page
{
    public string user;
    public  static string Employee_Code_Jquery; 
    
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

         //LoadEmployeeforChat();
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

    public string EmployeeCode;

    //public void LoadEmployeeforChat()
    //{
    //    BLLEmployeeInfo objbll = new BLLEmployeeInfo();
    //    objbll.Emp_code = user;
    //    List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
    //    objlist = objbll.SelectEmployeeforChat(objbll);
    //    if (objlist.Count > 0)
    //    {
    //        gridview_Online_Persons.DataSource = objlist;
    //        gridview_Online_Persons.DataBind();
    //    }
    //}

    //protected void btnSendMessage_Click(object sender, EventArgs e)
    //{
    //    EmployeeCode = HEmployeeCode.Value;
    //    InsertChat();
    //    SelectMessage();
    //}

    //public void InsertChat()
    //{
    //    BLLChat objbll = new BLLChat();
    //    objbll.Message = txtChat.Text;
    //    objbll.Message_from = user;
    //    objbll.Message_to = EmployeeCode;
    //    int a = objbll.InsertChat(objbll);
    //    if (a == 1)
    //    {
    //        txtChat.Text = string.Empty;
    //        txtChat.Focus();
    //    }
    //}

    //public void SelectMessage()
    //{
    //    BLLChat objbll = new BLLChat();
    //    objbll.Message_from = user;
    //    objbll.Message_to = EmployeeCode;
    //    List<BLLChat> objlist = new List<BLLChat>();
    //    objlist = objbll.SelectMessage(objbll);
    //    if (objlist.Count > 0)
    //    {
    //        dgmessage.DataSource = objlist;
    //        dgmessage.DataBind();
    //    }
    //}
    protected void Button1_Click(object sender, EventArgs e)
    {
        //SelectMessage();
    }
    
    protected void linkChangePassword_Click1(object sender, EventArgs e)
    {
        Response.Redirect("../Login/ChangePasword.aspx");
    }
}