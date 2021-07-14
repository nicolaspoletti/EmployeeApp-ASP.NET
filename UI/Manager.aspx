<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Manager.aspx.cs" Inherits="EfficientEnergyEmployees.UI.Manager" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EfficentEnergyConnectionString %>" SelectCommand="SELECT * FROM [Manager]"></asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="manID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="manID" HeaderText="ID" ReadOnly="True" SortExpression="manID" />
            <asp:BoundField DataField="manFirst" HeaderText="Name" SortExpression="manFirst" />
            <asp:BoundField DataField="manLast" HeaderText="Surname" SortExpression="manLast" />
            <asp:BoundField DataField="manDOB" HeaderText="DOB" SortExpression="manDOB" />
            <asp:BoundField DataField="manPhoneNo" HeaderText="Phone" SortExpression="manPhoneNo" />
            <asp:BoundField DataField="manSalary" HeaderText="Salary" SortExpression="manSalary" />
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
    <asp:Button ID="IDC_btn_Manager_AddManager" runat="server" Text="Add Manager" PostBackUrl="~/UI/AddManager.aspx" />
</asp:Content>
