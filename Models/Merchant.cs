using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Models
{
    public class Merchant
    {
        public Merchant()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string NameAR { get; set; }
        public string NameEN { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }


        // Customer
        [InverseProperty("Merchant")]
        public List<Customer> Customers { get; set; }

        // CustomerAddress
        [InverseProperty("Merchant")]
        public List<CustomerAddress> CustomerAddresses { get; set; }

        // CustomerBill
        [InverseProperty("Merchant")]
        public List<CustomerBill> CustomerBills { get; set; }

        // CustomerBillItem
        [InverseProperty("Merchant")]
        public List<CustomerBillItem> CustomerBillItems { get; set; }

        // DeliveryPerson
        [InverseProperty("Merchant")]
        public List<DeliveryPerson> DeliveryPersons { get; set; }

        // Permission
        [InverseProperty("Merchant")]
        public List<Permission> Permissions { get; set; }

        // Printer
        [InverseProperty("Merchant")]
        public List<Printer> Printers { get; set; }

        // Product
        [InverseProperty("Merchant")]
        public List<Product> Products { get; set; }

        // ProductGroup
        [InverseProperty("Merchant")]
        public List<ProductGroup> ProductGroups { get; set; }

        // ProductTag
        [InverseProperty("Merchant")]
        public List<ProductTag> ProductTags { get; set; }

        // ProductTaxation
        [InverseProperty("Merchant")]
        public List<ProductTaxation> ProductTaxations { get; set; }

        // ProductUnit
        [InverseProperty("Merchant")]
        public List<ProductUnit> ProductUnits { get; set; }

        // Role
        [InverseProperty("Merchant")]
        public List<Role> Roles { get; set; }

        // RolePermission
        [InverseProperty("Merchant")]
        public List<RolePermission> RolePermissions { get; set; }


        // Taxation
        [InverseProperty("Merchant")]
        public List<Taxation> Taxations { get; set; }

        // Unit
        [InverseProperty("Merchant")]
        public List<Unit> Units { get; set; }

        // UnitValue
        [InverseProperty("Merchant")]
        public List<UnitValue> UnitValues { get; set; }

        // User
        [InverseProperty("Merchant")]
        public List<User> Users { get; set; }

        // UserRole
        [InverseProperty("Merchant")]
        public List<UserRole> UserRoles { get; set; }
    }
}
