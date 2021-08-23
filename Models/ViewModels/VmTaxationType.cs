using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmTaxationType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class VmTaxationTypeCreate
    {
        public string Name { get; set; }
    }

    public class VmTaxationTypeUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
