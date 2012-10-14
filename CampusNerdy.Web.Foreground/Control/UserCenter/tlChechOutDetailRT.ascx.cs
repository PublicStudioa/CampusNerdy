using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CampusNerdy.Common.CHelper;
using CampusNerdy.Model;
using System.Data;
namespace CampusNerdy.Web.Foreground.Control.UserCenter
{
    public partial class tlChechOutDetailRT : System.Web.UI.UserControl
    {
        private CampusNerdy.Bll.UserCenter.UserCenter _bllUsercenter;
        public string _marketIMG;
        public tlChechOutDetailRT()
        {
            _bllUsercenter = new Bll.UserCenter.UserCenter();
            _marketIMG = string.Empty;
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string addThisGood(string aaa)
        {
            JS.Alert(aaa);
            return "ddd";
        }



        public void dataBind()
        {
            string checkOutID = "1";
            this.dtlChechOutDetail.DataSource = getDTbyCheckOutID(checkOutID);
            this.dtlChechOutDetail.DataBind();
        }


        /// <summary>
        /// 获取dataTable for 前台dataList显示  
        /// </summary>
        /// <param name="checkOutID"></param>
        /// <returns></returns>
        public DataTable getDTbyCheckOutID(string checkOutID)
        {
            //获取超市-物品对象
            DataTable dt = _bllUsercenter.getCheckOutViewTableByMarketID(checkOutID);
            if (dt != null)
            {
                _marketIMG = dt.Rows[0]["SuperMarketIMG"].ToString();
            }
            return dt;
        }

        protected void dtlChechOutDetail_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Length > 0)
            {


                string[] strs = e.CommandName.ToString().Split('-');
                if (strs[1] == "plus")
                {

                    _bllUsercenter.checkOutItemAddOrSub("1", strs[0], 1, "+");
                    dataBind();
                }
                else
                {

                    _bllUsercenter.checkOutItemAddOrSub("1", strs[0], 1, "-");
                    dataBind();

                }
            }
        }


    }

}