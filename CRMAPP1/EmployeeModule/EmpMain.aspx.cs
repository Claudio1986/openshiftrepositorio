using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace CRMAPP1.EmployeeModule
{
	/// <summary>
	/// Summary description for EmpMain.
	/// </summary>
	public class EmpMain : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.LinkButton LinkButton2;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Panel Panel2;
		protected System.Web.UI.WebControls.Image Image1;
		protected System.Web.UI.WebControls.LinkButton LinkButton3;
	
		private void Page_Load(object sender, System.EventArgs e)
		{
			// Put user code to initialize the page here
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
			this.LinkButton3.Click += new System.EventHandler(this.LinkButton3_Click);
			this.LinkButton2.Click += new System.EventHandler(this.LinkButton2_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton2_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("..//EmployeeModule/EmpPayRoll.aspx");
		}

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
		Response.Redirect("..//EmployeeModule/EmpPDetail.aspx");
		}

		private void LinkButton3_Click(object sender, System.EventArgs e)
		{
		Response.Redirect("..//EmployeeModule/CustQuery.aspx");
		}
	}
}
