/******************************************
 * 说明：本文件由代码工具自动生成。
 * 版本：V1.0.0
 * 版权：贵州省邮电规划设计院有限公司 * 制作：蓝善根
 * 时间：2012年08月06日 22:25:14
 ******************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CampusNerdy.Model;
using CampusNerdy.IDal;

namespace CampusNerdy.Dal
{
    /// <summary>
    /// 商品和超市的关联表
    /// </summary>
    public class GoodinfotosupermarketDal:IGoodinfotosupermarketDal
    {
        //日志数据库写入接口
        CampusNerdyEntities _context;

        #region 构造函数
        public GoodinfotosupermarketDal()
        {
            _context = new CampusNerdyEntities(SqlDBCon.ShopEntityCon);
        }
        #endregion

        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraGoodsuperid">商品超市关系编号</param>
        /// <returns>查询成功返回true，否则返回false</returns>
        public bool existModeByGoodsuperid(string paraGoodsuperid)
        {
            try
            {
                Int32 tempGoodsuperid =  Int32.Parse(paraGoodsuperid.Trim());

                var query = from p in _context.tb_GoodInfoToSuperMarket
                    where p.GoodSuperId == tempGoodsuperid 
                    select p;
                return query.ToList().Count() > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region[删除数据]
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="paraGoodsuperid">商品超市关系编号</param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteModeByGoodsuperid(string paraGoodsuperid)
        {
            if(paraGoodsuperid == null)
                throw new ArgumentNullException("paraGoodsuperid");
            try
            {
                Int32 tempGoodsuperid =  Int32.Parse(paraGoodsuperid.Trim());

                var query = from p in _context.tb_GoodInfoToSuperMarket
                    where p.GoodSuperId == tempGoodsuperid 
                    select p;
                if (query.ToList().Count<1)
                {
                    return false;
                }
                else
                {
                    foreach(var model in query.ToList())
                    {
                        if(!_context.IsAttached(model))
                            _context.tb_GoodInfoToSuperMarket.Attach(model);
                        _context.tb_GoodInfoToSuperMarket.DeleteObject(model);
                        _context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="paraTb_Goodinfotosupermarket"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteMode(tb_GoodInfoToSuperMarket paraTb_Goodinfotosupermarket)
        {
            if(paraTb_Goodinfotosupermarket == null)
                throw new ArgumentNullException("paraTb_Goodinfotosupermarket");
            try
            {
                var query = from p in _context.tb_GoodInfoToSuperMarket
                    where p.GoodSuperId == paraTb_Goodinfotosupermarket.GoodSuperId 
                    select p;
                if (query.ToList().Count<1)
                {
                    return false;
                }
                else
                {
                    foreach(var model in query.ToList())
                    {
                        if(!_context.IsAttached(model))
                            _context.tb_GoodInfoToSuperMarket.Attach(model);
                        _context.tb_GoodInfoToSuperMarket.DeleteObject(model);
                        _context.SaveChanges();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region[更新数据]
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="paraTb_Goodinfotosupermarket"></param>
        /// <returns>true：更新成功，false：更新数据失败，不存在该记录！</returns>
        public bool updateMode(tb_GoodInfoToSuperMarket paraTb_Goodinfotosupermarket)
        {
            if(paraTb_Goodinfotosupermarket == null)
                throw new ArgumentNullException("paraTb_Goodinfotosupermarket");
            try
            {
                var oldEntity = (from p in _context.tb_GoodInfoToSuperMarket
                    where p.GoodSuperId == paraTb_Goodinfotosupermarket.GoodSuperId 
                    select p).FirstOrDefault();
                if (oldEntity == null)
                {
                    return false;
                }
                else
                {
                    _context.ApplyCurrentValues(oldEntity.GetType().Name, paraTb_Goodinfotosupermarket);
                    _context.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region[插入数据]
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="paraTb_Goodinfotosupermarket"></param>
        /// <returns>true：插入成功，false：已存在该记录</returns>
        public bool addMode(tb_GoodInfoToSuperMarket paraTb_Goodinfotosupermarket)
        {
            if(paraTb_Goodinfotosupermarket == null)
                throw new ArgumentNullException("paraTb_Goodinfotosupermarket");
            try
            {
                var query = from p in _context.tb_GoodInfoToSuperMarket
                    where p.GoodSuperId == paraTb_Goodinfotosupermarket.GoodSuperId 
                    select p;
                if (query.ToList().Count() > 0)
                {
                    return false;
                }
                else
                {
                    _context.tb_GoodInfoToSuperMarket.AddObject(paraTb_Goodinfotosupermarket);
                    _context.SaveChanges();
                    return true;
                }
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
        /// <param name="paraGoodid">商品编号</param>
        /// <param name="paraSupermarketid">超市编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public tb_GoodInfoToSuperMarket getModelByGoodidAndSupermarketid(string paraGoodid,string paraSupermarketid)
        {
            try
            {
                Int32 tempGoodid =  Int32.Parse(paraGoodid.Trim());
Int32 tempSupermarketid =  Int32.Parse(paraSupermarketid.Trim());

                var query = from p in _context.tb_GoodInfoToSuperMarket
                    orderby p.GoodSuperId descending
                    where p.GoodId == tempGoodid && p.SuperMarketId == tempSupermarketid 
                    select p;
                return query.FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// 查询表单，获取单个数据模型对象
        /// </summary>
        /// <param name="paraGoodsuperid">商品超市关系编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public tb_GoodInfoToSuperMarket getModelByGoodsuperid(string paraGoodsuperid)
        {
            try
            {
                Int32 tempGoodsuperid =  Int32.Parse(paraGoodsuperid.Trim());

                var query = from p in _context.tb_GoodInfoToSuperMarket
                    orderby p.GoodSuperId descending
                    where p.GoodSuperId == tempGoodsuperid 
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
        /// <param name="paraSupermarketid">超市编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_GoodInfoToSuperMarket> getListBySupermarketid(string paraSupermarketid)
        {
            try
            {
                Int32 tempSupermarketid =  Int32.Parse(paraSupermarketid.Trim());

                var query = from p in _context.tb_GoodInfoToSuperMarket
                    orderby p.GoodSuperId
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
        /// <param name="paraGoodid">商品编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_GoodInfoToSuperMarket> getListByGoodid(string paraGoodid)
        {
            try
            {
                Int32 tempGoodid =  Int32.Parse(paraGoodid.Trim());

                var query = from p in _context.tb_GoodInfoToSuperMarket
                    orderby p.GoodSuperId
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
        /// <param name="paraGoodsuperid">商品超市关系编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_GoodInfoToSuperMarket> getListByGoodsuperid(string paraGoodsuperid)
        {
            try
            {
                Int32 tempGoodsuperid =  Int32.Parse(paraGoodsuperid.Trim());

                var query = from p in _context.tb_GoodInfoToSuperMarket
                    orderby p.GoodSuperId
                    where p.GoodSuperId == tempGoodsuperid 
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
        public List<tb_GoodInfoToSuperMarket> getList()
        {
            try
            {
                var query = from p in _context.tb_GoodInfoToSuperMarket
                    orderby p.GoodSuperId
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