using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using CampusNerdy.IDal;
using System.Reflection;

namespace CampusNerdy.DalFactory
{
    public sealed class DataAccess
    {
        private static readonly string path = ConfigurationManager.AppSettings["WebDal"];

        private DataAccess() { }

        public static IAreaDal CreateAreaDal()
        {
            string className = path + ".AreaDal";
            return (IAreaDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IDealhistoryDal CreateDealhistoryDal()
        {
            string className = path + ".DealhistoryDal";
            return (IDealhistoryDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IDealrequestDal CreateDealrequestDal()
        {
            string className = path + ".DealrequestDal";
            return (IDealrequestDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IDictionaryDal CreateDictionaryDal()
        {
            string className = path + ".DictionaryDal";
            return (IDictionaryDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IGoodDal CreateGoodDal()
        {
            string className = path + ".GoodDal";
            return (IGoodDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IGoodinfotosupermarketDal CreateGoodinfotosupermarketDal()
        {
            string className = path + ".GoodinfotosupermarketDal";
            return (IGoodinfotosupermarketDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IGroupDal CreateGroupDal()
        {
            string className = path + ".GroupDal";
            return (IGroupDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IModuleDal CreateModuleDal()
        {
            string className = path + ".ModuleDal";
            return (IModuleDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IRoleDal CreateRoleDal()
        {
            string className = path + ".RoleDal";
            return (IRoleDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IRoletouserDal CreateRoletouserDal()
        {
            string className = path + ".RoletouserDal";
            return (IRoletouserDal)Assembly.Load(path).CreateInstance(className);
        }

        public static ISupermaketDal CreateSupermaketDal()
        {
            string className = path + ".SupermaketDal";
            return (ISupermaketDal)Assembly.Load(path).CreateInstance(className);
        }

        public static ISenderDal CreateSenderDal()
        {
            string className = path + ".SenderDal";
            return (ISenderDal)Assembly.Load(path).CreateInstance(className);
        }

        public static IUserDal CreateUserDal()
        {
            string className = path + ".UserDal";
            return (IUserDal)Assembly.Load(path).CreateInstance(className);
        }
    }
}
