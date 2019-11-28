<%@ Page Language="C#"  AutoEventWireup="true"  CodeBehind="VictimInfo.aspx.cs" Inherits="VictimManagementSystemV1._0.Victims.VictimInfo" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>VMS Victims Info </title>
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
.style1 {
	font-size: 12px;
	font-family: "Lucida Grande", Arial, Tahoma;
}
.style3 {font-size: 14px}
.style4 {color: #332c5f}
.style5 {font-weight: bold; font-size: 20px;}
.style6 {
	font-family: "Lucida Grande", Arial, Tahoma;
	color: #333333;
}
.style7 {
	font-size: 10px;
	font-weight: bold;
	font-family: "Lucida Grande", Arial, Tahoma;
	color: #666666;
}
body,td,th {
	font-family: Lucida Grande, Arial, Tahoma;
}
.style8 {font-size: 10px}
-->
</style>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table border="0" cellpadding="0" cellspacing="0" 
            style="height: 753px; width: 783px">
  <tr>
    <td background="/images/header_top.jpg"> 
	<img src="/images/vms_logo.jpg" width="190" height="64" class="logo">
      <div id="Layer1" 
            style="position:absolute; width:200px; height:115px; z-index:1; top: 28px; left: 194px;" 
            class="toptextlinks"> <a href="#" class="toptextlinkson">Log 0ut</a> | <a href="#" class="toptextlinkson">Search</a> | <a href="#" class="toptextlinkson">Setting</a> | <a href="#" class="toptextlinkson">Help</a> <img src="/images/space_gary.gif" width="20" height="2"> </div>
    <div id="Layer2" 
            style="position:absolute; width:200px; height:115px; z-index:2; top: 29px; left: 391px; margin-left: 1px;" 
            class="welcomemessage">Welcome Paul</div></td>
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
                      <li class="moduletaskson">Victim Info                    </li>
            <li class="moduletasks">
                <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click1">Offender Info</asp:LinkButton>
        </li>
            <li class="moduletasks">
                <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click1">ChildrenInfo</asp:LinkButton>
        </li>
            <li class="moduletasks">
                <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click1">Other Contact Info</asp:LinkButton>
        </li>
            <li class="moduletasks">
                <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click1">Previous Offender</asp:LinkButton>
        </li>
            <li class="moduletasks">
                <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">AgencyInfo</asp:LinkButton>
        </li>
            <li class="moduletasks"><a href="1.7_note.htm" class="moduletaskslinks">Note</a></li>
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
                <td>&nbsp;</td>
                <td><p class="style1 style4"><span class="style5">Smiths, Jo</span>
                  <p>
                    <span class="style3"><span class="style6">KK3488, 12/12/1974 , Female, 37 yeras, 8months </span><span class="style7">FST Victim YES Previous Case YES Case ID# 6666RF, 786GH</span></span></p>
                  <p class="style8">2b/369 Great South Road, Manurewa, Auckland 2034, 09 544 6788, 0213456789 </p></td>
              </tr>
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
           
    <table style="width:87%;">
                            <tr>
                                <td>
                         <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
                                </td>
                                <td>
                        <asp:TextBox ID="TxtFirstName" runat="server"></asp:TextBox>
                                </td>
                               
                            </tr>
                            <tr>
                                <td>
         <asp:Label ID="Label2" runat="server" Text="Surname"></asp:Label>
                                </td>
                                <td>
       <asp:TextBox ID="TxtSurname" runat="server"></asp:TextBox>
                                </td>
                                
                            </tr>
                            <tr>
                                <td>
          <asp:Label ID="Label3" runat="server" Text="DateofBirth"></asp:Label>
                                </td>
                                <td>
       <asp:TextBox ID="TxtDateofBirth" runat="server"></asp:TextBox>
                                </td>
                                
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

       <asp:CheckBox ID="ChkFST" runat="server" Text="FST Victim " />
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
        <asp:Label ID="Label15" runat="server" Text="Police Record Number"></asp:Label>
                                 </td>
                                <td>
       <asp:TextBox ID="TxtPoliceRecord" runat="server"></asp:TextBox>
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
        <asp:Label ID="Label5" runat="server" Text="Home Address"></asp:Label>
                                 </td>
                                <td>
      
       <asp:TextBox ID="TxtHomeAddress1" runat="server" ontextchanged="TextBox4_TextChanged" 
           Height="20px"></asp:TextBox>
      
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
       <asp:TextBox ID="TxtHomeAddress2" runat="server"></asp:TextBox>
      
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
                                    &nbsp;</td>
                                <td>
       <asp:TextBox ID="TxtHomeAddress3" runat="server"></asp:TextBox>
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
      
       
        <asp:Label ID="Label6" runat="server" Text="PostCode"></asp:Label>
        
                                 </td>
                                <td>
       <asp:TextBox ID="TxtPostCode" runat="server"></asp:TextBox>
                                 </td>
                                
                            </tr>
                            <tr>
                                <td>
      
        <asp:Label ID="Label7" runat="server" Text="Home Phone"></asp:Label>
        
                                </td>
                                <td>

       <asp:TextBox ID="TxtHomePhone" runat="server" 
           ontextchanged="TxtHomePhone_TextChanged"></asp:TextBox>
                                </td>
                                
                            </tr>
                            <tr>
                                <td>
       
        <asp:Label ID="Label8" runat="server" Text="MobilePhone"></asp:Label>
                                </td>
                                <td>

       <asp:TextBox ID="TxtMobilePhone" runat="server"></asp:TextBox>
                                </td>
                                
                            </tr>
                            <tr>
                                <td>
        
       
        <asp:Label ID="Label9" runat="server" Text="Occupation"></asp:Label>
        
                                </td>
                                <td>

       <asp:TextBox ID="TxtOccupation" runat="server"></asp:TextBox>
                                </td>
                                
                            </tr>
                             <tr>
                                <td>
       
        <asp:Label ID="Label10" runat="server" Text="Place of Work"></asp:Label>
        
                                 </td>
                                <td>

       <asp:TextBox ID="TxtPlaceofWork" runat="server"></asp:TextBox>
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
       
        <asp:Label ID="Label11" runat="server" Text="Work Phone"></asp:Label>
        
                                 </td>
                                <td>

       <asp:TextBox ID="TxtWrkPhone" runat="server"></asp:TextBox>
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
       
        <asp:Label ID="Label12" runat="server" Text="Ethinicity"></asp:Label>
        
                                 </td>
                                <td>

       <asp:DropDownList ID="DrpEthinicity" runat="server">
           <asp:ListItem>Maori</asp:ListItem>
           <asp:ListItem>Samoan</asp:ListItem>
           <asp:ListItem>Indian</asp:ListItem>
           <asp:ListItem>Asian</asp:ListItem>
       </asp:DropDownList>
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
       
        <asp:Label ID="Label13" runat="server" Text="Iwi/Hapu"></asp:Label>
        
                                 </td>
                                <td>

       <asp:DropDownList ID="DrpIwi" runat="server">
           <asp:ListItem>AtiAwa</asp:ListItem>
           <asp:ListItem>KaiTahu</asp:ListItem>
           <asp:ListItem>Morirori</asp:ListItem>
           <asp:ListItem>Waikato</asp:ListItem>
       </asp:DropDownList>
                                 </td>
                                
                            </tr>
                             <tr>
                                <td>
       
        <asp:Label ID="Label14" runat="server" Text="ImmigrationStatus"></asp:Label>
                                 </td>
                                <td>

       <asp:DropDownList ID="drpImmigrationstatus" runat="server">
           <asp:ListItem>Citizen</asp:ListItem>
           <asp:ListItem>Resident</asp:ListItem>
           <asp:ListItem>WorkPermit</asp:ListItem>
           <asp:ListItem>Student</asp:ListItem>
           <asp:ListItem>Visitor</asp:ListItem>
       </asp:DropDownList>
                                 </td>
                                
                            </tr>
                            <tr>
                                <td>
        
       
        <asp:Label ID="VictimIdLbl" runat="server"></asp:Label>
                                </td>
                                <td>

       <asp:Button ID="BtnSave" runat="server" Text="Save" onclick="BtnSave_Click" 
           Width="42px" />
       <asp:Button ID="BtnEdit" runat="server" Text="Edit" onclick="BtnEdit_Click" />
      
                        
      
                                </td>
                                
                            </tr>
                        </table>

    
          

          </td>
      </tr>
    </table>    </td>

        </table>

</table>

    </div>
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
        <asp:BoundField DataField="DateofBirth" HeaderText="DateofBirth" 
            SortExpression="DateofBirth" />
        <asp:CommandField ShowSelectButton="True" />
    </Columns>
</asp:GridView>   
<asp:SqlDataSource ID="SqlDataSource1" runat="server" 
    ConnectionString="<%$ ConnectionStrings:VictimManagementDatabaseConnectionString2 %>" 
    SelectCommand="SELECT [FirstName], [Surname], [VictimId], [DateofBirth] FROM [Victim]">
</asp:SqlDataSource>
</form>
</body>
</html>
