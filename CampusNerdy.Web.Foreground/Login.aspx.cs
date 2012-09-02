using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CampusNerdy.Bll.UserCenter;
using CampusNerdy.Model;
using CampusNerdy.Dal;
using CampusNerdy.Bll;
using System.Web.Security;
using CampusNerdy.Common.CHelper;
using System.Text;
using System.Collections;
using System.Data;

namespace CampusNerdy.Web.Foreground
{
    public partial class Login : System.Web.UI.Page
    {
        #region[私有UserCenter对象]
        private UserCenter _userCenter = new UserCenter();
        private BaseControllerObjects _baseControllerObjects = new BaseControllerObjects();
        #endregion
        public int ErrCount
        {
            get
            {
                if (ViewState["ERROR_COUNT"] == null)
                {
                    ViewState["ERROR_COUNT"] = 0;
                }
                return Convert.ToInt32(ViewState["ERROR_COUNT"]);
            }
            set
            {
                ViewState["ERROR_COUNT"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {

            string userName = txtusername.Text.Trim();
            string password = txtpassword.Text;
            if (string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                this.lberrormessage.Text = "你输入的用户名或密码为空！请重新输入";
                this.lberrormessage.Visible = true;
                return;
            }
            //错误三次以上后开始验证码
            if (ErrCount > 3)
            {
                string yanCode = Request.Params["code"].ToUpper();
                if (!yanCode.Equals((string)Session["Code"]))
                {
                    this.lberrormessage.Text = "验证码错误";
                    this.lberrormessage.Visible = true;
                    return;
                }
            }
            else if (ErrCount == 2)
            {
                divCode.Visible = true;
                lblCode.Visible = true;
            }
            //获取当前登录的用户名；
            View_UserAndRole verifyUser = _baseControllerObjects.view_UserandroleDal.getModelByUserid(userName);
            if (verifyUser != null && Convert.ToBoolean(verifyUser.IsUse))
            {
                if (verifyUser.Hashed_PassWord == BaseHelper.getSHA2HashedPassword(password, verifyUser.Salt))
                {
                    SysUser user = new SysUser();
                    user.userName = verifyUser.UserName;
                    user.userID = verifyUser.UserID;
                    user.Description = verifyUser.UserDescribe;
                    user.Email = verifyUser.Email;
                    tb_Group group = _baseControllerObjects.groupDal.getModelByGroupid(user.userID);
                    if (group != null)
                    {
                        user.groupID = group.GroupId;
                    }
                    else
                    {
                        user.groupID = "no-groupID";
                    }
                    Session["curUser"] = user;
                    //  logger.Info(String.Format("登录成功：用户“{0}”", userName));
                    if (!string.IsNullOrEmpty(user.userName))
                    {
                        //判断该用户是否在列表中，如果不存在，则添加；
                        object onlineUserObject = Application.Get("onlineUser");
                        if (onlineUserObject != null)
                        {
                            ArrayList onlineUser = (ArrayList)onlineUserObject;
                            if (!onlineUser.Contains(user.userID))
                                onlineUser.Add(user.userID);
                        }
                    }
                    FormsAuthentication.RedirectFromLoginPage(userName, false);

                    return;
                }
                else
                {
                    //  logger.Warn(String.Format("登录失败：用户“{0}”用户密码错误", userName));
                    this.lberrormessage.Text = "用户名或密码错误！";
                    this.lberrormessage.Visible = true;
                    ErrCount = ErrCount + 1;
                    return;
                }
            }
            else
            {
                //logger.Warn(String.Format("登录失败：用户“{0}”不存在", userName));
                this.lberrormessage.Text = "用户名或密码错误！";
                this.lberrormessage.Visible = true;
                ErrCount = ErrCount + 1;
                return;
            }
        }

    }
}