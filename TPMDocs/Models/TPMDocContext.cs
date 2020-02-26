namespace TPMDocs.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TPMDocContext : DbContext
    {
        public TPMDocContext()
            : base("name=TPMDocContext")
        {
        }

        public virtual DbSet<DocsContract> DocsContracts { get; set; }
        public virtual DbSet<DocsRoute> DocsRoutes { get; set; }
        public virtual DbSet<DocsRouteUser> DocsRouteUsers { get; set; }
        public virtual DbSet<Виды_отгрузки> Виды_отгрузки { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<tbGoodCode> tbGoodCodes { get; set; }
        public virtual DbSet<Виды_гофропродукции> Виды_гофропродукции { get; set; }
        public virtual DbSet<Комплектующие> Комплектующие { get; set; }
        public virtual DbSet<Справочник_гофропродукции> Справочник_гофропродукции { get; set; }
        public virtual DbSet<Справочник_городов> Справочник_городов { get; set; }
        public virtual DbSet<tbContract> tbContracts { get; set; }
        public virtual DbSet<tbContractCategory> tbContractCategories { get; set; }
        public virtual DbSet<tbContractChk> tbContractChks { get; set; }
        public virtual DbSet<tbContractDeliveryTerm> tbContractDeliveryTerms { get; set; }
        public virtual DbSet<tbContractProd> tbContractProds { get; set; }

        public virtual DbSet<tbСправочник_банков> tbСправочник_банков { get; set; }
        public virtual DbSet<tbСправочник_валют> tbСправочник_валют { get; set; }
        public virtual DbSet<tbСправочник_валют_курсы> tbСправочник_валют_курсы { get; set; }
        public virtual DbSet<Работники> Работники { get; set; }
        public virtual DbSet<Справочник_клиентов> Справочник_клиентов { get; set; }
        public virtual DbSet<Справочник_клиентов_банки> Справочник_клиентов_банки { get; set; }
        public virtual DbSet<Справочник_клиентов_жд> Справочник_клиентов_жд { get; set; }
        public virtual DbSet<Справочник_клиентов_Интернет> Справочник_клиентов_Интернет { get; set; }
        public virtual DbSet<Справочник_клиентов_поставка> Справочник_клиентов_поставка { get; set; }
        public virtual DbSet<Справочник_клиентов_продукция> Справочник_клиентов_продукция { get; set; }
        public virtual DbSet<Справочник_клиентов_руководители> Справочник_клиентов_руководители { get; set; }
        public virtual DbSet<tbУсловия_поставки> tbУсловия_поставки { get; set; }
        public virtual DbSet<Единицы_измерения> Единицы_измерения { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<Виды_отгрузки>()
              .Property(e => e.SSMA_TimeStamp)
              .IsFixedLength();

            modelBuilder.Entity<tbУсловия_поставки>()
             .Property(e => e.SSMA_TimeStamp)
             .IsFixedLength();

            modelBuilder.Entity<Единицы_измерения>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tbGoodCode>()
               .Property(e => e.SSMA_TimeStamp)
               .IsFixedLength();

            modelBuilder.Entity<Виды_гофропродукции>()
              .Property(e => e.SSMA_TimeStamp)
              .IsFixedLength();

            modelBuilder.Entity<Справочник_гофропродукции>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tbContract>()
             .Property(e => e.SSMA_TimeStamp)
             .IsFixedLength();
   
            modelBuilder.Entity<tbContractCategory>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tbContractChk>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tbContractDeliveryTerm>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tbContractProd>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tbСправочник_банков>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tbСправочник_валют>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tbСправочник_валют_курсы>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Справочник_клиентов_банки>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Справочник_клиентов_жд>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Справочник_клиентов_Интернет>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Справочник_клиентов_поставка>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Справочник_клиентов_продукция>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<Справочник_клиентов_руководители>()
                .Property(e => e.SSMA_TimeStamp)
                .IsFixedLength();
        }
    }
}
