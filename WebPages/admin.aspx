<%@ Page Language="C#" AutoEventWireup="true" CodeFile="admin.aspx.cs" Inherits="Web_Pages_PortoQuiz_Home" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <%--Starting Title Tag--%>
    <title>Porto Quiz</title>

    <%--Linking To External StyleSheet For Account--%>
    <link href="../StyleSheet/Admin.css" rel="stylesheet" type="text/css"/>
    <%--<link href="../StyleSheet/Admin2.css" rel="stylesheet" type="text/css"/>--%>

<script>   
</script>
    <%--<script src="http://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>--%>
<script src="../Javascript/Jquery_Accelator.js"></script>

<script>

    $(document).ready(function () {
        $("#Profile_Box_layout").hide();
        $(".show_hide").show();

        $("#lblAccountUsername").mouseover(function () {
            $("#Profile_Box_layout").fadeIn();
        });

        $("#lblAccountUsername").mouseleave(function () {
            $("#Profile_Box_layout").hide();
        });

        $("#Profile_Box_layout").mouseover(function () {
            $("#Profile_Box_layout").show();
        });

        $("#Profile_Box_layout").mouseleave(function () {
            $("#Profile_Box_layout").fadeOut();
        });

});

</script>

<script>
    $(document).ready(function ()
    {
        $(".Chat_Title_Td").hide();
        $(".Chat_Title_Td").click(function () {


            $(".Chat_Contents_Td").slideToggle(100);
            $(".Chat_Message_Button").slideToggle(100);
            $(".Chat_TextBox_Td").slideToggle(100);
            $(".Chat_Title_Td_Settings").slideToggle(100);


        }

        )
    });
</script>
 <script>
     $(document).ready(function () {
         $(".Chat_Settings_Contents_Div").hide();

         $(".Setting_Image").click(function () {


             $(".Chat_Settings_Contents_Div").slideToggle(100);



         }

            )
     });
</script>

 <script>
     $(document).ready(function () {
         $(".Chat_Box_Div").hide();

         $(".Chat_Close_Button").click(function () {


             $(".Chat_Box_Div").hide();



         }

            )
     });
</script>

<script>

    $(document).ready(function () {


        $(".Online_Chat_Title_Td").click(function () {

            $(".Chat_Contents_Td_Online").slideToggle(100);
            $(".Online_Chat_Title_Td_Settings").slideToggle(100);



        }

        )
    });

</script>
 
    <script>
        $(document).ready(function () {
            $(".Online_Chat_Settings_Contents_Div").hide();

            $(".Online_Setting_Image").click(function () {


                $(".Online_Chat_Settings_Contents_Div").slideToggle(100);



            }

               )
        });
    </script>
    
    <script>
        $(document).ready(function () {
           
            $(".Chat-Tr").click(function ()
            {
                var GettingID = this.title;

                document.getElementById("HEmployeeCode").value = GettingID;
                
                var GettingHiddenValue = document.getElementById("HEmployeeCode").value;

                $('.Show_Username').text(GettingHiddenValue);
                $('.Chat_Box_Div').show();
                $('.Chat_Title_Td_Settings').show();
                $('.Chat_Contents_Td').show();
                $('.Chat_TextBox_Td').show();
                $('.Chat_Message_Button').show();
                $('.Chat_Title_Td').show();
            }

               )
        });
    </script> 

    
    <script>
        function GettingEmployeeCodeFunction()
        {

            var GettingEmployeeCode = document.getElementById("HEmployeeCode").value;
            document.getElementById("HEmployeeCode").value = GettingEmployeeCode;
            
        }
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
         <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
  
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
                    
                    <a href="admin.aspx" style="text-decoration:none"><span class="Title_Porto">P O R T O</span></a>
                    &nbsp;
                    <a href="admin.aspx" style="text-decoration:none"><span class="Title_Quiz">Q U I Z</span></a>                
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
                                          <asp:Label ID="lblSignIn_Time" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="#757576"></asp:Label>

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

                           <asp:LinkButton ID="linkProfile" runat="server" CssClass="Profile-Box" OnClick="linkProfile_Click" Font-Names="arial" Font-Size="12px" ForeColor="gray" ToolTip="Profile">Profile</asp:LinkButton>

                       </div>
                    <hr width="80%" />

                    <div style="margin-top:10px;margin-bottom:10px;">
                        
                           <asp:LinkButton ID="linkChangePassword" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="gray" CssClass="ChnagePassword_Link" ToolTip="Change Password" OnClick="linkChangePassword_Click1">Change Password</asp:LinkButton>

                       </div>
                       
                     <hr width="80%" />

                    <div style="margin-top:10px;">
                    
                           <asp:LinkButton ID="linkSignOut" runat="server" Font-Names="Arial" OnClick="linkSignOut_Click" Font-Size="12px" ForeColor="gray" CssClass="SignOut-Box" ToolTip="Sign Out">Sign Out</asp:LinkButton>

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
                                <Border BorderColor="#FF503F" BorderStyle="Solid" BorderWidth="3px" />
                                </dx:ASPxImage>

                                </div>
                            <div class="UserImage_Div" style="float:right">

                            <asp:Label ID="lblAdmin_USername" runat="server" Text="Samantha Wilson" Font-Bold="False" Font-Names="Arial" Font-Size="14px" ForeColor="#5886A4"></asp:Label>
                            <br />
                                <asp:Label ID="lblDesignation" runat="server" Text="Administrator" Font-Bold="False" Font-Names="Arial" Font-Size="14px" ForeColor="gray"></asp:Label>


                            </div>
                        </td>                      

                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="employee.aspx" id="MenuBar_Links"><div class="MenuBar_Div"><br />Employee</div></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="student.aspx"><div class="MenuBar_Div"><br />Student</div></a>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="assignlectures.aspx"><div class="MenuBar_Div"><br />Assign Lecture</div></a>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="courses.aspx"><div class="MenuBar_Div" ><br />Courses</div></a>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="schedule.aspx"><div class="MenuBar_Div"><br />Schedule</div></a>

                        </td>
                    </tr>
                     <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="notice.aspx"><div class="MenuBar_Div"><br />Notice</div></a>

                        </td>
                    </tr>
                     <tr>
                        <td>
                            <a class="MenuBar_Anchor" href="userrights.aspx"><div class="MenuBar_Div"><br />User Rights</div></a>

                        </td>
                    </tr>
                    <tr>
                        <td>
                            <a href="notifications.aspx" style="text-decoration:none"><div class="MenuBar_Sub_Div"><br />Notifications</div></a>
                          
                            <a href="viewquestion.aspx" style="text-decoration:none"><div class="MenuBar_Sub_Div"><br />View Questions</div></a>
                           
                            <a href="calender.aspx" style="text-decoration:none"><div class="MenuBar_Sub_Div"><br />Calender</div></a>
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
                      <div class="Contents_Link_View">
                           <div class="Contents_Link_View_Icon">

                           </div>

                           <br />
                           <br />
                           
                           <a class="Contents_Link_Anchor" href="viewprograms.aspx" style="text-decoration:none" id="View_Tooltip" tooltip="You Can View Programs Here">&nbsp;&nbsp;&nbsp;<strong>View Programs</strong></a>

                       </div>
                       
                       <div class="Contents_Link_New">
                           <div class="Contents_Link_New_Icon">                              
                           <img src="../Website_Images/AddNew_Icon.gif" />
                           
                           </div>
                           <br />
                           <br />
                           
                           <a class="Contents_Link_Anchor" href="programs.aspx" style="text-decoration:none" id="New_Tooltip" tooltip="Add New Programs Here">&nbsp;&nbsp;&nbsp;<strong>Add Programs</strong></a>
                       
                       </div>
                       
                       <div class="Contents_Link_Deleted">
                           <div class="Contents_Link_Deleted_Icon">
                           </div>
                           <br />
                           <br />
                           
                           <a class="Contents_Link_Anchor" href="viewsession.aspx" style="text-decoration:none" id="Deleted_Tootip" tooltip="You Can View Session Here">&nbsp;&nbsp;&nbsp;<strong>View Session</strong></a>

                       </div>
                       
                       <div class="Contents_Link_Deleted">
                           <div class="Contents_Link_forth_Icon">
                               
                           </div>
                           <br />
                           <br />
                           
                           <a class="Contents_Link_Anchor" id="Div4" href="session.aspx" style="text-decoration:none" id="A1" tooltip="Add New Session Here">&nbsp;&nbsp;&nbsp;<strong>Add Session</strong></a>

                       </div> 
                       

                       <div class="Contents_Link_View">
                           <div class="Contents_Link_View_Icon">

                           </div>

                           <br />
                           <br />
                           
                           <a class="Contents_Link_Anchor" href="viewdepartment.aspx" style="text-decoration:none" id="A1" tooltip="You Can View Department Here">&nbsp;&nbsp;&nbsp;<strong>View Department</strong></a>

                       </div>
                       
                       <div class="Contents_Link_New">
                           <div class="Contents_Link_New_Icon">                              
                           <img src="../Website_Images/AddNew_Icon.gif" />
                           
                           </div>
                           <br />
                           <br />
                           
                           <a class="Contents_Link_Anchor" href="department.aspx" style="text-decoration:none" id="A2" tooltip="Add New Departments Here">&nbsp;&nbsp;&nbsp;<strong>Add Department</strong></a>
                       
                       </div>
                       
                       <div class="Contents_Link_Deleted">
                           <div class="Contents_Link_Deleted_Icon">
                           </div>
                           <br />
                           <br />
                           
                           <a class="Contents_Link_Anchor" href="viewdesignation.aspx" style="text-decoration:none" id="A3" tooltip="You Can View Designation Here">&nbsp;&nbsp;&nbsp;<strong>View Designation</strong></a>

                       </div>
                       
                       <div class="Contents_Link_Deleted">
                           <div class="Contents_Link_forth_Icon">
                           </div>
                           <br />
                           <br />
                           
                           <a class="Contents_Link_Anchor" id="A4" href="designation.aspx" style="text-decoration:none" id="A1" tooltip="Add New Designation Here">&nbsp;&nbsp;&nbsp;<strong>Add Designation</strong></a>

                       </div>
                   </div>
                    

   <%--Ending MenuBar Base TD--%>
                       </td>
                    </tr>
                </table>                
                      
    <%--<div class="Chat_Box_Div">
      
       
        <table>
          <tr>
              <td class="Chat_Title_Td">
                  &nbsp;&nbsp;&nbsp;&nbsp; Chat Message Panel 
              </td>
              <td class="Chat_Close_Button" title="Close Chat Bar">
                 &nbsp; X
              </td>
              
          </tr>
            <tr>

                
                <td class="Online_Chat_Title_Td_UserName">
                
                   
                    <span class="Show_Username" style="margin-left:15px;font-family:Arial;font-size:12px;color:white;"></span>
                    <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <%--<ContentTemplate>
                        &nbsp;&nbsp;&nbsp;&nbsp;<span id="lblChatUSerName" title=""></span>
                    </ContentTemplate>
                    --%>    
                <%--</asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                
                <td class="Chat_Title_Td_Settings" align="right" valign="Middle" hidden>
                  <img src="../Website_Images/Chat_Settings.gif" style="width:20px;height:20px;" class="Setting_Image" title="Settings" />--%>
                
               <%-- <div class="Chat_Settings_Contents_Div">
                    <div class="Chat_Setting_Contents_Title_Div">
                         <span class="Settings_Panel">Settings Panel</span>
                    </div>
                    
                    <table class="Setings_Contents_Table">
                        <tr>
                            <td>

                            </td>
                        </tr>
                        <tr>
                            <td style="width:15px;">

                            </td>
                            
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                    <ContentTemplate>
                                        <dx:ASPxCheckBox ID="chk_Settings_Offline" runat="server" Text="Hide Offline Messages" Theme="Metropolis" ForeColor="#666666">
                                        </dx:ASPxCheckBox>
                                    </ContentTemplate>
                                      
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                          <tr>
                              <td colspan="2">
                                  <hr />
                              </td>
                          </tr>
                         <tr>
                             <td style="width:15px;">

                             </td>
                            <td>
                                <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                    <ContentTemplate>
                                        <dx:ASPxCheckBox ID="chk_Block_Messages" runat="server" Text="Block All Messages" Theme="Metropolis" ForeColor="#666666">
                                        </dx:ASPxCheckBox>
                                    </ContentTemplate>
                                      
                                </asp:UpdatePanel>
                            </td>
                        </tr>
                    </table>
                
                </div>
                
                </td>
                

              
               

                    

            </tr>
            <tr>

               <td class="Chat_Contents_Td" hidden>
                   <input type="hidden" runat="server" id="HEmployeeCode" value="" />
                    
                   <div style="max-height:200px; overflow:scroll;">
                   <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                       <ContentTemplate>
                   <asp:GridView ID="dgmessage" runat="server" AutoGenerateColumns="False" GridLines="None" ShowHeader="False">

                       <Columns>
                           <asp:TemplateField>
                               <ItemTemplate>

                                   
                                   <div>
                                   <span style="font-family:Arial;font-size:12px;background-color:#fbf69f;padding-top:10px;padding-bottom:10px;">
                                        <%#Eval("message")%>
                                   
                                   </span>    
                                   </div>
                                   
                                   <span style="font-family:Arial;font-size:10px;color:black;margin-left:10px;">
                                       <%#Eval("insert_date")%>
                                   </span>
                                   
                                   <div style="height:20px;">

                                   </div>

                               </ItemTemplate>
                           </asp:TemplateField>
                       </Columns>
                   </asp:GridView>
                           </ContentTemplate>
                    </asp:UpdatePanel>

                    </div>
              </td>

            </tr>
             <tr>

              <td class="Chat_TextBox_Td" align="center" hidden>
                   <dx:ASPxTextBox ID="txtChat" runat="server" Width="220px" Font-Names="Arial" Font-Size="12px" NullText="Type Message Here ..." Theme="MetropolisBlue" BackColor="#EDEDED" Height="35px" CssClass="Chat-Message"></dx:ASPxTextBox>
                   
              </td>

            </tr>

            <tr>
                <td class="Chat_Message_Button" hidden>

                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                        <ContentTemplate>

                            <asp:Button ID="btnSendMessage" BackColor="#EDEDED" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="#666666" Height="30px" Text="Send Message" Width="220px" OnClick="btnSendMessage_Click" OnClientClick="GettingEmployeeCodeFunction();"></asp:Button>

                            
                        </ContentTemplate>
                    </asp:UpdatePanel>

                </td>
            </tr>
            
      </table>
      
    </div>        

    
    <div class="Online_Chat_Box_Div">
      
       
        <table>
          <tr>
              <td class="Online_Chat_Title_Td">
                  &nbsp;&nbsp;&nbsp;&nbsp;Online Persons (Chat)
              </td>
            
              
          </tr>
            <tr>
                <td class="Online_Chat_Title_Td_Settings" align="right" valign="Middle" hidden>
                  <img src="../Website_Images/Chat_Settings.gif" style="width:20px;height:20px;" class="Online_Setting_Image" title="Settings" />
                
                
                    
                     <div class="Online_Chat_Settings_Contents_Div">
                    <div class="Online_Chat_Setting_Contents_Title_Div">
                         <span class="Settings_Panel">Settings Panel</span>
                    </div>
                    
                    <table class="Online_Setings_Contents_Table">
                        <tr>
                            
                            <td style="width:7px;">

                            </td>

                            <td>
                                
                                 <asp:UpdatePanel ID="UpdatePanel6" runat="server">
                                    <ContentTemplate>
                                        <dx:ASPxCheckBox ID="chkShowOnline" runat="server" Text="Show Online Persons Only" Theme="Metropolis" ForeColor="#666666">
                                        </dx:ASPxCheckBox>
                                    </ContentTemplate>
                                      
                                </asp:UpdatePanel>

                            </td>
                        </tr>
                                         
                    </table>
                
                </div>
               



                
                </td>
                

              
               

                    

            </tr>
            <tr>

               <td class="Chat_Contents_Td_Online" style="vertical-align:top;" hidden>

                   <div style="max-height:250px; overflow:scroll;">
                   
                   <asp:GridView ID="gridview_Online_Persons" runat="server" CssClass="GridView_Online_Persons" AllowSorting="True" ShowHeader="false" AutoGenerateColumns="False" GridLines="None">
                       
                       <Columns>
                           <asp:TemplateField>
                               <ItemTemplate>
                                   <table>
                                       <tr class="Chat-Tr" title='<%#Eval("Emp_code")%>'>
                                           <td>
                                               <dx:ASPxImage ID="imgemployee"  runat="server" ImageUrl='<%#Eval("Pic_name")%>' Height="30" Width="30"></dx:ASPxImage>
                                           </td>
                                           <td>
                                               <span style="font-family:Arial;font-size:12px;color:blue;"><%#Eval("Name")%></span>
                                               <br />
                                               <span style="font-family:Arial;font-size:10px;" class="Employee-Code" title='<%#Eval("Emp_code")%>' value='<%#Eval("Emp_code")%>'><%#Eval("Emp_code")%></span>
                                               
                                           </td>
                                           <td>
                                              
                                               <span style="font-family:Arial;font-size:10px;"><%#Eval("Online")%></span>
                                               
                                           </td>
                                       </tr>
                                       
                                   </table>
                               </ItemTemplate>
                           </asp:TemplateField>
                       </Columns>
                       
                       <RowStyle Height="20px" />
                   </asp:GridView>

                   </div>

              </td>

            </tr>
            
           </table>
      
    </div>--%>
   
    
</center>
               
</form>
</body>
</html>
