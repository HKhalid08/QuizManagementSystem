using System;
using System.Collections.Generic;
using System.Data;
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
        LoadCourses();
    }

    public void LoadCourses()
    {
        List<BLLCourses> objlist = new List<BLLCourses>();
        BLLCourses objbll = new BLLCourses();
        objlist = objbll.SelectCourses();
        if (objlist.Count > 0)
        {
            cbcourses.DataSource = objlist;
            cbcourses.ValueField = "course_code";
            cbcourses.TextField = "course_title";
            cbcourses.DataBind();
        }
    }

    public void SelectCalenderbycourse()
    {
        BLLCourses objbll = new BLLCourses();
        objbll.Course_code = cbcourses.SelectedItem.Value.ToString();
        List<BLLCourses> objlist = new List<BLLCourses>();
        objlist = objbll.Selectcalenderbycourse(objbll);
        if (objlist.Count > 0)
        {
            dglecture.DataSource = objlist;
            dglecture.DataBind();
            for (int i = 0; i <= dglecture.Rows.Count-1; i++)
            {
                if (i == 0)
                {
                    dglecture.Rows[0].Enabled = true;
                }
                else
                {
                    dglecture.Rows[i].Enabled = false;
                }
            }
        }
    }
    protected void cbcourses_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectCalenderbycourse();
    }

    protected void dglecture_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
    {
        InsertCourseCalendar();
    }

    public void InsertCourseCalendar()
    {
        for (int i = 0; i <= dglecture.Rows.Count-1; i++)
        {
                TextBox txttopic = (TextBox)dglecture.Rows[i].Cells[1].FindControl("txt_topic");
                TextBox txtlecture = (TextBox)dglecture.Rows[i].Cells[2].FindControl("txt_lecture");
                TextBox txtresource = (TextBox)dglecture.Rows[i].Cells[3].FindControl("txt_resources");

                BLLCourses objbll = new BLLCourses();
                objbll.Course_code = cbcourses.SelectedItem.Value.ToString();
                objbll.Topic = txttopic.Text;
                objbll.Lecture = txtlecture.Text;
                objbll.Resource = txtresource.Text;
                int b = objbll.InsertCourseCalendar(objbll);
        }
        SelectCalenderbycourse();
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
        objbll.App_detail = "CourseCalender";
        objlist = objbll.Selectuserrights(objbll);
        if (objlist.Count > 0)
        {
            string r_add = objlist[0].Rr_add;

            if (r_add == "1")
            {
                //BtnSave.Enabled = true;
                //BtnClear.Enabled = true;
                //BtnNew.Enabled = false;
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