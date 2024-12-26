<%@ Page Title="" Language="C#" MasterPageFile="~/MainPage.Master" AutoEventWireup="true" CodeBehind="EmployeeMain.aspx.cs" Inherits="ProjcetMangement.EmployeeMain" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>--%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
        <style type="text/css">
    .auto-style4 {
        width: 100%;
    }
    .auto-style5 {
        text-align: center;
    }
    .auto-style6 {
        height: 40px;
    }
    .auto-style7 {
        height: 39px;
    }
    .auto-style8 {
        height: 40px;
        text-align: center;
    }
    .auto-style9 {
        height: 39px;
        text-align: center;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        
        <div class="auto-style5">
        </div>
        <table class="auto-style4">
            <tr>
                <td class="auto-style8">Position</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="drplstPositon" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Name</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">Email</td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Phone</td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">Country</td>
                <td class="auto-style6">
                    <asp:DropDownList ID="drplstCountry" runat="server" OnSelectedIndexChanged="drplstCountry_SelectedIndexChanged">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">State</td>
                <td class="auto-style7">
                    <asp:DropDownList ID="drplstState" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style6">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">Password</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
                </td>
                <td>
                    <asp:Button ID="btnClear" runat="server" Text="Clear" Width="76px" OnClick="btnClear_Click" />
                </td>
            </tr>
        </table>
        <br />
        <br />
</div>
</asp:Content>

