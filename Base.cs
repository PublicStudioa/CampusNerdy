using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CampusNerdy.Dal;
namespace CampusNerdy.Bll
{
    class Base
    {
        /// <summary>
        /// 地区操作类
        /// </summary>
        public AreaDal areaDal 
        {
            get 
            {
                return new AreaDal()  ;
            }
        }

    }
}
