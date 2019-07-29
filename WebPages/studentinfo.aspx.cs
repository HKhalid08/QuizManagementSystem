using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxUploadControl;

public partial class Web_Pages_PortoQuiz_Home : System.Web.UI.Page
{
    private string user;
    static string ThumbnailFileName = string.Empty;

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
        SelectProgram();
        SelectSession();
        SelectRollno();

        if (!IsPostBack)
        {
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
        txtname.Text = string.Empty;
        txtfname.Text = string.Empty;
        txtcnic.Text = string.Empty;
        txtnationality.Text = string.Empty;
        txtmobileno.Text = string.Empty;
        txtpaddress.Text = string.Empty;
        txtphoneno.Text = string.Empty;
        txtcaddress.Text = string.Empty;
        txtemail.Text = string.Empty;
        lblresult.Text = string.Empty;
        dtreg_date.Text = string.Empty;
        dtdob.Text = string.Empty;
    }

    public void SelectRollno()
    {
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();
        BLLStudentInfo objbll = new BLLStudentInfo();
        objlist = objbll.SelectMaxRollno();
        if (objlist.Count > 0)
        {
            string reg1 = objlist[0].Rollno;
            long reg_no = Convert.ToInt64(reg1.Substring(2, 5));
            long reg = reg_no + 1;
            txtrollno.Text = Convert.ToString("S-" + reg);
        }
    }

    public void SelectProgram()
    {
        List<BLLProgram> objlist = new List<BLLProgram>();
        BLLProgram objbll = new BLLProgram();
        objlist = objbll.SelectProgram();
        if (objlist.Count > 0)
        {
            cmdprogram.DataSource = objlist;
            cmdprogram.ValueField = "program_id";
            cmdprogram.TextField = "program_name";
            cmdprogram.DataBind();
        }
    }

    public void SelectSession()
    {
        List<BLLSession> objlist = new List<BLLSession>();
        BLLSession objbll = new BLLSession();
        objlist = objbll.SelectSession();
        if (objlist.Count > 0)
        {
            cmdsession.DataSource = objlist;
            cmdsession.ValueField = "session_id";
            cmdsession.TextField = "description";
            cmdsession.DataBind();
        }
    }
    
    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string mod = (string)Session["mode"];
        if (mod == "ed")
        {
            UpdateStudentinfo();
        }
        else
        {
            InsertStudentinfo();
        }
    }

    public void InsertStudentinfo()
    {
        BLLStudentInfo objbll = new BLLStudentInfo();
        objbll.Rollno = txtrollno.Text; ;
        objbll.Program_id = cmdprogram.SelectedItem.Value.ToString();
        objbll.Session_id = cmdsession.SelectedItem.Value.ToString();
        objbll.Reg_date = Convert.ToDateTime(dtreg_date.Value);
        objbll.Name = txtname.Text;
        objbll.Father_name = txtfname.Text;
        objbll.Gender = cbgender.SelectedItem.ToString();
        objbll.Dob = Convert.ToDateTime(dtdob.Value);
        objbll.Nic = txtcnic.Text;
        objbll.Nationality = txtnationality.Text;
        objbll.Mobile = txtmobileno.Text;
        objbll.Phone = txtphoneno.Text;
        objbll.C_address = txtcaddress.Text;
        objbll.P_address = txtpaddress.Text;
        objbll.Email = txtemail.Text;

        objbll.Username = txtrollno.Text;
        objbll.Password = Encrypt("usa".Trim());

        objbll.Pic_name = ("~/Student_Images/" + ThumbnailFileName.ToString());
        objbll.Pic_path = "d";

        objbll.Createdby = user;
        objbll.Modifiedby = user;

        int a = objbll.InsertStudentInfo(objbll);
        if (a == 3)
        {
            lblresult.Text = "Student Information Save Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }

    private string Encrypt(string clearText)
    {
        string EncryptionKey = "MAKV2SPBNI99212";
        byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(clearBytes, 0, clearBytes.Length);
                    cs.Close();
                }
                clearText = Convert.ToBase64String(ms.ToArray());
            }
        }
        return clearText;
    }
    
    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        SelectRollno();
        Clear();
        SelectSession();
        SelectProgram();
    }

    const string UploadDirectory = "~/Student_Images/";
    
    protected void Btnbrowse_FileUploadComplete(object sender, DevExpress.Web.ASPxUploadControl.FileUploadCompleteEventArgs e)
    {
        e.CallbackData = SavePostedFile(e.UploadedFile);
    }

    public string SavePostedFile(UploadedFile uploadedFile)
    {


        ThumbnailFileName = uploadedFile.FileName.ToString();

        if (uploadedFile.IsValid)
        {
            try
            {

                string ParentDirectoryName = Server.MapPath(UploadDirectory);

                string ImageFilePath = Path.Combine(Server.MapPath(UploadDirectory), ThumbnailFileName);
                uploadedFile.SaveAs(ImageFilePath);



                //imgEmployeeBox.ImageUrl = "~/Student_Images/" + ThumbnailFileName;




            }
            catch
            {


            }



        }

        return ThumbnailFileName;

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
        objbll.App_detail = "Student";
        objlist = objbll.Selectuserrights(objbll);
        if (objlist.Count > 0)
        {
            string r_add = objlist[0].Rr_add;

            if (r_add == "1")
            {
                BtnSave.Enabled = true;
                BtnClear.Enabled = true;
                BtnNew.Enabled = false;
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

    public void LoadForm()
    {
        BLLStudentInfo objbll = new BLLStudentInfo();
        objbll.Rollno = (string)Session["stu_update"];
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();
        objlist = objbll.Selectstudentinfobyid(objbll);
        if (objlist.Count > 0)
        {
            txtrollno.Text = objlist[0].Rollno;
            cmdprogram.Text = objlist[0].Program_id;
            cmdsession.Text = objlist[0].Session_id;
            dtreg_date.Text = Convert.ToString(objlist[0].Reg_date);

            txtname.Text = objlist[0].Name;
            txtfname.Text = objlist[0].Father_name;
            cbgender.Text = objlist[0].Gender;
            dtdob.Text = Convert.ToString(objlist[0].Dob);
            txtcnic.Text = objlist[0].Nic.ToString();
            txtnationality.Text = objlist[0].Nationality;
            txtmobileno.Text = objlist[0].Mobile;
            txtphoneno.Text = objlist[0].Phone;
            txtcaddress.Text = objlist[0].C_address;
            txtpaddress.Text = objlist[0].P_address;
            txtemail.Text = objlist[0].Email;

            imgUser.ImageUrl = objlist[0].Pic_name;
        }
    }

    public void UpdateStudentinfo()
    {
        BLLStudentInfo objbll = new BLLStudentInfo();
        objbll.Rollno = (string)Session["stu_update"];
        objbll.Program_id = cmdprogram.SelectedItem.Value.ToString();
        objbll.Session_id = cmdsession.SelectedItem.Value.ToString();
        objbll.Reg_date = Convert.ToDateTime(dtreg_date.Value);
        objbll.Name = txtname.Text;
        objbll.Father_name = txtfname.Text;
        objbll.Gender = cbgender.SelectedItem.ToString();
        objbll.Dob = Convert.ToDateTime(dtdob.Value);
        objbll.Nic = txtcnic.Text;
        objbll.Nationality = txtnationality.Text;
        objbll.Mobile = txtmobileno.Text;
        objbll.Phone = txtphoneno.Text;
        objbll.C_address = txtcaddress.Text;
        objbll.P_address = txtpaddress.Text;
        objbll.Email = txtemail.Text;

        objbll.Modifiedby = user;

        int a = objbll.UpdateStudentInfo(objbll);
        if (a == 1)
        {
            lblresult.Text = "Student Information Update Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
}