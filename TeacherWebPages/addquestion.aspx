<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addquestion.aspx.cs" Inherits="Web_Pages_PortoQuiz_Home" %>

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
       
        .auto-style4
        {
            height: 20px;
        }
       
        .auto-style7
        {
            width: 97px;
        }
        .auto-style16
        {
            width: 146px;
        }
        .auto-style17
        {
            height: 20px;
            width: 146px;
        }
       
        .auto-style18
        {
            height: 20px;
            width: 66px;
        }
        .auto-style19
        {
            width: 66px;
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

                           <asp:LinkButton ID="linkProfile" runat="server" CssClass="Profile-Box" CausesValidation="false" Font-Names="arial" Font-Size="12px" ForeColor="gray" ToolTip="Profile" OnClick="linkProfile_Click">Profile</asp:LinkButton>

                       </div>
                    <hr width="80%" />

                    <div style="margin-top:10px;margin-bottom:10px;">
                        
                           <asp:LinkButton ID="linkChangePassword" runat="server" Font-Names="Arial" CausesValidation="false" Font-Size="12px" ForeColor="gray" CssClass="ChnagePassword_Link" ToolTip="Change Password" OnClick="linkChangePassword_Click">Change Password</asp:LinkButton>

                       </div>
                       
                     <hr width="80%" />

                    <div style="margin-top:10px;">
                    
                           <asp:LinkButton ID="linkSignOut" runat="server" Font-Names="Arial" Font-Size="12px" CausesValidation="false" ForeColor="gray" CssClass="SignOut-Box" ToolTip="Sign Out" OnClick="linkSignOut_Click">Sign Out</asp:LinkButton>

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
                       <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                       <asp:UpdatePanel ID="UpdatePanel5" runat="server">
                        <ContentTemplate>
                    <table class="insert-form">
                           <tbody style="margin:0px;">

                               <tr style="margin-top:-10px;padding-top:-10px">
                                   <td colspan:4 style="padding:0px 0px 0px 0px; text-align:center; margin:0px 0px 0px 0px" class="auto-style16">

                                       <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text="Add Questions" Theme="DevEx">
                                       </dx:ASPxLabel>

                                       </td>
                                   </tr>

                               <tr style="margin-top:-10px;padding-top:-10px">
                                   <td colspan:4 style="padding:0px 0px 0px 0px; margin:0px 0px 0px 0px" class="auto-style16">

                                       &nbsp;</td>
                                   </tr>

                               <tr style="margin-top:-10px;padding-top:-10px">
                                   <td colspan:4 style="padding:0px 0px 0px 0px; margin:0px 0px 0px 0px" class="auto-style16">

                                       &nbsp;</td>
                                   </tr>

                               <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        <dx:ASPxLabel ID="lblEmployeeCodebel" runat="server" Text="CourseCode :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td colspan="5">
                                        <dx:ASPxTextBox ID="txtcoursecode" runat="server" Theme="DevEx" Width="170px" ReadOnly="True">
                                       </dx:ASPxTextBox>
                                   </td>
                                   <td style="text-align:right;" class="auto-style18">
                                        <dx:ASPxLabel ID="lblEmployeeCodebel0" runat="server" Text="Title :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td>
                                        <dx:ASPxTextBox ID="txtcoursetitle" runat="server" Theme="DevEx" Width="235px" ReadOnly="True" Height="17px">
                                       </dx:ASPxTextBox>
                                   </td>
                               </tr>

                               <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        <dx:ASPxLabel ID="lblEmployeeCodebel2" runat="server" Text="AnswerType :" Theme="DevEx"></dx:ASPxLabel>
                                   </td>
                                   <td colspan="5">
                                       <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                              <ContentTemplate>
                                        <dx:ASPxComboBox ID="cbanswertype" runat="server" AutoPostBack="True" NullText="--Select--" OnSelectedIndexChanged="cbanswertype_SelectedIndexChanged" Theme="DevEx">
                                            <Items>
                                                <dx:ListEditItem Text="Objective" Value="Objective" />
                                                <dx:ListEditItem Text="Subjective" Value="Subjective" />
                                            </Items>
                                        </dx:ASPxComboBox>
                                                  </ContentTemplate>
                                          </asp:UpdatePanel>
                                   </td>
                                   <td colspan="2">
                                        &nbsp;</td>
                               </tr>
                               <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Topic :" Theme="DevEx">
                                        </dx:ASPxLabel>
                                   </td>
                                   <td colspan="5">
                                        <dx:ASPxTextBox ID="txttopic" runat="server" Theme="DevEx" Width="170px">
                                            
                                        </dx:ASPxTextBox>
                                      
                                   </td>
                                   <td class="auto-style19">
                                       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txttopic" ErrorMessage="Enter Alpahbatics Only" ForeColor="Red" ValidationExpression="^[a-zA-Z ]*$"></asp:RegularExpressionValidator>
                                   </td>
                                   <td>&nbsp;</td>
                               </tr>
                               <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        <dx:ASPxLabel ID="ASPxLabel4" runat="server" Text="Question :" Theme="DevEx">
                                        </dx:ASPxLabel>
                                   </td>
                                   <td colspan="7">
                                        <dx:ASPxMemo ID="txtquestion" runat="server" Height="71px" Width="300px">
                                            <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="Vlidate_quiz">
                                                <RequiredField ErrorText="" IsRequired="True" />
                                            </ValidationSettings>
                                        </dx:ASPxMemo>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtquestion" ErrorMessage="Enter Question" ForeColor="Red"></asp:RequiredFieldValidator>
                                   </td>
                               </tr>
                               <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        <dx:ASPxLabel ID="lblEmployeeCodebel1" runat="server" Text="Level :" Theme="DevEx">
                                        </dx:ASPxLabel>
                                   </td>
                                   <td colspan="5">
                                        <dx:ASPxComboBox ID="cblevel" runat="server" NullText="--Select--" Theme="DevEx">
                                            <Items>
                                                <dx:ListEditItem Text="Very Simple" Value="Very Simple" />
                                                <dx:ListEditItem Text="Simple" Value="Simple" />
                                                <dx:ListEditItem Text="Normal" Value="Normal" />
                                                <dx:ListEditItem Text="Difficult" Value="Difficult" />
                                                <dx:ListEditItem Text="More Difficult" Value="More Difficult" />
                                                <dx:ListEditItem Text="Many More Difficult" Value="Many More Difficult" />
                                            </Items>
                                        </dx:ASPxComboBox>
                                                 
                                   </td>
                                   <td style="text-align:right;" class="auto-style18">
                                        &nbsp;</td>
                                   <td>
                                        &nbsp;</td>
                               </tr>

                               <tr>
                                   <td style="text-align:center;" class="auto-style17">
                                        <dx:ASPxLabel ID="lblnoofanswer" runat="server" Text="No.of Answers for Current Question :" Theme="DevEx">
                                        </dx:ASPxLabel>
                                   </td>
                                   <td colspan="5">
                                       <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                        <dx:ASPxComboBox ID="cbnoofanswers" runat="server" NullText="--Select--" Theme="DevEx" AutoPostBack="True">
                                            <Items>
                                                <dx:ListEditItem Text="1" Value="1" />
                                                <dx:ListEditItem Text="2" Value="2" />
                                                <dx:ListEditItem Text="3" Value="3" />
                                                <dx:ListEditItem Text="4" Value="4" />
                                            </Items>
                                        </dx:ASPxComboBox>
                                                </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="cbanswertype" EventName="SelectedIndexChanged" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                   </td>
                                   <td class="auto-style19">&nbsp;</td>
                                   <td>&nbsp;</td>
                               </tr>

                                <tr>
                                    <td style="text-align:center;" class="auto-style17">
                                        <dx:ASPxLabel ID="lblanswer" runat="server" Text="Answers" Theme="DevEx">
                                        </dx:ASPxLabel>
                                    </td>
                                    <td colspan="5">&nbsp;</td>
                                    <td class="auto-style19">&nbsp;</td>
                                    <td>&nbsp;</td>
                               </tr>

                                <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        
                                        <dx:ASPxLabel ID="lbla" runat="server" Text="A :" Theme="DevEx"></dx:ASPxLabel>
                                        
                                   </td>
                                    <td colspan="5" class="auto-style4">
                                        
                                        <dx:ASPxTextBox ID="txta" runat="server" Theme="DevEx" Width="170px">
                                       </dx:ASPxTextBox>
                                        
                                   </td>
                                     <td class="auto-style18">
                                        
                                   </td>
                                     <td class="auto-style4">
                                        
                                         </td>
                               </tr>

                                <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        
                                        <dx:ASPxLabel ID="lblb" runat="server" Text="B :" Theme="DevEx"></dx:ASPxLabel>
                                        
                                   </td>
                                    <td colspan="5">
                                        
                                        <dx:ASPxTextBox ID="txtb" runat="server" Theme="DevEx" Width="170px">
                                       </dx:ASPxTextBox>
                                    </td>
                                     <td class="auto-style19">
                                        
                                         &nbsp;</td>
                                     <td>
                                        
                                         &nbsp;</td>
                               </tr>

                                <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        
                                        <dx:ASPxLabel ID="lblc" runat="server" Text="C :" Theme="DevEx"></dx:ASPxLabel>
                                        
                                   </td>
                                    <td colspan="5">
                                        
                                        <dx:ASPxTextBox ID="txtc" runat="server" Theme="DevEx" Width="170px">
                                       </dx:ASPxTextBox>
                                    </td>
                                     <td class="auto-style19">
                                        
                                         &nbsp;</td>
                                     <td>
                                        
                                         &nbsp;</td>
                               </tr>

                                <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        
                                        <dx:ASPxLabel ID="lbld" runat="server" Text="D :" Theme="DevEx"></dx:ASPxLabel>
                                        
                                   </td>
                                    <td colspan="5">
                                        
                                        <dx:ASPxTextBox ID="txtd" runat="server" Theme="DevEx" Width="170px">
                                       </dx:ASPxTextBox>
                                    </td>
                                     <td class="auto-style19">
                                        
                                         &nbsp;</td>
                                     <td>
                                        
                                         &nbsp;</td>
                               </tr>

                                <tr>
                                   <td style="text-align:right;" class="auto-style17">
                                        
                                        <dx:ASPxLabel ID="lblcorrectanswer" runat="server" Text="Correct Answer :" Theme="DevEx"></dx:ASPxLabel>
                                    </td>
                                    <td style="width:36px;">
                                        
                                        <dx:ASPxRadioButton ID="rba" runat="server" Text="A" Theme="DevEx" GroupName="correctanswer">
                                        </dx:ASPxRadioButton>
                                    </td>
                                    <td style="width:36px;">&nbsp;</td>
                                    <td style="width:36px;">
                                        
                                        <dx:ASPxRadioButton ID="rbb" runat="server" Text="B" Theme="DevEx" GroupName="correctanswer">
                                        </dx:ASPxRadioButton>
                                    </td>
                                    <td style="width:36px;">
                                        
                                        <dx:ASPxRadioButton ID="rbc" runat="server" Text="C" Theme="DevEx" GroupName="correctanswer">
                                        </dx:ASPxRadioButton>
                                    </td>
                                    <td class="auto-style7">
                                        
                                        <dx:ASPxRadioButton ID="rbd" runat="server" Text="D" Theme="DevEx" GroupName="correctanswer">
                                        </dx:ASPxRadioButton>
                                    </td>
                                     <td class="auto-style19">
                                        
                                         &nbsp;</td>
                                     <td>
                                        
                                         &nbsp;</td>
                               </tr>

                                <tr>
                                   <td class="auto-style16">
                                        
                                       &nbsp;</td>
                                    <td colspan="5">
                                        
                                        <dx:ASPxLabel ID="lblresult" runat="server" Theme="DevEx"></dx:ASPxLabel>
                                    </td>
                                     <td class="auto-style19">
                                        
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
</center>
</form>
</body>
</html>
