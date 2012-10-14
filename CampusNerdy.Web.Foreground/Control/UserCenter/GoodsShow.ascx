<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="GoodsShow.ascx.cs" Inherits="CampusNerdy.Web.Foreground.Control.UserCenter.GoodsShow" %>
<asp:DataList ID="dlGoodShow" runat="server" 
    onitemcommand="dlGoodShow_ItemCommand">
    <ItemTemplate>
        <table style="width: 100%;">
            <tr>
                <td colspan="2">
                    <asp:Image ID="image1" Width="78px" Height="78px" ImageUrl='<%#"~/ImageTest/"+Eval("GoodIMG").ToString() %>'
                        runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <%# Eval("GoodName") %>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <%# Eval("GoodSignCost")%>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="BtnAddIntoCar" runat="server" Text="GOOOO" CommandName='<%#Convert.ToString( Eval("GoodSuperId"))+"-"+Convert.ToString( Eval("superMarketID"))%>'  />
                </td>
                <td>
                    <a href='sfasdfasdfasd' target="_blank">看点评</a>
                </td>
            </tr>
        </table>
    </ItemTemplate>
</asp:DataList>