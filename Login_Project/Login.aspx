<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login_Project.Login" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head id="Head1" runat="server">
<title>Login Page</title>
</head>
<body>
<form id="form1" runat="server">
<div>
<asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
<br />
<br />
<asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
<asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
<br />

<br />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<asp:Button ID="btnlogin" runat="server" Text="Login" onclick="btnlogin_Click" Width="47px" />
&nbsp;
<br />

&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>

</div>

</form>

</body>

</html>