using SharedConfig.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Text.Json.Serialization;

namespace Models
{
    public class User
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string MobileNumber { get; set; }
        public AppLanguages Language { get; set; }
        public string Username { get; set; }
        public byte[] Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid MerchantId { get; set; }
        [ForeignKey("MerchantId")]
        public Merchant Merchant { get; set; }

        public Guid UserTypeId { get; set; }
        [ForeignKey("UserTypeId")]
        public UserType UserType { get; set; }


        // CustomerBill
        [InverseProperty("CreatedByUser")]
        public List<CustomerBill> CreatorCustomerBills { get; set; }

        // CustomerBill
        [InverseProperty("PaymentReceivedByUser")]
        public List<CustomerBill> ReceiverCustomerBills { get; set; }

        // UserRole
        [InverseProperty("User")]
        public List<UserRole> UserRoles { get; set; }
    }
}
