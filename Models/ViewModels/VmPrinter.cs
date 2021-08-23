using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class VmPrinter
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
    }

    public class VmPrinterCreate
    {
        public string Name { get; set; }
    }

    public class VmPrinterUpdate
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
