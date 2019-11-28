<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PreviousOffender.aspx.cs" Inherits="VictimManagementSystemV1._0.Victims.PreviousOffender" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <title>VMS Victims Previous Offender</title>
<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
<style type="text/css">
<!--
body {
	background-color: #D6cee6;
	margin-top: 0px;
	margin-left: 0px;
}
-->
</style>
<link href="main.css" rel="stylesheet" type="text/css">
<script language="JavaScript" type="text/JavaScript">
<!--
    function MM_reloadPage(init) {  //reloads the window if Nav4 resized
        if (init == true) with (navigator) {
            if ((appName == "Netscape") && (parseInt(appVersion) == 4)) {
                document.MM_pgW = innerWidth; document.MM_pgH = innerHeight; onresize = MM_reloadPage;
            } 
        }
        else if (innerWidth != document.MM_pgW || innerHeight != document.MM_pgH) location.reload();
    }
    MM_reloadPage(true);
//-->
</script>
<style type="text/css">
<!--
body,td,th {
	font-family: Lucida Grande, Arial, Tahoma;
}
    .style1
    {
        width: 217px;
    }
-->
</style>
</head>



<body>
    
    
    
    
    <form id="form1" runat="server">
<table width="800" border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td background="/images/header_top.jpg"> 
	<img src="/images/vms_logo.jpg" width="190" height="64" class="logo">
      <div id="Layer1" 
            style="position:absolute; width:200px; height:115px; z-index:1; top: -6px; left: 188px;" 
            class="toptextlinks"> <a href="#" class="toptextlinkson">Log 0ut</a> | <a href="#" class="toptextlinkson">Search</a> | <a href="#" class="toptextlinkson">Setting</a> | <a href="#" class="toptextlinkson">Help</a> <img src="/images/space_gary.gif" width="20" height="2"> </div>
    <div id="Layer2" 
            style="position:absolute; width:591px; height:151px; z-index:2; top: -36px; left: 206px;" 
            class="welcomemessage"></div></td>
<div id="Layer3" style="position:absolute; width:200px; height:115px; z-index:3"><img src="/images/btm_top_new.jpg" width="79" height="25" class="topbtm_new"></div> 
<div id="Layer4" style="position:absolute; width:200px; height:115px; z-index:3"><img src="/images/btm_top_print.jpg" width="79" height="25" class="topbtm_print"></div> 



  </tr>
 
  <tr>
    <td><table border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td><table border="0" cellpadding="0" cellspacing="0">
  <tr>
    <td><img src="/images/header_victims.jpg" width="228" height="67"></td>
  </tr>
  <tr>
    <td>
      <li class="moduleheadline"><strong>Victims</strong>  </li>    
                      <li class="moduletasks"><a href="1.1_victiminfo.htm" class="moduletaskslinks">Victim Info                    </a></li>
            <li class="moduletasks"><a href="1.2_offenderinfo.htm" class="moduletaskslinks">Offender Info </a> </li>
            <li class="moduletasks"><a href="1.3_childreninfo.htm" class="moduletaskslinks">Children Info</a> </li>
            <li class="moduletasks"><a href="1.4_othercontactinfo.htm" class="moduletaskslinks">Other Contact Info</a> </li>
            <li class="moduletaskson">Previous Offender </li>
            <li class="moduletasks"><a href="1.6_Agencyinfo.htm" class="moduletaskslinks">Agency Info </a> </li>
            <li class="moduletasks"><a href="1.2_offenderinfo.htm" class="moduletaskslinks">Note</a></li>
            <li class="moduleheadline"> <strong>Assessment</strong></li>
             <li class="moduletasks"><a href="2.1_odara.htm" class="moduletaskslinks">ODARA</a></li>
             <li class="moduletasks"><a href="2.2_jcdangerassessment.htm" class="moduletaskslinks">J C Danger Assessment</a></li>
              <li class="moduletasks"><a href="2.3_assessment.htm" class="moduletaskslinks">Main Assessment</a></li>
             <li class="moduletasks"><a href="2.4_referral.htm" class="moduletaskslinks">Referral Accepted/Declined</a></li>
              <li class="moduleheadline"> <strong>Active Case</strong></li>
              <li class="moduletasks"><a href="3.1_activecaseaddinfo.htm" class="moduletaskslinks">Additional Info</a> </li>
              <li class="moduletasks"><a href="3.2_historycharges.htm" class="moduletaskslinks">History &amp; Charges</a></li>
              <li class="moduletasks"><a href="3.3_activecastasks.htm" class="moduletaskslinks">Tasks</a></li>
              <li class="moduletasks"><a href="3.4_courtinfo.htm" class="moduletaskslinks">Court Info</a></li>
             
              <li class="moduleheadline"> <strong>Monitoring</strong></li>
             <li class="moduletasks"><a href="4.1_monitoring.htm" class="moduletaskslinks">Monitoring </a></li>
              <li class="moduletasks"><a href="4.2_monitoringnotes.htm" class="moduletaskslinks">Notes</a></li>
             
              <li class="moduleheadline"> <strong>Case Closure</strong></li>
              <li class="moduletasks"><a href="5.1_caseclosuretasks.htm" class="moduletaskslinks">Tasks</a></li>
             <li class="moduletasks"><a href="5.2_performancemeasure.htm" class="moduletaskslinks"> Performance Measure</a></li>
              <li class="moduletasks"><a href="5.3_caseclosureotherinfo.htm" class="moduletaskslinks">Other Info</a></li>
              
              <li class="moduleheadline"> <strong>Report</strong></li>
              <li class="moduletasks"><a href="6.1_report.htm" class="moduletaskslinks">Report
              </a></li>          </td>
  </tr>
  <tr>
    <td><table align="center" bgcolor="#FFFFFF">
      <tr>
        <td colspan="3" bgcolor="#6958A8"><div align="center"><img src="/images/search_panel.jpg" width="214" height="47"></div></td>
        </tr>
      <tr>
        <td><img src="/images/btm_on_victims.jpg" width="70" height="58"></td>
        <td><a href="2.1_odara.htm"><img src="/images/btm_off_assessment.jpg" width="70" height="58" border="0"></a></td>
        <td><a href="3.1_activecaseaddinfo.htm"><img src="/images/btm_off_actives_case.jpg" width="70" height="58" border="0"></a></td>
      </tr>
      <tr>
        <td><a href="4.1_monitoring.htm"><img src="/images/btm_off_monitoring.jpg" width="70" height="58" border="0"></a></td>
        <td><a href="5.1_caseclosuretasks.htm"><img src="/images/btm_off_case_closure.jpg" width="70" height="58" border="0"></a></td>
        <td><a href="6.1_report.htm"><img src="/images/btm_off_report--.jpg" width="70" height="58" border="0"></a></td>
      </tr>
    </table></td>
  </tr>
</table>
</td>
        <td valign="top"><table width="560" border="0" cellpadding="0" cellspacing="0">
          <tr>
            <td width="20"><img src="/images/space_gary.gif" width="20" height="2"></td>
            <td><table border="0" cellpadding="0" cellspacing="0" bgcolor="#FFFFFF">
              
              <tr>
                <td width="12" height="12"><img src="/images/table%20image/table.jpg" width="1" height="16"><img src="/images/table%20image/table.jpg" width="1" height="16"></td>
                <td valign="top">&nbsp;</td>
              </tr>
            </table></td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
          </tr>
          <tr>
            <td>&nbsp;</td>
            <td bgcolor="#cadea9">&nbsp;</td>
          </tr>
        </table>
           
            <table style="width: 100%; height: 132px;">
                <tr>
                    <td class="style1">
                        Previous Offender</td>
                    <td>
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="style1">
                        <asp:Label ID="Label2" runat="server" Text="Surname"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="TxtSurname" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Date of Birth"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtDateofBirth" runat="server"></asp:TextBox>
                </td>
                <td></td>
                </tr>
                <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
                    </td>
                <td>
                    <asp:DropDownList ID="DrpGender" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:DropDownList>
                    </td>
                <td></td>
                </tr>
                 <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Home Address"></asp:Label>
                     </td>
                <td>
                    <asp:TextBox ID="TxtHomeAddress1" runat="server"></asp:TextBox>
                     </td>
                <td></td>
                </tr>
                 <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="TxtHomeAddress2" runat="server"></asp:TextBox>
                     </td>
                <td></td>
                </tr>
                 <tr>
                <td></td>
                <td>
                    <asp:TextBox ID="TxtHomeAddress3" runat="server"></asp:TextBox>
                     </td>
                <td></td>
                </tr>
                <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="PostCode"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtPostCode" runat="server"></asp:TextBox>
                </td>
                <td></td>
                </tr>
                 <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Police Record Number"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtPoliceRecordNumber" runat="server"></asp:TextBox>
                </td>
                <td></td>
                </tr>
                 <tr>
                <td>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Save" />
                    <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Edit" />
                </td>
                <td></td>
                </tr>
            
            </table>
           
          
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
                DataSourceID="SqlDataSource1" 
                onselectedindexchanged="GridView1_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="FirstName" HeaderText="FirstName" 
                        SortExpression="FirstName" />
                    <asp:BoundField DataField="Surname" HeaderText="Surname" 
                        SortExpression="Surname" />
                    <asp:BoundField DataField="VictimId" HeaderText="VictimId" 
                        SortExpression="VictimId" />
                    <asp:BoundField DataField="PreviousOffenderId" HeaderText="PreviousOffenderId" 
                        SortExpression="PreviousOffenderId" />
                    <asp:CommandField ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
                ConnectionString="<%$ ConnectionStrings:VictimManagementDatabaseConnectionString %>" 
                SelectCommand="SELECT [FirstName], [Surname], [VictimId], [PreviousOffenderId] FROM [PreviousOffender] WHERE ([VictimId] = @VictimId)">
                <SelectParameters>
                    <asp:SessionParameter Name="VictimId" SessionField="VictimId" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
           
          
          </td>
      </tr>
    </table>    </td>
  </tr>
</table>
    
    
    
    
    <div>
    
    </div>
    </form>
</body>
</html>
