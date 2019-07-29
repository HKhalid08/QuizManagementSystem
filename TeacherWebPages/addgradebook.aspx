<%@ Page Language="C#" AutoEventWireup="true" CodeFile="addgradebook.aspx.cs" Inherits="Web_Pages_PortoQuiz_Home" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxMenu" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPopupControl" tagprefix="dx" %>


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
       
        .auto-style3
        {
            width: 227px;
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
                      <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                               <ContentTemplate>
                        <table class="insert-form">
                          <tbody style="margin:0px;">
                              <tr>
                                <td>

                                        <dx:ASPxLabel ID="ASPxLabel8" runat="server" Text="Courses Name :" Theme="DevEx">
                                        </dx:ASPxLabel>

                                </td>
                                <td class="auto-style3">
                                   <%-- <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                              <ContentTemplate>--%>
                                        <dx:ASPxComboBox ID="cbcourses" runat="server" Theme="DevEx" ValueType="System.String" AutoPostBack="False" OnSelectedIndexChanged="cbcourses_SelectedIndexChanged" Height="21px" Width="199px">
                                        </dx:ASPxComboBox>
                                                 <%-- </ContentTemplate>
                                          </asp:UpdatePanel>--%>
                                </td>
                                  <td>
                                      <dx:ASPxLabel ID="ASPxLabel9" runat="server" Text="Marks For :" Theme="DevEx">
                                      </dx:ASPxLabel>
                                  </td>
                                  <td>
                                      <asp:UpdatePanel ID="UpdatePanel2" runat="server">
                                              <ContentTemplate>
                                      <dx:ASPxComboBox ID="cbmarks" runat="server" EnableTheming="True" Theme="DevEx" AutoPostBack="True" OnSelectedIndexChanged="cbmarks_SelectedIndexChanged">
                                          <Items>
                                              <dx:ListEditItem Text="Quiz" Value="Quiz" />
                                              <dx:ListEditItem Text="Assignments" Value="Assignments" />
                                          </Items>
                                      </dx:ASPxComboBox>
                                                  </ContentTemplate>
                                          </asp:UpdatePanel>
                                  </td>
                                  <td>
                                      &nbsp;</td>
                              </tr>
                              <tr>
                                  <td colspan="2">
                                      <dx:ASPxLabel ID="ASPxLabel10" runat="server" Text="Quiz / Assignment Name :" Theme="DevEx">
                                      </dx:ASPxLabel>
                                  </td>
                                  <td>
                                        <asp:UpdatePanel ID="UpdatePanel3" runat="server">
                                            <ContentTemplate>
                                      <dx:ASPxComboBox ID="cbname" runat="server" AutoPostBack="True"  Theme="DevEx" ValueType="System.String" OnSelectedIndexChanged="cbname_SelectedIndexChanged">
                                      </dx:ASPxComboBox>
                                                 </ContentTemplate>
                                            <Triggers>
                                                <asp:AsyncPostBackTrigger ControlID="cbmarks" EventName="SelectedIndexChanged" />
                                            </Triggers>
                                        </asp:UpdatePanel>
                                  </td>
                                  <td>
                                      <dx:ASPxButton ID="btnsave" runat="server" OnClick="btnsave_Click" Text="Save" Theme="DevEx">
                                      </dx:ASPxButton>
                                  </td>
                                  <td>&nbsp;</td>
                              </tr>
                              <tr>
                                  <td colspan="4">

                                <asp:GridView ID="dggradebook" runat="server" AutoGenerateColumns="False" ShowFooter="True" GridLines="None" CellPadding="4" ForeColor="#333333" Width="730px">
                                    <AlternatingRowStyle BackColor="White" />
                                    <Columns>
                                        <asp:BoundField DataField="rollno" HeaderText="Roll Number">
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="100px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="name" HeaderText="Name">
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="150px" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="no_of_question" HeaderText="No of Questions">
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="total_marks" HeaderText="Total Marks">
                                        <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                        </asp:BoundField>

                                        <asp:TemplateField HeaderText="Attempted Questions">
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtattemptquestion" runat="server" Width="120px" NullText="Attempted Questions"></asp:TextBox>
                                                  <%--<dx:ASPxTextBox ID="txtattemptquestion" runat="server" Width="120px" NullText="Attempted Questions"></dx:ASPxTextBox>--%>
                                            </ItemTemplate>
                                            <ItemStyle HorizontalAlign="Center" VerticalAlign="Middle" Width="125px" />
                                        </asp:TemplateField>

                                         <asp:TemplateField HeaderText="Obtained Marks">
                                            <ItemTemplate>
                                                <asp:TextBox ID="txtobtainedmarks" runat="server" Width="120px" NullText="Obtain Marks"></asp:TextBox>
                                                  <%--<dx:ASPxTextBox ID="txtobtainedmarks" runat="server" Width="120px" NullText="Obtain Marks"></dx:ASPxTextBox>--%>
                                            </ItemTemplate>
                                             <ItemStyle HorizontalAlign="Center" VerticalAlign="Top" Width="125px" />
                                        </asp:TemplateField>

                                    </Columns>

                                    <EditRowStyle BackColor="#2461BF" />
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <RowStyle BackColor="#EFF3FB" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <SortedAscendingCellStyle BackColor="#F5F7FB" />
                                    <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                                    <SortedDescendingCellStyle BackColor="#E9EBEF" />
                                    <SortedDescendingHeaderStyle BackColor="#4870BE" />

                                </asp:GridView>

                                      </td>
                                  </tr>
                          </tbody>
                          </table>    
                       <table>
                           <tr>
                               <td style="width:272px">
                                   </td>
                               <td style="width:65px">
                                    <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" BackColor="#0094FF" Font-Names="Arial" Font-Size="12pt" ForeColor="White" Height="100px" Pinned="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" RenderMode="Lightweight" ShowHeader="False" Width="380px">
                                        <ContentCollection>
                                            <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                                                <br />
                                                Marks Has been Submitted Successfully ...<br />
                                                <dx:ASPxButton ID="popupokbutton" runat="server" OnClick="popupokbutton_Click" Text="OK " Theme="iOS">
                                                </dx:ASPxButton>
                                            </dx:PopupControlContentControl>
                                        </ContentCollection>
                                    </dx:ASPxPopupControl>
                               </td>
                               <td style="width:65px">
                                   &nbsp;</td>
                               <td style="width:65px">
                                   &nbsp;</td>
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
