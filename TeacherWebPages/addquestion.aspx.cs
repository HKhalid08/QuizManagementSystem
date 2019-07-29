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
            ControlEnableFalse();
            string mode = (string)Session["mode"];
            if (mode == "ed")
            {
                LoadForm();
            }
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
        txtquestion.Text = string.Empty;
        txttopic.Text = string.Empty;
        txta.Text = string.Empty;
        txtb.Text = string.Empty;
        txtc.Text = string.Empty;
        txtd.Text = string.Empty;
        lblresult.Text = string.Empty;
        rba.Checked = false;
        rbb.Checked = false;
        rbc.Checked = false;
        rbd.Checked = false;
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string mod = (string)Session["mode"];
        if (mod == "ed")
        {
            UpdateQuestion();
        }
        else
        {
            InsertQuestion();
        }
    }

    public void InsertQuestion()
    {
        string val = cbanswertype.SelectedItem.ToString();
        if (val == "Objective")
        {
            InsertObjectiveQuestion();
        }
        else
        {
            InsertSubjectiveQuestion();
        }
    }

    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
    }

    protected void cbanswertype_SelectedIndexChanged(object sender, EventArgs e)
    {
        string val = cbanswertype.SelectedItem.ToString();
        if (val == "Subjective")
        {
            ControlEnableFalse();
        }
        else
        {
            ControlEnableTrue();
        }
    }

    public void ControlEnableFalse()
    {
        lblnoofanswer.Enabled = false;
        lblanswer.Enabled = false;
        lbla.Enabled = false;
        lblb.Enabled = false;
        lblc.Enabled = false;
        lbld.Enabled = false;
        lblcorrectanswer.Enabled = false;
        cbnoofanswers.Enabled = false;
        txta.Enabled = false;
        txtb.Enabled = false;
        txtc.Enabled = false;
        txtd.Enabled = false;
        rba.Enabled = false;
        rbb.Enabled = false;
        rbc.Enabled = false;
        rbd.Enabled = false;
    }

    public void ControlEnableTrue()
    {
        lblnoofanswer.Enabled = true;
        lblanswer.Enabled = true;
        lbla.Enabled = true;
        lblb.Enabled = true;
        lblc.Enabled = true;
        lbld.Enabled = true;
        lblcorrectanswer.Enabled = true;
        cbnoofanswers.Enabled = true;
        txta.Enabled = true;
        txtb.Enabled = true;
        txtc.Enabled = true;
        txtd.Enabled = true;
        rba.Enabled = true;
        rbb.Enabled = true;
        rbc.Enabled = true;
        rbd.Enabled = true;
    }

    public void InsertObjectiveQuestion()
    {
        BLLQuestion objbll = new BLLQuestion();
        objbll.Course_code = txtcoursecode.Text;
        objbll.Course_title = txtcoursetitle.Text;
        objbll.Answer_type = "Objective";
        objbll.No_of_answer = cbnoofanswers.SelectedItem.ToString();
        objbll.Topic = txttopic.Text;
        objbll.Question = txtquestion.Text;
        objbll.Ques_level = cblevel.SelectedItem.ToString();
        objbll.Answer_a = txta.Text;
        objbll.Answer_b = txtb.Text;
        objbll.Answer_c = txtc.Text;
        objbll.Answer_d = txtd.Text;
        if (rba.Checked == true)
        {
            objbll.Correct_answer = "A";
        }
        else if (rbb.Checked == true)
        {
            objbll.Correct_answer = "B";
        }
        else if (rbc.Checked == true)
        {
            objbll.Correct_answer = "C";
        }
        else
        {
            objbll.Correct_answer = "D";
        }

        objbll.Createdby = user;
        objbll.Modifiedby = user;
        int a = objbll.InsertQuestion(objbll);
        if (a == 1)
        {
            lblresult.Text = "Question Save Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            txttopic.Focus();
        }
    }

    public void InsertSubjectiveQuestion()
    {
        BLLQuestion objbll = new BLLQuestion();
        objbll.Course_code = txtcoursecode.Text;
        objbll.Course_title = txtcoursetitle.Text;
        objbll.Answer_type = "Subjective";
        objbll.Topic = txttopic.Text;
        objbll.Question = txtquestion.Text;
        objbll.Ques_level = cblevel.SelectedItem.ToString();
  
        objbll.Createdby = user;
        objbll.Modifiedby = user;
        int a = objbll.InsertQuestion(objbll);
        if (a == 1)
        {
            lblresult.Text = "Question Save Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            txttopic.Focus();
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

    public void LoadForm()
    {
        BLLQuestion objbll = new BLLQuestion();
        objbll.Id = (int)Session["ques_update"];
        List<BLLQuestion> objlist = new List<BLLQuestion>();
        objlist = objbll.Selectquestionbyid(objbll);
        if (objlist.Count > 0)
        {
            string answer_type = objlist[0].Answer_type;

            if (answer_type == "Objective")
            {
                ControlEnableTrue();
            }
            else
            {
                ControlEnableFalse();
            }
            cbanswertype.Text = answer_type;
            txttopic.Text = objlist[0].Topic;
            txtquestion.Text = objlist[0].Question;
            cblevel.Text = objlist[0].Ques_level;

            cbnoofanswers.Text = objlist[0].No_of_answer;
            txta.Text = objlist[0].Answer_a;
            txtb.Text = objlist[0].Answer_b;
            txtc.Text = objlist[0].Answer_c;
            txtd.Text = objlist[0].Answer_d;
            string val = objlist[0].Correct_answer;
            if (val == "A")
            {
                rba.Checked = true;
            }
            else
                if (val == "B")
                {
                    rbb.Checked = true;
                }
                else
                    if (val == "C")
                    {
                        rbc.Checked = true;
                    }
                    else
                        if (val == "D")
                        {
                            rbd.Checked = true;
                        }
        }
    }

    public void UpdateObjectiveQuestion()
    {
        BLLQuestion objbll = new BLLQuestion();
        objbll.Id = (int)Session["ques_update"];
        objbll.Answer_type = "Objective";
        objbll.No_of_answer = cbnoofanswers.SelectedItem.ToString();
        objbll.Topic = txttopic.Text;
        objbll.Question = txtquestion.Text;
        objbll.Ques_level = cblevel.SelectedItem.ToString();
        objbll.Answer_a = txta.Text;
        objbll.Answer_b = txtb.Text;
        objbll.Answer_c = txtc.Text;
        objbll.Answer_d = txtd.Text;
        if (rba.Checked == true)
        {
            objbll.Correct_answer = "A";
        }
        else if (rbb.Checked == true)
        {
            objbll.Correct_answer = "B";
        }
        else if (rbc.Checked == true)
        {
            objbll.Correct_answer = "C";
        }
        else
        {
            objbll.Correct_answer = "D";
        }

        objbll.Modifiedby = user;
        int a = objbll.UpdateQuestion(objbll);
        if (a == 1)
        {
            lblresult.Text = "Question Update Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            txttopic.Focus();
            Session["mode"] = null;
        }
    }

    public void UpdateSubjectiveQuestion()
    {
        BLLQuestion objbll = new BLLQuestion();
        objbll.Answer_type = "Subjective";
        objbll.Topic = txttopic.Text;
        objbll.Question = txtquestion.Text;
        objbll.Ques_level = cblevel.SelectedItem.ToString();

        objbll.Modifiedby = user;
        int a = objbll.UpdateQuestion(objbll);
        if (a == 1)
        {
            lblresult.Text = "Question Update Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
            txttopic.Focus();
            Session["mode"] = null;
        }
    }

    public void UpdateQuestion()
    {
        string val = cbanswertype.SelectedItem.ToString();
        if (val == "Objective")
        {
            UpdateObjectiveQuestion();
        }
        else
        {
            UpdateSubjectiveQuestion();
        }
    }
}