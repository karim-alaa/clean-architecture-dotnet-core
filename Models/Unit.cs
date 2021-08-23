using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class Unit
    {
        public Unit()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        // Product
        [InverseProperty("Unit")]
        public List<Product> Products { get; set; }


        // UnitValue
        [InverseProperty("Unit")]
        public List<UnitValue> UnitValues { get; set; }
    }
}
