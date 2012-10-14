using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AjaxControlToolkit;
using CampusNerdy.Model;
namespace CampusNerdy.Web.Foreground.Control.UserCenter
{
    public partial class zxTest : System.Web.UI.Page
    {


        GoodsShow tttt1;

        CampusNerdy.Bll.UserCenter.UserCenter _bllUserCenter;
        CampusNerdy.Bll.BaseControllerObjects _baseControllerObjects;
        public zxTest()
        {
            _bllUserCenter = new Bll.UserCenter.UserCenter();
            _baseControllerObjects = new CampusNerdy.Bll.BaseControllerObjects();
        }

        void page_Init(object sender, EventArgs e)
        {
            
            List<tb_SuperMaket> listaa = getmarketList("GZU_North");
            foreach (tb_SuperMaket one in listaa)
            {
                tttt1 = (GoodsShow)Page.LoadControl(Request.ApplicationPath + "/Control/UserCenter/GoodsShow.ascx");
                tttt1.ContextDataShow = tlChechOutDetailRT1.dataBind;
                TabPanel tpanel = new TabPanel();
                tpanel.HeaderText = one.superMarketName;
                tpanel.Controls.Add(tttt1);
                TabContainer1.Controls.Add(tpanel);
                tttt1.dataBind(one.SuperMarketId.ToString());
            }


           
        }
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                tlChechOutDetailRT1.dataBind();
            }
        }


        public List<tb_SuperMaket> getmarketList(string areaID)
        {
            List<tb_SuperMaket> superMarketList = _baseControllerObjects.supermaketDal.getListByAreaid(areaID);
            return superMarketList;
        }
    }
}