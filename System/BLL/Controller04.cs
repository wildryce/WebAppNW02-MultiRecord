using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DBSystem.DAL;
using DBSystem.ENTITIES;

namespace DBSystem.BLL
{
    public class Controller04 //Supplier
    {
        public List<Entity04> List()
        {
            using (var context = new Context())
            {
                return context.Entity04s.ToList();
            }
        }

        public Entity04 Get(int id)
        {
            using (var context = new Context())
            {
                return context.Entity04s.Find(id);
            }
        }
    }
}
