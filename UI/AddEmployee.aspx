<%@ Page Title="" Language="C#" MasterPageFile="~/UI/MasterEmployees.Master" AutoEventWireup="true" CodeBehind="AddEmployee.aspx.cs" Inherits="EfficientEnergyEmployees.UI.AddEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label1" runat="server" Text="ID" AssociatedControlID="IDC_txtEmpID"></asp:Label>
            </td>              
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtEmpID" runat="server" Width="290px" OnTextChanged="IDC_txtEmpID_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 666px">
                <asp:Label ID="IDC_lblValidID" runat="server" Font-Italic="False" Font-Names="Consolas" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 328px; height: 28px;">
                <asp:Label ID="IDC_lblFirstname" runat="server" AssociatedControlID="IDC_txtEmpName" Text="First name"></asp:Label>
            </td>              
            <td style="width: 644px; height: 28px;">
                <asp:TextBox ID="IDC_txtEmpName" runat="server" Width="290px" OnTextChanged="IDC_txtEmpName_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 666px; height: 28px;">
                <asp:Label ID="IDC_lblValidName" runat="server" Font-Names="Consolas" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 328px; height: 29px;">
                <asp:Label ID="Label3" runat="server" Text="Surname" AssociatedControlID="IDC_txtEmpLast"></asp:Label>
            </td>              
            <td style="width: 644px; height: 29px;">
                <asp:TextBox ID="IDC_txtEmpLast" runat="server" Width="290px" OnTextChanged="IDC_txtEmpLast_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 666px; height: 29px;">
                <asp:Label ID="IDC_lblValidSurname" runat="server" Font-Names="Consolas" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label4" runat="server" Text="DOB" AssociatedControlID="IDC_txtEmpDOB"></asp:Label>
            </td>              
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtEmpDOB" runat="server" Width="290px" OnTextChanged="IDC_txtEmpDOB_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 666px">
                <asp:Label ID="IDC_lblValidDOB" runat="server" Font-Names="Consolas" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 328px; height: 29px;">
                <asp:Label ID="Label5" runat="server" Text="Address" AssociatedControlID="IDC_txtEmpAddress"></asp:Label>
            </td>              
            <td style="width: 644px; height: 29px;">
                <asp:TextBox ID="IDC_txtEmpAddress" runat="server" Width="290px" OnTextChanged="IDC_txtEmpAddress_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 666px; height: 29px;">
                <asp:Label ID="IDC_lblValidAddress" runat="server" Font-Names="Consolas" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 328px">
                <asp:Label ID="Label6" runat="server" Text="Type" AssociatedControlID="IDC_radCasual"></asp:Label>
            </td>              
            <td style="width: 644px">
                <asp:RadioButton ID="IDC_radCasual" runat="server" Text="Casual" />
                <asp:RadioButton ID="IDC_radFulltime" runat="server" Text="Fulltime" />
            </td>
            <td style="width: 666px">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 328px; height: 29px;">Phone</td>              
            <td style="width: 644px; height: 29px;">
                <asp:TextBox ID="IDC_txtEmpPhone" runat="server" Width="290px"></asp:TextBox>
            </td>
            <td style="width: 666px; height: 29px;">
                <asp:Label ID="IDC_lblValidPhone" runat="server" Font-Names="Consolas" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 328px">Salary</td>              
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtEmpSalary" runat="server" Width="290px" OnTextChanged="IDC_txtEmpSalary_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 666px">
                <asp:Label ID="IDC_lblValidSalary" runat="server" Font-Names="Consolas" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 328px">Dept ID</td>              
            <td style="width: 644px">
                <asp:TextBox ID="IDC_txtEmpDeptID" runat="server" Width="290px" OnTextChanged="IDC_txtEmpDeptID_TextChanged"></asp:TextBox>
            </td>
            <td style="width: 666px">
                <asp:Label ID="IDC_lblValidDeptID" runat="server" Font-Names="Consolas" Font-Overline="False" Font-Strikeout="False" ForeColor="#CC3300"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 328px">&nbsp;</td>              
            <td style="width: 644px">
                <asp:Button ID="IDC_btnEmpAdd" runat="server" OnClick="IDC_btnEmpAdd_Click" Text="Add"/>
            </td>
            <td style="width: 666px"></td>
        </tr>
    </table>
</asp:Content>
