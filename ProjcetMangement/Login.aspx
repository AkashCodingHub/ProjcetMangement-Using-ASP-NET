<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ProjcetMangement.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
    .auto-style5 {
        text-align: left;
    }
    .auto-style6 {
        text-align: center;
        height: 49px;
    }
    .auto-style7 {
        height: 49px;
    }
    .auto-style8 {
        text-align: center;
        height: 50px;
    }
    .auto-style9 {
        height: 50px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">&nbsp;     <table class="auto-style4">
    <tr>
        <td class="auto-style5" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login </td>
    </tr>
    <tr>
        <td class="auto-style6">Position</td>
        <td class="auto-style7">
            <asp:DropDownList ID="drplstPosition" runat="server">
                <asp:ListItem>Admin</asp:ListItem>
                <asp:ListItem>Team Leader</asp:ListItem>
                <asp:ListItem>Project Manager</asp:ListItem>
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Email</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Password</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </td>
        <td class="auto-style9">
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
