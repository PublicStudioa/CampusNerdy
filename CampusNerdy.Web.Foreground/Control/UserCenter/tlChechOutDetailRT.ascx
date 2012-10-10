<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tlChechOutDetailRT.ascx.cs"
    Inherits="CampusNerdy.Web.Foreground.Control.UserCenter.tlChechOutDetailRT" %>
<div>
    <%--   <asp:Image ID="MarketIMG" runat="server" ImageUrl= '<%#_marketIMG.ToString()%> '/>--%>
    <%--<img alt="" src='<%="/ImageTest/"+this._marketIMG%> ' />--%>
</div>
<div>
    <asp:DataList ID="dtlChechOutDetail" runat="server" OnItemCommand="dtlChechOutDetail_ItemCommand">
        <ItemTemplate>
            <table style="width: 100%;">
                <tr>
                    <td colspan="4">
                        <asp:Image ID="GoodIMG" runat="server" ImageUrl='<%#"~/ImageTest/"+Eval("GoodIMG").ToString() %>' />
                    </td>
                </tr>
                <tr>
                    <td>
                       <%#Eval("SuperMarketName")%> 的商品：
                        <%#Eval("GoodNameACount")%>
                        单价：
                        <%#Eval("GoodSignCost")%>
                        小计：
                        <%#Eval("GoodsSumCost")%>
                    </td>
                    <td>
                        <asp:Button ID="btnPlus" runat="server" Text="[+]" CommandName='<%#Convert.ToString( Eval("GoodSuperId")+"-"+"plus")%>' />
                    </td>
                    <td>
                        <asp:Button ID="btnSubtract" runat="server" Text="[-]" CommandName='<%#Convert.ToString( Eval("GoodSuperId")+"-"+"Subtract")%>' />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</div>
