<%@ Register TagPrefix="uc1" TagName="WebUserControl1" Src="../WebUserControl1.ascx" %>
<%@ Page language="c#" Codebehind="Invaliduidpwd.aspx.cs" AutoEventWireup="false" Inherits="CRMAPP1.EmployeeModule.Invaliduidpwd" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>Invaliduidpwd</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Panel id="Panel1" style="Z-INDEX: 101; LEFT: 120px; POSITION: absolute; TOP: 176px" runat="server"
				Width="224px" Font-Bold="True" Font-Italic="True" Font-Size="Large" ForeColor="Navy" Height="128px">
				<P>Invalid UserName&nbsp;&amp; Password.... Please....Try 
					Again.....&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
				</P>
			</asp:Panel>
			<asp:LinkButton id="LinkButton1" style="Z-INDEX: 102; LEFT: 184px; POSITION: absolute; TOP: 328px"
				runat="server">To Login Page</asp:LinkButton>
			<asp:Image id="Image1" style="Z-INDEX: 100; LEFT: 344px; POSITION: absolute; TOP: 176px" runat="server"
				Width="120px" Height="128px" ImageUrl="file:///D:\Ramesh\crm-images\VIT\login.gif"></asp:Image>
			<uc1:WebUserControl1 id="WebUserControl11" runat="server"></uc1:WebUserControl1>
		</form>
	</body>
</HTML>
