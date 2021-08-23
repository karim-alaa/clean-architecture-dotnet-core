using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmRole
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class VmRoleCreate
    {
        public string Name { get; set; }
    }

    public class VmRoleUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
