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
    /// 
    /// </summary>
    public class DictionaryDal:IDictionaryDal
    {
        //日志数据库写入接口
        CampusNerdyEntities _context;

        #region 构造函数
        public DictionaryDal()
        {
            _context = new CampusNerdyEntities(SqlDBCon.ShopEntityCon);
        }
        #endregion

        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraDicid">字典编号</param>
        /// <returns>查询成功返回true，否则返回false</returns>
        public bool existModeByDicid(string paraDicid)
        {
            try
            {
                Int32 tempDicid =  Int32.Parse(paraDicid.Trim());

                var query = from p in _context.tb_Dictionary
                    where p.DicId == tempDicid 
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
        /// <param name="paraDicid">字典编号</param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteModeByDicid(string paraDicid)
        {
            if(paraDicid == null)
                throw new ArgumentNullException("paraDicid");
            try
            {
                Int32 tempDicid =  Int32.Parse(paraDicid.Trim());

                var query = from p in _context.tb_Dictionary
                    where p.DicId == tempDicid 
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
                            _context.tb_Dictionary.Attach(model);
                        _context.tb_Dictionary.DeleteObject(model);
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
        /// <param name="paraTb_Dictionary"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteMode(tb_Dictionary paraTb_Dictionary)
        {
            if(paraTb_Dictionary == null)
                throw new ArgumentNullException("paraTb_Dictionary");
            try
            {
                var query = from p in _context.tb_Dictionary
                    where p.DicId == paraTb_Dictionary.DicId 
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
                            _context.tb_Dictionary.Attach(model);
                        _context.tb_Dictionary.DeleteObject(model);
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
        /// <param name="paraTb_Dictionary"></param>
        /// <returns>true：更新成功，false：更新数据失败，不存在该记录！</returns>
        public bool updateMode(tb_Dictionary paraTb_Dictionary)
        {
            if(paraTb_Dictionary == null)
                throw new ArgumentNullException("paraTb_Dictionary");
            try
            {
                var oldEntity = (from p in _context.tb_Dictionary
                    where p.DicId == paraTb_Dictionary.DicId 
                    select p).FirstOrDefault();
                if (oldEntity == null)
                {
                    return false;
                }
                else
                {
                    _context.ApplyCurrentValues(oldEntity.GetType().Name, paraTb_Dictionary);
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
        /// <param name="paraTb_Dictionary"></param>
        /// <returns>true：插入成功，false：已存在该记录</returns>
        public bool addMode(tb_Dictionary paraTb_Dictionary)
        {
            if(paraTb_Dictionary == null)
                throw new ArgumentNullException("paraTb_Dictionary");
            try
            {
                var query = from p in _context.tb_Dictionary
                    where p.DicId == paraTb_Dictionary.DicId 
                    select p;
                if (query.ToList().Count() > 0)
                {
                    return false;
                }
                else
                {
                    _context.tb_Dictionary.AddObject(paraTb_Dictionary);
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
        /// <param name="paraDicid">字典编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public tb_Dictionary getModelByDicid(string paraDicid)
        {
            try
            {
                Int32 tempDicid =  Int32.Parse(paraDicid.Trim());

                var query = from p in _context.tb_Dictionary
                    orderby p.DicId descending
                    where p.DicId == tempDicid 
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
        /// <param name="paraDickey">键</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public tb_Dictionary getModelByDickey(string paraDickey)
        {
            try
            {
                var query = from p in _context.tb_Dictionary
                    orderby p.DicId descending
                    where p.dicKey == paraDickey 
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
        /// <param name="paraDicid">字典编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_Dictionary> getListByDicid(string paraDicid)
        {
            try
            {
                Int32 tempDicid =  Int32.Parse(paraDicid.Trim());

                var query = from p in _context.tb_Dictionary
                    orderby p.DicId
                    where p.DicId == tempDicid 
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
        /// <param name="paraDicprekey">父键</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_Dictionary> getListByDicprekey(string paraDicprekey)
        {
            try
            {
                var query = from p in _context.tb_Dictionary
                    orderby p.DicId
                    where p.dicPreKey == paraDicprekey 
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
        /// <param name="paraDictype">字典类型</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_Dictionary> getListByDictype(string paraDictype)
        {
            try
            {
                var query = from p in _context.tb_Dictionary
                    orderby p.DicId
                    where p.dicType == paraDictype 
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
        public List<tb_Dictionary> getList()
        {
            try
            {
                var query = from p in _context.tb_Dictionary
                    orderby p.DicId
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