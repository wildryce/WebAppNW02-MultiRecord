using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DBSystem.ENTITIES
{
    [Table("Region")]
    public class Entity01 
    {
        [Key]
        public int RegionID { get; set; }
        public string RegionDescription { get; set; }

    }
}
