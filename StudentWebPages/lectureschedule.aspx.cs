using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

public partial class Web_Pages_PortoQuiz_Home : System.Web.UI.Page
{
    private string user;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty((string)Session["student"]))
        {
            user = (string)Session["student"];
        }
        else
        {
            Response.Redirect("../Login/Login.aspx");
        }

        lblAdmin_USername.Text = (string)Session["name"];
        lblAccountUsername.Text = (string)Session["name"];
        lblDesignation.Text = (string)Session["des_id"];
        imgUser.ImageUrl = (string)Session["pic_name"];
        lblSignIn_Time.Text = (string)Session["signin"];

        LoadReport();
    }

    public void LoadReport()
    {
        string connectionString = ConfigurationSettings.AppSettings["Connection"];
        SqlConnection con = new SqlConnection(connectionString);

        con.Open();
        DataTable dt;
        SqlCommand comm = new SqlCommand();
        comm.Connection = con;
        comm.CommandText = "sp_selectschedulebyrollno";
        comm.CommandType = CommandType.StoredProcedure;

        SqlParameter param = new SqlParameter("@rollno", SqlDbType.NVarChar);
        param.Value = user;
        comm.Parameters.Add(param);

        using (SqlDataAdapter da = new SqlDataAdapter(comm))
        {
            dt = new DataTable("tbl");
            da.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                ReportDocument objdocument = new ReportDocument();
                string reportPath = Server.MapPath(".\\lectureschedule1.rpt");
                objdocument.Load(reportPath);
                objdocument.SetDataSource(dt);
                CrystalReportViewer1.ReportSource = objdocument;
                con.Close();
            }
        }
    }
    protected void linkProfile_Click(object sender, EventArgs e)
    {
        Response.Redirect("profile.aspx");
    }
    protected void linkChangePassword_Click(object sender, EventArgs e)
    {
        Session["username"] = user;
        Response.Redirect("../Login/ChangePasword.aspx");
    }
    protected void linkSignOut_Click(object sender, EventArgs e)
    {
        try
        {
            Session["teacher"] = null;
            Session.Abandon();
            Response.Redirect("../Login/Login.aspx");
        }
        catch
        {

        }
    }
}