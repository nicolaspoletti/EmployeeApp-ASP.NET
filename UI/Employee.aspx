<%@ Page Title="" Language="C#" MasterPageFile="~/UI/MasterEmployees.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="EfficientEnergyEmployees.UI.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EfficentEnergyConnectionString %>" SelectCommand="SELECT * FROM [Employee]" DeleteCommand="DELETE FROM [Employee] WHERE [empID] = @empID" InsertCommand="INSERT INTO [Employee] ([empID], [empFirst], [empLast], [empDOB], [empAddress], [empType], [empPhoneNo], [empSalary], [deptID]) VALUES (@empID, @empFirst, @empLast, @empDOB, @empAddress, @empType, @empPhoneNo, @empSalary, @deptID)" UpdateCommand="UPDATE [Employee] SET [empFirst] = @empFirst, [empLast] = @empLast, [empDOB] = @empDOB, [empAddress] = @empAddress, [empType] = @empType, [empPhoneNo] = @empPhoneNo, [empSalary] = @empSalary, [deptID] = @deptID WHERE [empID] = @empID">
        <DeleteParameters>
            <asp:Parameter Name="empID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="empID" Type="Int32" />
            <asp:Parameter Name="empFirst" Type="String" />
            <asp:Parameter Name="empLast" Type="String" />
            <asp:Parameter Name="empDOB" Type="DateTime" />
            <asp:Parameter Name="empAddress" Type="String" />
            <asp:Parameter Name="empType" Type="String" />
            <asp:Parameter Name="empPhoneNo" Type="String" />
            <asp:Parameter Name="empSalary" Type="Single" />
            <asp:Parameter Name="deptID" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="empFirst" Type="String" />
            <asp:Parameter Name="empLast" Type="String" />
            <asp:Parameter Name="empDOB" Type="DateTime" />
            <asp:Parameter Name="empAddress" Type="String" />
            <asp:Parameter Name="empType" Type="String" />
            <asp:Parameter Name="empPhoneNo" Type="String" />
            <asp:Parameter Name="empSalary" Type="Single" />
            <asp:Parameter Name="deptID" Type="Int32" />
            <asp:Parameter Name="empID" Type="Int32" />
        </UpdateParameters>
</asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="empID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
    <AlternatingRowStyle BackColor="White" />
    <Columns>
        <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
        <asp:BoundField DataField="empID" HeaderText="empID" ReadOnly="True" SortExpression="empID" />
        <asp:BoundField DataField="empFirst" HeaderText="empFirst" SortExpression="empFirst" />
        <asp:BoundField DataField="empLast" HeaderText="empLast" SortExpression="empLast" />
        <asp:BoundField DataField="empDOB" HeaderText="empDOB" SortExpression="empDOB" />
        <asp:BoundField DataField="empAddress" HeaderText="empAddress" SortExpression="empAddress" />
        <asp:BoundField DataField="empType" HeaderText="empType" SortExpression="empType" />
        <asp:BoundField DataField="empPhoneNo" HeaderText="empPhoneNo" SortExpression="empPhoneNo" />
        <asp:BoundField DataField="empSalary" HeaderText="empSalary" SortExpression="empSalary" />
        <asp:BoundField DataField="deptID" HeaderText="deptID" SortExpression="deptID" />
    </Columns>
    <EditRowStyle BackColor="#2461BF" />
    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#EFF3FB" />
    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#F5F7FB" />
    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
    <SortedDescendingCellStyle BackColor="#E9EBEF" />
    <SortedDescendingHeaderStyle BackColor="#4870BE" />
</asp:GridView>
    <asp:Button ID="IDC_btnLinkAddEmployee" runat="server" Text="Add Employee" PostBackUrl="~/UI/AddEmployee.aspx" ValidateRequestMode="Disabled" />
</asp:Content>
