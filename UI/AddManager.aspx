<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddManager.aspx.cs" Inherits="EfficientEnergyEmployees.UI.AddManager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label1" runat="server" Text="Manager ID"></asp:Label>
            </td>
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtManID" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label2" runat="server" Text="First name"></asp:Label>
            </td>
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtManFirst" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label3" runat="server" Text="Last name"></asp:Label>
            </td>
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtManLast" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label4" runat="server" Text="D.O.B"></asp:Label>
            </td>
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtManDOB" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label5" runat="server" Text="Phone"></asp:Label>
            </td>
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtManPhone" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label6" runat="server" Text="Salary"></asp:Label>
            </td>
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtManSalary" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Button ID="IDC_btnAddManager" runat="server" OnClick="IDC_btnAddManager_Click" Text="Add Manager" />
                <asp:Button ID="IDC_btnViewManagers" runat="server" PostBackUrl="~/UI/Manager.aspx" Text="View Managers" />
            </td>
            <td></td>
        </tr>
    </table>
</asp:Content>
