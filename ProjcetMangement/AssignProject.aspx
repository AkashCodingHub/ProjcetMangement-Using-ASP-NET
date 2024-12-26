<%--<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AssignProject.aspx.cs" Inherits="ProjcetMangement.AssignProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style11 {
            text-align: center;
        }
        .auto-style12 {
            width: 641px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style11">
        &nbsp;Assign&nbsp;&nbsp; Project</p>
    <p>
        &nbsp;</p>
    <p class="auto-style12">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; Project Manager&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="cmbbxProjectManager" runat="server" OnSelectedIndexChanged="cmbbxProjectManager_SelectedIndexChanged">
        </asp:DropDownList>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p class="auto-style12">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email :&nbsp;&nbsp; &nbsp;<asp:Label ID="lblEmail" runat="server" Text=".........."></asp:Label>
    </p>
    <p class="auto-style12">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Phone:&nbsp;&nbsp; &nbsp;<asp:Label ID="lblPhone" runat="server" Text=".........."></asp:Label>
    </p>

    <asp:GridView ID="grdAsign" runat="server" Width="645px">
  <Columns>
   <asp:TemplateField HeaderText="Select">
        <ItemTemplate>
            <asp:CheckBox ID="chkSelect" runat="server" />
        </ItemTemplate>
    </asp:TemplateField>
</Columns>
  
</asp:GridView>
    </asp:GridView>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnAssign" runat="server" Text="Assign To Project" OnClick="btnAssign_Click" />
    </p>
    <p>
&nbsp;<div class="auto-style11">
        </div>
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
</asp:Content>--%>
<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="AssignProject.aspx.cs" Inherits="ProjcetMangement.AssignProject" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- Include Bootstrap for responsive layout and enhanced styling -->
    <link href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" rel="stylesheet">
    <style type="text/css">
        .auto-style12 {
            max-width: 641px;
            margin: auto; /* Centers the block */
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 class="text-center mt-4">&nbsp;Assign Project</h2>
        <div class="auto-style12 mt-4">
            <label>Project Manager:</label>
            <asp:DropDownList ID="cmbbxProjectManager" CssClass="form-control" runat="server" OnSelectedIndexChanged="cmbbxProjectManager_SelectedIndexChanged" AutoPostBack="true">
            </asp:DropDownList>
        </div>
        <div class="auto-style12 mt-3">
            <label>Email:</label>
            <asp:Label ID="lblEmail" runat="server" Text=".........." CssClass="form-control"></asp:Label>
        </div>
        <div class="auto-style12 mt-3">
            <label>Phone:</label>
            <asp:Label ID="lblPhone" runat="server" Text=".........." CssClass="form-control"></asp:Label>
        </div>
        <div class="auto-style12 mt-3">
            <asp:GridView ID="grdAsign" CssClass="table table-striped" runat="server">
                <Columns>
                    <asp:TemplateField HeaderText="Select">
                        <ItemTemplate>
                            <asp:CheckBox ID="chkSelect" runat="server" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <div class="auto-style12 mt-3">
            <asp:Button ID="btnAssign" CssClass="btn btn-primary" runat="server" Text="Assign To Project" OnClick="btnAssign_Click" />
        </div>
    </div>
</asp:Content>

