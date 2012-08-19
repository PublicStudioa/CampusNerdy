<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CheckOut.ascx.cs" Inherits="CampusNerdy.Web.Background.Control.UserCenter.CheckOut" %>
<div>
    <asp:DataList ID="dtlCompletelyChechOut" runat="server">
        <ItemTemplate>
        </ItemTemplate>
    </asp:DataList>
    <div>
        <asp:TextBox ID="txtSaySthWhenCheckOut" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnCheckOut" runat="server" Text="速度送来" />
    </div>
</div>
