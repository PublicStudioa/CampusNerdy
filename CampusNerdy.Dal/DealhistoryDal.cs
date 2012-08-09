/******************************************
 * 说明：本文件由代码工具自动生成。
 * 版本：V1.0.0
 * 版权：贵州省邮电规划设计院有限公司 * 制作：蓝善根
 * 时间：2012年08月06日 22:25:13
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
    /// 交易历史表
    /// </summary>
    public class DealhistoryDal:IDealhistoryDal
    {
        //日志数据库写入接口
        CampusNerdyEntities _context;

        #region 构造函数
        public DealhistoryDal()
        {
            _context = new CampusNerdyEntities(SqlDBCon.ShopEntityCon);
        }
        #endregion

        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraDealhid">交易历史编号</param>
        /// <returns>查询成功返回true，否则返回false</returns>
        public bool existModeByDealhid(string paraDealhid)
        {
            try
            {
                Int32 tempDealhid =  Int32.Parse(paraDealhid.Trim());

                var query = from p in _context.tb_DealHistory
                    where p.DealHId == tempDealhid 
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
        /// <param name="paraDealhid">交易历史编号</param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteModeByDealhid(string paraDealhid)
        {
            if(paraDealhid == null)
                throw new ArgumentNullException("paraDealhid");
            try
            {
                Int32 tempDealhid =  Int32.Parse(paraDealhid.Trim());

                var query = from p in _context.tb_DealHistory
                    where p.DealHId == tempDealhid 
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
                            _context.tb_DealHistory.Attach(model);
                        _context.tb_DealHistory.DeleteObject(model);
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
        /// <param name="paraTb_Dealhistory"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteMode(tb_DealHistory paraTb_Dealhistory)
        {
            if(paraTb_Dealhistory == null)
                throw new ArgumentNullException("paraTb_Dealhistory");
            try
            {
                var query = from p in _context.tb_DealHistory
                    where p.DealHId == paraTb_Dealhistory.DealHId 
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
                            _context.tb_DealHistory.Attach(model);
                        _context.tb_DealHistory.DeleteObject(model);
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
        /// <param name="paraTb_Dealhistory"></param>
        /// <returns>true：更新成功，false：更新数据失败，不存在该记录！</returns>
        public bool updateMode(tb_DealHistory paraTb_Dealhistory)
        {
            if(paraTb_Dealhistory == null)
                throw new ArgumentNullException("paraTb_Dealhistory");
            try
            {
                var oldEntity = (from p in _context.tb_DealHistory
                    where p.DealHId == paraTb_Dealhistory.DealHId 
                    select p).FirstOrDefault();
                if (oldEntity == null)
                {
                    return false;
                }
                else
                {
                    _context.ApplyCurrentValues(oldEntity.GetType().Name, paraTb_Dealhistory);
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
        /// <param name="paraTb_Dealhistory"></param>
        /// <returns>true：插入成功，false：已存在该记录</returns>
        public bool addMode(tb_DealHistory paraTb_Dealhistory)
        {
            if(paraTb_Dealhistory == null)
                throw new ArgumentNullException("paraTb_Dealhistory");
            try
            {
                var query = from p in _context.tb_DealHistory
                    where p.DealHId == paraTb_Dealhistory.DealHId 
                    select p;
                if (query.ToList().Count() > 0)
                {
                    return false;
                }
                else
                {
                    _context.tb_DealHistory.AddObject(paraTb_Dealhistory);
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
        /// <param name="paraDealhid">交易历史编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public tb_DealHistory getModelByDealhid(string paraDealhid)
        {
            try
            {
                Int32 tempDealhid =  Int32.Parse(paraDealhid.Trim());

                var query = from p in _context.tb_DealHistory
                    orderby p.DealHId descending
                    where p.DealHId == tempDealhid 
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
        /// <param name="paraDealrequestid">交易请求</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_DealHistory> getListByDealrequestid(string paraDealrequestid)
        {
            try
            {
                Int32 tempDealrequestid =  Int32.Parse(paraDealrequestid.Trim());

                var query = from p in _context.tb_DealHistory
                    orderby p.DealHId
                    where p.DealRequestID == tempDealrequestid 
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
        /// <param name="paraSenderid">送货人ID</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_DealHistory> getListBySenderid(string paraSenderid)
        {
            try
            {
                var query = from p in _context.tb_DealHistory
                    orderby p.DealHId
                    where p.SenderID == paraSenderid 
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
        /// <param name="paraDealhid">交易历史编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_DealHistory> getListByDealhid(string paraDealhid)
        {
            try
            {
                Int32 tempDealhid =  Int32.Parse(paraDealhid.Trim());

                var query = from p in _context.tb_DealHistory
                    orderby p.DealHId
                    where p.DealHId == tempDealhid 
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
        public List<tb_DealHistory> getList()
        {
            try
            {
                var query = from p in _context.tb_DealHistory
                    orderby p.DealHId
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