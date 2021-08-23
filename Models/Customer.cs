using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class Customer
    {
        public Customer()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ServiceName { get; set; }
        public string Salt { get; set; }
        public byte[] Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        // CustomerAddress
        [InverseProperty("Customer")]
        public List<CustomerAddress> CustomerAddresses { get; set; }

        // CustomerBill
        [InverseProperty("Customer")]
        public List<CustomerBill> CustomerBills { get; set; }
    }
}
