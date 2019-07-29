using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Web_Pages_PortoQuiz_Home : System.Web.UI.Page
{
    private string user,namequiz,subj;
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
    }

    public void LoadGrid()
    {
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Course_code = txtcoursecode.Text;
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();
        objlist = objbll.SelectQuiz(objbll);
        if (objlist.Count > 0)
        {
            dgquiz.DataSource = objlist;
            dgquiz.DataBind();

            for (int i = 0; i <= dgquiz.Rows.Count - 1; i++)
            {
                DateTime currentdate = System.DateTime.Now;
                DateTime start_date = objlist[i].Quiz_start_date;
                DateTime end_date = objlist[i].Quiz_end_date;

                string quiz_name = objlist[i].Quiz_name;
                string status = Convert.ToString(objlist[i].Quiz_status);

                int a = DateTime.Compare(currentdate, start_date);
                int b = DateTime.Compare(end_date, currentdate);

                CheckQuizName(quiz_name);
                CheckQuizNameSubjective(quiz_name);
                
                if (namequiz == quiz_name)
                {
                    dgquiz.Rows[i].Cells[1].Enabled = false;
                }
                    else
                if (status == "True")
                {
                    dgquiz.Rows[i].Cells[1].Enabled = false;
                }
                else
                if (a == 1 && b == -1)
                {
                    dgquiz.Rows[i].Cells[1].Enabled = true;
                }
                else
                if (a == 1 && b == 1)
                {
                    dgquiz.Rows[i].Cells[1].Enabled = true;
                }
                else
                {
                    dgquiz.Rows[i].Cells[1].Enabled = false;
                }
            }
        }
    }

    public string CheckQuizName(string quiz)
    {
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Rollno = user;
        objbll.Course_code = txtcoursecode.Text;
        objbll.Quiz_name = quiz;
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();
        objlist = objbll.SelectQuizNameforCheck(objbll);
        if (objlist.Count > 0)
        {
            namequiz = objlist[0].Quiz_name;
        }
        return namequiz;
    }

    public string CheckQuizNameSubjective(string quiz)
    {
        //string quizname = "";
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Rollno = user;
        objbll.Course_code = txtcoursecode.Text;
        objbll.Quiz_name = quiz;
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();
        objlist = objbll.SelectQuizNameSubjectiveforCheck(objbll);
        if (objlist.Count > 0)
        {
            namequiz = objlist[0].Quiz_name;
        }
        return namequiz;
    }

    public void StartQuiz()
    {
        string quiz_type = (string)Session["quiz_type"];
        string quiz_level = (string)Session["quiz_level"];

        if (quiz_type == "Objective" && quiz_level == "Topic base")
        {
            Response.Redirect("takequiz.aspx");
        }
        else
            if (quiz_type == "Objective" && quiz_level == "Subject base")
            {
                Response.Redirect("takequizobjectivefull.aspx");
            }
            else
                if (quiz_type == "Subjective" && quiz_level == "Topic base")
                {
                    Response.Redirect("takequizsubjective.aspx");
                }
                else
                    if (quiz_type == "Subjective" && quiz_level == "Subject base")
                    {
                        Response.Redirect("takequizsubjectivefull.aspx");
                    }
                    else
                    {
                        Response.Redirect("student.aspx");
                    }
    }

    protected void btnstart_Click1(object sender, EventArgs e)
    {
        string[] arg = new string[3];
        LinkButton obj = (LinkButton)(sender);
        arg = obj.CommandArgument.ToString().Split(';');
        Session["id"] = arg[0];
        Session["quiz_type"] = arg[1];
        Session["quiz_level"] = arg[2];
        StartQuiz();
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