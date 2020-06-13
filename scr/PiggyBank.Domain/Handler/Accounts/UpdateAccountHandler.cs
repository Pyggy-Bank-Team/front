using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Commands.Accounts;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Accounts
{
    public class UpdateAccountHandler : BaseHandler<UpdateAccountCommand>
    {
        public UpdateAccountHandler(PiggyContext context, UpdateAccountCommand command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var account = await GetRepository<Account>()
                .FirstOrDefaultAsync(a => a.Id == Command.Id);

            if (account == null)
                return;

            account.Title = Command.Title;
            account.Type = Command.Type;
            account.Balance = Command.Balance;
            account.Currency = Command.Currency;

            GetRepository<Account>().Update(account);
        }
    }
}
