<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="tlChechOutDetailRT.ascx.cs"
    Inherits="CampusNerdy.Web.Background.Control.UserCenter.tlChechOutDetailRT" %>
<div>
    超市：<asp:Label ID="lbMarketName" runat="server" Text="Label"></asp:Label>
</div>
<div>
    <asp:DataList ID="dtlChechOutDetail" runat="server" 
        onitemcommand="dtlChechOutDetail_ItemCommand"  >
        <ItemTemplate>
            <table style="width: 100%;">
                <tr>
                    <td>
                        <%#Eval("GoodNameACount")%>
                    </td>
                    <td>
                        <asp:Button ID="btnPlus" runat="server" Text="[+]"  CommandName='<%#Convert.ToString( Eval("GoodNameACount")+"-"+"plus")%>'/>
                          
                    </td>
                    <td>
                        <asp:Button ID="btnSubtract" runat="server" Text="[-]"   CommandName='<%#Convert.ToString( Eval("GoodNameACount")+"-"+"Subtract")%>'/>
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
</div>
