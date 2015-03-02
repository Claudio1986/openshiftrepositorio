using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace CRMAPP1.EmployeeModule
{
	/// <summary>
	/// Summary description for CustQuery.
	/// </summary>
	public class CustQuery : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.DataGrid DataGrid1;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;

		public SqlConnection con=new SqlConnection ("server=.;database=crm;uid=sa;pwd=;");

		
		private void Page_Load(object sender, System.EventArgs e)
		{
		{
			SqlDataAdapter apt=new SqlDataAdapter("select * from crm_CustQuery",con);
			DataSet ds=new DataSet();
			apt.Fill(ds);
			DataGrid1.DataSource=ds;
			DataGrid1.DataBind();
				
		}
		}

		#region Web Form Designer generated code
		override protected void OnInit(EventArgs e)
		{
			//
			// CODEGEN: This call is required by the ASP.NET Web Form Designer.
			//
			InitializeComponent();
			base.OnInit(e);
		}
		
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{    
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.DataGrid1.SelectedIndexChanged += new System.EventHandler(this.DataGrid1_SelectedIndexChanged);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("..//EmployeeModule/EmpMain.aspx");
		}

		private void DataGrid1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
