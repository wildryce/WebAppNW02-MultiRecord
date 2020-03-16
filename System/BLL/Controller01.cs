using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DBSystem.DAL;
using DBSystem.ENTITIES;

namespace DBSystem.BLL
{
    public class Controller01 //Region
    {
        public Entity01 FindByID(int id)
        {
            using (var context = new Context())
            {
                return context.Entity01s.Find(id);
            }
        }
    }
}
