using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.EntityClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CampusNerdy.Model
{
    public class SqlDBCon
    {
        public static EntityConnection ShopEntityCon
        {
            get
            {
                try
                {
                    string providerString = ConfigurationManager.ConnectionStrings["CampusNerdyEntities"].ConnectionString;
                    EntityConnectionStringBuilder entityBuilder = new EntityConnectionStringBuilder();
                    entityBuilder.Metadata = "res://*/CampusNerdy.csdl|res://*/CampusNerdy.ssdl|res://*/CampusNerdy.msl";
                    entityBuilder.ProviderConnectionString = providerString;
                    entityBuilder.Provider = "System.Data.SqlClient";
                    EntityConnection entCon = new EntityConnection(entityBuilder.ToString());
                    return entCon;
                }
                catch (Exception ex)
                {
                    throw new Exception("数据库连接字符串错误");
                }
            }
        }
        

    }
}
