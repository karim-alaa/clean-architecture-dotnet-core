using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmCustomerAddress
    {
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
        public Guid CustomerId { get; set; }
    }

    public class VmCustomerAddressCreate
    {
        public string BuildingNo { get; set; }
        public string Street { get; set; }
        public string Zone { get; set; }
        public string FloorNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string Mark { get; set; }

        public Guid CustomerId { get; set; }
    }

    public class VmCustomerAddressUpdate
    {
        public Guid Id { get; set; }
        public string BuildingNo { get; set; }
        public string Street { get; set; }
        public string Zone { get; set; }
        public string FloorNumber { get; set; }
        public string ApartmentNumber { get; set; }
        public string Mark { get; set; }

        public Guid CustomerId { get; set; }
    }
}
