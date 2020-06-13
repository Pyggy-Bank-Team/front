using System.Threading;
using System.Threading.Tasks;
using PiggyBank.Common.Commands.Accounts;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;

namespace PiggyBank.Domain.Handler.Accounts
{
    public class AddAccountHandler : BaseHandler<AddAccountCommand>
    {
        public AddAccountHandler(PiggyContext context, AddAccountCommand command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            await GetRepository<Account>().AddAsync(new Account
            {
                Balance = Command.Balance,
                Currency = Command.Currency,
                IsArchived = Command.IsArchived,
                IsDeleted = Command.IsDeleted,
                Title = Command.Title,
                Type = Command.Type,
                CreatedBy = Command.CreatedBy,
                CreatedOn = Command.CreatedOn
            }, token);
        }
    }
}
