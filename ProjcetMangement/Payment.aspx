<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="ProjcetMangement.Payment" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="auto-style12 mt-3">
     <asp:GridView ID="grdAsign" CssClass="table table-striped" runat="server">
         <Columns>
             <asp:TemplateField HeaderText="">
                 <ItemTemplate>
                    <%-- <asp:CheckBox ID="chkSelect" runat="server" />--%>
                 </ItemTemplate>
             </asp:TemplateField>
         </Columns>
     </asp:GridView>
 </div>
    <p>
        <br />
    </p>
    <p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="CheckOut" Height="48px" Width="210px" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
