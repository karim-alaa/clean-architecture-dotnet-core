using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class UnitValue
    {
        public UnitValue()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid UnitId { get; set; }
        [ForeignKey("UnitId")]
        public Unit Unit { get; set; }

        // ProductUnit
        [InverseProperty("UnitValue")]
        public List<ProductUnit> ProductUnits { get; set; }
    }
}
