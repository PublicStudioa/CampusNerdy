<%@ Control Language="C#" AutoEventWireup="true" CodeFile="yanCode.ascx.cs" Inherits="adminGJ_yanCode" %>
<style type="text/css">
    .style1
    {
        width: 65px;
        height: 19px;
    }
    .style2
    {
        height: 19px;
    }
    .style3
    {
        width: 65px;
    }
</style>
<table style="width:180" cellpadding="0" cellspacing="0">
  <tr style="height:22">
    <td class="style3">验证码：</td>
    <td><input class="wenbenkuang" name="code" type="text" value="" maxLength="4" size="10" style="BORDER-RIGHT: #000000 1px solid; BORDER-TOP: #000000 1px solid; BORDER-LEFT: #000000 1px solid; BORDER-BOTTOM: #000000 1px solid">
       <img  style="height:25px;" id="imgVerify" alt="看不清？点击更换" onclick="this.src=this.src+'?'" src="VerifyCode.aspx?" />
       </td>   
  </tr>
  <tr>
     <td class="style1"></td>
     <td class="style2"><span style="font-size:12px;">看不清?点击更换</span></td>
  </tr>
</table>
