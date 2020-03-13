using System;
using System.Collections.Generic;
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
    public class SupplierController
    {
        //expose a method to ODS
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
