using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Taxation
    {
        public Taxation()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid TaxationTypeId { get; set; }
        [ForeignKey("TaxationTypeId")]
        public TaxationType TaxationType { get; set; }


        // ProductTaxation
        [InverseProperty("Taxation")]
        public List<ProductTaxation> ProductTaxations { get; set; }
    }
}
