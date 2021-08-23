using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmCustomerBillItem
    {
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
        public Guid CustomerBillId { get; set; }
        public Guid ProductUnitId { get; set; }
    }

    public class VmCustomerBillItemCreate
    {
        public string Comment { get; set; }
        public double Quantity { get; set; }
        public double UnitAmount { get; set; }
        public double DueAmount { get; set; }
        public double Taxation { get; set; }
        public double TotalAmount { get; set; }

        public Guid CustomerBillId { get; set; }
        public Guid ProductUnitId { get; set; }
    }

    public class VmCustomerBillItemUpdate
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public double Quantity { get; set; }
        public double UnitAmount { get; set; }
        public double DueAmount { get; set; }
        public double Taxation { get; set; }
        public double TotalAmount { get; set; }

        public Guid CustomerBillId { get; set; }
        public Guid ProductUnitId { get; set; }
    }
}
