<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addcourses.aspx.cs" Inherits="Web_Pages_PortoQuiz_Home" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxUploadControl" tagprefix="dx1" %>

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
                            <asp:ScriptManager ID="ScriptManager1" runat="server">
                            </asp:ScriptManager>
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

                           <asp:LinkButton ID="linkProfile" runat="server" CssClass="Profile-Box" Font-Names="arial" Font-Size="12px" ForeColor="gray" ToolTip="Profile" CausesValidation="false" OnClick="linkProfile_Click">Profile</asp:LinkButton>

                       </div>
                    <hr width="80%" />

                    <div style="margin-top:10px;margin-bottom:10px;">
                        
                           <asp:LinkButton ID="linkChangePassword" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="gray" CssClass="ChnagePassword_Link" ToolTip="Change Password" CausesValidation="false" OnClick="linkChangePassword_Click">Change Password</asp:LinkButton>

                       </div>
                       
                     <hr width="80%" />

                    <div style="margin-top:10px;">
                    
                           <asp:LinkButton ID="linkSignOut" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="gray" CssClass="SignOut-Box" ToolTip="Sign Out" CausesValidation="false" OnClick="linkSignOut_Click">Sign Out</asp:LinkButton>

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
                      
<asp:UpdatePanel ID="UpdatePanel5" runat="server">
    <ContentTemplate>
                      <table class="insert-form">
                           <tbody style="margin:0px;">

                               <tr style="margin-top:-10px;padding-top:-10px">
                                   <td colspan:4 style="padding:0px 0px 0px 0px; margin:0px 0px 0px 0px">

                                       <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Courses :" Theme="DevEx">
                                       </dx:ASPxLabel>

                                       </td>
                                   </tr>

                               <tr style="margin-top:-10px;padding-top:-10px">
                                   <td colspan:4 style="padding:0px 0px 0px 0px; margin:0px 0px 0px 0px">

                                       &nbsp;</td>
                                   </tr>

                               <tr style="margin-top:-10px;padding-top:-10px">
                                   <td colspan:4 style="padding:0px 0px 0px 0px; margin:0px 0px 0px 0px">

                                       &nbsp;</td>
                                   </tr>

                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Course Code :" Theme="DevEx">
                                        </dx:ASPxLabel>
                                   </td>
                                   <td class="auto-style3">
                                        <dx:ASPxTextBox ID="txtcoursecode" runat="server" Theme="DevEx" Width="170px">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="validate_group">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                   </td>
                                   <td class="auto-style3" style="text-align:left">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtcoursecode" ErrorMessage="Enter Course Code" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                               </tr>
                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text="Course Title :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td class="auto-style3">
                                        <dx:ASPxTextBox ID="txtcoursetitle" runat="server" Width="170px" Theme="DevEx">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="validate_group">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                   </td>
                                   <td class="auto-style3">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtcoursetitle" ErrorMessage="Enter Course Title" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                               </tr>
                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text="Short Name :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td class="auto-style3">
                                        <dx:ASPxTextBox ID="txtshortname" runat="server" Width="170px" Theme="DevEx">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="validate_group">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                   </td>
                                   <td class="auto-style3">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtshortname" ErrorMessage="Enter ShortName" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                               </tr>
                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;" rowspan="2">
                                        <dx:ASPxLabel ID="ASPxLabel6" runat="server" Text="Credit Hours :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td class="auto-style3" rowspan="2">
                                        <dx:ASPxTextBox ID="txtcredithours" runat="server" Width="170px" Theme="DevEx">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="validate_group">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                   </td>
                                   <td class="auto-style3">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtcredithours" ErrorMessage="Enter Credit Hours" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                                   <td class="auto-style3" rowspan="2">
                                        &nbsp;</td>
                               </tr>

                               <tr>
                                   <td class="auto-style3">
                                       <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtcredithours" ErrorMessage="Enter Numeric Value Only" ForeColor="Red" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                                   </td>
                               </tr>

                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text="Cetegory :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td class="auto-style3">
                                        <dx:ASPxTextBox ID="txtcetegory" runat="server" Width="170px" Theme="DevEx">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="validate_group">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxTextBox>
                                   </td>
                                   <td class="auto-style3">
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtcetegory" ErrorMessage="Enter Category" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                               </tr>

                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        &nbsp;</td>
                                   <td class="auto-style3">
                                       
                                        <dx:ASPxLabel ID="lblresult" runat="server" Theme="DevEx">
                                        </dx:ASPxLabel>
                                       
                                   </td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                               </tr>

                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        &nbsp;</td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                                   <td class="auto-style3">
                                        &nbsp;</td>
                               </tr>

                               </tbody>
                           </table>
                       <table>
                           <tr>
                               <td style="width:272px">
                                   </td>
                               <td style="width:65px">
                                    <dx:ASPxButton ID="BtnSave" runat="server" Text="Save" Theme="DevEx" OnClick="BtnSave_Click"></dx:ASPxButton>
                                   </td>
                               <td style="width:65px">
                                   <dx:ASPxButton ID="BtnNew" runat="server" Text="New" Theme="DevEx" OnClick="BtnNew_Click"></dx:ASPxButton>
                                   </td>
                               <td style="width:65px">
                                   <dx:ASPxButton ID="BtnClear" runat="server" Text="Clear" Theme="DevEx" OnClick="BtnClear_Click"></dx:ASPxButton>
                                   </td>
                               <td style="width:272px">
                                   </td>
                               </tr>
                       </table> 
                        </ContentTemplate>
                       </asp:UpdatePanel>
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
                <asp:UpdatePanel ID="UpdatePanel4" runat="server">
                    <ContentTemplate>
                        &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="lblChatUSerName" runat="server" CssClass="Chat_Panel_Username" Text="Sarosh Rasheed" Font-Names="Arial" Font-Size="10pt" ForeColor="White"></asp:Label>
                    </ContentTemplate>
                        
                </asp:UpdatePanel>
                </td>
            </tr>
            <tr>
                
                <td class="Chat_Title_Td_Settings" align="right" valign="Middle" hidden>
                  <img src="../Website_Images/Chat_Settings.gif" style="width:20px;height:20px;" class="Setting_Image" title="Settings" />
                
                <div class="Chat_Settings_Contents_Div">
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
                            <dx:ASPxButton ID="btnSendMessage" runat="server" BackColoR="#EDEDED" CssClass="Chat-Message" Visible="false" Cursor="Pointer" Font-Names="Arial" Font-Size="12px" ForeColor="#666666" Height="30px" Text="Send Message" Theme="MetropolisBlue" ToolTip="Send Message" Width="220px">
                                <HoverStyle BackColor="#FF503F" Font-Names="Arial" ForeColor="White">
                                    <Border BorderStyle="None" />
                                </HoverStyle>
                                <Border BorderColor="#CACACA" BorderStyle="Solid" BorderWidth="1px" />
                            </dx:ASPxButton>
                        </ContentTemplate>
                    </asp:UpdatePanel>

                </td>
            </tr>
            
      </table>
      
    </div>   --%>     

    
   <%-- <div class="Online_Chat_Box_Div">
      
       
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

               <td class="Chat_Contents_Td_Online" hidden>

                   
                   <asp:GridView ID="gridview_Online_Persons" runat="server" CssClass="GridView_Online_Persons" AllowSorting="True" AutoGenerateColumns="False">
                       <RowStyle Height="20px" />
                   </asp:GridView>



              </td>

            </tr>
            
           </table>
      
    </div>--%>
   
    
</center>
</form>
</body>
</html>
