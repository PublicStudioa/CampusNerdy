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
    /// 区域表
    /// </summary>
    public class AreaDal:IAreaDal
    {
        //日志数据库写入接口
        CampusNerdyEntities _context;

        #region 构造函数
        public AreaDal()
        {
            _context = new CampusNerdyEntities(SqlDBCon.ShopEntityCon);
        }
        #endregion

        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraAreaid">区域编号</param>
        /// <returns>查询成功返回true，否则返回false</returns>
        public bool existModeByAreaid(string paraAreaid)
        {
            try
            {
                var query = from p in _context.tb_Area
                    where p.AreaId == paraAreaid 
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
        /// <param name="paraAreaid">区域编号</param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteModeByAreaid(string paraAreaid)
        {
            if(paraAreaid == null)
                throw new ArgumentNullException("paraAreaid");
            try
            {
                var query = from p in _context.tb_Area
                    where p.AreaId == paraAreaid 
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
                            _context.tb_Area.Attach(model);
                        _context.tb_Area.DeleteObject(model);
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
        /// <param name="paraTb_Area"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteMode(tb_Area paraTb_Area)
        {
            if(paraTb_Area == null)
                throw new ArgumentNullException("paraTb_Area");
            try
            {
                var query = from p in _context.tb_Area
                    where p.AreaId == paraTb_Area.AreaId 
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
                            _context.tb_Area.Attach(model);
                        _context.tb_Area.DeleteObject(model);
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
        /// <param name="paraTb_Area"></param>
        /// <returns>true：更新成功，false：更新数据失败，不存在该记录！</returns>
        public bool updateMode(tb_Area paraTb_Area)
        {
            if(paraTb_Area == null)
                throw new ArgumentNullException("paraTb_Area");
            try
            {
                var oldEntity = (from p in _context.tb_Area
                    where p.AreaId == paraTb_Area.AreaId 
                    select p).FirstOrDefault();
                if (oldEntity == null)
                {
                    return false;
                }
                else
                {
                    _context.ApplyCurrentValues(oldEntity.GetType().Name, paraTb_Area);
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
        /// <param name="paraTb_Area"></param>
        /// <returns>true：插入成功，false：已存在该记录</returns>
        public bool addMode(tb_Area paraTb_Area)
        {
            if(paraTb_Area == null)
                throw new ArgumentNullException("paraTb_Area");
            try
            {
                var query = from p in _context.tb_Area
                    where p.AreaId == paraTb_Area.AreaId 
                    select p;
                if (query.ToList().Count() > 0)
                {
                    return false;
                }
                else
                {
                    _context.tb_Area.AddObject(paraTb_Area);
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
        /// <param name="paraAreaid">区域编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public tb_Area getModelByAreaid(string paraAreaid)
        {
            try
            {
                var query = from p in _context.tb_Area
                    orderby p.AreaId descending
                    where p.AreaId == paraAreaid 
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
        /// <param name="paraAreaid">区域编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_Area> getListByAreaid(string paraAreaid)
        {
            try
            {
                var query = from p in _context.tb_Area
                    orderby p.AreaId
                    where p.AreaId == paraAreaid 
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
        public List<tb_Area> getList()
        {
            try
            {
                var query = from p in _context.tb_Area
                    orderby p.AreaId
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