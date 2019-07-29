<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ChangePasword.aspx.cs" Inherits="Login_Login" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Porto Quiz</title>
    <style type="text/css">
        .auto-style1 {
            width: 97px;
        }
        .auto-style4 {
            width: 97px;
            height: 59px;
        }
        .auto-style5 {
            height: 59px;
        }
        .auto-style11
        {
            width: 97px;
            height: 64px;
        }
        .auto-style12
        {
            height: 64px;
        }
        .auto-style13
        {
            width: 97px;
            height: 54px;
        }
        .auto-style14
        {
            height: 54px;
        }
        .auto-style15
        {
            width: 97px;
            height: 75px;
        }
        .auto-style16
        {
            height: 75px;
        }
        .auto-style19
        {
            width: 25px;
            height: 23px;
        }
        .auto-style20
        {
            height: 23px;
        }
        .auto-style23
        {
            height: 17px;
        }
        .auto-style24
        {
            width: 97px;
            height: 58px;
        }
        .auto-style25
        {
            height: 58px;
        }
        .label-padding
        {
            padding-left:40px;
        }
        .auto-style26 {
            width: 97px;
            height: 70px;
        }
        .auto-style27 {
            height: 70px;
        }
    </style>

<script>
    $(document).ready(function ()
    {
        
        $(".Chat_Title_Td").click(function ()
        {
                $(".Chat_Contents_Td").slideToggle(100);

                $(".Chat_TextBox_Td").slideToggle(100);
            }

            )
        });
</script>

</head>

    

<body style="background-color:#ecf0f1;">

    <p>
        <br />
    </p>
    <p>
        &nbsp;</p>

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
 <table style="width:100%;">
     <tr>
         <td valign="middle" align="center">

       
     
    <br />
    <br />
             
               <table style="width:424px;height:440px;background-image:url('../Website_Images/ChangePassword.png');">
                   <tr>
                       <td class="auto-style11">
                            
                       </td>
                       <td class="auto-style12" style="text-align:left;">
                            
                           <asp:Label ID="Label1" runat="server" BackColor="#111010" Text="QUIZ PORTO Control Panel" Width="250px" Font-Names="Arial" Font-Size="Medium" ForeColor="White"></asp:Label>
                            
                           </td>
                   </tr>
                   <tr>
                       <td class="auto-style13"></td>
                       <td class="auto-style14">
                           <asp:Label ID="Label2" CssClass="label-padding" runat="server" BackColor="#FF503F" Font-Names="Arial" Font-Size="12pt" ForeColor="White" Height="20px" Text="Change Password" Width="260px"></asp:Label>
                       </td>
                   </tr>
                   <tr>
                       <td class="auto-style15">
                            
                       </td>
                       <td class="auto-style16" style="vertical-align:middle;">
                            
                           <dx:ASPxTextBox ID="txtusername" runat="server" BackColor="#151414" Height="50px" Theme="Metropolis" Width="250px" Font-Names="Arial" Font-Size="12px" ForeColor="#CCCCCC" ReadOnly="True" NullText="Type Username Here ...">
                               <Paddings PaddingLeft="10px" />
                               <ValidationSettings CausesValidation="True" ErrorDisplayMode="ImageWithTooltip" ValidationGroup="SignIn">
                                   <RequiredField ErrorText="" IsRequired="True" />
                               </ValidationSettings>
                               <Border BorderColor="#333333" />
                           </dx:ASPxTextBox>
                            
                       </td>
                   </tr>
                   <tr>
                       <td class="auto-style4">
                            
                       </td>
                       <td class="auto-style5" valign="top">
                            
                        <dx:ASPxTextBox ID="txtoldpassword" runat="server" BackColor="#151414" Height="50px" Theme="Metropolis" Width="250px" Font-Names="Arial" Font-Size="12px" ForeColor="#CCCCCC" style="margin-left: 0px" Password="True" NullText="Type Old Password Here ..." ToolTip="Current Password Here ..." HelpText="Type Old Password Here ...">
                               <Paddings PaddingLeft="10px" />
                               <HelpTextSettings DisplayMode="Popup">
                               </HelpTextSettings>
                               <ValidationSettings ErrorText="" ValidationGroup="SignIn">
                                   <RequiredField ErrorText="" IsRequired="True" />
                               </ValidationSettings>
                               <Border BorderColor="#333333" />
                           </dx:ASPxTextBox>   
                       
                       </td>
                   </tr>
                   <tr>
                       <td class="auto-style26"></td>
                       <td class="auto-style27" valign="top">
                           <dx:ASPxTextBox ID="txtnewpassword" runat="server" BackColor="#151414" Font-Names="Arial" Font-Size="12px" ForeColor="#CCCCCC" Height="50px" Password="True" style="margin-left: 0px" Theme="Metropolis" Width="250px" NullText="Type New Password Here ..." ToolTip="New Password Here ..." HelpText="Type New Password Here ...">
                               <Paddings PaddingLeft="10px" />
                               <HelpTextSettings DisplayMode="Popup">
                               </HelpTextSettings>
                               <ValidationSettings ErrorText="" ValidationGroup="SignIn">
                                   <RequiredField ErrorText="" IsRequired="True" />
                               </ValidationSettings>
                               <Border BorderColor="#333333" />
                           </dx:ASPxTextBox>
                       </td>
                   </tr>
                   <tr>
                       <td class="auto-style23" colspan="2" >
                            
                          
                            <table>
                                <tr>
                                    <td class="auto-style19">

                                    </td>
                                    <td class="auto-style20">
                                         <dx:ASPxButton ID="btnchange" runat="server" BackColor="#FF503F" CausesValidation="False" Font-Names="Arial" Font-Size="12px" ForeColor="White" Height="40px" Text="Change Password" Theme="MetropolisBlue" Width="350px" OnClick="btnchange_Click">
                                             <HoverStyle BackColor="#F93E2C">
                                             </HoverStyle>
                                             <Border BorderStyle="None" />
                                         </dx:ASPxButton>
                                   </td>
                                </tr>
                            </table>
                          
                            
                           
                       </td>
                   </tr>
                   <tr>
                       <td class="auto-style1">
                            
                           &nbsp;</td>
                       <td>
                            
                           <asp:Button ID="btncon" runat="server" OnClick="btncon_Click" Text="Press to Continue" Visible="False" />
                            
                           <asp:Label ID="lblresult" runat="server" ForeColor="White"></asp:Label>
                       </td>
                   </tr>
               </table>
     
  
          
       
         </td>
     </tr>
 </table>
                </ContentTemplate>
        </asp:UpdatePanel>
    </form>

</body>
</html>
