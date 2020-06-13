using System;
using System.Threading.Tasks;
using PiggyBank.Domain.Queries;
using PiggyBank.Model;

namespace PiggyBank.Domain.Infrastructure
{
    public class QueryDispatcher
    {
        private readonly PiggyContext _context;

        public QueryDispatcher(PiggyContext context)
            => _context = context;

        public Task<TOutput> Invoke<TQuery, TOutput>(object param1) where TQuery : BaseQuery<TOutput>
            => PrivateInvoke<TQuery, TOutput>(_context, param1);

        public Task<TOutput> Invoke<TQuery, TOutput>() where TQuery : BaseQuery<TOutput>
            => PrivateInvoke<TQuery, TOutput>(_context);

        private async Task<TOutput> PrivateInvoke<TQuery, TOutput>(params object[] obj) where TQuery : BaseQuery<TOutput>
        {
            TOutput result;
            using var query = (TQuery)Activator.CreateInstance(typeof(TQuery), obj);
            try
            {
                result = await query.Invoke();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return result;
        }
    }
}
