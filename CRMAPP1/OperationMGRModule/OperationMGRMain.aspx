<%@ Page language="c#" Codebehind="OperationMGRMain.aspx.cs" AutoEventWireup="false" Inherits="CRMAPP1.OperationMGRModule.OperationMGRMain" %>
<%@ Register TagPrefix="uc1" TagName="WebUserControl1" Src="../WebUserControl1.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<HTML>
	<HEAD>
		<title>OperationMGRMain</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Panel id="Panel1" style="Z-INDEX: 101; LEFT: 288px; POSITION: absolute; TOP: 168px" runat="server"
				Height="176px" Width="264px" Font-Bold="True" BackColor="Lavender"></asp:Panel>
			<asp:Image id="Image1" style="Z-INDEX: 105; LEFT: 48px; POSITION: absolute; TOP: 168px" runat="server"
				Height="176px" Width="240px" ImageUrl="file:///D:\Ramesh\crm-images\VIT\contact.jpg"></asp:Image>
			<asp:LinkButton id="LinkButton3" style="Z-INDEX: 104; LEFT: 312px; POSITION: absolute; TOP: 280px"
				runat="server" ForeColor="Crimson" Font-Bold="True" Font-Italic="True" Font-Size="Larger">ViewQuery</asp:LinkButton>
			<asp:LinkButton id="LinkButton2" style="Z-INDEX: 103; LEFT: 312px; POSITION: absolute; TOP: 240px"
				runat="server" ForeColor="Crimson" Font-Bold="True" Font-Italic="True" Font-Size="Larger">Scheme</asp:LinkButton>
			<asp:LinkButton id="LinkButton1" style="Z-INDEX: 102; LEFT: 304px; POSITION: absolute; TOP: 192px"
				runat="server" ForeColor="Crimson" Font-Bold="True" Font-Italic="True" Font-Size="Larger">Operation Manager Query</asp:LinkButton>
			<uc1:WebUserControl1 id="WebUserControl11" runat="server"></uc1:WebUserControl1>
		</form>
	</body>
</HTML>
