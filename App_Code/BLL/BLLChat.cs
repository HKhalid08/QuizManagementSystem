using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLChat
/// </summary>
public class BLLChat
{
	public BLLChat()
	{
        Initialize();
	}

    private int id;

    public int Id
    {
        get { return id; }
        set { id = value; }
    }
    private string message;

    public string Message
    {
        get { return message; }
        set { message = value; }
    }
    private string message_to;

    public string Message_to
    {
        get { return message_to; }
        set { message_to = value; }
    }
    private string message_from;

    public string Message_from
    {
        get { return message_from; }
        set { message_from = value; }
    }
    private bool message_status;

    public bool Message_status
    {
        get { return message_status; }
        set { message_status = value; }
    }
    private DateTime insert_date;

    public DateTime Insert_date
    {
        get { return insert_date; }
        set { insert_date = value; }
    }

    public void Initialize()
    {
        id = 0;
        message = string.Empty;
        message_to = string.Empty;
        message_from = string.Empty;
        message_status = true;
        insert_date = System.DateTime.Now;
    }

    public int InsertChat(BLLChat objbll)
    {
        DALChat objdal = new DALChat();
        return objdal.InsertChat(objbll);
    }

    public List<BLLChat> SelectMessage(BLLChat objbll)
    {
        DALChat objdal = new DALChat();
        return objdal.SelectMessage(objbll);
    }
}