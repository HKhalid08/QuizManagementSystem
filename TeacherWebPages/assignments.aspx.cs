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
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    public void Clear()
    {
        txttopic.Text = string.Empty;
        txtlesson.Text = string.Empty;
        txttotalmarks.Text = string.Empty;
        lblresult.Text = string.Empty;
    }

    public void InsertAssignment()
    {
        if (FileUpload1.HasFile)
        {
            string fileName = FileUpload1.PostedFile.FileName;
            string extension = System.IO.Path.GetExtension(fileName);
            if (extension == ".pdf" || extension == ".doc" || extension == ".docx")
            {
                BLLAssignment objbll = new BLLAssignment();
                objbll.Course_code = txtcoursecode.Text;
                objbll.Course_title = txtcoursetitle.Text;
                objbll.Title = txttopic.Text;
                objbll.Lesson = txtlesson.Text;
                objbll.Assignment_name = fileName;
                objbll.Assignment_path = ("Assignments/" + fileName);
                objbll.Total_marks = txttotalmarks.Text;
                objbll.Due_date = Convert.ToDateTime(dtduedate.Text);
                objbll.Createdby = user;
                objbll.Modifiedby = user;
                FileUpload1.PostedFile.SaveAs(Server.MapPath("Assignments/") + fileName);
                int a = objbll.InsertAssignment(objbll);
                if (a == 1)
                {
                    lblresult.Text = "Assignment upload Successfully";
                    BtnSave.Enabled = false;
                    BtnNew.Enabled = true;
                }
            }
            else
            {
                lblresult.Text = "Choose Pdf or Doc file...";
            }
        }
    }

    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
        txttopic.Focus();
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        InsertAssignment();
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