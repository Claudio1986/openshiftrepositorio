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
	/// Summary description for CustQueries.
	/// </summary>
	public class CustQueries : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.TextBox contxt;
		protected System.Web.UI.WebControls.TextBox subtxt;
		protected System.Web.UI.WebControls.Label Label4;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.TextBox totxt;
		protected System.Web.UI.WebControls.Panel Panel2;
		protected System.Web.UI.WebControls.Button sendbtn;

		public SqlConnection con=new SqlConnection ("server=.;database=crm;uid=sa;pwd=;");
		protected System.Web.UI.WebControls.Panel Panel3;
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
			this.subtxt.TextChanged += new System.EventHandler(this.subtxt_TextChanged);
			this.sendbtn.Click += new System.EventHandler(this.sendbtn_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void temptxt_TextChanged(object sender, System.EventArgs e)
		{
			

		
		}

		private void sendbtn_Click(object sender, System.EventArgs e)
		{

			con.Open();
			cmd.Connection=con;
			cmd.CommandText ="insert into crm_CustQuery values('"+totxt.Text+"','"+subtxt.Text+"','"+contxt.Text+"')";
			cmd.ExecuteNonQuery();
			con.Close();
		
		}

		private void subtxt_TextChanged(object sender, System.EventArgs e)
		{
		
		}
	}
}
