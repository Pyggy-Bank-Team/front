using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PiggyBank.Common.Enums;
using PiggyBank.Domain.Models.Operations;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Operations
{
    public class DeleteBudgetOperationHanlder : BaseHandler<int>
    {
        public DeleteBudgetOperationHanlder(PiggyContext context, int command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var operationRepository = GetRepository<BudgetOperation>();
            var accountRepository = GetRepository<Account>();

            var operation = await operationRepository.FirstOrDefaultAsync(o => o.Id == Command, token);

            if (operation == null)
                return;

            operation.IsDeleted = true;
            operationRepository.Update(operation);

            var account = accountRepository.FirstOrDefault(a => a.Id == operation.AccountId
                                                            && !a.IsDeleted && !a.IsArchived);

            if (account != null)
            {
                var shapshot = JsonConvert.DeserializeObject<OperationSnapshot>(operation.Shapshot);

                account.ChangeBalance(shapshot.CategoryType == CategoryType.Income ? -operation.Amount : operation.Amount);
                accountRepository.Update(account);
            }
        }
    }
}
