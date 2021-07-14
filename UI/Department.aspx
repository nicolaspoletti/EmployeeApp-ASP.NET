<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="EfficientEnergyEmployees.UI.Department" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EfficentEnergyConnectionString %>" SelectCommand="SELECT * FROM [Department]" DeleteCommand="DELETE FROM [Department] WHERE [deptID] = @deptID" InsertCommand="INSERT INTO [Department] ([deptID], [deptName], [deptAddress], [manID]) VALUES (@deptID, @deptName, @deptAddress, @manID)
" UpdateCommand="UPDATE [Department] SET [deptName] = @deptName, [deptAddress] = @deptAddress, [manID] = @manID WHERE [deptID] = @deptID">
        <DeleteParameters>
            <asp:Parameter Name="deptID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="deptID" Type="Int32" />
            <asp:Parameter Name="deptName" Type="String" />
            <asp:Parameter Name="deptAddress" Type="String" />
            <asp:Parameter Name="manID" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="deptName" Type="String" />
            <asp:Parameter Name="deptAddress" Type="String" />
            <asp:Parameter Name="manID" Type="Int32" />
            <asp:Parameter Name="deptID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="deptID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="deptID" HeaderText="ID" ReadOnly="True" SortExpression="deptID" />
            <asp:BoundField DataField="deptName" HeaderText="Department" SortExpression="deptName" />
            <asp:BoundField DataField="deptAddress" HeaderText="Address" SortExpression="deptAddress" />
            <asp:BoundField DataField="manID" HeaderText="Manager(ID)" SortExpression="manID" />
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

    <asp:Button ID="IDC_btnLinkAddDepartment" runat="server" PostBackUrl="~/UI/AddDepartment.aspx" Text="Add Department" />

</asp:Content>
