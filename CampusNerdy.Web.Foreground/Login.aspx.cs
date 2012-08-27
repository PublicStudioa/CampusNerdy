using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CampusNerdy.Bll.UserCenter;

namespace CampusNerdy.Web.Foreground
{
    public partial class Login : System.Web.UI.Page
    {
        #region[私有UserCenter对象]
        private UserCenter _userCenter = new UserCenter();
        #endregion
        private int errCount
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

    }
}