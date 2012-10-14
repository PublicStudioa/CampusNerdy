using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CampusNerdy.Dal;

namespace CampusNerdy.Bll
{
    public class BaseControllerObjects
    {
        /// <summary>
        /// 地区操作类
        /// </summary>
        public AreaDal areaDal { get { return new AreaDal(); } }
        /// <summary>
        /// 购物会话保存的物品
        /// </summary>
        public CheckitemDal checkItemDal { get { return new CheckitemDal(); } }
        /// <summary>
        /// 购物会话的ID保存表操作类
        /// </summary>
        public CheckoutDal checkOutDal { get { return new CheckoutDal(); } }
        /// <summary>
        /// 交易历史的操作类
        /// </summary>
        public DealhistoryDal dealhistoryDal { get { return new DealhistoryDal(); } }
        /// <summary>
        /// 字典表的操作类
        /// </summary>
        public DictionaryDal dictionaryDal { get { return new DictionaryDal(); } }
        /// <summary>
        /// 商品操作类
        /// </summary>
        public GoodDal goodDal { get { return new GoodDal(); } }
        /// <summary>
        /// 超市商品明细表操作类
        /// </summary>
        public GoodinfotosupermarketDal goodinfotosupermarketDal { get { return new GoodinfotosupermarketDal(); } }
        /// <summary>
        ///  送货团体明细表操作类
        /// </summary>
        public GroupDal groupDal { get { return new GroupDal(); } }
        /// <summary>
        /// 模块，角色能访问的页面限定
        /// </summary>
        public ModuleDal moduleDal { get { return new ModuleDal(); } }
        /// <summary>
        /// 角色操作类
        /// </summary>
        public RoleDal roleDal { get { return new RoleDal(); } }
        /// <summary>
        /// 角色用户操作类
        /// </summary>
        public RoletouserDal roletouserDal { get { return new RoletouserDal(); } }
        /// <summary>
        /// 送货人员操作类
        /// </summary>
        public SenderDal senderDal { get { return new SenderDal(); } }
        /// <summary>
        /// 超市总体信息操作类
        /// </summary>
        public SupermaketDal supermaketDal { get { return new SupermaketDal(); } }
        /// <summary>
        /// 用户角色视图
        /// </summary>
        public UserandroleDal view_UserandroleDal { get { return new UserandroleDal(); } }
        /// <summary>
        /// 地区操作类
        /// </summary>
        public UserDal userDal { get { return new UserDal(); } }
        /// <summary>
        /// 结账视图
        /// </summary>
        public ViewchectoutDal viewchectoutDal { get { return new ViewchectoutDal(); } }
        /// <summary>
        /// 获取超市-商品视图
        /// </summary>
        public ViewgoodsuperinfoDal viewgoodsuperinfoDal { get { return new ViewgoodsuperinfoDal(); } }
    }
}
