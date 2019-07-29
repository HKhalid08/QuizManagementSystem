<%@ Page Language="C#" AutoEventWireup="true" CodeFile="profile.aspx.cs" Inherits="Web_Pages_PortoQuiz_Home" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <%--Starting Title Tag--%>
    <title>Porto Quiz</title>

    <%--Linking To External StyleSheet For Account--%>
    <link href="../StyleSheet/Teacher.css" rel="stylesheet" type="text/css"/>

<script>   
</script>
<%--<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>--%>
<script src="../Javascript/Jquery_Accelator.js"></script>
<script>

    $(document).ready(function ()
    {
        $("#Profile_Box_layout").hide();
        $(".show_hide").show();

        $("#lblAccountUsername").mouseover(function(){
            $("#Profile_Box_layout").fadeIn();
        });

        $("#lblAccountUsername").mouseleave(function(){
            $("#Profile_Box_layout").hide();
        });

        $("#Profile_Box_layout").mouseover(function(){
            $("#Profile_Box_layout").show();
        });

        $("#Profile_Box_layout").mouseleave(function(){
            $("#Profile_Box_layout").fadeOut();
        });

        
    });
    $(document).ready(function ()
    {  
        
       
    });

</script>

<script>
    $(document).ready(function () {
        $(".Chat_Title_Td").click(function ()
        {
            $(".Chat_Contents_Td").slideToggle(100);
            
            $(".Chat_TextBox_Td").slideToggle(100);
        }
        
        )
    });
</script>

    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <script type="text/javascript" src="../Javascript/date_time.js"></script>
    

    <style type="text/css">
        .auto-style2 
        {
            width: 600px;
        }
        .UserImage 
        {
            border-radius:80px;
        }
        .SignOut-Box
        {
            margin-left:70px;
            text-decoration:none;
        }
     
        .Profile-Box
        {
             margin-left:77px;
             text-decoration:none;
        }
        .ChnagePassword_Link
        {
            margin-left:42px;
            text-decoration:none;
        }
        .Chat-Message 
        {
            border-radius:3px;
        }
       
    </style>
</head>    
<body>
    <form id="form1" runat="server">   
<center>
    <%--Starting Base Table--%>
    <table>
        <tr>
            <td>
   <%-- --Strting Follow Us Table----%>
                <table class="FollowUs_Table">
                    <tr>
                        <td class="auto-style2">
                        </td>                       
                        <td style="text-align:right;">

                           <span class="FollowUs_Title">Follow Us&nbsp;&nbsp;&nbsp;</span>                            
                        </td>
                           
                            <td class="FollowUs_TdFacebook" title="Follow Us : Facebook">
                               <span class="FollowUs_Links">f</span>
                           </td>
                            
                            <td class="FollowUs_TdTwitter" title="Follow Us : Twitter">
                                <span class="FollowUs_Links">t</span>
                            </td>
                            
                             <td class="FollowUs_TdLinkedIn" title="Follow Us : LinkedIn">
                                <span class="FollowUs_LinkedIn">in</span>
                            </td>
                            <td class="FollowUs_TdLinkedIn" title="Follow Us : Googleplus">
                                <span class="FollowUs_GooglePlus">g</span><span class="FollowUs_GooglePlusSup">+</span>
                            </td>
    <%----Ending Follow Us Table----%>
                    </tr>
                </table>
    <%--Starting Title Table--%>
                <div class="Title_Div" style="text-align:center;">
                    
                    <br />
                    <br />
                    
                    <a href="teacher.aspx" style="text-decoration:none"><span class="Title_Porto">P O R T O</span></a>
                    &nbsp;
                    <a href="teacher.aspx" style="text-decoration:none"><span class="Title_Quiz">Q U I Z</span></a>                
                </div>
                
                <div class="Username_Div">
                    <br />
                  
                    <div class="Time">
                        <div class="SignIn-Time">

                            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblcurrent" runat="server" Font-Names="Arial" Font-Size="12px" Text="Current Time :"></asp:Label>
                                    </td>
                                    <td  id="date_time" style="font-family:Arial;font-size:12px;color:#757576;">
                                         <script type="text/javascript">window.onload = date_time('date_time');</script>
                                    </td>
                                </tr>
                            </table> 
                        </div>
                      
                        <hr />

                        <div class="Current-Time">
                            <table>
                                <tr>
                                    <td>
                                        <asp:Label ID="lblSignIn" runat="server" Font-Names="Arial" Font-Size="12px" Text="Sign In Time :"></asp:Label>
                                    </td>
                                    <td>
                                          <asp:Label ID="lblSignIn_Time" runat="server" Font-Names="Arial" Font-Size="12px" Text="Wednesday September 17 2014 6:19:09 PM" ForeColor="#757576"></asp:Label>

                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>

                    <div class="Username_Inner_Div">

                        <br />
                         <asp:Label ID="lblWelcomeNote" runat="server" Font-Names="Arial" Font-Size="14px" ForeColor="#666666" Text="Welcome !"></asp:Label>&nbsp;
                        <asp:Label ID="lblAccountUsername" runat="server" Font-Names="Arial" Font-Size="14px" ForeColor="#666666" Text="Smantha Wilson"></asp:Label>

                    </div>

                <div class="User_Profile_Box" id="Profile_Box_layout">
                       <div class="User_Profile_Box_Profile_Link_Div">

                           <br />

                           <asp:LinkButton ID="linkProfile" runat="server" CssClass="Profile-Box" Font-Names="arial" Font-Size="12px" ForeColor="gray" ToolTip="Profile">Profile</asp:LinkButton>

                       </div>
                    <hr width="80%" />

                    <div style="margin-top:10px;margin-bottom:10px;">
                        
                           <asp:LinkButton ID="linkChangePassword" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="gray" CssClass="ChnagePassword_Link" ToolTip="Change Password">Change Password</asp:LinkButton>

                       </div>
                       
                     <hr width="80%" />

                    <div style="margin-top:10px;">
                    
                           <asp:LinkButton ID="linkSignOut" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="gray" CssClass="SignOut-Box" ToolTip="Sign Out">Sign Out</asp:LinkButton>

                       </div>
                                    
                </div>
                    
                </div>               
   
                <br />

    <%--Ending Base Table--%>
               <div class="MenuBar_Layout_Div">
                      
                <table cellspacing="0" >
                    <tr>
                        <td class="MenuBar_UserImage">
                          
                            <div class="UserName_Div">
                             &nbsp;&nbsp;&nbsp;&nbsp;
                                <dx:ASPxImage ID="imgUser" runat="server" Height="80px" Width="80px" ToolTip="User Image" Cursor="pointer" CssClass="UserImage">
                                <EmptyImage Url="~/Website_Images/animal_5-wallpaper-1024x768.jpg">
                                </EmptyImage>
                                <Border BorderColor="#A5C562" BorderStyle="Solid" BorderWidth="3px" />
                                </dx:ASPxImage>

                                </div>
                            <div class="UserImage_Div" style="float:right">

                            <asp:Label ID="lblAdmin_USername" runat="server" Text="Samantha Wilson" Font-Bold="False" Font-Names="Arial" Font-Size="14px" ForeColor="#5886A4"></asp:Label>
                            <asp:Label ID="lblDesignation" runat="server" Text="Lecturar" Font-Bold="False" Font-Names="Arial" Font-Size="14px" ForeColor="gray"></asp:Label>


                            </div>
                        </td>                      

                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="teacher.aspx" id="MenuBar_Links"><div class="MenuBar_Div"><br />Home</div></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="gradebook.aspx"><div class="MenuBar_Div"><br />Grade Book</div></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="lectureschedule.aspx"><div class="MenuBar_Div"><br />Lecture Schedule</div></a>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="notice.aspx"><div class="MenuBar_Div" ><br />Notice</div></a>

                        </td>
                    </tr>
                    
                     
                    <tr>
                        <td>
                            <a href="tnotifications.aspx" style="text-decoration:none"><div class="MenuBar_Sub_Div"><br />Notifications</div></a>
                          
                            <a href="tmessages.aspx" style="text-decoration:none"><div class="MenuBar_Sub_Div"><br />Messages</div></a>
                           
                            <a href="tcalender.aspx" style="text-decoration:none"><div class="MenuBar_Sub_Div"><br />Calender</div></a>
                        </td>
                    </tr>
                </table>
                    </div>
                    
                    <div class="Contents_Title_Div">

                        <br />
                        <br />

                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblPage_Title" runat="server" Text="DASHBORAD" Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="White"></asp:Label>

                   </div>                
                   <br />

                   <div class="Contents_Proper_Div">
                     <table class="insert-form">
                          <tbody style="margin:0px;">
                              <tr>
                                  <td>
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                <ContentTemplate>

                                    <asp:GridView ID="dgprofile" runat="server" AutoGenerateColumns="False" CellPadding="4" GridLines="None" PageSize="1">
                            <Columns>
                            <asp:TemplateField>
                            <ItemTemplate>

                                
                            <table style="width:100%;">
                            <tr>
                            <td>                                                                
                               <dx:ASPxLabel ID="lblEmployeeCodebel" runat="server" Text="Employee Info" Theme="DevEx" Font-Bold="true" Font-Size="Medium"></dx:ASPxLabel>
                            </td>
                            </tr>
                            <tr>
                            <td>
                            </td>
                            </tr>
                             <tr>
                            <td align="left" style=" font-weight:bold; font-size:12pt;font-family:Arial Narrow;">
                                <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Employee Code :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Department :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Designation :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Joining Date :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                
                            </td>
                                 <td align="left" style="font-family:Arial Narrow;font-size:12pt;">
                                     <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text='<%#Eval("emp_code")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text='<%#Eval("dep_id")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text='<%#Eval("dep_id")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel8" runat="server" Text='<%#Eval("joining_date","{0:d}")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                
                                </td>

                                 <td style="width:170px;">
                                     <dx:ASPxImage ID="imgemployee" runat="server" ImageUrl='<%#Eval("Pic_name")%>' Height="100" Width="100"></dx:ASPxImage>
                                    </td>
                            </tr>                

                                <tr>
                                    <td>
                                        </td>
                                    </tr>
                    <tr>
                        <td>
                            <dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Personal Info" Theme="DevEx" Font-Bold="true" Font-Size="Medium"></dx:ASPxLabel>
                            </td>
                        </tr>
                                <tr>
                                    <td>
                                        </td>
                                    </tr>
                                 <tr>
                            <td>
                            </td>
                            </tr>
                                 <tr>
                            <td>
                            </td>
                            </tr>
                                <tr>
                                   <td align="left" style=" font-weight:bold; font-size:12pt;font-family:Arial Narrow;">
                                       <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Name :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                       <dx:ASPxLabel ID="ASPxLabel11" runat="server" Text="Gender :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                       <dx:ASPxLabel ID="ASPxLabel12" runat="server" Text="CNIC :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                       <dx:ASPxLabel ID="ASPxLabel13" runat="server" Text="Mobile No :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                       <dx:ASPxLabel ID="ASPxLabel14" runat="server" Text="Current Address :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                       <dx:ASPxLabel ID="ASPxLabel15" runat="server" Text="Email :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                
                            </td>
                                 <td align="left" style="font-family:Arial Narrow;font-size:12pt;">
                                     <dx:ASPxLabel ID="ASPxLabel16" runat="server" Text='<%#Eval("name")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel17" runat="server" Text='<%#Eval("gender")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel18" runat="server" Text='<%#Eval("nic")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel19" runat="server" Text='<%#Eval("mobile")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel20" runat="server" Text='<%#Eval("c_address")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel21" runat="server" Text='<%#Eval("email")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                
                                </td>

                                    <td align="left" style=" font-weight:bold; font-size:12pt;font-family:Arial Narrow;">
                                        <dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="Father Name :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                        <dx:ASPxLabel ID="ASPxLabel23" runat="server" Text="Date of Birth :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                        <dx:ASPxLabel ID="ASPxLabel24" runat="server" Text="Nationality :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                        <dx:ASPxLabel ID="ASPxLabel25" runat="server" Text="Phone No :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                        <dx:ASPxLabel ID="ASPxLabel26" runat="server" Text="Permanent Address :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                
                                
                            </td>
                                 <td align="left" style="font-family:Arial Narrow;font-size:12pt;">
                                     <dx:ASPxLabel ID="ASPxLabel27" runat="server" Text='<%#Eval("father_name")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel28" runat="server" Text='<%#Eval("dob","{0:d}")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel29" runat="server" Text='<%#Eval("nationality")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel30" runat="server" Text='<%#Eval("phone")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                     <dx:ASPxLabel ID="ASPxLabel31" runat="server" Text='<%#Eval("p_address")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                
                                </td>
                                    </tr>
                                <tr>
                                    <td>
                                        </td>
                                    </tr>

                                <tr>
                                    <td>
                                        <dx:ASPxLabel ID="ASPxLabel32" runat="server" Text="Acadamic Info" Theme="DevEx" Font-Bold="true" Font-Size="Medium"></dx:ASPxLabel>
                                        </td>
                                    </tr
                 <tr>
                                    <td>
                                        
                                        </td>
                                    </tr
                               
                                 <tr>
                                    <td align="left" style=" font-weight:bold; font-size:12pt;font-family:Arial Narrow;">
                                        <dx:ASPxLabel ID="ASPxLabel33" runat="server" Text="Qualification :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                        <dx:ASPxLabel ID="ASPxLabel34" runat="server" Text="About :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                
                                        </td>
                                     <td align="left" style="font-family:Arial Narrow;font-size:12pt;">
                                         <dx:ASPxLabel ID="ASPxLabel36" runat="server" Text='<%#Eval("qualification")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                         <dx:ASPxLabel ID="ASPxLabel37" runat="server" Text='<%#Eval("about")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                
                                         </td>

                                      <td align="left" style=" font-weight:bold; font-size:12pt;font-family:Arial Narrow;">
                                          <dx:ASPxLabel ID="ASPxLabel35" runat="server" Text="Specialization :" Theme="DevEx" Font-Bold="True" Font-Size="Small"></dx:ASPxLabel><br/>
                                
                                          </td>
                                     <td align="left" style="font-family:Arial Narrow;font-size:12pt;">
                                         <dx:ASPxLabel ID="ASPxLabel38" runat="server" Text='<%#Eval("specialization")%>' Theme="DevEx"></dx:ASPxLabel><br/>
                                
                                         </td>
                                    </tr>
                            </table>

                                                </ItemTemplate>
                                            </asp:TemplateField>
                                        </Columns>
                                    </asp:GridView>
                                    <rowstyle BackColor="#EFF3FB"/>
                                    </ContentTemplate>
                            </asp:UpdatePanel>

                                      </td>
                                  </tr>
                          </tbody>
                          </table>
                   </div>
                    

   <%--Ending MenuBar Base TD--%>
                       </td>
                    </tr>
                </table>    
</center>
</form>
</body>
</html>
