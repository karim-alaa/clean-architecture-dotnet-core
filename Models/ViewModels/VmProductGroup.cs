using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ValidationLayer.Validators;

namespace Models
{
    public class VmProductGroup
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int SortValue { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
    }

    public class VmProductGroupCreate
    {
        [RequiredValidator]
        public string Name { get; set; }
    }

    public class VmProductGroupUpdate
    {
        [RequiredValidator]
        public Guid Id { get; set; }

        [RequiredValidator]
        public string Name { get; set; }

        [RequiredValidator]
        public int SortValue { get; set; }
    }
}
