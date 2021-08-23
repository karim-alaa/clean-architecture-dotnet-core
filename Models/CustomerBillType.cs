using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerBillType
    {
        public CustomerBillType()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string NameEN { get; set; }
        public string NameAR { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        // CustomerBill
        [InverseProperty("CustomerBillType")]
        public List<CustomerBill> CustomerBills { get; set; }
    }
}
