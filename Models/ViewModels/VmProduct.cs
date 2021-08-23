using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmProduct
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        public Guid ProductGroupId { get; set; }
        public Guid UnitId { get; set; }
        public Guid PrinterId { get; set; }
    }

    public class VmProductCreate
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid ProductGroupId { get; set; }
        public Guid UnitId { get; set; }
        public Guid PrinterId { get; set; }
    }

    public class VmProductUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid ProductGroupId { get; set; }
        public Guid UnitId { get; set; }
        public Guid PrinterId { get; set; }
    }
}
