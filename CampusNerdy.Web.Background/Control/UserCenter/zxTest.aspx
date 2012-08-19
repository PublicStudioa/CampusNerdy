<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zxTest.aspx.cs" Inherits="CampusNerdy.Web.Background.Control.UserCenter.zxTest" %>

<%@ Register Src="tlChechOutDetailRT.ascx" TagName="tlChechOutDetailRT" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
<asp:scriptmanager ID="Scriptmanager1" runat="server"></asp:scriptmanager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
                <uc1:tlChechOutDetailRT ID="tlChechOutDetailRT1" runat="server" />
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
