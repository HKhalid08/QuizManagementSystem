<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login_Login" %>

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
        .auto-style10 {
            height: 41px;
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
    </style>
</head>
<body style="background-color:#ecf0f1;">

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
 <table style="width:100%;height:100%;">
     <tr>
         <td valign="middle" align="center">

       
     
    <br />
    <br />
             
               <table style="width:424px;height:444px;background-image:url('../Website_Images/Login-Design-CPanel.gif');">
                   <tr>
                       <td class="auto-style11">
                            
                       </td>
                       <td class="auto-style12" style="text-align:left;">
                            
                           <asp:Label ID="Label1" runat="server" BackColor="#111010" Text="QUIZ PORTO Control Panel" Width="250px" Font-Names="Arial" Font-Size="Medium" ForeColor="White"></asp:Label>
                            
                           </td>
                   </tr>
                   <tr>
                       <td class="auto-style13"></td>
                       <td class="auto-style14"></td>
                   </tr>
                   <tr>
                       <td class="auto-style15">
                            
                       </td>
                       <td class="auto-style16" style="vertical-align:middle;">
                            
                           <dx:ASPxTextBox ID="txtusername" runat="server" BackColor="#151414" Height="50px" Theme="Metropolis" Width="250px" Font-Names="Arial" Font-Size="12px" ForeColor="#CCCCCC">
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
                            
                        <dx:ASPxTextBox ID="txtpasssword" runat="server" BackColor="#151414" Height="50px" Theme="Metropolis" Width="250px" Font-Names="Arial" Font-Size="12px" ForeColor="#CCCCCC" style="margin-left: 0px" Password="True">
                               <Paddings PaddingLeft="10px" />
                               <ValidationSettings ErrorText="" ValidationGroup="SignIn">
                                   <RequiredField ErrorText="" IsRequired="True" />
                               </ValidationSettings>
                               <Border BorderColor="#333333" />
                           </dx:ASPxTextBox>   
                       
                       </td>
                   </tr>
                   <tr>
                       <td class="auto-style10" colspan="2" >
                            
                          
                            <table>
                                <tr>
                                    <td style="width:25px;">

                                    </td>
                                    <td>
                                         <dx:ASPxButton ID="btnLogin" runat="server" BackColor="#FF503F" Font-Names="Arial" Font-Size="12px" ForeColor="White" Height="40px" Text="Sign In" Theme="MetropolisBlue" Width="350px" OnClick="btnLogin_Click" ValidationGroup="SignIn">
                                             <HoverStyle BackColor="#F93E2C">
                                             </HoverStyle>
                                             <Border BorderStyle="None" />
                                         </dx:ASPxButton>
                                       </td>
                                   </tr>
                                <tr>
                                    <td style="width:25px;">

                                    </td>
                                    <td>
                                         <dx:ASPxButton ID="btnForgot" runat="server" BackColor="#FF503F" Font-Names="Arial" Font-Size="12px" ForeColor="White" Height="40px" Text="Cancel" Theme="MetropolisBlue" Width="350px" CausesValidation="False" OnClick="btnForgot_Click">
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
                            
                           <dx:ASPxLabel ID="lblresult" runat="server" ForeColor="White" Theme="DevEx">
                           </dx:ASPxLabel>
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
