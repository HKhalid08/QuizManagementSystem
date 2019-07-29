using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLProgram
/// </summary>
public class BLLProgram
{
	public BLLProgram()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string program_id;

    public string Program_id
    {
        get { return program_id; }
        set { program_id = value; }
    }
    private string program_name;

    public string Program_name
    {
        get { return program_name; }
        set { program_name = value; }
    }
    private string credit_hours;

    public string Credit_hours
    {
        get { return credit_hours; }
        set { credit_hours = value; }
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
    private string system_ip;

    public string System_ip
    {
        get { return system_ip; }
        set { system_ip = value; }
    }

    public void Initialize()
    {
        id = 0;
        program_id = string.Empty;
        program_name = string.Empty;
        credit_hours = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
        system_ip = string.Empty;
    }

    public int InsertProgram(BLLProgram objbll)
    {
        DALProgram objdal = new DALProgram();
        return objdal.InsertProgram(objbll);
    }

    public List<BLLProgram> SelectProgram()
    {
        DALProgram objdal = new DALProgram();
        return objdal.SelectProgram();
    }

    public int DeleteProgram(BLLProgram objbll)
    {
        DALProgram objdal = new DALProgram();
        return objdal.DeleteProgram(objbll);
    }

    public List<BLLProgram> SelectProgrambyid(BLLProgram objbll)
    {
        DALProgram objdal = new DALProgram();
        return objdal.SelectProgrambyid(objbll);
    }

    public int UpdateProgram(BLLProgram objbll)
    {
        DALProgram objdal = new DALProgram();
        return objdal.UpdateProgram(objbll);
    }
}