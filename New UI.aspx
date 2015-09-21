<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="New UI.aspx.cs" Inherits="New_UI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Checkbox1 {
            height: 21px;
            width: 21px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
        <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/Images/compS1.JPG" Height="631px" Width="623px">
            <table style="width: 100%;">
                <tr style="height: 45px">
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td style="width: 527px">&nbsp;</td>
                    <td>&nbsp;<asp:CheckBox runat="server" /></td>
                    <td>&nbsp;<asp:CheckBox runat="server" /></td>

                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </asp:Panel>
    </form>
</body>
</html>
