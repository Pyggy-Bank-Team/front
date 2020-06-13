using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PiggyBank.IdentityServer.Models
{
    public class IndeintityContext : IdentityDbContext
    {
        public IndeintityContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityUser>().ToTable("Users", "Idt");
            builder.Entity<IdentityRole>().ToTable("Roles", "Idt");
            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "Idt");
            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "Idt");
            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "Idt");
            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "Idt");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "Idt");
        }
    }

    public class IndeintityContextFactory : IDesignTimeDbContextFactory<IndeintityContext>
    {
        public IndeintityContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<IndeintityContext>();
            builder.UseSqlServer("Server=(local)\\SQL2016;Database=PiggyBank;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new IndeintityContext(builder.Options);
        }
    }
}
