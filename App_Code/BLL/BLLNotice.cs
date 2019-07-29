using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLNotice
/// </summary>
public class BLLNotice
{
	public BLLNotice()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string notice_id;

    public string Notice_id
    {
        get { return notice_id; }
        set { notice_id = value; }
    }
    private string notification_id;

    public string Notification_id
    {
        get { return notification_id; }
        set { notification_id = value; }
    }
    private string title;

    public string Title
    {
        get { return title; }
        set { title = value; }
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
        notice_id = string.Empty;
        notification_id = string.Empty;
        title = string.Empty;
        description = string.Empty;
        status = true;
        createdby = string.Empty;
        modifiedby = string.Empty;
        insert_date = System.DateTime.Now;
        update_date = System.DateTime.Now;
    }

    public int InsertNotice(BLLNotice objbll)
    {
        DALNotice objdal = new DALNotice();
        return objdal.InsertNotice(objbll);
    }

    public int InsertNotification(BLLNotice objbll)
    {
        DALNotice objdal = new DALNotice();
        return objdal.InsertNotification(objbll);
    }

    public List<BLLNotice> SelectNotice()
    {
        DALNotice objdal = new DALNotice();
        return objdal.SelectNotice();
    }

    public List<BLLNotice> SelectNotification()
    {
        DALNotice objdal = new DALNotice();
        return objdal.SelectNotification();
    }

    public List<BLLNotice> SelectNoticebyid(BLLNotice objbll)
    {
        DALNotice objdal = new DALNotice();
        return objdal.SelectNoticebyid(objbll);
    }

    public int UpdateNotice(BLLNotice objbll)
    {
        DALNotice objdal = new DALNotice();
        return objdal.UpdateNotice(objbll);
    }
    public List<BLLNotice> SelectNotificationbyid(BLLNotice objbll)
    {
        DALNotice objdal = new DALNotice();
        return objdal.SelectNotificationbyid(objbll);
    }

    public int UpdateNotification(BLLNotice objbll)
    {
        DALNotice objdal = new DALNotice();
        return objdal.UpdateNotification(objbll);
    }

    public int DeleteNotice(BLLNotice objbll)
    {
        DALNotice objdal = new DALNotice();
        return objdal.DeleteNotice(objbll);
    }

    public int DeleteNotification(BLLNotice objbll)
    {
        DALNotice objdal = new DALNotice();
        return objdal.DeleteNotification(objbll);
    }
}