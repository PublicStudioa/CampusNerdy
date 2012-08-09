/******************************************
 * 说明：本文件由代码工具自动生成。
 * 版本：V1.0.0
 * 版权：贵州省邮电规划设计院有限公司 * 制作：蓝善根
 * 时间：2012年08月06日 22:25:16
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
    /// 用户表
    /// </summary>
    public class UserDal:IUserDal
    {
        //日志数据库写入接口
        CampusNerdyEntities _context;

        #region 构造函数
        public UserDal()
        {
            _context = new CampusNerdyEntities(SqlDBCon.ShopEntityCon);
        }
        #endregion

        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraUserid">用户编号</param>
        /// <returns>查询成功返回true，否则返回false</returns>
        public bool existModeByUserid(string paraUserid)
        {
            try
            {
                var query = from p in _context.tb_User
                    where p.UserId == paraUserid 
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
        /// <param name="paraUserid">用户编号</param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteModeByUserid(string paraUserid)
        {
            if(paraUserid == null)
                throw new ArgumentNullException("paraUserid");
            try
            {
                var query = from p in _context.tb_User
                    where p.UserId == paraUserid 
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
                            _context.tb_User.Attach(model);
                        _context.tb_User.DeleteObject(model);
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
        /// <param name="paraTb_User"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        public bool deleteMode(tb_User paraTb_User)
        {
            if(paraTb_User == null)
                throw new ArgumentNullException("paraTb_User");
            try
            {
                var query = from p in _context.tb_User
                    where p.UserId == paraTb_User.UserId 
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
                            _context.tb_User.Attach(model);
                        _context.tb_User.DeleteObject(model);
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
        /// <param name="paraTb_User"></param>
        /// <returns>true：更新成功，false：更新数据失败，不存在该记录！</returns>
        public bool updateMode(tb_User paraTb_User)
        {
            if(paraTb_User == null)
                throw new ArgumentNullException("paraTb_User");
            try
            {
                var oldEntity = (from p in _context.tb_User
                    where p.UserId == paraTb_User.UserId 
                    select p).FirstOrDefault();
                if (oldEntity == null)
                {
                    return false;
                }
                else
                {
                    _context.ApplyCurrentValues(oldEntity.GetType().Name, paraTb_User);
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
        /// <param name="paraTb_User"></param>
        /// <returns>true：插入成功，false：已存在该记录</returns>
        public bool addMode(tb_User paraTb_User)
        {
            if(paraTb_User == null)
                throw new ArgumentNullException("paraTb_User");
            try
            {
                var query = from p in _context.tb_User
                    where p.UserId == paraTb_User.UserId 
                    select p;
                if (query.ToList().Count() > 0)
                {
                    return false;
                }
                else
                {
                    _context.tb_User.AddObject(paraTb_User);
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
        /// <param name="paraUserid">用户编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public tb_User getModelByUserid(string paraUserid)
        {
            try
            {
                var query = from p in _context.tb_User
                    orderby p.UserId descending
                    where p.UserId == paraUserid 
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
        /// <param name="paraUserid">用户编号</param>
        /// <param name="paraHashed_Password">加密后密码</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public tb_User getModelByUseridAndHashed_Password(string paraUserid,string paraHashed_Password)
        {
            try
            {
                var query = from p in _context.tb_User
                    orderby p.UserId descending
                    where p.UserId == paraUserid && p.Hashed_PassWord == paraHashed_Password 
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
        /// <param name="paraUserid">用户编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<tb_User> getListByUserid(string paraUserid)
        {
            try
            {
                var query = from p in _context.tb_User
                    orderby p.UserId
                    where p.UserId == paraUserid 
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
        public List<tb_User> getList()
        {
            try
            {
                var query = from p in _context.tb_User
                    orderby p.UserId
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