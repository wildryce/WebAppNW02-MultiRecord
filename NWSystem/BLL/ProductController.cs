using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NWSystem.DAL;
using NWSystem.ENTITIES;
using System.ComponentModel; //needed to expose class and methods to ODS wizard

namespace NWSystem.BLL
{
    //expose the class to the ObjectDataSource wizard
    [DataObject]
    public class ProductController
    {
        //expose a method to ODS
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Product> Products_FindByCategory(int categoryid)
        {
            using (var context = new NWContext())
            {
                //syntax
                //context.Database.SqlQuery<T>("sqlprocname [@parameterid[,@parameterid, ...]]"
                //      [, new SqlParameter("parameterid", value)[, new SqlParameter("parameterid",value)]]);
                //examples
                //context.Database.SqlQuery<T>("sqlprocname");  no parameters
                //context.Database.SqlQuery<T>("sqlprocname @parameterid"
                //      , new SqlParameter("parameterid", value)); one parameter
                //context.Database.SqlQuery<T>("sqlprocname @parameterid,@parameterid"
                //      , new SqlParameter("parameterid", value), new SqlParameter("parameterid",value)); +1> parameters

                //the return datatype of this query is IEnumerable<T>
                IEnumerable<Product> results =
                    context.Database.SqlQuery<Product>("Products_GetByCategories @CategoryID"
                        , new SqlParameter("CategoryID", categoryid));
                return results.ToList();
            }
        }
    }
}
