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
        txtcoursecode.Text = (string)Session["course_code"];
        txtcoursetitle.Text = (string)Session["course_title"];

        if (!IsPostBack)
        {
            ////cbquizlevel.Enabled = false;
            ////txttopic.Enabled = false;
        }
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    public void Clear()
    {
        //txtcoursecode.Text = string.Empty;
        //txtcoursetitle.Text = string.Empty;
        txtnoofquestion.Text = string.Empty;
        txtpassingmarks.Text = string.Empty;
        txtquizname.Text = string.Empty;
        txtquiztime.Text = string.Empty;
        txttotalmarks.Text = string.Empty;
        lblresult.Text = string.Empty;
        txttopic.Text = string.Empty;
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        InsertQuizSetting();
    }

    public void InsertQuizSetting()
    {
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Course_code = txtcoursecode.Text;
        objbll.Course_title = txtcoursetitle.Text;
        objbll.Quiz_name = txtquizname.Text;
        objbll.No_of_question = txtnoofquestion.Text;
        objbll.Total_marks = txttotalmarks.Text;
        objbll.Passing_marks = txtpassingmarks.Text;
        objbll.Quiz_time = txtquiztime.Text;
        string value = cbquiztype.SelectedItem.ToString();
        if (value == "Objective")
        {
            objbll.Quiz_type = value;
            string val = cbquizlevel.SelectedItem.ToString();
            if (val == "Topic base")
            {
                objbll.Quiz_level = val;
                objbll.Topic = txttopic.Text;
            }
            else
            {
                objbll.Quiz_level = val;
                objbll.Topic = "All Topicss";
            }
        }
        else
        {
            objbll.Quiz_type = value;
            string val = cbquizlevel.SelectedItem.ToString();
            if (val == "Topic base")
            {
                objbll.Quiz_level = val;
                objbll.Topic = txttopic.Text;
            }
            else
            {
                objbll.Quiz_level = val;
                objbll.Topic = "All Topicss";
            }
        }
        objbll.Quiz_start_date = Convert.ToDateTime(dtquizstart.Text);
        objbll.Quiz_end_date = Convert.ToDateTime(dtquizend.Text);
        objbll.Createdby = user;
        objbll.Modifiedby = user;
        int a = objbll.InsertQuizSetting(objbll);
        if (a == 1)
        {
            lblresult.Text = "Quiz Setting save Successfully";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }

    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
        txtquizname.Focus();
    }

    protected void cbquiztype_SelectedIndexChanged(object sender, EventArgs e)
    {
        string value = cbquiztype.SelectedItem.ToString();
        if (value == "Objective")
        {
            //cbquizlevel.Enabled = true;
        }
        else
        {
            //cbquizlevel.Enabled = false;
            //txttopic.Enabled = true;
        }
    }

    protected void cbquizlevel_SelectedIndexChanged(object sender, EventArgs e)
    {
        string value = cbquizlevel.SelectedItem.ToString();
        if (value == "Topic base")
        {
            txttopic.Enabled = true;
        }
        else
        {
            txttopic.Enabled = false;
        }
    }
    protected void linkProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
    }
    protected void linkChangePassword_Click(object sender, EventArgs e)
    {
        Session["username"] = user;
        Response.Redirect("../Login/ChangePasword.aspx");
    }
    protected void linkSignOut_Click(object sender, EventArgs e)
    {
        try
        {
            Session["teacher"] = null;
            Session.Abandon();
            Response.Redirect("../Login/Login.aspx");
        }
        catch
        {

        }
    }
}