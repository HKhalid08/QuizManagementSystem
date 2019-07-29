using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BLLUserRights
/// </summary>
public class BLLUserRights
{
	public BLLUserRights()
	{
		Initailize();
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
        private bool status;    
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        private string app_detail;
        public string App_detail
        {
            get { return app_detail; }
            set { app_detail = value; }
        }

        private bool  rights;
        public bool Rights
        {
            get { return rights; }
            set { rights = value; }
        }
        private bool r_add;

        public bool R_add
        {
            get { return r_add; }
            set { r_add = value; }
        }
        private bool r_visible;

        public bool R_visible
        {
            get { return r_visible; }
            set { r_visible = value; }
        }
        private bool r_edit;

        public bool R_edit
        {
            get { return r_edit; }
            set { r_edit = value; }
        }
        private bool r_delete;

        public bool R_delete
        {
            get { return r_delete; }
            set { r_delete = value; }
        }
        private string rrights;

        public string Rrights
        {
            get { return rrights; }
            set { rrights = value; }
        }
        private string rr_add;

        public string Rr_add
        {
            get { return rr_add; }
            set { rr_add = value; }
        }
        private string rr_visible;

        public string Rr_visible
        {
            get { return rr_visible; }
            set { rr_visible = value; }
        }
        private string rr_edit;

        public string Rr_edit
        {
            get { return rr_edit; }
            set { rr_edit = value; }
        }
        private string rr_delete;

        public string Rr_delete
        {
            get { return rr_delete; }
            set { rr_delete = value; }
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

        public void Initailize()
        {
            id = 0;
            emp_code = string.Empty;
            name = string.Empty;
            app_detail = string.Empty;
            rights = false;
            r_add = false;
            r_visible = false;
            r_edit = false;
            r_delete = false;
            rrights = string.Empty;
            rr_add = string.Empty;
            rr_visible = string.Empty;
            rr_edit = string.Empty;
            rr_delete = string.Empty;
            status = true;
            insert_date = System.DateTime.Now;
            update_date = System.DateTime.Now;
        }

        public List<BLLUserRights> SelectApplicationDetail()
        {
            DALUserRights objdal = new DALUserRights();
            return objdal.SelectApplicationDetail();
        }

        public int Insertuserrights(BLLUserRights objbll)
        {
            DALUserRights objdal = new DALUserRights();
            return objdal.Insertuserrights(objbll);
        }

        public List<BLLUserRights> Selectuserrights(BLLUserRights objbll)
        {
            DALUserRights objdal = new DALUserRights();
            return objdal.Selectuserrights(objbll);
        }
}