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
    private string user,mode;
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
        SelectDepartment();
        SelectDesignation();
        SelecEmpCode();

        if (!IsPostBack)
        {
            mode = (string)Session["mode"];
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
        txtqualification.Text = string.Empty;
        txtspecialization.Text = string.Empty;
        txtabout.Text = string.Empty;
        txtemail.Text = string.Empty;
        lblresult.Text = string.Empty;
        dateJoing.Text = string.Empty;
        dtdob.Text = string.Empty;
    }

    public void SelectDepartment()
    {
        List<BLLDepartmentDesignation> objlist = new List<BLLDepartmentDesignation>();
        BLLDepartmentDesignation objbll = new BLLDepartmentDesignation();
        objlist = objbll.SelectDepartment();
        if (objlist.Count > 0)
        {
            cmdDepartmants.DataSource = objlist;
            cmdDepartmants.ValueField = "dep_id";
            cmdDepartmants.TextField = "dep_name";
            cmdDepartmants.DataBind();
        }
    }

    public void SelectDesignation()
    {
        List<BLLDepartmentDesignation> objlist = new List<BLLDepartmentDesignation>();
        BLLDepartmentDesignation objbll = new BLLDepartmentDesignation();
        objlist = objbll.SelectDesignation();
        if (objlist.Count > 0)
        {
            cmbDesignation.DataSource = objlist;
            cmbDesignation.ValueField = "des_id";
            cmbDesignation.TextField="des_name";
            cmbDesignation.DataBind();
        }
    }

    public void SelecEmpCode()
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();
        objlist = objbll.SelectMaxEmpCode();
        if (objlist.Count > 0)
        {
            string reg1 = objlist[0].Emp_code;
            long reg_no = Convert.ToInt64(reg1.Substring(2, 5));
            long reg = reg_no + 1;
            txtemployeecode.Text = Convert.ToString("E-" + reg);
        }
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        string mod = (string)Session["mode"];
        if (mod == "ed")
        {
            UpdateEmployeeInfo();
        }
        else
        {
            InsertEmployeeinfo();
        }
    }

    public void InsertEmployeeinfo()
    {
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();
        objbll.Emp_code = txtemployeecode.Text; ;
        objbll.Dep_id = cmdDepartmants.SelectedItem.Value.ToString();
        objbll.Des_id = cmbDesignation.SelectedItem.Value.ToString();
        objbll.Joining_date = Convert.ToDateTime(dateJoing.Value);
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

        objbll.Username = txtemployeecode.Text;
        objbll.Password = Encrypt("usa".Trim());

         
        
        objbll.Qualification = txtqualification.Text;
        objbll.Specialization = txtspecialization.Text;
        objbll.About = txtabout.Text;

        objbll.Pic_name = ( "~/Record_Images/" + ThumbnailFileName.ToString());
        objbll.Pic_path = "d";

        objbll.Createdby = user;
        objbll.Modifiedby = user;

        int a = objbll.InsertEmployeeInfo(objbll);
        if (a == 4)
        {
            lblresult.Text = "Employee Information Save Successfully....";
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

    const string UploadDirectory = "~/Record_Images/";
    
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



               imgEmployeeBox.ImageUrl = "~/Record_Images/" + ThumbnailFileName;

              


           }
           catch 
           {
           
               
           }

          

       }

       return ThumbnailFileName;

    }

    protected void BtnNew_Click(object sender, EventArgs e)
    {
        BtnSave.Enabled = true;
        Clear();
        SelecEmpCode();
        SelectDepartment();
        SelectDesignation();
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
        objbll.App_detail = "Employee";
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
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();
        objbll.Emp_code = (string)Session["emp_update"];
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        objlist = objbll.SelectEmployeeInfobyid(objbll);
        if (objlist.Count > 0)
        {
            txtemployeecode.Text = objlist[0].Emp_code;
            cmdDepartmants.Text = objlist[0].Dep_id;
            cmbDesignation.Text = objlist[0].Des_id;
            dateJoing.Text = Convert.ToString(objlist[0].Joining_date);

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

            txtqualification.Text = objlist[0].Qualification;
            txtspecialization.Text = objlist[0].Specialization;
            txtabout.Text = objlist[0].About;
        }
    }

    public void UpdateEmployeeInfo()
    {
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();
        objbll.Emp_code = (string)Session["emp_update"];
        objbll.Dep_id = cmdDepartmants.SelectedItem.Value.ToString();
        objbll.Des_id = cmbDesignation.SelectedItem.Value.ToString();
        objbll.Joining_date = Convert.ToDateTime(dateJoing.Value);
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

        objbll.Qualification = txtqualification.Text;
        objbll.Specialization = txtspecialization.Text;
        objbll.About = txtabout.Text;

        objbll.Modifiedby = user;

        int a = objbll.UpdateEmployeeInfo(objbll);
        if (a == 2)
        {
            lblresult.Text = "Employee Information Update Successfully....";
            BtnSave.Enabled = false;
            BtnNew.Enabled = true;
        }
    }
}