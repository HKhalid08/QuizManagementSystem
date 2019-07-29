<%@ Page Language="C#" AutoEventWireup="true" CodeFile="takequiz.aspx.cs" Inherits="Login_Login" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxEditors" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxTimer" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.6.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPopupControl" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Porto Quiz</title>
    <style type="text/css">
        .label-padding
        {
            padding-left:40px;
        }
        .auto-style34
        {
            width: 108px;
        }
        .auto-style35
        {
            width: 129px;
        }
        .auto-style36
        {
            width: 89px;
        }
    </style>

<script type="text/javascript">
    window.history.forward();
    function preventBack() { window.history.forward(1); }
        //$(document).ready(function ()
        //{
        //    window.history.forward(1);
        //    window.history.forward(-1);
        //});

</script>

</head>
<body style="background-color:#ecf0f1;" onload="preventBack();">

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                <asp:Timer ID="Timer1" runat="server" Interval="1000" OnTick="Timer1_Tick"></asp:Timer>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <center>
 <table style="width:600px;height:120px;background-color:#0094ff;border-radius:10px;">
     <tr>
         <td valign="middle" align="right" class="auto-style34">
             <span style="font-family:Arial;font-size:14px;color:white;">&nbsp;<dx:ASPxLabel ID="lblcourse" runat="server" ForeColor="White" Text="Course Code :" Theme="DevEx">
             </dx:ASPxLabel>
             </span>
         </td>
         <td class="auto-style35">

             <dx:ASPxLabel ID="lblcoursecode" runat="server" Theme="DevEx">
             </dx:ASPxLabel>

         </td>
         <td align="right" class="auto-style36">
             <dx:ASPxLabel ID="lbltitle" runat="server" ForeColor="White" Text="Course Title :" Theme="DevEx">
             </dx:ASPxLabel>
             <span style="font-family:Arial;font-size:14px;color:white;">&nbsp;</span></td>
         <td style="width:160px;">

             <dx:ASPxLabel ID="lblcoursetitle" runat="server" Theme="DevEx">
             </dx:ASPxLabel>

         </td>
     </tr>
     <tr>
         <td valign="middle" align="right" class="auto-style34">
             <dx:ASPxLabel ID="lblquiz" runat="server" ForeColor="White" Text="Quiz Name :" Theme="DevEx">
             </dx:ASPxLabel>
         </td>
         <td class="auto-style35">

             <dx:ASPxLabel ID="lblquizname" runat="server" Theme="DevEx">
             </dx:ASPxLabel>

         </td>
         <td align="right" class="auto-style36">
             <dx:ASPxLabel ID="lbltype" runat="server" ForeColor="White" Text="Quiz Type :" Theme="DevEx">
             </dx:ASPxLabel>
         </td>
         <td>

             <dx:ASPxLabel ID="lblquiztype" runat="server" Theme="DevEx">
             </dx:ASPxLabel>

         </td>
     </tr>
     <tr>
         <td align="right" class="auto-style34" valign="middle"><span style="font-family:Arial;font-size:14px;color:white;">&nbsp;<dx:ASPxLabel ID="lbltype0" runat="server" ForeColor="White" Text="Quiz Level :" Theme="DevEx">
             </dx:ASPxLabel>
             </span></td>
         <td class="auto-style35">
             <dx:ASPxLabel ID="lblquizlevel" runat="server" Theme="DevEx">
             </dx:ASPxLabel>
         </td>
         <td align="right" class="auto-style36"><span style="font-family:Arial;font-size:14px;color:white;">&nbsp;<dx:ASPxLabel ID="lbltotal" runat="server" ForeColor="White" Text="Total Marks :" Theme="DevEx">
             </dx:ASPxLabel>
             </span></td>
         <td>
             <dx:ASPxLabel ID="lbltotalmarks" runat="server" Theme="DevEx">
             </dx:ASPxLabel>
         </td>
     </tr>
     <tr>
         <td valign="middle" align="right" class="auto-style34">
             <dx:ASPxLabel ID="lblpassing" runat="server" ForeColor="White" Text=" Passing Marks :" Theme="DevEx">
             </dx:ASPxLabel>
             <span style="font-family:Arial;font-size:14px;color:white;">&nbsp;</span></td>
         <td class="auto-style35">

             <dx:ASPxLabel ID="lblpassingmarks" runat="server" Theme="DevEx">
             </dx:ASPxLabel>

             <dx:ASPxLabel ID="lblques" runat="server" Theme="DevEx" Visible="False">
             </dx:ASPxLabel>
             <dx:ASPxLabel ID="lblno" runat="server" Theme="DevEx" Visible="False">
             </dx:ASPxLabel>

         </td>
         <td align="right" class="auto-style36">
             <dx:ASPxLabel ID="lbltime" runat="server" ForeColor="White" Text="Timer :" Theme="DevEx">
             </dx:ASPxLabel>
             <span style="font-family:Arial;font-size:14px;color:white;">&nbsp;</span></td>
         <td>

             <%--<asp:ScriptManager ID="ScriptManager2" runat="server">
             </asp:ScriptManager>--%>
                    <asp:UpdatePanel id="updPnl" runat="server" UpdateMode="Conditional">
                        <ContentTemplate>
                        <asp:Label ID="lblTimer" runat="server"></asp:Label>
                        </ContentTemplate>
                        <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Timer1" EventName ="tick" />
                        </Triggers>
                    </asp:UpdatePanel>
         </td>
     </tr>
 </table>

                    <table>
                        <tr>
                            <td>

                                <%--<asp:GridView ID="dgquestion" runat="server" BackColor="White" GridLines="None" ShowHeader="False" AutoGenerateColumns="False"  PageSize="1" AllowPaging="True" Width="594px" OnPageIndexChanging="dgquestion_PageIndexChanging">
                                    <Columns>
                                        <asp:TemplateField>
                                            <ItemTemplate>--%>
                                                <table style="width:580px; height:250px">
                                                    <tr>
                                                        <td style="height:20px;">

                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <asp:Label ID="lblquesno" runat="server" Font-Names="arial" Font-Size="14pt" ForeColor="#999999"></asp:Label>
                                                            &nbsp;:
                                                            <asp:Label ID="lblQuestionNumber" runat="server" Text="" ForeColor="#999999" Font-Size="14" Font-Names="arial"></asp:Label>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height:20px;">

                                                        </td>
                                                    </tr>

                                                    <tr>
                                                        <td align="left">
                                                            <asp:RadioButton ID="rbOption1" runat="server" Text="" Font-Names="Arial" Font-Size="Small" GroupName="answer"></asp:RadioButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                             <asp:RadioButton ID="rbOption2" runat="server" Text="" Font-Names="Arial" Font-Size="Small" GroupName="answer"></asp:RadioButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                             <asp:RadioButton ID="rbOption3" runat="server" Text="" Font-Names="Arial" Font-Size="Small" GroupName="answer"></asp:RadioButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left">
                                                             <asp:RadioButton ID="rbOption4" runat="server" Text="" Font-Names="Arial" Font-Size="Small" GroupName="answer"></asp:RadioButton>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height:20px;">

                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td align="left"> 
                                                             <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click"></asp:Button>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td style="height:20px;">

                                                            <dx:ASPxPopupControl ID="ASPxPopupControl1" runat="server" BackColor="#0094FF" Font-Names="Arial" Font-Size="12pt" ForeColor="White" Height="100px" Pinned="True" PopupHorizontalAlign="WindowCenter" PopupVerticalAlign="WindowCenter" RenderMode="Lightweight" ShowHeader="False" Width="380px">
                                                                <ContentCollection>
                                                                    <dx:PopupControlContentControl runat="server" SupportsDisabledAttribute="True">
                                                                        <br />Your Qiz Has been Submitted Successfully ...<br />
                                                                                     <dx:ASPxButton ID="popupokbutton" runat="server" OnClick="popupokbutton_Click" Text="OK " Theme="iOS">
                                                                        </dx:ASPxButton>
                                                                    </dx:PopupControlContentControl>
                                                                </ContentCollection>
                                                            </dx:ASPxPopupControl>

                                                        </td>
                                                    </tr>
                                                </table>
                                           <%-- </ItemTemplate>
                                        </asp:TemplateField>
                                    </Columns>
                                    <PagerStyle BackColor="#CCCCCC" Height="30px" />
                                </asp:GridView>--%>

                            </td>
                        </tr>
                    </table>
</center>

                </ContentTemplate>
        </asp:UpdatePanel>
    </form>

</body>
</html>
