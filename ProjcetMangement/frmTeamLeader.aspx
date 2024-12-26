<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Teamleader.Master" AutoEventWireup="true" CodeBehind="frmTeamLeader.aspx.cs" Inherits="ProjcetMangement.frmTeamLeader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </asp:Content>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/Teamleader.Master" AutoEventWireup="true" CodeBehind="frmTeamLeader.aspx.cs" Inherits="ProjcetMangement.frmTeamLeader" %>

<script runat="server">
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style5 {
            height: 73px;
        }
        .auto-style6 {
            height: 72px;
        }
        .auto-style7 {
            height: 72px;
            text-align: center;
            font-size: x-large;
        }
        .auto-style8 {
            height: 73px;
            text-align: center;
            font-size: x-large;
        }
        .auto-style9 {
            font-size: x-large;
        }
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Project Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:DropDownList ID="cmbbxPrjName" runat="server" OnSelectedIndexChanged="cmbbxPrjName_SelectedIndexChanged">
    </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnLogout" runat="server" Text="LogOut" OnClick="btnLogout_Click" />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </strong>
    <br />
    <table class="auto-style1">
        <tr>
            <%--<%@ Page Title="" Language="C#" MasterPageFile="~/Teamleader.Master" AutoEventWireup="true" CodeBehind="frmTeamLeader.aspx.cs" Inherits="ProjcetMangement.frmTeamLeader" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    </asp:Content>--%>
        <tr>
            <td class="auto-style8"><strong>
&nbsp; Iteration 1</strong></td>
            <td class="auto-style5">
                <asp:Button ID="btnIteration1" runat="server" Font-Size="20px" Text="Complete" OnClick="btnIteration1_Click" BackColor="#FF3300" />
                <strong>
                <asp:Label ID="lbl5" runat="server" CssClass="auto-style9" Visible="False">Complete</asp:Label>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>
&nbsp;&nbsp; Iteration 2</strong></td>
            <td class="auto-style6">
                <asp:Button ID="btnIteration2" runat="server" Font-Size="20px" Text="Complete" OnClick="btnIteration2_Click" BackColor="White" />
                <strong>
                <asp:Label ID="lbl6" runat="server" CssClass="auto-style9" Visible="False">Complete</asp:Label>
                </strong></td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>
&nbsp;&nbsp; Iteration 3</strong></td>
            <td class="auto-style6">
                <asp:Button ID="btnIteration3" runat="server" Font-Size="20px" Text="Complete" OnClick="btnIteration3_Click" BackColor="#006600" />
                <strong>
                <asp:Label ID="lbl7" runat="server" CssClass="auto-style9" Visible="False">Complete</asp:Label>
                </strong></td>
        </tr>
    </table>
</asp:Content>
