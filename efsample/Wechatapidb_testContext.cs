using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace efsample
{
    public partial class Wechatapidb_testContext : DbContext
    {
        public Wechatapidb_testContext()
        {
        }

        public Wechatapidb_testContext(DbContextOptions<Wechatapidb_testContext> options)
            : base(options)
        {
        }

        public virtual DbSet<OrderPoolDmsPoTpd> OrderPoolDmsPoTpd { get; set; }
        public virtual DbSet<OrderPoolDmsSo> OrderPoolDmsSo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
      
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderPoolDmsPoTpd>(entity =>
            {
                entity.ToTable("Order_Pool_Dms_PO_TPD");

                entity.HasKey(x => new { x.LogisticCode });

                entity.Property(e => e.CustName).HasMaxLength(255);

                entity.Property(e => e.CustomerId).HasMaxLength(255);

                entity.Property(e => e.Cyl).HasColumnName("CYL");

                entity.Property(e => e.DistName).HasMaxLength(255);

                entity.Property(e => e.DistributorId)
                    .HasColumnName("DistributorID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.DmsorderId)
                    .HasColumnName("DMSOrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.Eye).HasColumnName("EYE");

                entity.Property(e => e.IsNeedPurchase).HasColumnName("IS_NEED_PURCHASE");

                entity.Property(e => e.LogisticCode)
                    .HasColumnName("LOGISTIC_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.MdsBrand)
                    .HasColumnName("MDS_Brand")
                    .HasMaxLength(255);

                entity.Property(e => e.MdsIndex)
                    .HasColumnName("MDS_Index")
                    .HasMaxLength(255);

                entity.Property(e => e.MdsProductName)
                    .HasColumnName("MDS_Product_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.OutboundTime)
                    .HasColumnName("Outbound_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.RxCustomer)
                    .HasColumnName("RX_Customer")
                    .HasMaxLength(128);

                entity.Property(e => e.RxProduct)
                    .HasColumnName("RX_Product")
                    .HasMaxLength(128);

                entity.Property(e => e.SkuBarcode)
                    .HasColumnName("Sku_Barcode")
                    .HasMaxLength(20);

                entity.Property(e => e.Sph).HasColumnName("SPH");

                entity.Property(e => e.ToEssilor).HasColumnName("toEssilor");
            });

            modelBuilder.Entity<OrderPoolDmsSo>(entity =>
            {
                entity.ToTable("Order_Pool_Dms_SO");

                entity.HasKey(x => new { x.LogisticCode });

                entity.Property(e => e.CustName).HasMaxLength(255);

                entity.Property(e => e.CustomerId).HasMaxLength(255);

                entity.Property(e => e.Cyl).HasColumnName("CYL");

                entity.Property(e => e.DistName).HasMaxLength(255);

                entity.Property(e => e.DistributorId)
                    .HasColumnName("DistributorID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.DmsorderId)
                    .HasColumnName("DMSOrderID")
                    .HasMaxLength(50);

                entity.Property(e => e.Eye).HasColumnName("EYE");

                entity.Property(e => e.IsNeedPurchase).HasColumnName("IS_NEED_PURCHASE");

                entity.Property(e => e.LogisticCode)
                    .HasColumnName("LOGISTIC_CODE")
                    .HasMaxLength(50);

                entity.Property(e => e.MdsBrand)
                    .HasColumnName("MDS_Brand")
                    .HasMaxLength(255);

                entity.Property(e => e.MdsIndex)
                    .HasColumnName("MDS_Index")
                    .HasMaxLength(255);

                entity.Property(e => e.MdsProductName)
                    .HasColumnName("MDS_Product_Name")
                    .HasMaxLength(255);

                entity.Property(e => e.OutboundTime)
                    .HasColumnName("Outbound_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.RxCustomer)
                    .HasColumnName("RX_Customer")
                    .HasMaxLength(128);

                entity.Property(e => e.RxProduct)
                    .HasColumnName("RX_Product")
                    .HasMaxLength(128);

                entity.Property(e => e.SkuBarcode)
                    .HasColumnName("Sku_Barcode")
                    .HasMaxLength(50);

                entity.Property(e => e.SoId)
                    .HasColumnName("SO_ID")
                    .HasColumnType("numeric(19, 0)");

                entity.Property(e => e.Sph).HasColumnName("SPH");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
