
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

