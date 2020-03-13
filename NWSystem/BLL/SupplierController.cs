using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NWSystem.DAL;
using NWSystem.ENTITIES;
using System.ComponentModel;

namespace NWSystem.BLL
{
    [DataObject]
    public class SupplierController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Supplier> Supplier_List()
        {
            using (var context = new NWContext())
            {
                return context.Suppliers.ToList();
            }
        }

        public Supplier Supplier_Get(int supplierid)
        {
            using (var context = new NWContext())
            {
                return context.Suppliers.Find(supplierid);
            }
        }
    }
}
