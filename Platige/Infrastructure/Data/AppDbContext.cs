using Microsoft.EntityFrameworkCore;
using Platige.Domain.Entities;

namespace Platige.Infrastructure.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Contractor> Contractors { get; set; } = null!;

        public DbSet<Invoice> Invoices { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Contractor>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Type).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.ShortName).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Country).IsRequired().HasMaxLength(20);
                entity.Property(e => e.Address).IsRequired().HasMaxLength(100);
                entity.Property(e => e.NIP).IsRequired().HasMaxLength(10);
                entity.Property(e => e.IsActive).IsRequired();
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Number).IsRequired().HasMaxLength(30);
                entity.Property(e => e.NetValue).IsRequired();
                entity.Property(e => e.Currency).IsRequired().HasMaxLength(3);
                entity.Property(e => e.VatRate).IsRequired();
                entity.Property(e => e.SaleDate).IsRequired();
            });

            modelBuilder.Entity<Invoice>()
                .HasOne(f => f.Contractor)
                .WithMany(k => k.Invoices)
                .HasForeignKey(f => f.ContractorId)
                .OnDelete(DeleteBehavior.Cascade)
                .IsRequired();
        }
    }
}
