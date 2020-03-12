<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormRegister.aspx.cs" Inherits="MVC_MNJ.WebFormRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form_Register" runat="server">
        <div>
            <div>
                <asp:Label ID="Label_Name" runat="server" Text="Name : - "></asp:Label>
                <asp:TextBox ID="TextBox_Name" runat="server"></asp:TextBox>
                <br/>
                <asp:Label ID="Label_Age" runat="server" Text="Age : - "></asp:Label>
                <asp:TextBox ID="TextBox_Age" runat="server"></asp:TextBox>
                <br/>
                <asp:Label ID="Label_Address" runat="server" Text="Address : - "></asp:Label>
                <asp:TextBox ID="TextBox_Address" runat="server"></asp:TextBox>
                <br/>
                <asp:Label ID="Label_Phone" runat="server" Text="Phone No : - "></asp:Label>
                <asp:TextBox ID="TextBox_Phone" runat="server"></asp:TextBox>
                <br/>
                <br/>
                <div>
                    <asp:Button ID="Button_Add" runat="server" Text="Add" OnClick="Button_Add_Click" />
                    <asp:Button ID="Button_Update" runat="server" Text="Update" OnClick="Button_Update_Click"/>
                    <asp:Button ID="Button_Delete" runat="server" Text="Delete" OnClick="Button_Delete_Click"/>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
