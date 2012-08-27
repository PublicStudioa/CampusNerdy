using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CampusNerdy.Common.CHelper;
using System.Data;
namespace CampusNerdy.Web.Background.Control.UserCenter
{
    public partial class tlChechOutDetailRT : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public string addThisGood(string aaa)
        {
            JS.Alert(aaa);
            return "ddd";
        }



        public void dataBind(string checkOutID = "aaaaaa")
        {
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
            DataTable dtTemp = new DataTable();
            dtTemp.Columns.Add("GoodNameACount", "".GetType());
            List<string> ls = new List<string> { checkOutID, "lulululullu" };
            foreach (string one in ls)
            {
                DataRow dr = dtTemp.NewRow();
                dr["GoodNameACount"] = one;
                dtTemp.Rows.Add(dr);
            }
            return dtTemp;
        }

        protected void dtlChechOutDetail_ItemCommand(object source, DataListCommandEventArgs e)
        {
            if (e.CommandName.Length > 0)
            {

              
                string[] strs = e.CommandName.ToString().Split('-');
                if (strs[1] == "plus")
                {
                    lbMarketName.Text= "加1" + strs[0] ;
                }
                else
                {
                    lbMarketName.Text = "减1" + strs[0];
                }
            }
        }


    }

}