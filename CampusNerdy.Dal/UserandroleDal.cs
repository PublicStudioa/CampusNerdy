/******************************************
 * 说明：本文件由代码工具自动生成。
 * 版本：V1.0.0
 * 版权：贵州省邮电规划设计院有限公司 * 制作：蓝善根
 * 时间：2012年08月27日 22:57:27
 ******************************************/
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CampusNerdy.Model;
using CampusNerdy.IDal;
using nameSpace;

namespace nameSpace
{
    /// <summary>
    /// 
    /// </summary>
    public class UserandroleDal:IUserandroleDal
    {
        //日志数据库写入接口
        CampusNerdyEntities _context;

        #region 构造函数
        public UserandroleDal()
        {
            _context = new  CampusNerdyEntities(SqlDBCon.ShopEntityCon);
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
                var query = from p in _context.View_UserAndRole
                            where p.UserID == paraUserid
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
        /// <param name="paraUserid">用户编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        public View_UserAndRole getModelByUserid(string paraUserid)
        {
            try
            {
                var query = from p in _context.View_UserAndRole

                            where p.UserID == paraUserid
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
        public List<View_UserAndRole> getListByUserid(string paraUserid)
        {
            try
            {
                var query = from p in _context.View_UserAndRole
                            where p.UserID == paraUserid
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
        /// <param name="paraRoletype">角色类型</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<View_UserAndRole> getListByRoletype(string paraRoletype)
        {
            try
            {
                var query = from p in _context.View_UserAndRole
                            where p.RoleType == paraRoletype
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
        /// <param name="paraRoleid">角色编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        public List<View_UserAndRole> getListByRoleid(string paraRoleid)
        {
            try
            {
                var query = from p in _context.View_UserAndRole
                            where p.RoleID == paraRoleid
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
        public List<View_UserAndRole> getList()
        {
            try
            {
                var query = from p in _context.View_UserAndRole
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