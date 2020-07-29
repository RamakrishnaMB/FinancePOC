using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Finance.Infra.Data2.ClassLibraryCore.DBModels
{
    public partial class PaymentDetailDBContext : DbContext
    {
        public PaymentDetailDBContext()
        {
        }

        public PaymentDetailDBContext(DbContextOptions<PaymentDetailDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Finances> Finances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //  optionsBuilder.UseSqlServer("Server=DESKTOP-LBTN8H4;Database=PaymentDetailDB;Trusted_Connection=True;");
                optionsBuilder.UseSqlServer(ConnectionString.GetConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Finances>(entity =>
            {
                entity.HasKey(e => e.Pmid);

                entity.Property(e => e.Pmid).HasColumnName("PMId");

                entity.Property(e => e.InsuranceDate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LoanDate)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.LoanHolderName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.LoanType)
                    .IsRequired()
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
