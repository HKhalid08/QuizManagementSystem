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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        SelectEmpLogin();
    }

    public void SelectEmpLogin()
    {
        string us = txtusername.Text.Substring(0, 1);

        if (us == "e")
        {
            BLLEmployeeInfo objbll = new BLLEmployeeInfo();
            objbll.Username = txtusername.Text;
            objbll.Password = Encrypt(txtpasssword.Text);
            List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
            objlist = objbll.SelectEmpLogin(objbll);
            if (objlist.Count > 0)
            {
                DateTime dt = DateTime.Now;
                string signin = String.Format("{0:F}", dt);

                string user = objlist[0].Username;
                string name = objlist[0].Name;
                string password = Decrypt(objlist[0].Password);
                string dep_id = objlist[0].Dep_id;
                string des_id = objlist[0].Des_id;
                string pic_name = objlist[0].Pic_name;

                if (password == "usa")
                {
                    Session["pass"] = "change";
                    Session["username"] = user;
                    Session["dep_id"] = dep_id;
                    Response.Redirect("ChangePasword.aspx");
                }
                if (dep_id == "Faculty")
                {
                    Session["teacher"] = user;
                    Session["username"] = user;
                    Session["name"] = name;
                    Session["des_id"] = des_id;
                    Session["pic_name"] = pic_name;
                    Session["signin"] = signin;
                    Session["dep_id"] = dep_id;
                    Response.Redirect("../TeacherWebPages/teacher.aspx");
                }
                else
                {
                    Session["user"] = user;
                    Session["username"] = user;
                    Session["name"] = name;
                    Session["des_id"] = des_id;
                    Session["pic_name"] = pic_name;
                    Session["signin"] = signin;
                    Session["dep_id"] = dep_id;
                    Response.Redirect("../WebPages/admin.aspx");
                }
            }
            else
            {
                lblresult.Text = "Enter Valid Username and Password";
                txtusername.Text = string.Empty;
                txtusername.Focus();
            }
        }
        else
        {
            BLLStudentInfo objbll = new BLLStudentInfo();
            objbll.Username = txtusername.Text;
            objbll.Password = Encrypt(txtpasssword.Text);
            List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();
            objlist = objbll.SelectStuLogin(objbll);
            if (objlist.Count > 0)
            {
                DateTime dt = DateTime.Now;
                string signin = String.Format("{0:F}", dt);

                string user = objlist[0].Username;
                string name = objlist[0].Name;
                string password = Decrypt(objlist[0].Password);

                string pic_name = objlist[0].Pic_name;

                if (password == "usa")
                {
                    Session["pass"] = "change";
                    Session["username"] = user;
                    Session["dep_id"] = "Student";
                    Response.Redirect("ChangePasword.aspx");
                }
                else
                {
                    Session["student"] = user;
                    Session["username"] = user;
                    Session["name"] = name;
                    Session["des_id"] = "Student";
                    Session["pic_name"] = pic_name;
                    Session["signin"] = signin;
                    Session["dep_id"] = "Student";
                    Response.Redirect("../StudentWebPages/student.aspx");
                }
            }
            else
            {
                lblresult.Text = "Enter Valid Username and Password";
                txtusername.Text = string.Empty;
                txtusername.Focus();
            }
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

    private string Decrypt(string cipherText)
    {
        string EncryptionKey = "MAKV2SPBNI99212";
        byte[] cipherBytes = Convert.FromBase64String(cipherText);
        using (Aes encryptor = Aes.Create())
        {
            Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
            encryptor.Key = pdb.GetBytes(32);
            encryptor.IV = pdb.GetBytes(16);
            using (MemoryStream ms = new MemoryStream())
            {
                using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(cipherBytes, 0, cipherBytes.Length);
                    cs.Close();
                }
                cipherText = Encoding.Unicode.GetString(ms.ToArray());
            }
        }
        return cipherText;
    }
    protected void btnForgot_Click(object sender, EventArgs e)
    {
        txtusername.Text = string.Empty;
        txtpasssword.Text = string.Empty;
        lblresult.Text = string.Empty;
        txtusername.Focus();
    }
}