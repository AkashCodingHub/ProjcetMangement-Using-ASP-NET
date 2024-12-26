<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MainLog.aspx.cs" Inherits="ProjcetMangement.MainLog" %>
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">&nbsp;    
    <table class="auto-style4">
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
            <asp:Button ID="btnRegister" runat="server" Text="Login" OnClick="btnRegister_Click" />
        </td>
        <td class="auto-style9">
            <asp:Button ID="btnClear" runat="server" Text="Clear" />
        </td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
<%--</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MainLog.aspx.cs" Inherits="ProjcetMangement.MainLog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-4 offset-md-4">
                <h3 class="text-center mb-4">Login</h3>
                <form>
                    <div class="form-group">
                        <label for="drplstPosition">Position</label>
                        <asp:DropDownList ID="drplstPosition" runat="server" CssClass="form-control">
                            <asp:ListItem>Admin</asp:ListItem>
                            <asp:ListItem>Team Leader</asp:ListItem>
                            <asp:ListItem>Project Manager</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtEmail">Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" TextMode="Email"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtPassword">Password</label>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="text-center">
                        <asp:Button ID="btnRegister" runat="server" Text="Login" CssClass="btn btn-primary" OnClick="btnRegister_Click" style="height: 26px" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn-secondary ml-2" OnClick="btnClear_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>

