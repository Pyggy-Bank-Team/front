using System.Threading.Tasks;
using PiggyBank.Domain.Infrastructure;
using PiggyBank.Model;

namespace PiggyBank.Domain.Queries
{
    public abstract class BaseQuery<TOutput> : DbWorker
    {
        protected BaseQuery(PiggyContext context) : base(context) {}

        public abstract Task<TOutput> Invoke();
    }
}
