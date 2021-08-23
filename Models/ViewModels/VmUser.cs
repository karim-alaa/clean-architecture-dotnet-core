using SharedConfig.Constants;
using SharedConfig.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ValidationLayer.Validators;

namespace Models.ViewModels
{
    public class VmUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public AppLanguages Language { get; set; }
        public string MobileNumber { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Guid UserTypeId { get; set; }
        public Guid MerchantId { get; set; }
    }

    public class VmUserCreate
    {
        [Required]
        [NameValidator]
        public string Name { get; set; }

        [Required]
        [UsernameValidator]
        public string Username { get; set; }

        [Required]
        public AppLanguages Language { get; set; }

        [Required]
        [PasswordValidator]
        public string Password { get; set; }

        [Required]
        [EmailValidator]
        public string Email { get; set; }

        [Required]
        [PhoneValidator]
        public string MobileNumber { get; set; }

        [Required]
        public Guid UserTypeId { get; set; }
    }

    public class VmUserUpdate
    {
        [RequiredValidator]
        public Guid Id { get; set; }

        [RequiredValidator]
        [NameValidator]
        public string Name { get; set; }

        [RequiredValidator]
        [UsernameValidator]
        public string Username { get; set; }

        [RequiredValidator]
        public AppLanguages Language { get; set; }

        [RequiredValidator]
        [PasswordValidator]
        public string Password { get; set; }

        [RequiredValidator]
        [EmailValidator]
        public string Email { get; set; }

        [RequiredValidator]
        [PhoneValidator]
        public string MobileNumber { get; set; }

        [RequiredValidator]
        public Guid UserTypeId { get; set; }
    }
}
