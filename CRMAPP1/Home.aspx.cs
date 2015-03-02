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

namespace CRMAPP1
{
	/// <summary>
	/// Summary description for Home.
	/// </summary>
	public class Home : System.Web.UI.Page
	{
		protected System.Web.UI.WebControls.Label Label3;
		protected System.Web.UI.WebControls.Button Button2;
		protected System.Web.UI.WebControls.Label Label2;
		protected System.Web.UI.WebControls.Label Label1;
		protected System.Web.UI.WebControls.LinkButton LinkButton4;
		protected System.Web.UI.WebControls.Panel Panel3;
		protected System.Web.UI.WebControls.LinkButton LinkButton1;
		protected System.Web.UI.WebControls.Image Image2;
		protected System.Web.UI.WebControls.TextBox TextBox1;
		protected System.Web.UI.WebControls.TextBox TextBox2;
		protected System.Web.UI.WebControls.Panel Panel1;
		protected System.Web.UI.WebControls.Panel Panel2;

			public SqlConnection con=new SqlConnection ("server=.;database=crm;uid=sa;pwd=;");
	
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
			this.Button2.Click += new System.EventHandler(this.Button2_Click);
			this.LinkButton1.Click += new System.EventHandler(this.LinkButton1_Click);
			this.LinkButton4.Click += new System.EventHandler(this.LinkButton4_Click);
			this.Load += new System.EventHandler(this.Page_Load);

		}
		#endregion

		private void LinkButton1_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("Official Link.aspx");
		}

		private void LinkButton2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void LinkButton4_Click(object sender, System.EventArgs e)
		{
			Response.Redirect("CustomerModule/CustReg.aspx");
		}

		private void Button2_Click(object sender, System.EventArgs e)
		{
			SqlCommand cmd=new SqlCommand();
			con.Open();
			cmd.Connection =con;
			cmd.CommandText ="select count(*) from crm_custreg where custname='"+TextBox1.Text+"' and pwd='"+TextBox2.Text+"'";
			object re=cmd.ExecuteScalar();
			con.Close();

			int chk=Convert.ToInt32(re);
   
			if(chk==1)
			{
				Response.Redirect("CustomerModule/CustoMain.aspx");					
			}
			else
			{
				Response.Redirect("CustomerModule/Invaliduidpwd.aspx");	
			}
		}
	}
}
