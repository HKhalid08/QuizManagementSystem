using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLStudentInfo
/// </summary>
public class BLLStudentInfo
{
	public BLLStudentInfo()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string rollno;

    public string Rollno
    {
        get { return rollno; }
        set { rollno = value; }
    }
    private string name;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private string father_name;

    public string Father_name
    {
        get { return father_name; }
        set { father_name = value; }
    }
    private string c_address;

    public string C_address
    {
        get { return c_address; }
        set { c_address = value; }
    }
    private string p_address;

    public string P_address
    {
        get { return p_address; }
        set { p_address = value; }
    }
    private string phone;

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    private string mobile;

    public string Mobile
    {
        get { return mobile; }
        set { mobile = value; }
    }
    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    private string nic;

    public string Nic
    {
        get { return nic; }
        set { nic = value; }
    }
    private DateTime dob;

    public DateTime Dob
    {
        get { return dob; }
        set { dob = value; }
    }
    private string nationality;

    public string Nationality
    {
        get { return nationality; }
        set { nationality = value; }
    }
    private string program_id;

    public string Program_id
    {
        get { return program_id; }
        set { program_id = value; }
    }
    private string session_id;

    public string Session_id
    {
        get { return session_id; }
        set { session_id = value; }
    }
    private DateTime reg_date;

    public DateTime Reg_date
    {
        get { return reg_date; }
        set { reg_date = value; }
    }
    private bool status;

    public bool Status
    {
        get { return status; }
        set { status = value; }
    }
    private string createdby;

    public string Createdby
    {
        get { return createdby; }
        set { createdby = value; }
    }
    private string modifiedby;

    public string Modifiedby
    {
        get { return modifiedby; }
        set { modifiedby = value; }
    }
    private DateTime insert_date;

    public DateTime Insert_date
    {
        get { return insert_date; }
        set { insert_date = value; }
    }
    private DateTime update_date;

    public DateTime Update_date
    {
        get { return update_date; }
        set { update_date = value; }
    }
    private string gender;

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    private string username;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }
    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }

    private string pic_name;

    public string Pic_name
    {
        get { return pic_name; }
        set { pic_name = value; }
    }
    private string pic_path;

    public string Pic_path
    {
        get { return pic_path; }
        set { pic_path = value; }
    }

    private bool online;

    public bool Online
    {
        get { return online; }
        set { online = value; }
    }


    public void Initialize()
    {
        id = 0;
        rollno = string.Empty;
        name = string.Empty;
        father_name = string.Empty;
        c_address = string.Empty;
        p_address = string.Empty;
        phone = string.Empty;
        mobile = string.Empty;
        email = string.Empty;
        nic = string.Empty;
        dob = System.DateTime.Now.Date;
        nationality = string.Empty;
        program_id = string.Empty;
        session_id = string.Empty;
        reg_date = System.DateTime.Now.Date;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        gender = string.Empty;
        username = string.Empty;
        password = string.Empty;
        pic_name = string.Empty;
        pic_path = string.Empty;
        online = false;
    }

    public int InsertStudentInfo(BLLStudentInfo objbll)
    {
        DALStudentInfo objdal = new DALStudentInfo();
        return objdal.InsertStudentInfo(objbll);
    }

    public List<BLLStudentInfo> SelectStudentInfo()
    {
        DALStudentInfo objdal = new DALStudentInfo();
        return objdal.SelectStudentInfo();
    }

    public List<BLLStudentInfo> SelectMaxRollno()
    {
        DALStudentInfo objdal = new DALStudentInfo();
         return objdal.SelectMaxRollno();
    }

    public List<BLLStudentInfo> Selectstunamebyrollno(BLLStudentInfo objbll)
    {
        DALStudentInfo objdal = new DALStudentInfo();
        return objdal.Selectstunamebyrollno(objbll);
    }

    public List<BLLStudentInfo> SelectStuLogin(BLLStudentInfo objbll)
    {
        DALStudentInfo objdal = new DALStudentInfo();
        return objdal.SelectStuLogin(objbll);
    }

    public List<BLLStudentInfo> Selectstuinfobyrollno(BLLStudentInfo objbll)
    {
        DALStudentInfo objdal = new DALStudentInfo();
        return objdal.Selectstuinfobyrollno(objbll);
    }

    public int DeleteStudentInfo(BLLStudentInfo objbll)
    {
        DALStudentInfo objdal = new DALStudentInfo();
        return objdal.DeleteStudentInfo(objbll);
    }

    public List<BLLStudentInfo> Selectstudentinfobyid(BLLStudentInfo objbll)
    {
        DALStudentInfo objdal = new DALStudentInfo();
        return objdal.Selectstudentinfobyid(objbll);
    }

    public int UpdateStudentInfo(BLLStudentInfo objbll)
    {
        DALStudentInfo objdal = new DALStudentInfo();
        return objdal.UpdateStudentInfo(objbll);
    }
}