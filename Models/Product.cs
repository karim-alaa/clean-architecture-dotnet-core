using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid ProductGroupId { get; set; }
        [ForeignKey("ProductGroupId")]
        public ProductGroup ProductGroup { get; set; }

        public Guid UnitId { get; set; }
        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }

        public Guid PrinterId { get; set; }
        [ForeignKey("PrinterId")]
        public Printer Printer { get; set; }

        // ProductTag
        [InverseProperty("Product")]
        public List<ProductTag> ProductTags { get; set; }

        // ProductTaxation
        [InverseProperty("Product")]
        public List<ProductTaxation> ProductTaxations { get; set; }

        // ProductUnit
        [InverseProperty("Product")]
        public List<ProductUnit> ProductUnits { get; set; }
    }
}
