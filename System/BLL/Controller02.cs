using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DBSystem.DAL;
using DBSystem.ENTITIES;

namespace DBSystem.BLL
{
    public class Controller02 //Category
    {
        public List<Entity02> List()
        {
            using (var context = new Context())
            {
                return context.Entity02s.ToList();
            }
        }
    }
}
