using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLSession
/// </summary>
public class BLLSession
{
	public BLLSession()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string session_id;

    public string Session_id
    {
        get { return session_id; }
        set { session_id = value; }
    }
    private string description;

    public string Description
    {
        get { return description; }
        set { description = value; }
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
        session_id = string.Empty;
        description = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
    }

    public int InsertSession(BLLSession objbll)
    {
        DALSession objdal = new DALSession();
        return objdal.InsertSession(objbll);
    }

    public List<BLLSession> SelectSession()
    {
        DALSession objdal = new DALSession();
        return objdal.SelectSession();
    }

    public int DeleteSession(BLLSession objbll)
    {
        DALSession objdal = new DALSession();
        return objdal.DeleteSession(objbll);
    }

    public List<BLLSession> SelectSessionbyid(BLLSession objbll)
    {
        DALSession objdal = new DALSession();
        return objdal.SelectSessionbyid(objbll);
    }

    public int UpdateSession(BLLSession objbll)
    {
        DALSession objdal = new DALSession();
        return objdal.UpdateSession(objbll);
    }
}