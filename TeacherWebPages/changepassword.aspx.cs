using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        txtusername.Text = user;
    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        Clear();
    }

    public void Clear()
    {
        txtusername.Text = string.Empty;
        txtoldpassword.Text = string.Empty;
        txtnewpassword.Text = string.Empty;
        txtconfirmpassword.Text = string.Empty;
        lblresult.Text = string.Empty;
    }

    protected void BtnSave_Click(object sender, EventArgs e)
    {
        ChangePassword();
    }

    public void ChangePassword()
    {
        BLLChangePassword objbll = new BLLChangePassword();
        objbll.Username = txtusername.Text;
        objbll.Old_password = Encrypt(txtoldpassword.Text);
        objbll.New_password = Encrypt(txtnewpassword.Text);
        int a = objbll.ChangePassword(objbll);
        if (a == 1)
        {
            lblresult.Text = "Password Changed Successfully";
        }
        else
        {
            lblresult.Text = "Password not - Changed";
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
}