<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CampusNerdy.Web.Foreground.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
// <![CDATA[

        function btnsubmit_onclick() {

        }

// ]]>
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="login_body">
        <div class="login_frame">
            <table>
                <tr>
                    <td class="ltd1">
                        <asp:Label ID="Label1" runat="server" Text="用户名："></asp:Label>
                    </td>
                    <td class="ltd2">
                        <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="ltd1">
                        <asp:Label ID="Label2" runat="server" Text="密码："></asp:Label>
                    </td>
                    <td class="ltd2">
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td valign="bottom" height="13">
                        <asp:Label ID="lblCode" Visible="false" Text="验证码：" runat="server" />
                    </td>
                    <td>
                        <div id="divCode" visible="false" runat="server">
                            <input class="nemo01" name="code" type="text" value="" maxlength="4" size="10" id="code"
                                tabindex="3" /><a id="A2" href="" onclick="ChangeCode();return false;"><img style="border-style: none;
                                    border-color: inherit; border-width: medium; height: 22px; width: 111px;" id="imgVerify"
                                    alt="看不清？点击更换" onclick="this.src=this.src+'?'" src="../Control/Verify/VerifyCode.aspx" /></a>
                        </div>
                    </td>
                </tr>
            </table>
            <div>
                <input id="btnsubmit" type="button" value="登陆" runat="server" onserverclick="btnsubmit_Click"
                    class="login_subbtn"     /></div>
            <div>
                <asp:Label ID="lberrormessage" runat="server"></asp:Label></div>
        </div>
    </div>
    </form>
</body>
</html>
