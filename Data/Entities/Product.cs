﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class ProductDto
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
         
        public string Description { get; set; }
        
        public decimal Price { get; set; }
        public string PictureFileName { get; set; }
        public string PictureUri { get; set; }
        public int CatalogTypeId { get; set; }
        [ForeignKey("CatalogTypeId")]
        public virtual CatalogType CatalogType { get; set; }
        public int CatalogBrandId { get; set; }
        [ForeignKey("CatalogBrandId")]
        public virtual CatalogBrand CatalogBrand { get; set; }
        public int AvailableStock { get; set; }
        public int RestockThreshold { get; set; }
        public int MaxStockThreshold { get; set; }

        public bool OnReorder { get; set; }
        

    }

}
