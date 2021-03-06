﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI.WebControls;

namespace CampusNerdy.Common.CHelper
{
    public class JS
    {
        protected static HttpResponse Response;
        protected static HttpSessionState Session;

        public JS()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }

        /// <summary>
        ///  关闭当前页，刷新待办页
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ltlScript"></param>
        public static void AlertAndCloseActiveTabAndShowTodo(object message, Literal ltlScript)
        {
            string js = string.Format(@"<Script language='JavaScript'>
                            alert('{0}');  
                            parent.closeActiveTabAndShowTodo();
                          </Script>", message);
            if (message == "")
                js = @"<Script language='JavaScript'>
                            parent.closeActiveTabAndShowTodo();
                          </Script>";
            ltlScript.Text = js;
        }

        /// <summary>
        /// 刷新待办页
        /// </summary>
        /// <param name="message"></param>
        /// <param name="ltlScript"></param>
        public static void AlertAndRefTodoPage(object message, Literal ltlScript)
        {
            string js = string.Format(@"<Script language='JavaScript'>
                            alert('{0}');  
                            parent.refTodoPage();
                          </Script>", message);
            if (message == "")
                js = @"<Script language='JavaScript'>
                            parent.refTodoPage();
                          </Script>";
            ltlScript.Text = js;
        }

        /// <summary>
        /// 刷新父窗口
        /// </summary>
        public static void RefreshParent(string message)
        {
            string js = string.Format(@"<Script language='JavaScript'>
                            alert('{0}');  
                            parent.location.reload();
                          </Script>", message);
            HttpContext.Current.Response.Write(js);
        }
        /// <summary>
        /// 弹出JavaScript小窗口,并转向指定的页面
        /// </summary>
        /// <param name="message">弹出信息</param>
        /// <param name="toURL">专转向的网页</param>
        public static void AlertAndRedirect(string message, string toURL)
        {
            string js = "<script language=javascript>alert('{0}');window.location.replace('{1}')</script>";
            HttpContext.Current.Response.Write(string.Format(js, message, toURL));
        }
        /// <summary>
        /// 弹出JavaScript小窗口,并转向指定的页面
        /// </summary>
        /// <param name="message">弹出信息</param>
        /// <param name="toURL">专转向的网页</param>
        public static void Redirect( string toURL)
        {
            string js = "<script language=javascript>window.location.replace('{0}')</script>";
            HttpContext.Current.Response.Write(string.Format(js,  toURL));
        }
        /// <summary>
        /// 向客户端发送函数KendoPostBack(eventTarget, eventArgument)
        /// 服务器端可接收__EVENTTARGET,__EVENTARGUMENT的值
        /// </summary>
        /// <param name="page">System.Web.UI.Page 一般为this</param>
        public static void JscriptSender(System.Web.UI.Page page)
        {

            page.RegisterHiddenField("__EVENTTARGET", "");
            page.RegisterHiddenField("__EVENTARGUMENT", "");
            string s = @"		
<script language=Javascript>
      function KendoPostBack(eventTarget, eventArgument) 
      {
				var theform = document.forms[0];
				theform.__EVENTTARGET.value = eventTarget;
				theform.__EVENTARGUMENT.value = eventArgument;
				theform.submit();
			}
</script>";

            page.RegisterStartupScript("sds", s);
        }
        //    /// <summary>
        //    /// 弹出JavaScript小窗口
        //    /// </summary>
        //    /// <param name="js">窗口信息</param>
        //    public static void Alert(string message)
        //    {
        //        message = StringUtil.DeleteUnVisibleChar(message);
        //        string js = @"<Script language='JavaScript'>
        //                    alert('" + message + "');</Script>";
        //        HttpContext.Current.Response.Write(js);
        //    }
        public static void Alert(object message)
        {
            string js = @"<Script language='JavaScript'>
                    alert('{0}');  
                  </Script>";
            HttpContext.Current.Response.Write(string.Format(js, message.ToString()));
        }
        public static void Alert(object message, Literal ltlScript)
        {
            string js = @"<Script> function window.onload() {alert('{0}');};</Script>";
            //            string js = @"<Script language='JavaScript'>
            //                    function window.onload() {alert('{0}');};  
            //                  </Script>";
            //ltlScript.Text = "<script >function window.onload() {alert('" + message.ToString() + "');}</script>";
            ltlScript.Text = "<script >alert('" + message.ToString() + "');</script>";
        }

        /// <summary>
        /// 此js不明白具体的用法
        /// </summary>
        /// <param name="message"></param>
        /// <param name="strWinCtrl"></param>
        public static void RtnRltMsgbox(object message, string strWinCtrl)
        {
            string js = @"<Script language='JavaScript'>
					 strWinCtrl = true;
                     strWinCtrl = if(!confirm('" + message + "'))return false;</Script>";
            HttpContext.Current.Response.Write(string.Format(js, message.ToString()));
        }

        /// <summary>
        /// 回到历史页面
        /// </summary>
        /// <param name="value">-1/1</param>
        public static void GoHistory(int value)
        {
            string js = @"<Script language='JavaScript'>
                    history.go({0});  
                  </Script>";
            HttpContext.Current.Response.Write(string.Format(js, value));
        }
        /// <summary>
        /// 关闭当前窗口,并且提示
        /// </summary>
        public static void AlterAndCloseWindow(string message)
        {
            string js = string.Format(@"<Script language='JavaScript'>
                  alert('{0}');                      
                  window.close();  
                  </Script>", message);
            HttpContext.Current.Response.Write(js);
            HttpContext.Current.Response.End();
        }
        /// <summary>
        /// 关闭当前窗口
        /// </summary>
        public static void CloseWindow()
        {
            string js = @"<Script language='JavaScript'>
                    window.close();  
                  </Script>";
            HttpContext.Current.Response.Write(js);
            HttpContext.Current.Response.End();
        }

        /// <summary>
        /// 刷新父窗口
        /// </summary>
        public static void RefreshParent()
        {
            string js = @"<Script language='JavaScript'>
                    parent.location.reload();
                  </Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        /// 格式化为JS可解释的字符串
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string JSStringFormat(string s)
        {
            return s.Replace("\r", "\\r").Replace("\n", "\\n").Replace("'", "\\'").Replace("\"", "\\\"");
        }

        /// <summary>
        /// 刷新打开窗口
        /// </summary>
        public static void RefreshOpener()
        {
            string js = @"<Script language='JavaScript'>
                    opener.location.reload();
                  </Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        /// 打开窗口
        /// </summary>
        /// <param name="url"></param>
        public static void OpenWebForm(string url)
        {

            /*…………………………………………………………………………………………*/
            /*修改人员:			*/
            /*修改时间:		*/
            /*修改目的:	新开页面去掉ie的菜单。。。						*/
            /*注释内容:								*/
            /*开始*/
            string js = @"<Script language='JavaScript'>
			//window.open('" + url + @"');
			window.open('" + url + @"','','left=310,top=120,width=379,height=142,location=no,menubar=no,resizable=no,scrollbars=no,status=no,titlebar=no,toolbar=no,directories=no');
			</Script>";
            /*结束*/
            /*…………………………………………………………………………………………*/
            HttpContext.Current.Response.Write(js);
        }
        public static void OpenWebForm(string url, string name, string future)
        {
            string js = @"<Script language='JavaScript'>
                     window.open('" + url + @"','" + name + @"','" + future + @"')
                  </Script>";
            HttpContext.Current.Response.Write(js);
        }
        public static void OpenWebForm(string url, string formName)
        {
            /*…………………………………………………………………………………………*/
            /*修改人员:							*/
            /*修改时间:	
            /*修改目的:	新开页面去掉ie的菜单。。。						*/
            /*注释内容:								*/
            /*开始*/
            string js = @"<Script language='JavaScript'>
			//window.open('" + url + @"','" + formName + @"');
			window.open('" + url + @"','" + formName + @"','height=0,width=0,top=0,left=0,location=no,menubar=no,resizable=yes,scrollbars=yes,status=yes,titlebar=no,toolbar=no,directories=no');
			</Script>";
            /*结束*/
            /*…………………………………………………………………………………………*/

            HttpContext.Current.Response.Write(js);
        }

        /// <summary>		
        /// 函数名:OpenWebForm	
        /// 功能描述:打开WEB窗口	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        /// <param name="url">WEB窗口</param>
        /// <param name="isFullScreen">是否全屏幕</param>
        public static void OpenWebForm(string url, bool isFullScreen)
        {
            string js = @"<Script language='JavaScript'>";
            if (isFullScreen)
            {
                js += "var iWidth = 0;";
                js += "var iHeight = 0;";
                js += "iWidth=window.screen.availWidth-10;";
                js += "iHeight=window.screen.availHeight-50;";
                js += "var szFeatures ='width=' + iWidth + ',height=' + iHeight + ',top=0,left=0,location=no,menubar=no,resizable=yes,scrollbars=yes,status=yes,titlebar=no,toolbar=no,directories=no';";
                js += "window.open('" + url + @"','',szFeatures);";
            }
            else
            {
                js += "window.open('" + url + @"','','height=0,width=0,top=0,left=0,location=no,menubar=no,resizable=yes,scrollbars=yes,status=yes,titlebar=no,toolbar=no,directories=no');";
            }
            js += "</Script>";
            HttpContext.Current.Response.Write(js);
        }
        /// <summary>
        /// 转向Url制定的页面
        /// </summary>
        /// <param name="url"></param>
        public static void JavaScriptLocationHref(string url)
        {
            string js = @"<Script language='JavaScript'>
                    window.location.replace('{0}');
                  </Script>";
            js = string.Format(js, url);
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        /// 指定的框架页面转换
        /// </summary>
        /// <param name="FrameName"></param>
        /// <param name="url"></param>
        public static void JavaScriptFrameHref(string FrameName, string url)
        {
            string js = @"<Script language='JavaScript'>
					
                    @obj.location.replace(""{0}"");
                  </Script>";
            js = js.Replace("@obj", FrameName);
            js = string.Format(js, url);
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        ///重置页面
        /// </summary>
        public static void JavaScriptResetPage(string strRows)
        {
            string js = @"<Script language='JavaScript'>
                    window.parent.CenterFrame.rows='" + strRows + "';</Script>";
            HttpContext.Current.Response.Write(js);
        }
        /// <summary>
        /// 函数名:JavaScriptSetCookie
        /// 功能描述:客户端方法设置Cookie
        /// 作者:
        /// 日期：
        /// 版本：
        /// </summary>
        /// <param name="strName">Cookie名</param>
        /// <param name="strValue">Cookie值</param>
        public static void JavaScriptSetCookie(string strName, string strValue)
        {
            string js = @"<script language=Javascript>
			var the_cookie = '" + strName + "=" + strValue + @"'
			var dateexpire = 'Tuesday, 01-Dec-2020 12:00:00 GMT';
			//document.cookie = the_cookie;//写入Cookie<BR>} <BR>
			document.cookie = the_cookie + '; expires='+dateexpire;			
			</script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>		
        /// 函数名:GotoParentWindow	
        /// 功能描述:返回父窗口	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 2003-04-30 10:00
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        /// <param name="parentWindowUrl">父窗口</param>		
        public static void GotoParentWindow(string parentWindowUrl)
        {
            string js = @"<Script language='JavaScript'>
                    this.parent.location.replace('" + parentWindowUrl + "');</Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>		
        /// 函数名:ReplaceParentWindow	
        /// 功能描述:替换父窗口	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 2003-04-30 10:00
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        /// <param name="parentWindowUrl">父窗口</param>
        /// <param name="caption">窗口提示</param>
        /// <param name="future">窗口特征参数</param>
        public static void ReplaceParentWindow(string parentWindowUrl, string caption, string future)
        {
            string js = "";
            if (future != null && future.Trim() != "")
            {
                js = @"<script language=javascript>this.parent.location.replace('" + parentWindowUrl + "','" + caption + "','" + future + "');</script>";
            }
            else
            {
                js = @"<script language=javascript>var iWidth = 0 ;var iHeight = 0 ;iWidth=window.screen.availWidth-10;iHeight=window.screen.availHeight-50;
							var szFeatures = 'dialogWidth:'+iWidth+';dialogHeight:'+iHeight+';dialogLeft:0px;dialogTop:0px;center:yes;help=no;resizable:on;status:on;scroll=yes';this.parent.location.replace('" + parentWindowUrl + "','" + caption + "',szFeatures);</script>";
            }

            HttpContext.Current.Response.Write(js);
        }


        /// <summary>		
        /// 函数名:ReplaceOpenerWindow	
        /// 功能描述:替换当前窗体的打开窗口	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 2003-04-30 16:00
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        /// <param name="openerWindowUrl">当前窗体的打开窗口</param>		
        public static void ReplaceOpenerWindow(string openerWindowUrl)
        {
            string js = @"<Script language='JavaScript'>
                    window.opener.location.replace('" + openerWindowUrl + "');</Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>		
        /// 函数名:ReplaceOpenerParentWindow	
        /// 功能描述:替换当前窗体的打开窗口的父窗口	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 2003-07-03 19:00
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        /// <param name="openerWindowUrl">当前窗体的打开窗口的父窗口</param>		
        public static void ReplaceOpenerParentFrame(string frameName, string frameWindowUrl)
        {
            string js = @"<Script language='JavaScript'>
                    window.opener.parent." + frameName + ".location.replace('" + frameWindowUrl + "');</Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>		
        /// 函数名:ReplaceOpenerParentWindow	
        /// 功能描述:替换当前窗体的打开窗口的父窗口	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        /// <param name="openerWindowUrl">当前窗体的打开窗口的父窗口</param>		
        public static void ReplaceOpenerParentWindow(string openerParentWindowUrl)
        {
            string js = @"<Script language='JavaScript'>
                    window.opener.parent.location.replace('" + openerParentWindowUrl + "');</Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>		
        /// 函数名:CloseParentWindow	
        /// 功能描述:关闭窗口	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 2003-04-30 16:00
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        public static void CloseParentWindow()
        {
            string js = @"<Script language='JavaScript'>
                    window.parent.close();  
                  </Script>";
            HttpContext.Current.Response.Write(js);
        }

        public static void CloseOpenerWindow()
        {
            string js = @"<Script language='JavaScript'>
                    window.opener.close();  
                  </Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        /// 函数名:ShowModalDialogJavascript	
        /// 功能描述:返回打开模式窗口的脚本	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        /// <param name="webFormUrl"></param>
        /// <returns></returns>
        public static string ShowModalDialogJavascript(string webFormUrl)
        {
            string js = @"<script language=javascript>
							var iWidth = 0 ;
							var iHeight = 0 ;
							iWidth=window.screen.availWidth-10;
							iHeight=window.screen.availHeight-50;
							var szFeatures = 'dialogWidth:'+iWidth+';dialogHeight:'+iHeight+';dialogLeft:0px;dialogTop:0px;center:yes;help=no;resizable:on;status:on;scroll=yes';
							showModalDialog('" + webFormUrl + "','',szFeatures);</script>";
            return js;
        }

        public static string ShowModalDialogJavascript(string webFormUrl, string features)
        {
            string js = @"<script language=javascript>							
							showModalDialog('" + webFormUrl + "','','" + features + "');</script>";
            return js;
        }

        /// <summary>
        /// 函数名:ShowModalDialogWindow	
        /// 功能描述:打开模式窗口	
        /// 处理流程:
        /// 算法描述:
        /// 作 者: 
        /// 日 期: 
        /// 修 改:
        /// 日 期:
        /// 版 本:
        /// </summary>
        /// <param name="webFormUrl"></param>
        /// <returns></returns>
        public static void ShowModalDialogWindow(string webFormUrl)
        {
            string js = ShowModalDialogJavascript(webFormUrl);
            HttpContext.Current.Response.Write(js);
        }

        public static void ShowModalDialogWindow(string webFormUrl, string features)
        {
            string js = ShowModalDialogJavascript(webFormUrl, features);
            HttpContext.Current.Response.Write(js);
        }
        public static void ShowModalDialogWindow(string webFormUrl, int width, int height, int top, int left)
        {
            string features = "dialogWidth:" + width.ToString() + "px"
                + ";dialogHeight:" + height.ToString() + "px"
                + ";dialogLeft:" + left.ToString() + "px"
                + ";dialogTop:" + top.ToString() + "px"
                + ";center:yes;help=no;resizable:no;status:no;scroll=no";
            ShowModalDialogWindow(webFormUrl, features);
        }

        public static void SetHtmlElementValue(string formName, string elementName, string elementValue)
        {
            string js = @"<Script language='JavaScript'>if(document." + formName + "." + elementName + "!=null){document." + formName + "." + elementName + ".value =" + elementValue + ";}</Script>";
            HttpContext.Current.Response.Write(js);
        }

        /// <summary>
        /// 判断Session中某键值是否存在，如果不存在，输出提示信息
        /// 并且转向相应页面
        /// </summary>
        /// <param name="SessionName">Session中键名称</param>
        /// <param name="Message">提示信息</param>
        /// <param name="RedirectUrl">要转向的页面</param>
        public static void CheckSession(string SessionName, string Message, string RedirectUrl)
        {
            Session = HttpContext.Current.Session;
            Response = HttpContext.Current.Response;
            if (Session[SessionName] == null)
            {
                WriteMessage(Message, false, false);
                string js = "top.document.location='" + RedirectUrl + "';";
                WriteJavaScript(js); ;
            }
        }

        /// <summary>
        /// 用Javascript的Window.alert()方法输出提示信息
        /// </summary>
        /// <param name="strMsg">要输出的信息</param>
        /// <param name="Back">输出信息后是否要history.back()</param>
        /// <param name="End">输出信息后是否要Response.end()</param>
        public static void WriteMessage(string strMsg, bool Back, bool End)
        {
            Response = HttpContext.Current.Response;
            //将单引号替换，防止javascript出错
            strMsg = strMsg.Replace("'", "“");
            //将回车换行符去掉，防止javascript出错
            strMsg = strMsg.Replace("\r\n", "");
            Response.Write("<script language=javascript>alert('" + strMsg + "');</script>");
            if (Back)
                Response.Write("<script language=javascript>history.back();</script>");
            if (End)
                Response.End();
        }

        /// <summary>
        /// 以Response.Write()方式输出一条JavaScript语句
        /// </summary>
        /// <param name="strJavaScript">要输出的JavaScript语句</param>
        public static void WriteJavaScript(string strJavaScript)
        {
            Response = HttpContext.Current.Response;
            Response.Write("<script language=javascript>" + strJavaScript + "</script>");
        }
        public static string MD5(string s)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(s, "MD5");
        }
    }
}