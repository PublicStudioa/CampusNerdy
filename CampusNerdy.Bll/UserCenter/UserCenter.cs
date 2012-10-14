using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using CampusNerdy.Dal;
using CampusNerdy.Model;
using System.Data;
namespace CampusNerdy.Bll.UserCenter
{
    public class UserCenter
    {
        private BaseControllerObjects _baseControllerObject;
        #region 构造函数
        public UserCenter()
        {
            _baseControllerObject = new BaseControllerObjects();
        }
        #endregion
        #region[获取超市商品信息]返回DataTable
        public DataTable getViewGoodSuperInfo(string marketID)
        {
            List<View_ViewGoodSuperInfo> ViewGoodSuperInfoList = _baseControllerObject.viewgoodsuperinfoDal.getListBySupermarketidAndIsusegoodAndIsusegoodinmarket(marketID, "true", "true");
            if (ViewGoodSuperInfoList.Count > 0)
            {
                DataTable dtTemp = new DataTable();
                dtTemp.Columns.Add("GoodName", "".GetType());
                dtTemp.Columns.Add("GoodIMG", "".GetType());
                dtTemp.Columns.Add("GoodSignCost", "".GetType());
                dtTemp.Columns.Add("GoodSuperId", "".GetType());
                dtTemp.Columns.Add("superMarketID", "".GetType());
                foreach (View_ViewGoodSuperInfo one in ViewGoodSuperInfoList)
                {
                    DataRow dr = dtTemp.NewRow();
                    dr["GoodName"] = one.GoodDescription.ToString();
                    dr["GoodIMG"] = one.Image.ToString();
                    dr["GoodSignCost"] = one.Cash.ToString();
                    dr["GoodSuperId"] = one.GoodSuperID.ToString();
                    dr["superMarketID"] = one.SuperMarketId.ToString();
                    dtTemp.Rows.Add(dr);
                }
                return dtTemp;
            }
            return null;
        }



        #endregion



        #region[获取结算商品相关信息]
        public DataTable getCheckOutViewTableByMarketID(string checkOutID)
        {
            //获取超市-物品对象

            List<View_ViewChectOut> viewChectOutList = _baseControllerObject.viewchectoutDal.getListByCheckoutid(checkOutID);
            if (viewChectOutList.Count > 0)
            {
                DataTable dtTemp = new DataTable();
                dtTemp.Columns.Add("SuperMarketName", "".GetType());
                dtTemp.Columns.Add("SuperMarketIMG", "".GetType());
                dtTemp.Columns.Add("GoodName", "".GetType());
                dtTemp.Columns.Add("GoodNameACount", "".GetType());
                dtTemp.Columns.Add("GoodIMG", "".GetType());
                dtTemp.Columns.Add("GoodSignCost", "".GetType());
                dtTemp.Columns.Add("GoodsSumCost", "".GetType());
                dtTemp.Columns.Add("GoodSuperId", "".GetType());
                foreach (View_ViewChectOut one in viewChectOutList)
                {
                    DataRow dr = dtTemp.NewRow();
                    dr["SuperMarketName"] = one.superMarketName.ToString();
                    dr["SuperMarketIMG"] = one.MarketIMG.ToString();
                    dr["GoodName"] = one.GoodName.ToString();
                    dr["GoodNameACount"] = one.GoodsSuperCount.ToString();
                    dr["GoodIMG"] = one.Image.ToString();
                    dr["GoodSignCost"] = one.Cash.ToString();
                    dr["GoodsSumCost"] = one.GoodsSuperCost.ToString();
                    dr["GoodSuperId"] = one.GoodSuperId.ToString();
                    dtTemp.Rows.Add(dr);
                }
                return dtTemp;
            }
            return null;
        }




        /// <summary>
        /// 结算信息±1
        /// </summary>
        /// <param name="checkOutID"></param>
        /// <param name="addCount"></param>
        /// <returns></returns>
        public bool checkOutItemAddOrSub(string checkOutID, string goodSupId, int addCount, string addOrSub)
        {
            tb_CheckItem checkItemModel = _baseControllerObject.checkItemDal.getModelByCheckoutidAndGoodsuperid(checkOutID, goodSupId);
            tb_GoodInfoToSuperMarket goodSpuerModel = _baseControllerObject.goodinfotosupermarketDal.getModelByGoodsuperid(goodSupId);

            if (checkItemModel != null && goodSpuerModel != null)
            {
                if (addOrSub == "+")
                {
                    checkItemModel.GoodsSuperCount += 1;
                }
                else
                {
                    if (checkItemModel.GoodsSuperCount == 1)
                    {
                        _baseControllerObject.checkItemDal.deleteMode(checkItemModel);
                    }
                    checkItemModel.GoodsSuperCount -= 1;
                }
                checkItemModel.GoodsSuperCost = checkItemModel.GoodsSuperCount * goodSpuerModel.Cash;
                _baseControllerObject.checkItemDal.updateMode(checkItemModel);
                return true;
            }
            return false;
        }
        /// <summary>
        /// 从商品列表里面给购物车添加商品
        /// </summary>
        /// <param name="checkOutID"></param>
        /// <param name="goodSupId"></param>
        /// <param name="superMarketID"></param>
        /// <returns></returns>
        public bool checkOutItemAddByGoodShow(string checkOutID, string goodSupId, string superMarketID)
        {
            tb_CheckItem checkItemModel = _baseControllerObject.checkItemDal.getModelByCheckoutidAndGoodsuperid(checkOutID, goodSupId);
            tb_GoodInfoToSuperMarket goodSpuerModel = _baseControllerObject.goodinfotosupermarketDal.getModelByGoodsuperid(goodSupId);
            if (goodSpuerModel == null) return false;
            if (checkItemModel == null)
            {
                //购物车里面增加字段
                tb_CheckItem checkItem = new tb_CheckItem();
                checkItem.CheckOutID = checkOutID;
                checkItem.GoodSuperId = Int32.Parse(goodSupId);
                checkItem.SuperMarketID = Int32.Parse(superMarketID);
                checkItem.GoodsSuperCount = 1;
                checkItem.GoodsSuperCost = goodSpuerModel.Cash;
                _baseControllerObject.checkItemDal.addMode(checkItem);
            }
            else
            {
                checkOutItemAddOrSub(checkOutID, goodSupId, 1, "+");
            }

            return true;
        }


        #endregion



        #region 普通函数
        public List<string> getCheckOutMarketID(string checkOutID)
        {
            List<string> strListBack = new List<string>();
            List<tb_CheckItem> checkOutItemList = _baseControllerObject.checkItemDal.getListByCheckoutid(checkOutID);
            foreach (tb_CheckItem one in checkOutItemList)
            {
                if (!strListBack.Contains(one.SuperMarketID.ToString()))
                {
                    strListBack.Add(one.SuperMarketID.ToString());
                }
            }
            if (strListBack.Count > 0)
            {
                return strListBack;
            }
            return null;
        }


        #endregion

    }
}
