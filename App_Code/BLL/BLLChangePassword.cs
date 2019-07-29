using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLChangePassword
/// </summary>
public class BLLChangePassword
{
	public BLLChangePassword()
	{
        Initailize();
	}

    private string username;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }
    private string old_password;

    public string Old_password
    {
        get { return old_password; }
        set { old_password = value; }
    }
    private string new_password;

    public string New_password
    {
        get { return new_password; }
        set { new_password = value; }
    }

    public void Initailize()
    {
        username = string.Empty;
        old_password = string.Empty;
        new_password=string.Empty;
    }

    public int ChangePassword(BLLChangePassword objbll)
    {
        DALChangePassword objdal = new DALChangePassword();
        return objdal.ChangePassword(objbll);
    }
}