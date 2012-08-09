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

namespace CampusNerdy.IDal
{
    /// <summary>
    /// 用户表
    /// </summary>
    public interface IUserDal
    {
        
        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraUserid">用户编号</param>
        /// <returns>查询成功返回true，否则返回false</returns>
        bool existModeByUserid(string paraUserid);
        #endregion

        #region[删除数据]
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="paraUserid">用户编号</param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        bool deleteModeByUserid(string paraUserid);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="paraTb_User"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        bool deleteMode(tb_User paraTb_User);
        #endregion

        #region[更新数据]
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="paraTb_User"></param>
        /// <returns>true：更新成功，false：不存在该记录</returns>
        bool updateMode(tb_User paraTb_User);
        #endregion

        #region[插入数据]
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="paraTb_User"></param>
        /// <returns>true：插入成功，false：已存在该记录</returns>
        bool addMode(tb_User paraTb_User);
        #endregion

        #region[获取单个数据模型对象]
        /// <summary>
        /// 查询表单，获取单个数据模型对象
        /// </summary>
        /// <param name="paraUserid">用户编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        tb_User getModelByUserid(string paraUserid);
        /// <summary>
        /// 查询表单，获取单个数据模型对象
        /// </summary>
        /// <param name="paraUserid">用户编号</param>
        /// <param name="paraHashed_Password">加密后密码</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        tb_User getModelByUseridAndHashed_Password(string paraUserid,string paraHashed_Password);
        #endregion

        #region[获取模型实体集合]
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <param name="paraUserid">用户编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_User> getListByUserid(string paraUserid);
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_User> getList();
        #endregion

    }
}