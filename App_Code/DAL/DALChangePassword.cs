using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALChangePassword
/// </summary>
public class DALChangePassword
{
	public DALChangePassword()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int ChangePassword(BLLChangePassword objbll)
    {
        SqlParameter[] param = new SqlParameter[3];

        param[0] = new SqlParameter("@username", SqlDbType.NVarChar);
        param[0].Value = objbll.Username;

        param[1] = new SqlParameter("@old_password", SqlDbType.NVarChar);
        param[1].Value = objbll.Old_password;

        param[2] = new SqlParameter("@new_password", SqlDbType.NVarChar);
        param[2].Value = objbll.New_password;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_changepassword", param);
        objcon.CloseConnection();
        return a;
    }
}