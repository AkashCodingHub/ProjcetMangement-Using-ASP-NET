
<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="MainEmployee.aspx.cs" Inherits="ProjcetMangement.MainEmployee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            text-align: center;
        }
        .custom-form-group {
            margin-bottom: 1rem;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <form class="form-horizontal">
                    <div class="form-group custom-form-group">
                        <label for="drplstPosition" class="col-form-label">Position</label>
                        <asp:DropDownList ID="drplstPositon" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>
                    
                    <div class="form-group custom-form-group">
                        <label for="txtName" class="col-form-label">Name</label>
                        <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group custom-form-group">
                        <label for="txtEmail" class="col-form-label">Email</label>
                        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group custom-form-group">
                        <label for="txtPhone" class="col-form-label">Phone</label>
                        <asp:TextBox ID="txtphone" runat="server" CssClass="form-control" OnTextChanged="txtphone_TextChanged"></asp:TextBox>
                    </div>

                    <div class="form-group custom-form-group">
                        <label for="drplstCountry" class="col-form-label">Country</label>
                        <asp:DropDownList ID="drplstCountry" runat="server" CssClass="form-control" OnSelectedIndexChanged="drplstCountry_SelectedIndexChanged">
                        </asp:DropDownList>
                    </div>

                    <div class="form-group custom-form-group">
                        <label for="drplstState" class="col-form-label">State</label>
                        <asp:DropDownList ID="drplstState" runat="server" CssClass="form-control">
                        </asp:DropDownList>
                    </div>

                    <div class="form-group custom-form-group">
                        <label for="txtPassword" class="col-form-label">Password</label>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
                    </div>

                    <div class="form-group custom-form-group text-center">
                        <asp:Button ID="btnRegister" runat="server" Text="Register" CssClass="btn btn-primary" OnClick="btnRegister_Click" />
                        <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="btn btn-secondary" OnClick="btnClear_Click" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</asp:Content>

