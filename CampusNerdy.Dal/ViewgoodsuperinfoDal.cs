/******************************************
 * 说明：本文件由代码工具自动生成。
 * 版本：V1.0.0
 * 版权：贵州省邮电规划设计院有限公司 * 制作：蓝善根
 * 时间：2012年10月14日 01:03:43
 ******************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CampusNerdy.IDal;
using CampusNerdy.Model;
using CampusNerdy.IDal;

namespace CampusNerdy.Dal
{
    /// <summary>
    /// 
    /// </summary>
    public class ViewgoodsuperinfoDal 
    {
        //日志数据库写入接口
        CampusNerdyEntities _context;

        #region 构造函数
        public ViewgoodsuperinfoDal()
        {
            _context = new CampusNerdyEntities(SqlDBCon.ShopEntityCon);
        }
        #endregion

        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraGoodsuperid">此项ID未验证ID当发现</param>
        /// <returns>查询成功返回true，否则返回false</returns>
        public bool existModeByGoodsuperid(string paraGoodsuperid)
        {
            try
            {
                Int32 tempGoodsuperid =  Int32.Parse(paraGoodsuperid.Trim());

                var query = from p in _context.View_ViewGoodSuperInfo
                    where p.GoodSuperID == tempGoodsuperid 
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
        /// <param name="paraGoodsuperid">此项ID未验证ID当发现</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public View_ViewGoodSuperInfo getModelByGoodsuperid(string paraGoodsuperid)
        {
            try
            {
                Int32 tempGoodsuperid =  Int32.Parse(paraGoodsuperid.Trim());

                var query = from p in _context.View_ViewGoodSuperInfo
                    
                    where p.GoodSuperID == tempGoodsuperid 
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
        public List<View_ViewGoodSuperInfo> getListBySupermarketid(string paraSupermarketid)
        {
            try
            {
                Int32 tempSupermarketid =  Int32.Parse(paraSupermarketid.Trim());

                var query = from p in _context.View_ViewGoodSuperInfo
                    where p.SuperMarketId == tempSupermarketid 
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
        /// <param name="paraSupermarketid">此项为冗余字段与GoodSuperId一起放在</param>
        /// <param name="paraIsusegood"></param>
        /// <param name="paraIsusegoodinmarket"></param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<View_ViewGoodSuperInfo> getListBySupermarketidAndIsusegoodAndIsusegoodinmarket(string paraSupermarketid,string paraIsusegood,string paraIsusegoodinmarket)
        {
            try
            {
                Int32 tempSupermarketid =  Int32.Parse(paraSupermarketid.Trim());
Boolean tempIsusegood =  Boolean.Parse(paraIsusegood.Trim());
Boolean tempIsusegoodinmarket =  Boolean.Parse(paraIsusegoodinmarket.Trim());

                var query = from p in _context.View_ViewGoodSuperInfo
                    where p.SuperMarketId == tempSupermarketid && p.IsUseGood == tempIsusegood && p.IsUseGoodInMarket == tempIsusegoodinmarket 
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
        /// <param name="paraGoodid">商品编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<View_ViewGoodSuperInfo> getListByGoodid(string paraGoodid)
        {
            try
            {
                Int32 tempGoodid =  Int32.Parse(paraGoodid.Trim());

                var query = from p in _context.View_ViewGoodSuperInfo
                    where p.GoodId == tempGoodid 
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
        public List<View_ViewGoodSuperInfo> getList()
        {
            try
            {
                var query = from p in _context.View_ViewGoodSuperInfo
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