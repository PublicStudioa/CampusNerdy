<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CheckOut.ascx.cs" Inherits="CampusNerdy.Web.Foreground.Control.UserCenter.CheckOut" %>
<%@ Register Src="tlChechOutDetailRT.ascx" TagName="tlChechOutDetailRT" TagPrefix="uc1" %>
<div>
    <asp:DataList ID="dtlCompletelyChechOut" runat="server">
        <ItemTemplate>
            <uc1:tlChechOutDetailRT ID="tlChechOutDetailRT1" runat="server" />
        </ItemTemplate>
    </asp:DataList>
    <div>
        <asp:TextBox ID="txtSaySthWhenCheckOut" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnCheckOut" runat="server" Text="速度送来" />
    </div>
</div>
