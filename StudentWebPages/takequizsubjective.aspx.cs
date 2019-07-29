using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login_Login : System.Web.UI.Page
{
    private string user, id, correct_answer, attempt_question, correct;
    private int time, question_id, no_of_question;
    public static int no = 0;
    public bool answer_status;
    List<BLLQuestion> objlistque = new List<BLLQuestion>();
    
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

        id = (string)Session["id"];
        LoadHeader();

        if (!ScriptManager1.IsInAsyncPostBack)
        {
            Session["timeout"] = DateTime.Now.AddMinutes(time).ToString();
        }

        if (!IsPostBack)
        {
            LoadQuestion();
            getQuestion(no);
            ASPxPopupControl1.ShowOnPageLoad = false;
        }
    }

    public void LoadHeader()
    {
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Id = Convert.ToInt32(id);
        List<BLLQuizSetting> objlist = new List<BLLQuizSetting>();
        objlist = objbll.SelecttakeQuiz(objbll);
        if (objlist.Count > 0)
        {
            lblcoursecode.Text = objlist[0].Course_code;
            lblcoursetitle.Text = objlist[0].Course_title;
            lblquizname.Text = objlist[0].Quiz_name;
            lbltotalmarks.Text = objlist[0].Total_marks;
            lblpassingmarks.Text = objlist[0].Passing_marks;
            lblquiztype.Text = objlist[0].Quiz_type;
            lblquizlevel.Text = objlist[0].Quiz_level;
            time = Convert.ToInt32(objlist[0].Quiz_time);
            no_of_question = Convert.ToInt32(objlist[0].No_of_question);
        }
    }

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        if (0 > DateTime.Compare(DateTime.Now,DateTime.Parse(Session["timeout"].ToString())))
        {
            lblTimer.Text = "Minutes Left: " +
            ((Int32)DateTime.Parse(Session["timeout"].
            ToString()).Subtract(DateTime.Now).TotalMinutes).ToString();
        }
    }

    public void LoadQuestion()
    {
        BLLQuestion objbll = new BLLQuestion();
        objbll.Quiz_name = lblquizname.Text;
        objbll.Course_code = lblcoursecode.Text;
        
        objlistque = objbll.Selectsubjectivequestionforquiz(objbll);
        Session["question"] = objlistque;
        lblques.Text = objlistque.Count.ToString();
    }

    public void getQuestion(int no)
    {
        objlistque = (List<BLLQuestion>)Session["question"];
        if (objlistque.Count > 0)
        {
            int qu = Convert.ToInt32(lblques.Text);
            if (no < qu)
            {
                int quesno = no + 1;
                lblquesno.Text = " Q." + (quesno.ToString());
                lblno.Text = Convert.ToString(objlistque[no].Id);
                lblQuestionNumber.Text = objlistque[no].Question;
            }
            else
            {
                btnSubmit.Enabled = false;
                ASPxPopupControl1.ShowOnPageLoad = true;
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        InsertQuizAnswer();
        no += 1;
        getQuestion(no); 
    }

    public void InsertQuizAnswer()
    {
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Rollno = user;
        objbll.Course_code = lblcoursecode.Text;
        objbll.Quiz_name = lblquizname.Text;
        objbll.Id = Convert.ToInt32(lblno.Text);
        objbll.Question = lblQuestionNumber.Text;
        objbll.Correct_answer = txtanswer.Text;
        int d = objbll.InsertQuizAnswerSubjective(objbll);
    }

    protected void popupokbutton_Click(object sender, EventArgs e)
    {
        try
        {
            Session["question"] = null;
            //Session.Abandon();
            Response.Redirect("student.aspx");
        }
        catch
        {

        }
    }
}