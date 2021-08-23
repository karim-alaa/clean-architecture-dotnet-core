using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmProductUnit
    {
        public Guid Id { get; set; }
        public double Price { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        public Guid ProductId { get; set; }
        public Guid UnitValueId { get; set; }
    }

    public class VmProductUnitCreate
    {
        public double Price { get; set; }

        public Guid ProductId { get; set; }
        public Guid UnitValueId { get; set; }
    }

    public class VmProductUnitUpdate
    {
        public Guid Id { get; set; }
        public double Price { get; set; }

        public Guid ProductId { get; set; }
        public Guid UnitValueId { get; set; }
    }
}
