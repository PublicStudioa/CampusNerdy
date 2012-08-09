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

namespace CampusNerdy.IDal
{
    /// <summary>
    /// 用户商品请求
    /// </summary>
    public interface IDealrequestDal
    {
        
        #region[判断实体是否存在]
        /// <summary>
        /// 查询表单，判断实体是否存在
        /// </summary>
        /// <param name="paraDealrid">交易编号</param>
        /// <returns>查询成功返回true，否则返回false</returns>
        bool existModeByDealrid(string paraDealrid);
        #endregion

        #region[删除数据]
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="paraDealrid">交易编号</param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        bool deleteModeByDealrid(string paraDealrid);
        /// <summary>
        /// 删除数据
        /// </summary>
        /// <param name="paraTb_Dealrequest"></param>
        /// <returns>true：删除成功，false：不存在该记录</returns>
        bool deleteMode(tb_DealRequest paraTb_Dealrequest);
        #endregion

        #region[更新数据]
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="paraTb_Dealrequest"></param>
        /// <returns>true：更新成功，false：不存在该记录</returns>
        bool updateMode(tb_DealRequest paraTb_Dealrequest);
        #endregion

        #region[插入数据]
        /// <summary>
        /// 插入数据
        /// </summary>
        /// <param name="paraTb_Dealrequest"></param>
        /// <returns>true：插入成功，false：已存在该记录</returns>
        bool addMode(tb_DealRequest paraTb_Dealrequest);
        #endregion

        #region[获取单个数据模型对象]
        /// <summary>
        /// 查询表单，获取单个数据模型对象
        /// </summary>
        /// <param name="paraDealrid">交易编号</param>
        /// <returns>null为没找到匹配对象，否则返回单行数据模型对象</returns>
        tb_DealRequest getModelByDealrid(string paraDealrid);
        #endregion

        #region[获取模型实体集合]
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <param name="paraDealrid">交易编号</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_DealRequest> getListByDealrid(string paraDealrid);
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <param name="paraUserid">购物者</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_DealRequest> getListByUserid(string paraUserid);
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <param name="paraUserid">购物者</param>
        /// <param name="paraState">状态；</param>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_DealRequest> getListByUseridAndState(string paraUserid,string paraState);
        /// <summary>
        /// 查询表单，获取模型实体集合
        /// </summary>
        /// <returns>查询成功返回符合条件的集合，否则返回空集合</returns>
        List<tb_DealRequest> getList();
        #endregion

    }
}