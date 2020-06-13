using PiggyBank.Model;
using System.Threading.Tasks;
using PiggyBank.Domain.Infrastructure;
using System.Threading;

namespace PiggyBank.Domain.Handler
{
    public abstract class BaseHandler<TCommand> : DbWorker
    {
        public TCommand Command { get; set; }

        protected BaseHandler(PiggyContext context, TCommand command) : base(context)
        => Command = command;

        public abstract Task Invoke(CancellationToken token);
    }
}
