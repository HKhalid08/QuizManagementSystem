using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALEmployeeInfo
/// </summary>
public class DALEmployeeInfo
{
	public DALEmployeeInfo()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertEmployeeInfo(BLLEmployeeInfo objbll)
    {
        SqlParameter[] param = new SqlParameter[28];

        param[0] = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Emp_code;

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

        param[11] = new SqlParameter("@dep_id ", SqlDbType.NVarChar);
        param[11].Value = objbll.Dep_id;

        param[12] = new SqlParameter("@des_id", SqlDbType.NVarChar);
        param[12].Value = objbll.Des_id;

        param[13] = new SqlParameter("@joining_date ", SqlDbType.DateTime);
        param[13].Value = objbll.Joining_date;

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

        param[24] = new SqlParameter("@qualification ", SqlDbType.NVarChar);
        param[24].Value = objbll.Qualification;

        param[25] = new SqlParameter("@specialization", SqlDbType.NVarChar);
        param[25].Value = objbll.Specialization;

        param[26] = new SqlParameter("@about ", SqlDbType.NVarChar);
        param[26].Value = objbll.About;

        param[27] = new SqlParameter("@online ", SqlDbType.NVarChar);
        param[27].Value = objbll.Online;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertemployeeinfo", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLEmployeeInfo> SelectEmployeeInfo()
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectemployeeinfo");
        while (dr.Read())
        {
            objbll = new BLLEmployeeInfo();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Emp_code = dr["emp_code"].ToString();
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
            objbll.Dep_id = dr["dep_id"].ToString();
            objbll.Des_id = dr["des_id"].ToString();
            objbll.Qualification = dr["qualification"].ToString();
            objbll.Specialization = dr["specialization"].ToString();
            objbll.About = dr["about"].ToString();
            objbll.Joining_date = Convert.ToDateTime(dr["joining_date"].ToString());
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

    public List<BLLEmployeeInfo> SelectEmployeeAdmincode()
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectemployeeadmincode");
        while (dr.Read())
        {
            objbll = new BLLEmployeeInfo();
            objbll.Emp_code = dr["emp_code"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLEmployeeInfo> SelectMaxEmpCode()
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();
        BLLEmployeeInfo objbll = new BLLEmployeeInfo();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectmaxempcode");
        while (dr.Read())
        {
            objbll = new BLLEmployeeInfo();
            objbll.Emp_code = dr["emp_code"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLEmployeeInfo> SelectEmpnamebycode(BLLEmployeeInfo objbll)
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param.Value = objbll.Emp_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectempnamebycode",param);
        while (dr.Read())
        {
            objbll = new BLLEmployeeInfo();
            objbll.Name = dr["name"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLEmployeeInfo> SelectEmpLogin(BLLEmployeeInfo objbll)
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();

        SqlParameter[] param = new SqlParameter[2];

        param[0] = new SqlParameter("@username", SqlDbType.NVarChar);
        param[0].Value = objbll.Username;

        param[1] = new SqlParameter("@password", SqlDbType.NVarChar);
        param[1].Value = objbll.Password;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectByMultimoreprogram("sp_selectEmplogin", param);
        while (dr.Read())
        {
            objbll = new BLLEmployeeInfo();
            objbll.Emp_code = dr["emp_code"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Dep_id = dr["dep_name"].ToString();
            objbll.Des_id = dr["des_name"].ToString();
            objbll.Pic_name = dr["pic_name"].ToString();
            objbll.Pic_path = dr["pic_path"].ToString();
            objbll.Username = dr["username"].ToString();
            objbll.Password = dr["password"].ToString();
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLEmployeeInfo> SelectEmpinfobycode(BLLEmployeeInfo objbll)
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param.Value = objbll.Emp_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectempinfobycode", param);
        while (dr.Read())
        {
            objbll = new BLLEmployeeInfo();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Emp_code = dr["emp_code"].ToString();
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
            objbll.Dep_id = dr["dep_id"].ToString();
            objbll.Des_id = dr["des_id"].ToString();
            objbll.Qualification = dr["qualification"].ToString();
            objbll.Specialization = dr["specialization"].ToString();
            objbll.About = dr["about"].ToString();
            objbll.Joining_date = Convert.ToDateTime(dr["joining_date"].ToString());
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

    public List<BLLEmployeeInfo> SelectEmployeeforChat(BLLEmployeeInfo objbll)
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param.Value = objbll.Emp_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectempforchat", param);
        while (dr.Read())
        {
            objbll = new BLLEmployeeInfo();
            objbll.Emp_code = dr["emp_code"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Pic_name = dr["pic_name"].ToString();
            objbll.Online = Convert.ToBoolean(dr["online"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public int DeleteEmployeeInfo(BLLEmployeeInfo objbll)
    {
        SqlParameter[] param = new SqlParameter[1];

        param[0] = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Emp_code;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_deleteemployee", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLEmployeeInfo> SelectEmployeeInfobyid(BLLEmployeeInfo objbll)
    {
        List<BLLEmployeeInfo> objlist = new List<BLLEmployeeInfo>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param.Value = objbll.Emp_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectemployeeinfobyid", param);
        while (dr.Read())
        {
            objbll = new BLLEmployeeInfo();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Emp_code = dr["emp_code"].ToString();
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
            objbll.Dep_id = dr["dep_id"].ToString();
            objbll.Des_id = dr["des_id"].ToString();
            objbll.Qualification = dr["qualification"].ToString();
            objbll.Specialization = dr["specialization"].ToString();
            objbll.About = dr["about"].ToString();
            objbll.Joining_date = Convert.ToDateTime(dr["joining_date"].ToString());
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

    public int UpdateEmployeeInfo(BLLEmployeeInfo objbll)
    {
        SqlParameter[] param = new SqlParameter[20];

        param[0] = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param[0].Value = objbll.Emp_code;

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

        param[11] = new SqlParameter("@dep_id ", SqlDbType.NVarChar);
        param[11].Value = objbll.Dep_id;

        param[12] = new SqlParameter("@des_id", SqlDbType.NVarChar);
        param[12].Value = objbll.Des_id;

        param[13] = new SqlParameter("@joining_date ", SqlDbType.DateTime);
        param[13].Value = objbll.Joining_date;

        param[14] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[14].Value = objbll.Modifiedby;

        param[15] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[15].Value = objbll.Update_date;

        param[16] = new SqlParameter("@gender", SqlDbType.NVarChar);
        param[16].Value = objbll.Gender;

        param[17] = new SqlParameter("@qualification ", SqlDbType.NVarChar);
        param[17].Value = objbll.Qualification;

        param[18] = new SqlParameter("@specialization", SqlDbType.NVarChar);
        param[18].Value = objbll.Specialization;

        param[19] = new SqlParameter("@about ", SqlDbType.NVarChar);
        param[19].Value = objbll.About;

        objcon.OpenConnection();
        int a = objcon.sqlcmdUpdateById("sp_updateemployeeinfo", param);
        objcon.CloseConnection();
        return a;
    }
}