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

namespace CampusNerdy.IDal
{
    /// <summary>
    /// 组编号
    /// </summary>
    public interface IGroupDal
    {
        
        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraGroupid"></param>
        /// <returns>查询成功返回true，否则返回false</returns>
        bool existModeByGroupid(string paraGroupid);
        #endregion

        #region[删除数据]
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="paraGroupid"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        bool deleteModeByGroupid(string paraGroupid);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="paraTb_Group"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        bool deleteMode(tb_Group paraTb_Group);
        #endregion

        #region[更新数据]
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="paraTb_Group"></param>
        /// <returns>true：更新成功，false：不存在该记录</returns>
        bool updateMode(tb_Group paraTb_Group);
        #endregion

        #region[插入数据]
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="paraTb_Group"></param>
        /// <returns>true：插入成功，false：已存在该记录</returns>
        bool addMode(tb_Group paraTb_Group);
        #endregion

        #region[获取单个数据模型对象]
        /// <summary>
        /// 查询表单，获取单个数据模型对象
        /// </summary>
        /// <param name="paraGroupid"></param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        tb_Group getModelByGroupid(string paraGroupid);
        #endregion

        #region[获取模型实体集合]
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <param name="paraGroupid"></param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_Group> getListByGroupid(string paraGroupid);
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <param name="paraAreaid"></param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_Group> getListByAreaid(string paraAreaid);
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_Group> getList();
        #endregion

    }
}