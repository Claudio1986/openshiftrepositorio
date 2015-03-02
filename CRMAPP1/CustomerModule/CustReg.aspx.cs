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

namespace CRMAPP1.CustomerModule
{
	/// <summary>
	/// Summary description for CustReg.
	/// </summary>
	public class CustReg : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label celllbl;
		protected System.Web.UI.WebControls.Label landlbl;
		protected System.Web.UI.WebControls.Label addrlbl;
		protected System.Web.UI.WebControls.Label agelbl;
		protected System.Web.UI.WebControls.Label sexlbl;
		protected System.Web.UI.WebControls.Label namelbl;
		protected System.Web.UI.WebControls.Label Label10;
		protected System.Web.UI.WebControls.Button registerbtn;
		protected System.Web.UI.WebControls.Label Label12;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator3;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator4;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator6;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator2;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator7;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator8;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		
		
		public SqlConnection con=new SqlConnection ("server=.;database=crm;uid=sa;pwd=;");
		protected System.Web.UI.WebControls.TextBox TextBox3;
		protected System.Web.UI.WebControls.TextBox TextBox4;
		protected System.Web.UI.WebControls.TextBox TextBox5;
		protected System.Web.UI.WebControls.TextBox TextBox7;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox TextBox6;
		protected System.Web.UI.WebControls.RequiredFieldValidator RequiredFieldValidator10;
		protected System.Web.UI.WebControls.Panel Panel2;
		protected System.Web.UI.WebControls.TextBox TextBox8;
		protected System.Web.UI.WebControls.RegularExpressionValidator RegularExpressionValidator1;
		public SqlCommand cmd =new SqlCommand();
		
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
			this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void registerbtn_Click(object sender, System.EventArgs e)
		{
			con.Open();
			cmd.Connection=con;
			cmd.CommandText="insert into crm_custreg values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"','"+TextBox4.Text+"','"+TextBox6.Text+"','"+TextBox5.Text+"','"+TextBox7.Text+"','"+TextBox8.Text+"')";
			Response.Write("<Script> alert ('Record Inserted')</Script>");
			cmd.ExecuteNonQuery();
			con.Close();


			Response.Redirect ("..//Home.aspx");
		}

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			//Response.Redirect ("..//Home.aspx");
		}
	}
}
