using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerBill
    {
        public CustomerBill()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsActive = true;
        }
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
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid? CustomerBillTypeId { get; set; }
        [ForeignKey("CustomerBillTypeId")]
        public CustomerBillType CustomerBillType { get; set; }

        public Guid? DeliveryPersonId { get; set; }
        [ForeignKey("DeliveryPersonId")]
        public DeliveryPerson DeliveryPerson { get; set; }

        public Guid CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        public Guid ChannelId { get; set; }
        [ForeignKey("ChannelId")]
        public Channel Channel { get; set; }

        public Guid? CreatedByUserId { get; set; }
        [ForeignKey("CreatedByUserId")]
        public User CreatedByUser { get; set; }

        public Guid? PaymentReceivedByUserId { get; set; }
        [ForeignKey("PaymentReceivedByUserId")]
        public User PaymentReceivedByUser { get; set; }

        // CustomerBillItem
        [InverseProperty("CustomerBill")]
        public List<CustomerBillItem> CustomerBillItems { get; set; }
    }
}
