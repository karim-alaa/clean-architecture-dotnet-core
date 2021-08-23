using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmProductTag
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        public Guid ProductId { get; set; }
    }

    public class VmProductTagCreate
    {
        public string Name { get; set; }

        public Guid ProductId { get; set; }
    }

    public class VmProductTagUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Guid ProductId { get; set; }
    }
}
