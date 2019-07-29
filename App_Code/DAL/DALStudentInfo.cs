using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALStudentInfo
/// </summary>
public class DALStudentInfo
{
	public DALStudentInfo()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertStudentInfo(BLLStudentInfo objbll)
    {
        SqlParameter[] param = new SqlParameter[25];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
        param[1].Value = objbll.Name;

        param[2] = new SqlParameter("@father_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Father_name;

        param[3] = new SqlParameter("@c_address", SqlDbType.NVarChar);
        param[3].Value = objbll.C_address;

        param[4] = new SqlParameter("@p_address", SqlDbType.NVarChar);
        param[4].Value = objbll.P_address;

        param[5] = new SqlParameter("@phone", SqlDbType.NVarChar);
        param[5].Value = objbll.Phone;

        param[6] = new SqlParameter("@mobile", SqlDbType.NVarChar);
        param[6].Value = objbll.Mobile;

        param[7] = new SqlParameter("@email", SqlDbType.NVarChar);
        param[7].Value = objbll.Email;

        param[8] = new SqlParameter("@nic", SqlDbType.NVarChar);
        param[8].Value = objbll.Nic;

        param[9] = new SqlParameter("@dob", SqlDbType.DateTime);
        param[9].Value = objbll.Dob;

        param[10] = new SqlParameter("@nationality", SqlDbType.NVarChar);
        param[10].Value = objbll.Nationality;

        param[11] = new SqlParameter("@program_id ", SqlDbType.NVarChar);
        param[11].Value = objbll.Program_id;

        param[12] = new SqlParameter("@session_id", SqlDbType.NVarChar);
        param[12].Value = objbll.Session_id;

        param[13] = new SqlParameter("@reg_date ", SqlDbType.DateTime);
        param[13].Value = objbll.Reg_date;

        param[14] = new SqlParameter("@status", SqlDbType.Bit);
        param[14].Value = objbll.Status;

        param[15] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[15].Value = objbll.Createdby;

        param[16] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[16].Value = objbll.Modifiedby;

        param[17] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[17].Value = objbll.Insert_date;

        param[18] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[18].Value = objbll.Update_date;

        param[19] = new SqlParameter("@gender", SqlDbType.NVarChar);
        param[19].Value = objbll.Gender;

        param[20] = new SqlParameter("@username", SqlDbType.NVarChar);
        param[20].Value = objbll.Username;

        param[21] = new SqlParameter("@password ", SqlDbType.NVarChar);
        param[21].Value = objbll.Password;

        param[22] = new SqlParameter("@pic_name", SqlDbType.NVarChar);
        param[22].Value = objbll.Pic_name;

        param[23] = new SqlParameter("@pic_path ", SqlDbType.NVarChar);
        param[23].Value = objbll.Pic_path;

        param[24] = new SqlParameter("@online ", SqlDbType.Bit);
        param[24].Value = objbll.Online;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertstudentinfo", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLStudentInfo> SelectStudentInfo()
    {
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();
        BLLStudentInfo objbll = new BLLStudentInfo();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectstudentinfo");
        while (dr.Read())
        {
            objbll = new BLLStudentInfo();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Father_name = dr["father_name"].ToString();
            objbll.C_address = dr["c_address"].ToString();
            objbll.P_address = dr["p_address"].ToString();
            objbll.Phone = dr["phone"].ToString();
            objbll.Mobile = dr["mobile"].ToString();
            objbll.Email = dr["email"].ToString();
            objbll.Nic = dr["nic"].ToString();
            objbll.Dob = Convert.ToDateTime(dr["dob"].ToString());
            objbll.Nationality = dr["nationality"].ToString();
            objbll.Program_id = dr["program_id"].ToString();
            objbll.Session_id = dr["session_id"].ToString();
            objbll.Reg_date = Convert.ToDateTime(dr["reg_date"].ToString());
            objbll.Status = Convert.ToBoolean(dr["status"].ToString());
            objbll.Createdby = dr["createdby"].ToString();
            objbll.Modifiedby = dr["modifiedby"].ToString();
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objbll.Update_date = Convert.ToDateTime(dr["update_date"].ToString());
            objbll.Gender = dr["gender"].ToString();
            objbll.Pic_name = dr["pic_name"].ToString();
            objbll.Pic_path = dr["pic_path"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLStudentInfo> SelectMaxRollno()
    {
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();
        BLLStudentInfo objbll = new BLLStudentInfo();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectmaxrollno");
        while (dr.Read())
        {
            objbll = new BLLStudentInfo();
            objbll.Rollno = dr["rollno"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLStudentInfo> Selectstunamebyrollno(BLLStudentInfo objbll)
    {
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param.Value = objbll.Rollno;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectstunamebyrollno", param);
        while (dr.Read())
        {
            objbll = new BLLStudentInfo();
            objbll.Name = dr["name"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLStudentInfo> SelectStuLogin(BLLStudentInfo objbll)
    {
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@username", SqlDbType.NVarChar);
        param[0].Value = objbll.Username;

        param[1] = new SqlParameter("@password", SqlDbType.NVarChar);
        param[1].Value = objbll.Password;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectstulogin", param);
        while (dr.Read())
        {
            objbll = new BLLStudentInfo();
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Username = dr["username"].ToString();
            objbll.Password = dr["password"].ToString();
            objbll.Pic_name = dr["pic_name"].ToString();
            objbll.Pic_path = dr["pic_path"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLStudentInfo> Selectstuinfobyrollno(BLLStudentInfo objbll)
    {
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param.Value = objbll.Rollno;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectstudentinfobyrollno", param);
        while (dr.Read())
        {
            objbll = new BLLStudentInfo();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Father_name = dr["father_name"].ToString();
            objbll.C_address = dr["c_address"].ToString();
            objbll.P_address = dr["p_address"].ToString();
            objbll.Phone = dr["phone"].ToString();
            objbll.Mobile = dr["mobile"].ToString();
            objbll.Email = dr["email"].ToString();
            objbll.Nic = dr["nic"].ToString();
            objbll.Dob = Convert.ToDateTime(dr["dob"].ToString());
            objbll.Nationality = dr["nationality"].ToString();
            objbll.Program_id = dr["program_id"].ToString();
            objbll.Session_id = dr["session_id"].ToString();
            objbll.Reg_date = Convert.ToDateTime(dr["reg_date"].ToString());
            objbll.Status = Convert.ToBoolean(dr["status"].ToString());
            objbll.Createdby = dr["createdby"].ToString();
            objbll.Modifiedby = dr["modifiedby"].ToString();
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objbll.Update_date = Convert.ToDateTime(dr["update_date"].ToString());
            objbll.Gender = dr["gender"].ToString();
            objbll.Pic_name = dr["pic_name"].ToString();
            objbll.Pic_path = dr["pic_path"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public int DeleteStudentInfo(BLLStudentInfo objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deletestudent", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLStudentInfo> Selectstudentinfobyid(BLLStudentInfo objbll)
    {
        List<BLLStudentInfo> objlist = new List<BLLStudentInfo>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param.Value = objbll.Rollno;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectstudentinfobyid", param);
        while (dr.Read())
        {
            objbll = new BLLStudentInfo();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Father_name = dr["father_name"].ToString();
            objbll.C_address = dr["c_address"].ToString();
            objbll.P_address = dr["p_address"].ToString();
            objbll.Phone = dr["phone"].ToString();
            objbll.Mobile = dr["mobile"].ToString();
            objbll.Email = dr["email"].ToString();
            objbll.Nic = dr["nic"].ToString();
            objbll.Dob = Convert.ToDateTime(dr["dob"].ToString());
            objbll.Nationality = dr["nationality"].ToString();
            objbll.Program_id = dr["program_id"].ToString();
            objbll.Session_id = dr["session_id"].ToString();
            objbll.Reg_date = Convert.ToDateTime(dr["reg_date"].ToString());
            objbll.Status = Convert.ToBoolean(dr["status"].ToString());
            objbll.Createdby = dr["createdby"].ToString();
            objbll.Modifiedby = dr["modifiedby"].ToString();
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objbll.Update_date = Convert.ToDateTime(dr["update_date"].ToString());
            objbll.Gender = dr["gender"].ToString();
            objbll.Pic_name = dr["pic_name"].ToString();
            objbll.Pic_path = dr["pic_path"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public int UpdateStudentInfo(BLLStudentInfo objbll)
    {
        SqlParameter[] param = new SqlParameter[16];

        param[0] = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param[0].Value = objbll.Rollno;

        param[1] = new SqlParameter("@name", SqlDbType.NVarChar);
        param[1].Value = objbll.Name;

        param[2] = new SqlParameter("@father_name", SqlDbType.NVarChar);
        param[2].Value = objbll.Father_name;

        param[3] = new SqlParameter("@c_address", SqlDbType.NVarChar);
        param[3].Value = objbll.C_address;

        param[4] = new SqlParameter("@p_address", SqlDbType.NVarChar);
        param[4].Value = objbll.P_address;

        param[5] = new SqlParameter("@phone", SqlDbType.NVarChar);
        param[5].Value = objbll.Phone;

        param[6] = new SqlParameter("@mobile", SqlDbType.NVarChar);
        param[6].Value = objbll.Mobile;

        param[7] = new SqlParameter("@email", SqlDbType.NVarChar);
        param[7].Value = objbll.Email;

        param[8] = new SqlParameter("@nic", SqlDbType.NVarChar);
        param[8].Value = objbll.Nic;

        param[9] = new SqlParameter("@dob", SqlDbType.DateTime);
        param[9].Value = objbll.Dob;

        param[10] = new SqlParameter("@nationality", SqlDbType.NVarChar);
        param[10].Value = objbll.Nationality;

        param[11] = new SqlParameter("@program_id ", SqlDbType.NVarChar);
        param[11].Value = objbll.Program_id;

        param[12] = new SqlParameter("@session_id", SqlDbType.NVarChar);
        param[12].Value = objbll.Session_id;

        param[13] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[13].Value = objbll.Modifiedby;

        param[14] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[14].Value = objbll.Update_date;

        param[15] = new SqlParameter("@gender", SqlDbType.NVarChar);
        param[15].Value = objbll.Gender;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updatestudentinfo", param);
        objcon.CloseConnection();
        return a;
    }
}