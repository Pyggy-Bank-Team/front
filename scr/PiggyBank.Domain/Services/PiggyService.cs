using Microsoft.EntityFrameworkCore;
using PiggyBank.Domain.Infrastructure;
using PiggyBank.Model;

namespace PiggyBank.Domain.Services
{
    public partial class PiggyService
    {
        private readonly HandlerDispatcher _handlerDispatcher;
        private readonly QueryDispatcher _queryDispatcher;

        public PiggyService(ServiceSettings settings)
        {
            var context = InitializationContext(settings.ConnectionString);
            context.Database.Migrate();

            _handlerDispatcher = new HandlerDispatcher(context);
            _queryDispatcher = new QueryDispatcher(context);
        }

        private PiggyContext InitializationContext(string connectionString)
        {
            var builder = new DbContextOptionsBuilder<PiggyContext>();
            builder.UseSqlServer(connectionString);
            return new PiggyContext(builder.Options);
        }
    }
}
