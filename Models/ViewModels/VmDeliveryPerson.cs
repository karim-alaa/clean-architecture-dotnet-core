using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmDeliveryPerson
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public DateTime MerchantId { get; set; }
    }

    public class VmDeliveryPersonCreate
    {
        public string Name { get; set; }
    }

    public class VmDeliveryPersonUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
