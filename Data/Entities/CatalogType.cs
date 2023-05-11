using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CatalogType
    {

        
        [Key]
        public int CatalogTypeId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
    }
}
