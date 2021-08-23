using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Models;
using DataAccessLayer.Interfaces;
using SharedConfig.Constants;
using GlobalHelpers.Interfaces;
using System.Threading.Tasks;
using System.Threading;

namespace DataAccessLayer
{
    public class DBContext : DbContext
    {
        private readonly IGlobalHelperService _globalHelperService;
        public DBContext(DbContextOptions<DBContext> options, IGlobalHelperService globalHelperService) : base(options)
        {
            _globalHelperService = globalHelperService;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Global Filter - IsActive

            // User
            modelBuilder.Entity<User>().Property<bool>("IsActive");
            modelBuilder.Entity<User>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // ProductGroup
            modelBuilder.Entity<ProductGroup>().Property<bool>("IsActive");
            modelBuilder.Entity<ProductGroup>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());


            // Customer
            modelBuilder.Entity<Customer>().Property<bool>("IsActive");
            modelBuilder.Entity<Customer>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());


            // CustomerAddresss
            modelBuilder.Entity<CustomerAddress>().Property<bool>("IsActive");
            modelBuilder.Entity<CustomerAddress>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // CustomerBill
            modelBuilder.Entity<CustomerBill>().Property<bool>("IsActive");
            modelBuilder.Entity<CustomerBill>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // CustomerBillItem
            modelBuilder.Entity<CustomerBillItem>().Property<bool>("IsActive");
            modelBuilder.Entity<CustomerBillItem>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // CustomerBillType
            modelBuilder.Entity<CustomerBillType>().Property<bool>("IsActive");
            modelBuilder.Entity<CustomerBillType>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // DeliveryPerson
            modelBuilder.Entity<DeliveryPerson>().Property<bool>("IsActive");
            modelBuilder.Entity<DeliveryPerson>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // Merchant
            modelBuilder.Entity<Merchant>().Property<bool>("IsActive");
            modelBuilder.Entity<Merchant>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // Permission
            modelBuilder.Entity<Permission>().Property<bool>("IsActive");
            modelBuilder.Entity<Permission>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true);

            // Printer
            modelBuilder.Entity<Printer>().Property<bool>("IsActive");
            modelBuilder.Entity<Printer>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // ProductGroup
            modelBuilder.Entity<ProductGroup>().Property<bool>("IsActive");
            modelBuilder.Entity<ProductGroup>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // ProductTaxation
            modelBuilder.Entity<ProductTaxation>().Property<bool>("IsActive");
            modelBuilder.Entity<ProductTaxation>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // ProductUnit
            modelBuilder.Entity<ProductUnit>().Property<bool>("IsActive");
            modelBuilder.Entity<ProductUnit>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // Role
            modelBuilder.Entity<Role>().Property<bool>("IsActive");
            modelBuilder.Entity<Role>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // RolePermission
            modelBuilder.Entity<RolePermission>().Property<bool>("IsActive");
            modelBuilder.Entity<RolePermission>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // Size
            modelBuilder.Entity<Size>().Property<bool>("IsActive");
            modelBuilder.Entity<Size>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // Taxation
            modelBuilder.Entity<Taxation>().Property<bool>("IsActive");
            modelBuilder.Entity<Taxation>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // TaxationType
            modelBuilder.Entity<TaxationType>().Property<bool>("IsActive");
            modelBuilder.Entity<TaxationType>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // Unit
            modelBuilder.Entity<Unit>().Property<bool>("IsActive");
            modelBuilder.Entity<Unit>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // UnitValue
            modelBuilder.Entity<UnitValue>().Property<bool>("IsActive");
            modelBuilder.Entity<UnitValue>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // UserRole
            modelBuilder.Entity<UserRole>().Property<bool>("IsActive");
            modelBuilder.Entity<UserRole>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());

            // TaxationType
            modelBuilder.Entity<UserType>().Property<bool>("IsActive");
            modelBuilder.Entity<UserType>().HasQueryFilter(m => EF.Property<bool>(m, "IsActive") == true  && EF.Property<Guid>(m, "MerchantId") == _globalHelperService.GetUserId());




            // Relationships

            /****** START CUSTOMER CONFIG ******/

            // Customer and Merchant
            modelBuilder.Entity<Customer>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Customers)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // Customer and CustomerAddress
            modelBuilder.Entity<Customer>()
                        .HasMany(u => u.CustomerAddresses)
                        .WithOne(r => r.Customer)
                        .HasForeignKey(r => r.CustomerId)
                        .OnDelete(DeleteBehavior.Cascade);

            /****** END CUSTOMER CONFIG ******/


            /****** START MERCHANT CONFIG ******/

            // Merchant and CustomerAddress
            modelBuilder.Entity<Merchant>()
                        .HasMany(u => u.CustomerAddresses)
                        .WithOne(r => r.Merchant)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END MERCHANT CONFIG ******/


            /****** START CUSTOMERBILL CONFIG ******/

            // CustomerBill and Merchant
            modelBuilder.Entity<CustomerBill>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.CustomerBills)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // CustomerBill and CustomerBillType
            modelBuilder.Entity<CustomerBill>()
                        .HasOne(u => u.CustomerBillType)
                        .WithMany(r => r.CustomerBills)
                        .HasForeignKey(r => r.CustomerBillTypeId)
                        .OnDelete(DeleteBehavior.Restrict);

            // CustomerBill and CustomerBillType
            modelBuilder.Entity<CustomerBill>()
                        .HasOne(u => u.CustomerBillType)
                        .WithMany(r => r.CustomerBills)
                        .HasForeignKey(r => r.CustomerBillTypeId)
                        .OnDelete(DeleteBehavior.SetNull);

            // CustomerBill and DeliveryPerson
            modelBuilder.Entity<CustomerBill>()
                        .HasOne(u => u.DeliveryPerson)
                        .WithMany(r => r.CustomerBills)
                        .HasForeignKey(r => r.DeliveryPersonId)
                        .OnDelete(DeleteBehavior.SetNull);

            // CustomerBill and Customer
            modelBuilder.Entity<CustomerBill>()
                        .HasOne(u => u.Customer)
                        .WithMany(r => r.CustomerBills)
                        .HasForeignKey(r => r.CustomerId)
                        .OnDelete(DeleteBehavior.Restrict);

            // CustomerBill and Channel
            modelBuilder.Entity<CustomerBill>()
                        .HasOne(u => u.Channel)
                        .WithMany(r => r.CustomerBills)
                        .HasForeignKey(r => r.ChannelId)
                        .OnDelete(DeleteBehavior.Restrict);

            // CustomerBill and User
            modelBuilder.Entity<CustomerBill>()
                        .HasOne(u => u.CreatedByUser)
                        .WithMany(r => r.CreatorCustomerBills)
                        .HasForeignKey(r => r.CreatedByUserId)
                        .OnDelete(DeleteBehavior.SetNull);

            // CustomerBill and User
            modelBuilder.Entity<CustomerBill>()
                        .HasOne(u => u.PaymentReceivedByUser)
                        .WithMany(r => r.ReceiverCustomerBills)
                        .HasForeignKey(r => r.PaymentReceivedByUserId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END CUSTOMERBILL CONFIG ******/


            /****** START CUSTOMERBILLITEM CONFIG ******/

            // CustomerBillItem and Merchant
            modelBuilder.Entity<CustomerBillItem>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.CustomerBillItems)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // CustomerBillItem and CustomerBill
            modelBuilder.Entity<CustomerBillItem>()
                        .HasOne(u => u.CustomerBill)
                        .WithMany(r => r.CustomerBillItems)
                        .HasForeignKey(r => r.CustomerBillId)
                        .OnDelete(DeleteBehavior.Cascade);

            // CustomerBillItem and ProductUnit
            modelBuilder.Entity<CustomerBillItem>()
                        .HasOne(u => u.ProductUnit)
                        .WithMany(r => r.CustomerBillItems)
                        .HasForeignKey(r => r.ProductUnitId)
                        .OnDelete(DeleteBehavior.SetNull);

            /****** END CUSTOMERBILLITEM CONFIG ******/

            /****** START CUSTOMERBILLTYPE CONFIG ******/


            /****** END CUSTOMERBILLTYPE CONFIG ******/

            /****** START DELIVERYPERSON CONFIG ******/

            // DeliveryPerson and Merchant
            modelBuilder.Entity<DeliveryPerson>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.DeliveryPersons)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END DELIVERYPERSON CONFIG ******/

            /****** START PERMISSION CONFIG ******/

            // Permission and Merchant
            modelBuilder.Entity<Permission>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Permissions)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // Permission and UserType
            modelBuilder.Entity<Permission>()
                        .HasOne(u => u.UserType)
                        .WithMany(r => r.Permissions)
                        .HasForeignKey(r => r.UserTypeId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END PERMISSION CONFIG ******/

            /****** START PRINTER CONFIG ******/

            // Printer and Merchant
            modelBuilder.Entity<Printer>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Printers)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END PRINTER CONFIG ******/

            /****** START PRODUCT CONFIG ******/

            // Product and Merchant
            modelBuilder.Entity<Product>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Products)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // Product and ProductGroup
            modelBuilder.Entity<Product>()
                        .HasOne(u => u.ProductGroup)
                        .WithMany(r => r.Products)
                        .HasForeignKey(r => r.ProductGroupId)
                        .OnDelete(DeleteBehavior.Restrict);

            // Product and Unit
            modelBuilder.Entity<Product>()
                        .HasOne(u => u.Unit)
                        .WithMany(r => r.Products)
                        .HasForeignKey(r => r.UnitId)
                        .OnDelete(DeleteBehavior.Restrict);

            // Product and Printer
            modelBuilder.Entity<Product>()
                        .HasOne(u => u.Printer)
                        .WithMany(r => r.Products)
                        .HasForeignKey(r => r.PrinterId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END PRODUCT CONFIG ******/

            /****** START PRODUCTGROUP CONFIG ******/

            // ProductGroup and Merchant
            modelBuilder.Entity<ProductGroup>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.ProductGroups)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END PRODUCTGROUP CONFIG ******/


            /****** START PRODUCTTAG CONFIG ******/

            // ProductTag and Merchant
            modelBuilder.Entity<ProductTag>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.ProductTags)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // ProductTag and Product
            modelBuilder.Entity<ProductTag>()
                        .HasOne(u => u.Product)
                        .WithMany(r => r.ProductTags)
                        .HasForeignKey(r => r.ProductId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END PRODUCTTAG CONFIG ******/

            /****** START PRODUCTTAXATION CONFIG ******/

            // ProductTaxation and Merchant
            modelBuilder.Entity<ProductTaxation>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.ProductTaxations)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // ProductTaxation and Product
            modelBuilder.Entity<ProductTaxation>()
                        .HasOne(u => u.Product)
                        .WithMany(r => r.ProductTaxations)
                        .HasForeignKey(r => r.ProductId)
                        .OnDelete(DeleteBehavior.Cascade);

            // ProductTaxation and Taxation
            modelBuilder.Entity<ProductTaxation>()
                        .HasOne(u => u.Taxation)
                        .WithMany(r => r.ProductTaxations)
                        .HasForeignKey(r => r.TaxationId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END PRODUCTTAXATION CONFIG ******/

            /****** START PRODUCTUNIT CONFIG ******/

            // ProductUnit and Merchant
            modelBuilder.Entity<ProductUnit>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.ProductUnits)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // ProductUnit and Product
            modelBuilder.Entity<ProductUnit>()
                        .HasOne(u => u.Product)
                        .WithMany(r => r.ProductUnits)
                        .HasForeignKey(r => r.ProductId)
                        .OnDelete(DeleteBehavior.Cascade);

            // ProductUnit and UnitValue
            modelBuilder.Entity<ProductUnit>()
                        .HasOne(u => u.UnitValue)
                        .WithMany(r => r.ProductUnits)
                        .HasForeignKey(r => r.UnitValueId)
                        .OnDelete(DeleteBehavior.SetNull);

            /****** END PRODUCTUNIT CONFIG ******/

            /****** START ROLE CONFIG ******/

            // Role and Merchant
            modelBuilder.Entity<Role>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Roles)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END ROLE CONFIG ******/

            /****** START ROLEPERMISSION CONFIG ******/

            // RolePermission and Merchant
            modelBuilder.Entity<RolePermission>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.RolePermissions)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // RolePermission and Permission
            modelBuilder.Entity<RolePermission>()
                        .HasOne(u => u.Permission)
                        .WithMany(r => r.RolePermissions)
                        .HasForeignKey(r => r.PermissionId)
                        .OnDelete(DeleteBehavior.Restrict);

            // RolePermission and Role
            modelBuilder.Entity<RolePermission>()
                        .HasOne(u => u.Role)
                        .WithMany(r => r.RolePermissions)
                        .HasForeignKey(r => r.RoleId)
                        .OnDelete(DeleteBehavior.Cascade);

            /****** END ROLEPERMISSION CONFIG ******/


            /****** START SIZE CONFIG ******/

            /****** END SIZE CONFIG ******/

            /****** START TAXATION CONFIG ******/

            // Taxation and Merchant
            modelBuilder.Entity<Taxation>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Taxations)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // Taxation and TaxationType
            modelBuilder.Entity<Taxation>()
                        .HasOne(u => u.TaxationType)
                        .WithMany(r => r.Taxations)
                        .HasForeignKey(r => r.TaxationTypeId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END TAXATION CONFIG ******/

            /****** START TAXATIONTYPE CONFIG ******/

     

            /****** END TAXATIONTYPE CONFIG ******/

            /****** START UNIT CONFIG ******/

            // Unit and Merchant
            modelBuilder.Entity<Unit>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Units)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END UNIT CONFIG ******/

            /****** START UNITVALUE CONFIG ******/

            // UnitValue and Merchant
            modelBuilder.Entity<UnitValue>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.UnitValues)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // UnitValue and Unit
            modelBuilder.Entity<UnitValue>()
                        .HasOne(u => u.Unit)
                        .WithMany(r => r.UnitValues)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END UNITVALUE CONFIG ******/

            /****** START USER CONFIG ******/

            // User and Merchant
            modelBuilder.Entity<User>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Users)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // User and UserType
            modelBuilder.Entity<User>()
                        .HasOne(u => u.UserType)
                        .WithMany(r => r.Users)
                        .HasForeignKey(r => r.UserTypeId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END USER CONFIG ******/

            /****** START USERROLE CONFIG ******/

            // UserRole and Merchant
            modelBuilder.Entity<UserRole>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.UserRoles)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            // UserRole and Role
            modelBuilder.Entity<UserRole>()
                        .HasOne(u => u.Role)
                        .WithMany(r => r.UserRoles)
                        .HasForeignKey(r => r.RoleId)
                        .OnDelete(DeleteBehavior.Restrict);

            // UserRole and User
            modelBuilder.Entity<UserRole>()
                        .HasOne(u => u.User)
                        .WithMany(r => r.UserRoles)
                        .HasForeignKey(r => r.UserId)
                        .OnDelete(DeleteBehavior.Cascade);

            /****** END PRODUCTUNIT CONFIG ******/

            /****** START USERTYPE CONFIG ******/

            // UserType and Merchant
            modelBuilder.Entity<User>()
                        .HasOne(u => u.Merchant)
                        .WithMany(r => r.Users)
                        .HasForeignKey(r => r.MerchantId)
                        .OnDelete(DeleteBehavior.Restrict);

            /****** END USERTYPE CONFIG ******/

            // SEEDING

            // Channel
            modelBuilder.Entity<Channel>().HasData(
                new Channel (){ Name = "SHOP"},
                new Channel() { Name = "APP" }
                );

            // CustomerBillType
            modelBuilder.Entity<CustomerBillType>().HasData(
                new CustomerBillType() { NameAR = "تيكاوى", NameEN = "TEKAWAY" },
                new CustomerBillType() { NameAR = "دليفرى", NameEN = "DELIVERY" },
                new CustomerBillType() { NameAR = "سفرة", NameEN = "TABLE" }
                );
             
            // TaxationType
            modelBuilder.Entity<TaxationType>().HasData(
                new TaxationType() { Name = "PERCENT" },
                new TaxationType() { Name = "FIXED" }
                );
           
            // UserType
            modelBuilder.Entity<UserType>().HasData(
                new UserType() { NameAR = "مدير", NameEN = "ADMIN" },
                new UserType() { NameAR = "كاشير", NameEN = "CASHER" }
                );
        }


        public DbSet<Channel> Channels { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<CustomerBill> CustomerBills { get; set; }
        public DbSet<CustomerBillItem> CustomerBillItems { get; set; }
        public DbSet<CustomerBillType> CustomerBillTypes { get; set; }
        public DbSet<DeliveryPerson> DeliveryPersons { get; set; }
        public DbSet<Merchant> Merchants { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Printer> Printers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductGroup> ProductGroups { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<ProductTaxation> ProductTaxations { get; set; }
        public DbSet<ProductUnit> ProductUnits { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Taxation> Taxations { get; set; }
        public DbSet<TaxationType> TaxationTypes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<UnitValue> UnitValues { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<UserType> UserTypes { get; set; }


        // override SaveChanges
        public override int SaveChanges()
        {
            UpdateStaticColumns();
            return base.SaveChanges();
        }

        // override SaveChangesAsync
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            UpdateStaticColumns();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        private void UpdateStaticColumns()
        {
            foreach (var entry in base.ChangeTracker.Entries())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["IsActive"] = true;
                        entry.CurrentValues["CreatedAt"] = DateTime.Now;
                        entry.CurrentValues["UpdatedAt"] = DateTime.Now;
                        break;
                    case EntityState.Deleted:
                        entry.CurrentValues["UpdatedAt"] = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues["UpdatedAt"] = DateTime.Now;
                        break;
                }
            }
        }

    }
}
