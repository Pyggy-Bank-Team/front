using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace PiggyBank.Model
{
    public class PiggyContextFactory : IDesignTimeDbContextFactory<PiggyContext>
    {
        public PiggyContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<PiggyContext>();
            builder.UseSqlServer("Server=(local)\\SQL2016;Database=PiggyBank;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new PiggyContext(builder.Options);
        }
    }
}
