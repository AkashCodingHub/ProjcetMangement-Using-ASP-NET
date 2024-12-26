<%@ Page Title="" Language="C#" MasterPageFile="~/Project.Master" AutoEventWireup="true" CodeBehind="Project.aspx.cs" Inherits="ProjcetMangement.Project1" %>
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
            <br />
            Project</td>
        <td class="auto-style9">
            <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:TextBox ID="txtProject" runat="server" TextMode="Date"></asp:TextBox>
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
        </td>
        <td>
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click"/>
        </td>
    </tr>
</table>
</asp:Content>
