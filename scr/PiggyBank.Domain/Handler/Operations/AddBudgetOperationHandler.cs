using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PiggyBank.Common.Commands.Operations;
using PiggyBank.Common.Enums;
using PiggyBank.Domain.Models.Operations;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Operations
{
    public class AddBudgetOperationHandler : BaseHandler<AddBudgetOperationCommand>
    {
        public AddBudgetOperationHandler(PiggyContext context, AddBudgetOperationCommand command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var accountRepository = GetRepository<Account>();
            var account = await accountRepository.FirstOrDefaultAsync(a => a.Id == Command.AccountId && !a.IsDeleted, token)
                ?? throw new ArgumentException($"Can't found account by {Command.AccountId}");

            var category = await GetRepository<Category>().FirstOrDefaultAsync(c => c.Id == Command.CategoryId && !c.IsDeleted, token)
                ?? throw new ArgumentException($"Can't found category by {Command.CategoryId}");

            var shapshot = new OperationSnapshot
            {
                CategoryType = category.Type
            };

            var operation = new BudgetOperation
            {
                Amount = Command.Amount,
                Type = OperationType.Budget,
                Comment = Command.Comment,
                AccountId = Command.AccountId,
                CategoryId = Command.CategoryId,
                CreatedOn = Command.CreatedOn,
                Shapshot = JsonConvert.SerializeObject(shapshot),
                CreatedBy = Command.CreatedBy
            };

            account.ChangeBalance(category.Type == CategoryType.Income ? operation.Amount : -operation.Amount);

            accountRepository.Update(account);

            await GetRepository<BudgetOperation>().AddAsync(operation, token);
        }
    }
}
