using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmCustomer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ServiceName { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
    }


    public class VmCustomerCreate
    {
        public string Name { get; set; }
        public string ServiceName { get; set; }
        public string Password { get; set; }
    }

    public class VmCustomerUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ServiceName { get; set; }
        public string Password { get; set; }
    }
}
