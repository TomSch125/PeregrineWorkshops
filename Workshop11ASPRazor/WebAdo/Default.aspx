<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebAdo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <form id="form1" runat="server">
            <div>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                <asp:textbox id="TextBox1" runat="server"></asp:textbox>
                <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            </div>
            <div>
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            </div>
        </form>
    </main>

</asp:Content>
