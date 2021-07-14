<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="EfficientEnergyEmployees.UI.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <table>
        <tr>
            <td style="width: 328px">              
                <asp:Label ID="Label1" runat="server" Text="User Name"></asp:Label>              
            </td>
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtUserName" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">              
                <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>              
            </td>
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtUserPw" runat="server" Width="290px" TextMode="Password">
</asp:TextBox>                
            </td>
            <td style="width: 666px"></td>
        </tr>
         <tr>
            <td style="width: 328px">              
                      
                <asp:Label ID="Label3" runat="server" Text="Type"></asp:Label>
                      
            </td>
            <td style="width: 644px">
                  
                <asp:RadioButton ID="IDC_radUser" runat="server" Text="User" />
                <asp:RadioButton ID="IDC_radAdmin" runat="server" Text="Admin" />
                  
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">              
            </td>
            <td style="width: 644px">
                <asp:Button ID="IDC_btn_User_Add" runat="server" Text="Add" OnClick="IDC_btn_User_Add_Click" />               
            </td>
            <td style="width: 666px"></td>
        </tr>
    </table>    
</asp:Content>
