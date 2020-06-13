using Microsoft.EntityFrameworkCore;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Accounts
{
    public class ArchiveAccountHandler : BaseHandler<int>
    {
        public ArchiveAccountHandler(PiggyContext context, int command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var repository = GetRepository<Account>();
            var account = await repository.FirstOrDefaultAsync(a => a.Id == Command && !a.IsDeleted);

            if (account == null || account.IsArchived)
                return;

            account.IsArchived = true;
            repository.Update(account);
        }
    }
}
