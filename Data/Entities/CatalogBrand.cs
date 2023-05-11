using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class CatalogBrand
    {
        [Key]
        public int CatalogBrandId { get; set; }
     
        public string? Name { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
    }
}
