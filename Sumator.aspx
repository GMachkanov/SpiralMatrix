<%@ Page Language="C#" AutoEventWireup="true"
    CodeBehind="Sumator.aspx.cs"
    Inherits="Sumator.Sumator" %>

<!DOCTYPE html>

<html>

<head runat="server">
    <title>Spiral Matrix</title>
</head>

<body>
    <form id="formSpiral" runat="server">
    <h1>Spiral Matrix</h1>
    x:
    <asp:TextBox ID="TextBoxFirstNum" runat="server"></asp:TextBox>
    <br />
    y:  
    <asp:TextBox ID="TextBoxSecondNum" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="ButtonCalculateSum" runat="server" 
        onclick="Spiral_Click" Text="Generate Matrix" />
    <br />
    </form>
    <br />
</body>

</html>
