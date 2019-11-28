<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgencyInfoTest.aspx.cs" Inherits="VictimManagementSystemV1._0.Victims.Agency_Info" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style2
        {
            width: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    
    <table style="width:100%;">
        <tr>
            <td>
            </td>
            <td class="style2">
                Date
                <br />
                <br />
                Agency
                <br />
                <br />
                ContactPerson
                <br />
                <br />
                <asp:Label ID="Label1" runat="server" Text="Telephone"></asp:Label>
                <br />
                <br />
                Fax
                <br />
                <br />
                <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
                <br />
                <br />
                </td>
            <td>
            <asp:TextBox ID="TxtDate" runat="server"></asp:TextBox>
            <br />
            <br />

             <asp:DropDownList ID="DrpAgency" runat="server" AutoPostBack="True" 
                    DataMember="CAA">
                </asp:DropDownList>
                <br />
                <br />

            <asp:TextBox ID="TxtContactPerson" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:TextBox ID="TxtTelephone" runat="server"></asp:TextBox>
            <br />
            <br />

            <asp:TextBox ID="TxtFax" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <br />
            <br />
                <asp:Button ID="Button1" runat="server" Text="Save" onclick="Button1_Click" />
                <asp:Button ID="Button2" runat="server" Text="Edit" onclick="Button2_Click" />
            <br />
            </td>
        </tr>
       
    </table>
    </form>
    </body>
</html>
