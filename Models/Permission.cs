using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Permission
    {
        public Permission()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid UserTypeId { get; set; }
        [ForeignKey("UserTypeId")]
        public UserType UserType { get; set; }


        // RolePermission
        [InverseProperty("Permission")]
        public List<RolePermission> RolePermissions { get; set; }
    }
}
