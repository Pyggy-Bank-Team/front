using Microsoft.EntityFrameworkCore;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Operations
{
    public class DeleteTransferOperationHandler : BaseHandler<int>
    {
        public DeleteTransferOperationHandler(PiggyContext context, int command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var operation = await GetRepository<TransferOperation>().FirstOrDefaultAsync(t => t.Id == Command, token);

            if (operation != null)
            {
                var accountRepository = GetRepository<Account>();
                var fromAccount = await accountRepository.FirstOrDefaultAsync(a => a.Id == operation.From, token)
                ?? throw new ArgumentException($"Can't found account by {operation.From}");

                var toAccount = await accountRepository.FirstOrDefaultAsync(a => a.Id == operation.To, token)
                    ?? throw new ArgumentException($"Can't found account by {operation.To}");

                fromAccount.ChangeBalance(operation.Amount);
                toAccount.ChangeBalance(-operation.Amount);

                accountRepository.UpdateRange(new[] { fromAccount, toAccount });

                operation.IsDeleted = true;
                GetRepository<TransferOperation>().Update(operation);
            }
        }
    }
}
