using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmTaxation
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        public Guid TaxationTypeId { get; set; }
    }

    public class VmTaxationCreate
    {
        public string Name { get; set; }
        public double Value { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }

        public Guid TaxationTypeId { get; set; }
    }

    public class VmTaxationUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }

        public Guid TaxationTypeId { get; set; }
    }
}
