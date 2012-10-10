using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CampusNerdy.Web.Foreground.Control.UserCenter
{
    public partial class zxTest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                tlChechOutDetailRT1.dataBind();

            }
        }
    }
}