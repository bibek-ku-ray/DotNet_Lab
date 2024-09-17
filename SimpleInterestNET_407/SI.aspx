<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SI.aspx.cs" Inherits="SimpleInterestNET_407.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>Simple Interest</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Principle</td>
                <td>
                    <asp:TextBox ID="txtPrincipal" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Rate</td>
                <td>
                    <asp:TextBox ID="txtRate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Time(Year)</td>
                <td>
                    <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="ButtonCalculate" runat="server" OnClick="ButtonCalculate_Click" Text="Calculate" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
