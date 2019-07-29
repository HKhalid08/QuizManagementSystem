<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewteacherenroll.aspx.cs" Inherits="Web_Pages_PortoQuiz_Home" %>

<%@ Register Assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web.ASPxGridView" TagPrefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    
    <%--Starting Title Tag--%>
    <title>Porto Quiz</title>

    <%--Linking To External StyleSheet For Account--%>
    <link href="../StyleSheet/Admin.css" rel="stylesheet" type="text/css"/>

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
<script>

    $(document).ready(function () {
        $("input").click(function () {

            var GettingID = this.title;

            //alert(GettingID);

            $("." + GettingID).slideToggle(100);




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
       
        .auto-style3 {
            width: 280px;
        }
       
        .auto-style4 {
            width: 162px;
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

                   <div class="Contents_Proper_Div" style="overflow:scroll;">
                     <table class="insert-form">
                        
                          <tbody style="margin:0px;">
                              <tr>
                                  <td>
                                       <table cellspacing="0" style="width:740px;">
                                       <tr style="background-color:#808080;height:40px;">
                                                        <td style="padding-left:10px;text-align:center;" class="auto-style3">
                                                            <dx:ASPxLabel ID="ASPxLabel16" runat="server" Text="Employee ID" Theme="DevEx"></dx:ASPxLabel>
                                                           
                                                        </td>
                                                        <td style="padding-left:45px;text-align:left;" class="auto-style4">
                                                            <dx:ASPxLabel ID="ASPxLabel26" runat="server" Text="Name" Theme="DevEx"></dx:ASPxLabel>
                                                           
                                                        </td>                                                        
                                                        <td style="padding-left:40px;text-align:left;">
                                                            <dx:ASPxLabel ID="ASPxLabel3" runat="server" Text="Session" Theme="DevEx"></dx:ASPxLabel>
                                                           
                                                        </td>                             
                                                        
                                                    </tr>
                                  </table>
                                  </td>
                              </tr>
                              <tr>
                                  <td>
                            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                               
                                <ContentTemplate>
                               
                            <asp:GridView ID="dgteacherenroll" runat="server" AllowPaging="True" AutoGenerateColumns="False" GridLines="None" CellPadding="4" ForeColor="#333333" ShowHeader="False">

                                    <AlternatingRowStyle BackColor="White" />           
                                

                                    <Columns>                                           
                                     
                                        
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <table style="width:740px;" cellspacing="0">
                                                   <tr>
                                                        <td style="height:5px;">

                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="width:350px;padding-left:10px;text-align:center;">
                                                            <dx:ASPxLabel ID="ASPxLabel5" runat="server" Text='<%#Eval("emp_code")%>' Theme="DevEx"></dx:ASPxLabel>
                                                           
                                                        </td>
                                                        <td style="width:150px;padding-left:10px;text-align:center;">
                                                            <dx:ASPxLabel ID="ASPxLabel1" runat="server" Text='<%#Eval("name")%>' Theme="DevEx"></dx:ASPxLabel>
                                                           
                                                        </td>                                                       
                                                        <td style="width:350px;padding-left:10px;text-align:center;">
                                                            <dx:ASPxLabel ID="ASPxLabel7" runat="server" Text='<%#Eval("session_id")%>' Theme="DevEx"></dx:ASPxLabel>
                                                           
                                                        </td>
                                                        <td style="text-align:center;">
                                                           <input type="button" value="View" title=<%#Eval("Id") %> />
                                                        </td>
                                                        
                                                    </tr>
                                                    
                                                    
                                                    <tr style="background-color:#f6f5f5;width:740px;">
                                                        <td colspan="6">

                                                        <table class='<%#Eval("Id")%>' hidden>
                                                            <tr>
                                                                

                                                               
                                                        <td style="width:120px;height:30px;padding-left:10px; text-align:left">
                                                            <dx:ASPxLabel ID="ASPxLabel22" runat="server" Text="Courses :" Theme="DevEx" Font-Bold="True"></dx:ASPxLabel>
                                                            
                                                        </td>
                                                        
                                                                </tr>
                                                        <tr>
                                                        <td style="width:700px;height:30px;padding-left:10px;">
                                                          <dx:ASPxLabel ID="ASPxLabel2" runat="server" Text='<%#Eval("course")%>' Theme="DevEx"></dx:ASPxLabel>  
                                                            
                                                        </td>                                               
                                                            
                                                            </tr>
                                                            
                                                           
                                                        </table>

                                                        
                                                        </td>    
                                                    </tr>
                                                
                                                </table>
                                            </ItemTemplate>
                                        </asp:TemplateField>                                   

                                      <asp:TemplateField HeaderText="Detail">
                                        <ItemTemplate>
                                        <asp:LinkButton ID="btnupdate" CommandArgument='<%#Eval("Id")%>' OnClick="btnupdate_Click" CausesValidation="false" runat="server">Update</asp:LinkButton>                  
                                        
                                        </ItemTemplate>

                                        </asp:TemplateField>
                                        <asp:TemplateField HeaderText="Delete">
                                            <ItemTemplate>
                                        <asp:LinkButton ID="btndelete" CommandArgument='<%#Eval("Id")%>' OnClick="btndelete_Click" CausesValidation="false" runat="server">Delete</asp:LinkButton>
                                        
                                                 </ItemTemplate>
                                        </asp:TemplateField>

                                    </Columns>
                                    
                                     

                                   <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#383F46" Font-Bold="True" ForeColor="White" Font-Names="Arial" Font-Size="12px" Height="60px" />
                                    <PagerStyle BackColor="#383F46" ForeColor="White" HorizontalAlign="Center" Font-Names="Arial" Font-Size="12px" Height="40px" />
                                    <RowStyle BackColor="#EFF3FB" CssClass="RowStyle" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" CssClass="RowStyle" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />

                                </asp:GridView>


                               
                                    

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
                      
   <%-- <div class="Chat_Box_Div">
      
        <table>
          <tr>
              <td class="Chat_Title_Td">
                  &nbsp;&nbsp;&nbsp;&nbsp;Chat
              </td>             
          </tr>
             <tr>

               <td class="Chat_TextBox_Td" align="center" hidden>
                   <dx:ASPxTextBox ID="txtChat" runat="server" Width="252px" Font-Names="Arial" Font-Size="12px" NullText="Type Message ..." Theme="DevEx" BackColor="#EDEDED" Height="25px" CssClass="Chat-Message"></dx:ASPxTextBox>
              </td>

            </tr>
      </table>
      
    </div>--%>        

    
</center>
</form>
</body>
</html>
