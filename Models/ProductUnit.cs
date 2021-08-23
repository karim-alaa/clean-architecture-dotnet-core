using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class ProductUnit
    {
        public ProductUnit()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        public Guid? UnitValueId { get; set; }
        [ForeignKey("UnitValueId")]
        public UnitValue UnitValue { get; set; }


        // CustomerBillItem
        [InverseProperty("ProductUnit")]
        public List<CustomerBillItem> CustomerBillItems { get; set; }
    }
}
