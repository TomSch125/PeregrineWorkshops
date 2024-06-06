<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAdo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <form id="form1" runat="server">
            <div>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
<%--                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>--%>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <div>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </form>
    </main>

</asp:Content>
