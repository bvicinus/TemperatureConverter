<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Converter.aspx.cs" Inherits="Converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temp Converter</title>
    <link rel="stylesheet" href="TempStyleSheet.css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    
        <asp:Label ID="lblTempConversion" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="XX-Large" ForeColor="Red" Text="Temperature Conversion"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="lblFahrenheit" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Text="Fahrenheit"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="lblCelsius" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Text="Celsius"></asp:Label>
    
        <br />
        <br />
        <asp:Button ID="btnGreatorThan" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Height="32px" OnClick="btnGreatorThan_Click" Text="&gt;&gt;" Width="86px" />
        <br />
        <asp:TextBox ID="tbFarhenheit" runat="server" OnTextChanged="tbFarhenheit_TextChanged"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="tbCelsius" runat="server" OnTextChanged="tbCelsius_TextChanged"></asp:TextBox>
        <br />
        <asp:Button ID="btnLessThan" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" Height="32px" OnClick="btnLessThan_Click" Text="&lt;&lt;" Width="86px" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblInvalid" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large" ForeColor="Red" Text="Invalid" Visible="False"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnClear" runat="server" Font-Bold="True" Font-Names="Arial" OnClick="btnClear_Click" Text="Clear" Width="59px" />
        <br />
    
    </div>
    </form>
</body>
</html>
