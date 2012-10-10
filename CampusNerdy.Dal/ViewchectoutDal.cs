/******************************************
 * 说明：本文件由代码工具自动生成。
 * 版本：V1.0.0
 * 版权：贵州省邮电规划设计院有限公司 * 制作：蓝善根
 * 时间：2012年09月21日 21:54:13
 ******************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CampusNerdy.IDal;
using CampusNerdy.Model;
using nameSpace;

namespace CampusNerdy.Dal
{
    /// <summary>
    /// 
    /// </summary>
    public class ViewchectoutDal
    {
        //日志数据库写入接口
        CampusNerdyEntities _context;
        #region 构造函数
        public ViewchectoutDal()
        {
            _context = new CampusNerdyEntities(SqlDBCon.ShopEntityCon);
        }
        #endregion

        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraCheckoutid"></param>
        /// <returns>查询成功返回true，否则返回false</returns>
        public bool existModeByCheckoutid(string paraCheckoutid)
        {
            try
            {
                Int32 tempCheckoutid = Int32.Parse(paraCheckoutid.Trim());

                var query = from p in _context.View_ViewChectOut
                            where p.CheckOutID == tempCheckoutid
                            select p;
                return query.ToList().Count() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region[获取单个数据模型对象]
        /// <summary>
        /// 查询表单，获取单个数据模型对象
        /// </summary>
        /// <param name="paraID"></param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public View_ViewChectOut getModelByID(string paraID)
        {
            try
            {
                Int32 tempID = Int32.Parse(paraID.Trim());

                var query = from p in _context.View_ViewChectOut

                            where p.ID == tempID
                            select p;
                return query.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region[获取模型实体集合]
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <param name="paraSupermarketid">此项为冗余字段与GoodSuperId一起放在</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<View_ViewChectOut> getListBySupermarketid(string paraSupermarketid)
        {
            try
            {
                Int32 tempSupermarketid = Int32.Parse(paraSupermarketid.Trim());

                var query = from p in _context.View_ViewChectOut
                            where p.SuperMarketID == tempSupermarketid
                            select p;
                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <param name="paraCheckoutid"></param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<View_ViewChectOut> getListByCheckoutid(string paraCheckoutid)
        {
            try
            {
                Int32 tempCheckoutid = Int32.Parse(paraCheckoutid.Trim());

                var query = from p in _context.View_ViewChectOut
                            where p.CheckOutID == tempCheckoutid
                            select p;
                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<View_ViewChectOut> getList()
        {
            try
            {
                var query = from p in _context.View_ViewChectOut
                            select p;
                return query.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

    }
}