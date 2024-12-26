<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MainProject.aspx.cs" Inherits="ProjcetMangement.MainProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
    .auto-style5 {
        text-align: center;
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
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  <table class="auto-style4">
    <tr>
        <td class="auto-style5" colspan="2">Project</td>
    </tr>
    <tr>
        <td class="auto-style6">Project Name</td>
        <td class="auto-style7">
            <asp:TextBox ID="txtProjectName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Technology</td>
        <td class="auto-style9">
            <asp:DropDownList ID="drplstTech" runat="server">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">Start Date</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">End Date<br />
            <br />
            Amount</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="txtAmount" runat="server" TextMode="Date"></asp:TextBox>
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" style="height: 26px" />
        </td>
        <td>
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click"/>
        </td>
    </tr>
</table>
</asp:Content>
<%--</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MainProject.aspx.cs" Inherits="ProjcetMangement.MainProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container mt-5">
        <div class="row">
            <div class="col-md-6 offset-md-3">
                <h3 class="text-center mb-4">Project Registration</h3>
                <form>
                    <div class="form-group">
                        <label for="txtProjectName">Project Name</label>
                        <asp:TextBox ID="txtProjectName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="drplstTech">Technology</label>
                        <asp:DropDownList ID="drplstTech" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="txtStartDate">Start Date</label>
                        <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtEndDate">End Date</label>
                        <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="txtAmount">Amount</label>
                        <asp:TextBox ID="txtAmount" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="form-group text-center">
                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" CssClass="btn btn-primary" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" CssClass="btn btn-secondary ml-2" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>


