using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using DBSystem.DAL;
using DBSystem.ENTITIES;

namespace DBSystem.BLL
{
    public class Controller03 //Product
    {
        public List<Entity03> FindByEntity02ID(int id)
        {
            using (var context = new Context())
            {
                IEnumerable<Entity03> results =
                    context.Database.SqlQuery<Entity03>("Products_GetByCategories @CategoryID"
                        , new SqlParameter("CategoryID", id));
                return results.ToList();
            }
        }
    }
}
