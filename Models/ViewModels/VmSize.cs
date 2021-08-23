using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmSize
    {
        public Guid Id { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }

    public class VmSizeCreate
    {
        public string NameAR { get; set; }
        public string NameEN { get; set; }
    }

    public class VmSizeUpdate
    {
        public Guid Id { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
    }
}
