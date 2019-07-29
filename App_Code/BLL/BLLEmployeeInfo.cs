using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLEmployeeInfo
/// </summary>
public class BLLEmployeeInfo
{
	public BLLEmployeeInfo()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string emp_code;

    public string Emp_code
    {
        get { return emp_code; }
        set { emp_code = value; }
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
    private string gender;

    public string Gender
    {
        get { return gender; }
        set { gender = value; }
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
    private string dep_id;

    public string Dep_id
    {
        get { return dep_id; }
        set { dep_id = value; }
    }
    private string des_id;

    public string Des_id
    {
        get { return des_id; }
        set { des_id = value; }
    }
    private string qualification;

    public string Qualification
    {
        get { return qualification; }
        set { qualification = value; }
    }
    private string specialization;

    public string Specialization
    {
        get { return specialization; }
        set { specialization = value; }
    }
    private string about;

    public string About
    {
        get { return about; }
        set { about = value; }
    }
    private DateTime joining_date;

    public DateTime Joining_date
    {
        get { return joining_date; }
        set { joining_date = value; }
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
        emp_code = string.Empty;
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
        gender = string.Empty;
        dep_id = string.Empty;
        des_id = string.Empty;
        qualification = string.Empty;
        specialization = string.Empty;
        about = string.Empty;
        joining_date = System.DateTime.Now.Date;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        username = string.Empty;
        password = string.Empty;
        pic_name = string.Empty;
        pic_path = string.Empty;
        online = false;
    }

    public int InsertEmployeeInfo(BLLEmployeeInfo objbll)
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.InsertEmployeeInfo(objbll);
    }

    public List<BLLEmployeeInfo> SelectEmployeeInfo()
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.SelectEmployeeInfo();
    }

    public List<BLLEmployeeInfo> SelectMaxEmpCode()
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.SelectMaxEmpCode();
    }

    public List<BLLEmployeeInfo> SelectEmpnamebycode(BLLEmployeeInfo objbll)
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.SelectEmpnamebycode(objbll);
    }

    public List<BLLEmployeeInfo> SelectEmpLogin(BLLEmployeeInfo objbll)
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.SelectEmpLogin(objbll);
    }

    public List<BLLEmployeeInfo> SelectEmpinfobycode(BLLEmployeeInfo objbll)
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.SelectEmpinfobycode(objbll);
    }

    public List<BLLEmployeeInfo> SelectEmployeeforChat(BLLEmployeeInfo objbll)
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.SelectEmployeeforChat(objbll);
    }

    public List<BLLEmployeeInfo> SelectEmployeeAdmincode()
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.SelectEmployeeAdmincode();
    }

    public int DeleteEmployeeInfo(BLLEmployeeInfo objbll)
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.DeleteEmployeeInfo(objbll);
    }

    public List<BLLEmployeeInfo> SelectEmployeeInfobyid(BLLEmployeeInfo objbll)
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.SelectEmployeeInfobyid(objbll);
    }

    public int UpdateEmployeeInfo(BLLEmployeeInfo objbll)
    {
        DALEmployeeInfo objdal = new DALEmployeeInfo();
        return objdal.UpdateEmployeeInfo(objbll);
    }
}