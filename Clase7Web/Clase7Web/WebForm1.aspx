<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Clase7Web.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 83px;
        }
        .auto-style4 {
            text-align: center;
            background-color: #99FFCC;
        }
        .auto-style5 {
            width: 81px;
        }
        .auto-style6 {
            margin-left: 472px;
            margin-top: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style4" colspan="2">Calculadora</td>
                    <td class="auto-style4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Numero1:<asp:TextBox ID="txtn1" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">Numero2:<asp:TextBox ID="txtn2" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">Resultado:<asp:TextBox ID="txtresultado" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <asp:RadioButton ID="RBSuma" runat="server" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Suma" />
        <asp:RadioButton ID="RBResta" runat="server" Text="Resta" />
        <asp:RadioButton ID="RBMulti" runat="server" Text="Multipicar" />
        <asp:RadioButton ID="RBDivision" runat="server" Text="Division" />
        <asp:Button ID="Boton_Calcular" runat="server" CssClass="auto-style6" OnClick="Boton_Calcular_Click" Text="Calcular" Width="106px" />
    </form>
</body>
</html>
