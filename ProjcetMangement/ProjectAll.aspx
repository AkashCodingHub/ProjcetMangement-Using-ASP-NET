<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="ProjectAll.aspx.cs" Inherits="ProjcetMangement.ProjectAll" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="grdAllRecord" runat="server" OnSelectedIndexChanged="grdAllRecord_SelectedIndexChanged" Width="843px">
</asp:GridView>
</asp:Content>


