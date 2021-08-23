using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmCustomerBill
    {
        public Guid Id { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string TableNo { get; set; }
        public double Taxation { get; set; }
        public double Service { get; set; }
        public double DueAmount { get; set; }
        public double TotalAmount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId {get;set;}
        public Guid CustomerBillTypeId { get; set; }
        public Guid DeliveryPersonId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ChannelId { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid PaymentReceivedBy { get; set; }
    }

    public class VmCustomerBillCreate
    {
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string TableNo { get; set; }
        public double Taxation { get; set; }
        public double Service { get; set; }
        public double DueAmount { get; set; }
        public double TotalAmount { get; set; }

        public Guid CustomerBillTypeId { get; set; }
        public Guid DeliveryPersonId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ChannelId { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid PaymentReceivedBy { get; set; }
    }

    public class VmCustomerBillUpdate
    {
        public Guid Id { get; set; }
        public bool IsPaid { get; set; }
        public DateTime PaymentDate { get; set; }
        public string TableNo { get; set; }
        public double Taxation { get; set; }
        public double Service { get; set; }
        public double DueAmount { get; set; }
        public double TotalAmount { get; set; }

        public Guid CustomerBillTypeId { get; set; }
        public Guid DeliveryPersonId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid ChannelId { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid PaymentReceivedBy { get; set; }
    }
}
