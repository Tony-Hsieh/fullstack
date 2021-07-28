using System.Reflection;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data
{
    public class BudgetTrackerDbContext: DbContext
    {
        public BudgetTrackerDbContext(DbContextOptions<BudgetTrackerDbContext> options): base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Expenditure> Expenditures { get; set; }
        public DbSet<Income> Incomes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(ConfigureUser);
            modelBuilder.Entity<Income>(ConfigureIncome);
            modelBuilder.Entity<Expenditure>(ConfigureExpenditure);
        }

        private void ConfigureExpenditure(EntityTypeBuilder<Expenditure> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).ValueGeneratedOnAdd();
            builder.Property(e => e.Amount).HasColumnType("decimal(5, 2)").HasDefaultValue(0);
        }

        private void ConfigureIncome(EntityTypeBuilder<Income> builder)
        {
            builder.HasKey(i => i.Id);
            builder.Property(i => i.Id).ValueGeneratedOnAdd();
            builder.Property(i => i.Amount).HasColumnType("decimal(5, 2)").HasDefaultValue(0);
            // builder.Property(i => i.Amount).HasColumnType("money").IsRequired();
        }

        private void ConfigureUser(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();
        }
    }

}