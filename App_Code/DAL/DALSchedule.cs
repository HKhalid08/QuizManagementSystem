using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using MISC;

/// <summary>
/// Summary description for DALSchedule
/// </summary>
public class DALSchedule
{
	public DALSchedule()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    ConnectionClass objcon = new ConnectionClass();

    public int InsertSchedule(BLLSchedule objbll)
    {
        SqlParameter[] param = new SqlParameter[13];

        param[0] = new SqlParameter("@session_id", SqlDbType.NVarChar);
        param[0].Value = objbll.Session_id;

        param[1] = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param[1].Value = objbll.Emp_code;

        param[2] = new SqlParameter("@name", SqlDbType.NVarChar);
        param[2].Value = objbll.Name;

        param[3] = new SqlParameter("@course_title", SqlDbType.NVarChar);
        param[3].Value = objbll.Course_title;

        param[4] = new SqlParameter("@course_code", SqlDbType.NVarChar);
        param[4].Value = objbll.Course_code;

        param[5] = new SqlParameter("@day", SqlDbType.NVarChar);
        param[5].Value = objbll.Day;

        param[6] = new SqlParameter("@time_from", SqlDbType.NVarChar);
        param[6].Value = objbll.Time_from;

        param[7] = new SqlParameter("@time_to", SqlDbType.NVarChar);
        param[7].Value = objbll.Time_to;

        param[8] = new SqlParameter("@status", SqlDbType.Bit);
        param[8].Value = objbll.Status;

        param[9] = new SqlParameter("@createdby", SqlDbType.NVarChar);
        param[9].Value = objbll.Createdby;

        param[10] = new SqlParameter("@modifiedby ", SqlDbType.NVarChar);
        param[10].Value = objbll.Modifiedby;

        param[11] = new SqlParameter("@Insert_Date", SqlDbType.DateTime);
        param[11].Value = objbll.Insert_date;

        param[12] = new SqlParameter("@Update_Date", SqlDbType.DateTime);
        param[12].Value = objbll.Update_date;

        objcon.OpenConnection();
        int a = objcon.sqlcmdInsert("sp_insertschedule", param);
        objcon.CloseConnection();
        return a;
    }

    public List<BLLSchedule> SelectSchedule()
    {
        List<BLLSchedule> objlist = new List<BLLSchedule>();
        BLLSchedule objbll = new BLLSchedule();

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectAll("sp_selectschedule");
        while (dr.Read())
        {
            objbll = new BLLSchedule();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Session_id = dr["session"].ToString();
            objbll.Emp_code = dr["emp_code"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Day = dr["day"].ToString();
            objbll.Time_from = dr["time_from"].ToString();
            objbll.Time_to = dr["time_to"].ToString();
            objbll.Status = Convert.ToBoolean(dr["status"].ToString());
            objbll.Createdby = dr["createdby"].ToString();
            objbll.Modifiedby = dr["modifiedby"].ToString();
            objbll.Insert_date = Convert.ToDateTime(dr["insert_date"].ToString());
            objbll.Update_date = Convert.ToDateTime(dr["update_date"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLSchedule> Selectschedulebyempcode(BLLSchedule objbll)
    {
        List<BLLSchedule> objlist = new List<BLLSchedule>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@emp_code", SqlDbType.NVarChar);
        param.Value = objbll.Emp_code;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectschedulebyempcode", param);
        while (dr.Read())
        {
            objbll = new BLLSchedule();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Session_id = dr["session_id"].ToString();
            objbll.Emp_code = dr["emp_code"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Day = dr["day"].ToString();
            objbll.Time_from = dr["time_from"].ToString();
            objbll.Time_to = dr["time_to"].ToString();
            objbll.Status = Convert.ToBoolean(dr["status"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }

    public List<BLLSchedule> Selectschedulebyrollno(BLLSchedule objbll)
    {
        List<BLLSchedule> objlist = new List<BLLSchedule>();

        SqlParameter param = new SqlParameter();

        param = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param.Value = objbll.Rollno;

        SqlDataReader dr;
        objcon.OpenConnection();
        dr = objcon.sqlcmdSelectById("sp_selectschedulebyrollno", param);
        while (dr.Read())
        {
            objbll = new BLLSchedule();
            objbll.Id = Convert.ToInt32(dr["id"].ToString());
            objbll.Session_id = dr["session_id"].ToString();
            objbll.Rollno = dr["rollno"].ToString();
            objbll.Name = dr["name"].ToString();
            objbll.Course_title = dr["course_title"].ToString();
            objbll.Course_code = dr["course_code"].ToString();
            objbll.Day = dr["day"].ToString();
            objbll.Time_from = dr["time_from"].ToString();
            objbll.Time_to = dr["time_to"].ToString();
            objbll.Status = Convert.ToBoolean(dr["status"].ToString());
            objlist.Add(objbll);
        }
        objcon.CloseConnection();
        return objlist;
    }
}