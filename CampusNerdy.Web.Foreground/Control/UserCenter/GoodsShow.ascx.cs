using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CampusNerdy.Model;

namespace CampusNerdy.Web.Foreground.Control.UserCenter
{
    public delegate void ContextDataShowHandler();

    public partial class GoodsShow : System.Web.UI.UserControl
    {
        CampusNerdy.Bll.UserCenter.UserCenter _bllUserCenter;
        CampusNerdy.Bll.BaseControllerObjects _baseControllerObjects;
        public ContextDataShowHandler ContextDataShow { protected get; set; }
        public GoodsShow()
        {
            _bllUserCenter = new Bll.UserCenter.UserCenter();
            _baseControllerObjects = new CampusNerdy.Bll.BaseControllerObjects();
        }


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void dataBind(string marketID)
        {
            this.dlGoodShow.DataSource = getViewGoodSuperInfo(marketID);
            this.dlGoodShow.DataBind();
        }

        public DataTable getViewGoodSuperInfo(string marketID)
        {
            return _bllUserCenter.getViewGoodSuperInfo(marketID);
        }

        protected void dlGoodShow_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Length > 0)
            {
                string[] strs = e.CommandName.ToString().Split('-');
                _bllUserCenter.checkOutItemAddByGoodShow("1", strs[0], strs[1]);
            }
            if (ContextDataShow != null) 
            {
                ContextDataShow();
            }
        }
    }
}