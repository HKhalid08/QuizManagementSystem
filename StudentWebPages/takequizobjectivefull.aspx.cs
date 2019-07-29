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
    private string user,id,ques_level="Normal",correct_answer,attempt_question,correct;
    private int time, question_id,no_of_question;
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
        objbll.Ques_level = ques_level;
        objbll.Course_code = lblcoursecode.Text;
        
        objlistque = objbll.Selectquestionforquizobjectivefull(objbll);
        Session["question"] = objlistque;
        if (objlistque.Count > 0)
        {
            if (no < no_of_question)
            {
                int quesno = no + 1;
                lblquesno.Text = " Q." + (quesno.ToString());
                lblno.Text = Convert.ToString(objlistque[0].Id);
                lblQuestionNumber.Text = objlistque[0].Question;
                rbOption1.Text = objlistque[0].Answer_a;
                rbOption2.Text = objlistque[0].Answer_b;
                rbOption3.Text = objlistque[0].Answer_c;
                rbOption4.Text = objlistque[0].Answer_d;
            }
            else
            {
                btnSubmit.Enabled = false;
                Selectanswerfromquiz();
                InsertGradeBook();
                ASPxPopupControl1.ShowOnPageLoad = true;
            }
        }
        //lblques.Text = objlistque.Count.ToString();
    }

    public void checkAnswer()
    {
        objlistque = (List<BLLQuestion>)Session["question"];
        if (objlistque.Count > 0)
        {
            string answer=" ";
            string correct_answer1 = objlistque[0].Correct_answer;
            string qus_level = objlistque[0].Ques_level;

            if (rbOption1.Checked == true)
            {
                answer = "A";
            }
            else
                if (rbOption2.Checked == true)
                {
                    answer = "B";
                }
                else
                    if (rbOption3.Checked == true)
                    {
                        answer = "C";
                    }
                    else
                        if (rbOption4.Checked == true)
                        {
                            answer = "D";
                        }
            correct_answer = answer;
            if (correct_answer == correct_answer1)
            {
                answer_status = true;
                if (qus_level == "Very Simple")
                {
                    ques_level = "Simple";
                }
                else
                    if (qus_level == "Simple")
                    {
                        ques_level = "Normal";
                    }
                    else
                        if (qus_level == "Normal")
                        {
                            ques_level = "Difficult";
                        }
                        else
                            if (qus_level == "Difficult")
                            {
                                ques_level = "More Difficult";
                            }
                            else
                                if (qus_level == "More Difficult")
                                {
                                    ques_level = "Many More Difficult";
                                }
                                else
                                    if (qus_level == "Many More Difficult")
                                    {
                                        ques_level = "Many More Difficult";
                                    }
            }
            else
            {
                answer_status = false;
                if (qus_level == "Very Simple")
                {
                    ques_level = "Very Simple";
                }
                else
                    if (qus_level == "Simple")
                    {
                        ques_level = "Very Simple";
                    }
                    else
                        if (qus_level == "Normal")
                        {
                            ques_level = "Simple";
                        }
                        else
                            if (qus_level == "Difficult")
                            {
                                ques_level = "Normal";
                            }
                            else
                                if (qus_level == "More Difficult")
                                {
                                    ques_level = "Difficult";
                                }
                                else
                                    if (qus_level == "Many More Difficult")
                                    {
                                        ques_level = "More Difficult";
                                    }
            }
        }
    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        checkAnswer();
        InsertQuizAnswer();
        no += 1;
        Clear();
        LoadQuestion();
    }

    public void InsertQuizAnswer()
    {
        BLLQuizSetting objbll = new BLLQuizSetting();
        objbll.Rollno = user;
        objbll.Course_code = lblcoursecode.Text;
        objbll.Quiz_name = lblquizname.Text;
        objbll.Id = Convert.ToInt32(lblno.Text);
        objbll.Question = lblQuestionNumber.Text;
        objbll.Correct_answer = correct_answer;
        objbll.Answer_status = answer_status;
        int d = objbll.InsertQuizAnswer(objbll);
    }

    public void Clear()
    {
        rbOption1.Checked = false;
        rbOption2.Checked = false;
        rbOption3.Checked = false;
        rbOption4.Checked = false;
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

    public void InsertGradeBook()
    {
        BLLGradeBook objbll = new BLLGradeBook();
        objbll.Rollno = user;
        objbll.Course_code = lblcoursecode.Text;
        objbll.Name = lblquizname.Text;
        objbll.Quiz_type = lblquiztype.Text;
        objbll.Quiz_level = lblquizlevel.Text;
        objbll.No_of_question = no_of_question.ToString();
        objbll.Attempt_question = attempt_question;
        objbll.Total_marks = lbltotalmarks.Text;
        objbll.Obtained_mark = correct;
        objbll.Quiz_date = System.DateTime.Now;
        int a = objbll.InsertGradeBook(objbll);
    }

    public void Selectanswerfromquiz()
    {
        BLLGradeBook objbll = new BLLGradeBook();
        objbll.Course_code = lblcoursecode.Text;
        objbll.Name = lblquizname.Text;
        objbll.Rollno = user;
        List<BLLGradeBook> objlist = new List<BLLGradeBook>();
        objlist = objbll.Selectanswerfromquiz(objbll);
        if (objlist.Count > 0)
        {
            attempt_question = objlist[0].Attempt_question;
            int coor = Convert.ToInt32(objlist[0].Obtained_mark);

            int tomark = Convert.ToInt32(lbltotalmarks.Text);
            int marks = tomark / no_of_question;
            correct = Convert.ToString(coor * marks);
        }
    }
}