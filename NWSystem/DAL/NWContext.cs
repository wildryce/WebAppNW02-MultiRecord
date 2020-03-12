using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity; //inheritance of DbContext from EntityFramework
using NWSystem.ENTITIES;
#endregion

namespace NWSystem.DAL
{
    internal class NWContext : DbContext
    {
        public NWContext() : base("NWDB")
        {

        }
        public DbSet<Region> Regions { get; set; }

    }
}