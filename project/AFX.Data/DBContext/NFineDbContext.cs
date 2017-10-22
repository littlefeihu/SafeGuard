using AFX.Data.Entity.SalverManager;
using AFX.Data.Entity.SystemManage;
using AFX.Data.Entity.SystemSecurity;
/*******************************************************************************
 * Copyright © 2016 分享智慧版权所有
 * Author: Allen
 * 分享智慧
 * 
*********************************************************************************/
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;

namespace AFX.Data
{
    public class NFineDbContext : DbContext
    {

        public DbSet<RentOrder> RentOrders { get; set; }
        public DbSet<RentOrderItem> RentOrderItems { get; set; }
        public DbSet<RentOrderNote> RentOrderNotes { get; set; }
        public DbSet<SalverEntity> Salvers { get; set; }
        public DbSet<SalverPosition> SalverPositions { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }

        public DbSet<AreaEntity> Areas { get; set; }
        public DbSet<ItemsDetailEntity> ItemsDetails { get; set; }
        public DbSet<ItemsEntity> ItemsEntities { get; set; }
        public DbSet<ModuleButtonEntity> ModuleButtonEntities { get; set; }
        public DbSet<ModuleEntity> ModuleEntities { get; set; }
        public DbSet<OrganizeEntity> OrganizeEntities { get; set; }
        public DbSet<RoleAuthorizeEntity> RoleAuthorizeEntities { get; set; }
        public DbSet<RoleEntity> RoleEntities { get; set; }
        public DbSet<UserEntity> UserEntities { get; set; }
        public DbSet<UserLogOnEntity> UserLogOnEntities { get; set; }
        public DbSet<DbBackupEntity> DbBackupEntities { get; set; }
        public DbSet<FilterIPEntity> FilterIPEntities { get; set; }
        public DbSet<LogEntity> LogEntities { get; set; }


        public NFineDbContext()
            : base("SalverDBContext")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
            this.Configuration.ValidateOnSaveEnabled = false;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !String.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }
            base.OnModelCreating(modelBuilder);
        }
    }
}
