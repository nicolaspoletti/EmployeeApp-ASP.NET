<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="User.aspx.cs" Inherits="EfficientEnergyEmployees.UI.User" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EfficentEnergyConnectionString %>" SelectCommand="SELECT * FROM [User]" DeleteCommand="DELETE FROM [User] WHERE [userID] = @original_userID" InsertCommand="INSERT INTO [User] ([userName], [userPw]) VALUES (@userName, @userPw)" OldValuesParameterFormatString="original_{0}" UpdateCommand="UPDATE [User] SET [userName] = @userName, [userPw] = @userPw WHERE [userID] = @original_userID">
        <DeleteParameters>
            <asp:Parameter Name="original_userID" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="userName" Type="String" />
            <asp:Parameter Name="userPw" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="userName" Type="String" />
            <asp:Parameter Name="userPw" Type="String" />
            <asp:Parameter Name="original_userID" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="userID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None" Width="461px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="userID" HeaderText="ID" ReadOnly="True" SortExpression="userID" InsertVisible="False" />
            <asp:BoundField DataField="userName" HeaderText="Username" SortExpression="userName" />
            <asp:BoundField DataField="userPw" HeaderText="Password" SortExpression="userPw" />
            <asp:BoundField DataField="userType" HeaderText="Type" SortExpression="userType" />
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
    <asp:Button ID="IDC_btnAddUser" runat="server" Text="Add User" PostBackUrl="~/UI/AddUser.aspx" CssClass="btnAddUser" style="margin-left: 200px;margin-top: 30px;"/>
</asp:Content>
