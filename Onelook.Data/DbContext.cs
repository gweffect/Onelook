using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Onelook.Data
{
    public class DbContext
    {
        public readonly IConfiguration configuration;
        public IFreeSql instance;
        public DbContext(IConfiguration _configuration)
        {
            configuration = _configuration;

            //var connPostgreSQL=configuration.GetConnectionString("PostgreSQL");
            var connMySQL = configuration.GetConnectionString("MySQL");

            instance = new FreeSql.FreeSqlBuilder()
                  .UseConnectionString(FreeSql.DataType.MySql, connMySQL)
                  .UseAutoSyncStructure(true) //自动同步实体结构到数据库
                  .Build();
            
            instance.Aop.CommandBefore += (sender, e) =>
            {
                Console.WriteLine(e.Command.CommandText);
                foreach (var p in e.Command.Parameters)
                {

                }
            };
        }


    }
}
