<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="EfficientEnergyEmployees.UI.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Efficient Energy</title>
    <link rel="stylesheet" type="text/css" href="../Styles/HomeStylesheet.css"/>
</head>
<body>
    <div id="background">
        <div class="form">
            <form id="form1" runat="server">
              <h2 class="title">Efficient Energy</h2>
              &nbsp;<asp:TextBox ID="IDC_txtUserName" runat="server" CssClass="info" Font-Italic="False" placeholder="username"></asp:TextBox>
               <ASP:RequiredFieldValidator ControlToValidate="IDC_txtUserName"
            Display="Static" ErrorMessage="*" runat="server" 
            ID="vUserName" />
              &nbsp;<asp:TextBox ID="IDC_txtUserPw" TextMode="Password" runat="server" CssClass="info" placeholder="password">password</asp:TextBox>
                <ASP:RequiredFieldValidator ControlToValidate="IDC_txtUserPw"
        Display="Static" ErrorMessage="*" runat="server"
        ID="vUserPass" />
                <div>
                    <p>Persistent Cookie:</p>
                    <ASP:CheckBox id="chkPersistCookie" runat="server" autopostback="false" />
                </div>
              <asp:Button ID="IDC_btnLogin" runat="server" Text="LOGIN" CssClass="loginButton" BackColor="#43A050" OnClick="IDC_btnLogin_Click" />
              <p class="message"><a href="#">Admin</a></p>

            </form>
        </div>
    </div>
</body>
</html>
