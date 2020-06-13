using Microsoft.EntityFrameworkCore;
using PiggyBank.Model.Models.Entities;

namespace PiggyBank.Model
{
    public class PiggyContext : DbContext
    {
        public PiggyContext(DbContextOptions<PiggyContext> options)
            : base(options) { }

        public DbSet<Account> Accounts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Operation> Operations { get; set; }

        public DbSet<BudgetOperation> BudgetOperations { get; set; }

        public DbSet<TransferOperation> TransferOperations { get; set; }

        public DbSet<PlanOperation> PlanOperations { get; set; }

        public DbSet<BalanceHistory> BalanceHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BudgetOperation>()
                .Property(b => b.AccountId)
                .HasColumnName(nameof(BudgetOperation.AccountId));

            modelBuilder.Entity<BudgetOperation>()
                .Property(b => b.CategoryId)
                .HasColumnName(nameof(BudgetOperation.CategoryId));

            modelBuilder.Entity<BudgetOperation>()
                .Property(b => b.Amount)
                .HasColumnName(nameof(BudgetOperation.Amount));

            modelBuilder.Entity<PlanOperation>()
                .Property(p => p.AccountId)
                .HasColumnName(nameof(PlanOperation.AccountId));

            modelBuilder.Entity<PlanOperation>()
                .Property(p => p.CategoryId)
                .HasColumnName(nameof(PlanOperation.CategoryId));

            modelBuilder.Entity<PlanOperation>()
                .Property(p => p.Amount)
                .HasColumnName(nameof(PlanOperation.Amount));

            modelBuilder.Entity<TransferOperation>()
                .Property(t => t.Amount)
                .HasColumnName(nameof(TransferOperation.Amount));

            modelBuilder.HasDefaultSchema("Pb");
        }
    }
}
