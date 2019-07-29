using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Pages_PortoQuiz_Home : System.Web.UI.Page
{
    private string user;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty((string)Session["student"]))
        {
            user = (string)Session["student"];
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

        LoadGrid();

        if (!IsPostBack)
        {
            ASPxPopupControl1.ShowOnPageLoad = false;
        }
    }

    public void LoadGrid()
    {
        BLLAssignment objbll = new BLLAssignment();
        objbll.Course_code = txtcoursecode.Text;
        objbll.Course_title = txtcoursetitle.Text;
        List<BLLAssignment> objlist = new List<BLLAssignment>();
        objlist = objbll.SelectAssignment(objbll);
        if (objlist.Count > 0)
        {
            dgassignment.DataSource = objlist;
            dgassignment.DataBind();

            for (int i = 0; i <= dgassignment.Rows.Count - 1; i++)
            {
                DateTime currentdate = System.DateTime.Now;
                DateTime duedate = objlist[i].Due_date;

                int a = DateTime.Compare(currentdate, duedate);
                if (a == 1)
                {
                    dgassignment.Rows[i].Cells[1].Enabled = false;
                }
                else
                {
                    dgassignment.Rows[i].Cells[1].Enabled = true;
                }
            }
        }
    }

    protected void AssignDownload_Click(object sender, EventArgs e)
    {
        string filePath = (sender as LinkButton).CommandArgument;
        Response.ContentType = ContentType;
        Response.AppendHeader("Content-Disposition", "attachment; filename=" + Path.GetFileName(filePath));
        Response.Redirect("../TeacherWebPages/" + filePath);
        //Response.BinaryWrite((byte[])[filePath]);
        Response.End();
    }

    protected void btnupload_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < dgassignment.Rows.Count - 1; i++)
        {
            FileUpload FileUpload1 = ((FileUpload)(dgassignment.Rows[i].Cells[1].FindControl("flu")));
            if (FileUpload1.HasFile)
            {
                string fileName = FileUpload1.PostedFile.FileName;
                string extension = System.IO.Path.GetExtension(fileName);
                if (extension == ".pdf" || extension == ".doc" || extension == ".docx")
                {
                    BLLAssignment objbll = new BLLAssignment();
                    objbll.Rollno = user;
                    objbll.Name = lblAdmin_USername.Text;
                    objbll.Course_code = txtcoursecode.Text;
                    objbll.Course_title = txtcoursetitle.Text;
                    objbll.Title = "Assignment";
                    //objbll.Total_marks = txtlesson.Text;
                    objbll.Assignment_path = ("SolutionAssignment/" + fileName);

                    FileUpload1.PostedFile.SaveAs(Server.MapPath("SolutionAssignment/") + fileName);
                    int a = objbll.InsertAssignmentSolution(objbll);
                    if (a == 1)
                    {
                        ASPxPopupControl1.ShowOnPageLoad = true;
                    }
                }
                else
                {
                    //lblresult.Text = "Choose Pdf or Doc file...";
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
    protected void popupokbutton_Click(object sender, EventArgs e)
    {
        LoadGrid();
    }
}