<%@ Page Language="C#" AutoEventWireup="true" CodeFile="assignments.aspx.cs" Inherits="Web_Pages_PortoQuiz_Home" %>

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

                           <asp:LinkButton ID="linkProfile" runat="server" CssClass="Profile-Box" Font-Names="arial" Font-Size="12px" ForeColor="gray" ToolTip="Profile" OnClick="linkProfile_Click">Profile</asp:LinkButton>

                       </div>
                    <hr width="80%" />

                    <div style="margin-top:10px;margin-bottom:10px;">
                        
                           <asp:LinkButton ID="linkChangePassword" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="gray" CssClass="ChnagePassword_Link" ToolTip="Change Password" OnClick="linkChangePassword_Click">Change Password</asp:LinkButton>

                       </div>
                       
                     <hr width="80%" />

                    <div style="margin-top:10px;">
                    
                           <asp:LinkButton ID="linkSignOut" runat="server" Font-Names="Arial" Font-Size="12px" ForeColor="gray" CssClass="SignOut-Box" ToolTip="Sign Out" OnClick="linkSignOut_Click">Sign Out</asp:LinkButton>

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
                          
                            <a href="tmessages.aspx" style="text-decoration:none"><div class="MenuBar_Sub_Div"><br />Collection</div></a>
                           
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

                               <tr style="margin-top:-10px;padding-top:-10px">
                                   <td colspan:4 style="padding:0px 0px 0px 0px; text-align:center; margin:0px 0px 0px 0px">

                                       <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Add Assignments" Theme="DevEx">
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
                                   <td style="text-align:right;" class="auto-style3">
                                        <dx:ASPxLabel ID="lblEmployeeCodebel4" runat="server" Text="Course Code :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td class="auto-style4">
                                        <dx:ASPxTextBox ID="txtcoursecode" runat="server" Theme="DevEx" Width="170px" ReadOnly="True">
                                       </dx:ASPxTextBox>
                                   </td>
                                   <td style="text-align:right;" class="auto-style3">
                                        <dx:ASPxLabel ID="lblEmployeeCodebel5" runat="server" Text="Course Title :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td class="auto-style4">
                                        <dx:ASPxTextBox ID="txtcoursetitle" runat="server" Theme="DevEx" Width="225px" Height="19px" ReadOnly="True">
                                       </dx:ASPxTextBox>
                                   </td>
                               </tr>

                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="lbltopic" runat="server" Text="Topic :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td>
                                        <dx:ASPxTextBox ID="txttopic" runat="server" Theme="DevEx" Width="170px">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Vlidate_quiz">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                       </dx:ASPxTextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txttopic" ErrorMessage="Enter Topic Name" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="lbllesson" runat="server" Text="Lesson :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td>
                                        <dx:ASPxTextBox ID="txtlesson" runat="server" Theme="DevEx" Width="170px">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Vlidate_quiz">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                       </dx:ASPxTextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtlesson" ErrorMessage="Enter Lesson Name" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                               </tr>

                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="lbltotalmarks" runat="server" Text="Total Marks :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td>
                                        <dx:ASPxTextBox ID="txttotalmarks" runat="server" Theme="DevEx" Width="170px">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Vlidate_quiz">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                       </dx:ASPxTextBox>
                                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txttotalmarks" ErrorMessage="Enter Numeric Value Only" ForeColor="Red" ValidationExpression="^[0-9]+$"></asp:RegularExpressionValidator>
                                   </td>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="lblduedate" runat="server" Text="Due Date :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td>
                                       <dx:ASPxDateEdit ID="dtduedate" runat="server" Theme="DevEx">
                                       </dx:ASPxDateEdit>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="dtduedate" ErrorMessage="Enter Date" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                               </tr>
                               <tr>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        <dx:ASPxLabel ID="lblassignment" runat="server" Text="Assignment :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td>
                                        <asp:FileUpload ID="FileUpload1" runat="server" />
                                   </td>
                                   <td style="height:20px;width:150px;text-align:right;">
                                        &nbsp;</td>
                                   <td>
                                        &nbsp;</td>
                               </tr>

                                <tr>
                                   <td>
                                        
                                       &nbsp;</td>
                                    <td>
                                        
                                        <dx:ASPxLabel ID="lblresult" runat="server" Theme="DevEx"></dx:ASPxLabel>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="FileUpload1" ErrorMessage="Select File" ForeColor="Red"></asp:RequiredFieldValidator>
                                    </td>
                                     <td>
                                        
                                         &nbsp;</td>
                                     <td>
                                        
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
                                   <dx:ASPxButton ID="BtnNew" runat="server" Text="New" Theme="DevEx" OnClick="BtnNew_Click" style="height: 23px" CausesValidation="False"></dx:ASPxButton>
                                   </td>
                               <td style="width:65px">
                                   <dx:ASPxButton ID="BtnClear" runat="server" Text="Clear" Theme="DevEx" OnClick="BtnClear_Click" CausesValidation="False"></dx:ASPxButton>
                                   </td>
                               <td style="width:272px">
                                   </td>
                               </tr>
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
