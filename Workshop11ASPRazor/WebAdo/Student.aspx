<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="WebAdo.Student" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:textbox id="TextBox1" runat="server"></asp:textbox>
        </div>
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
        </div>
        <div>
            <lable>Name:</lable>
            <asp:textbox id="TextBoxName" runat="server"></asp:textbox>
            <lable>Age:</lable>
            <asp:textbox id="TextBoxAge" runat="server"></asp:textbox>
            <asp:Button ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click" />
        </div>
        <div>
            <lable>Id:</lable>
            <asp:textbox id="TextBoxId" runat="server"></asp:textbox>
            <asp:Button ID="ButtonDel" runat="server" Text="Delete" OnClick="ButtonDel_Click" />
        </div>
        <div>
            <lable>Id:</lable>
            <asp:textbox id="TextBoxUpdateId" runat="server"></asp:textbox>
            <lable>Name:</lable>
            <asp:textbox id="TextBoxUpdateName" runat="server"></asp:textbox>
            <lable>Age:</lable>
            <asp:textbox id="TextBoxUpdateAge" runat="server"></asp:textbox>
            <asp:Button ID="Button2" runat="server" Text="Update" OnClick="ButtonUpdate_Click" />
        </div>
    </form>
</body>
</html>
