using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmProductTaxation
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        public Guid ProductId { get; set; }
        public Guid TaxationId { get; set; }
    }

    public class VmProductTaxationCreate
    {
        public Guid ProductId { get; set; }
        public Guid TaxationId { get; set; }
    }

    public class VmProductTaxationUpdate
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid TaxationId { get; set; }
    }
}
