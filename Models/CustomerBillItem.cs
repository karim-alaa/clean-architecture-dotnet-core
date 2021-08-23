using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class CustomerBillItem
    {
        public CustomerBillItem()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public double Quantity { get; set; }
        public double UnitAmount { get; set; }
        public double DueAmount { get; set; }
        public double Taxation { get; set; }
        public double TotalAmount { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid CustomerBillId { get; set; }
        [ForeignKey("CustomerBillId")]
        public CustomerBill CustomerBill { get; set; }

        public Guid? ProductUnitId { get; set; }
        [ForeignKey("ProductUnitId")]
        public ProductUnit ProductUnit { get; set; }
    }
}
