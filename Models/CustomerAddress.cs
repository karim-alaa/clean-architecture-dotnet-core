using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerAddress
    {
        public CustomerAddress()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string BuildingNo { get; set; }
        public string Street { get; set; }
        public string Zone { get; set; }
        public string FloorNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string Mark { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }
    }
}
