<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="AddDepartment.aspx.cs" Inherits="EfficientEnergyEmployees.UI.AddDepartment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td style="width: 328px">
                Department ID</td>
            <td style="width: 644px">
                <asp:TextBox ID="ICD_txtDeptID" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
                Department Name</td>
            <td style="width: 644px">
                <asp:TextBox ID="ICD_txtDeptName" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
                Dept. Address</td>
            <td style="width: 644px">
                <asp:TextBox ID="ICD_txtDeptAddress" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
                Manager ID</td>
            <td style="width: 644px">
                <asp:TextBox ID="ICD_txtDeptManID" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px"></td>
        </tr>
        <tr>
            <td style="width: 328px">
            </td>
            <td style="width: 644px">
                <asp:Button ID="ICD_btnAddDept" runat="server" OnClick="ICD_btnAddDept_Click" Text="Add" />
            </td>
            <td style="width: 666px"></td>
        </tr>
    </table>
</asp:Content>
