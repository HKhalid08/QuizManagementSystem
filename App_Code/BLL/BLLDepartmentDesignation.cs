using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLDepartmentDesignation
/// </summary>
public class BLLDepartmentDesignation
{
	public BLLDepartmentDesignation()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string dep_id;

    public string Dep_id
    {
        get { return dep_id; }
        set { dep_id = value; }
    }
    private string dep_name;

    public string Dep_name
    {
        get { return dep_name; }
        set { dep_name = value; }
    }
    private string des_id;

    public string Des_id
    {
        get { return des_id; }
        set { des_id = value; }
    }
    private string des_name;

    public string Des_name
    {
        get { return des_name; }
        set { des_name = value; }
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

    public void Initialize()
    {
        id = 0;
        dep_id = string.Empty;
        dep_name = string.Empty;
        des_id = string.Empty;
        des_name = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
    }

    public int InsertDepartment(BLLDepartmentDesignation objbll)
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.InsertDepartment(objbll);
    }

    public List<BLLDepartmentDesignation> SelectDepartment()
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.SelectDepartment();
    }

    public int InsertDesignation(BLLDepartmentDesignation objbll)
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.InsertDesignation(objbll);
    }

    public List<BLLDepartmentDesignation> SelectDesignation()
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.SelectDesignation();
    }

    public int DeleteDepartment(BLLDepartmentDesignation objbll)
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.DeleteDepartment(objbll);
    }

    public int DeleteDesignation(BLLDepartmentDesignation objbll)
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.DeleteDesignation(objbll);
    }

    public List<BLLDepartmentDesignation> SelectDepartmentbyid(BLLDepartmentDesignation objbll)
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.SelectDepartmentbyid(objbll);
    }

    public List<BLLDepartmentDesignation> SelectDesignationbyid(BLLDepartmentDesignation objbll)
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.SelectDesignationbyid(objbll);
    }

    public int UpdateDepartment(BLLDepartmentDesignation objbll)
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.UpdateDepartment(objbll);
    }

    public int UpdateDesignation(BLLDepartmentDesignation objbll)
    {
        DALDepartmentDesignation objdal = new DALDepartmentDesignation();
        return objdal.UpdateDesignation(objbll);
    }
}