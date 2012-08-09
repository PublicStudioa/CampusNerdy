using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Objects;
using System.Diagnostics;
using System.Data.Objects.DataClasses;
using System.Data;

namespace CampusNerdy.Model
{
    public static class Extension
    {
        /// <summary>
        /// 判断传入的对象是否已附加到当前实体数据对象中
        /// </summary>
        /// <param name="context">实体数据对象</param>
        /// <param name="entity">对象</param>
        /// <returns>是否附加成功</returns>
        public static bool IsAttached(this ObjectContext context, object entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity is null");
            }
            ObjectStateEntry entry;
            try
            {
                var dd = entity as EntityObject;
                entry = context.ObjectStateManager.GetObjectStateEntry(dd.EntityKey);
                return (entry.State != EntityState.Detached);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("实体是否已附加判断出错，异常信息：" + ex.Message);
                return false;
            }
        }
    }
}
