using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Enums;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Operations
{
    public class ApplyPlanOperationHandler : BaseHandler<int>
    {
        public ApplyPlanOperationHandler(PiggyContext context, int command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var budget = GetRepository<BudgetOperation>();
            var plan = GetRepository<PlanOperation>();
            var accounts = GetRepository<Account>();

            var operation = await plan.FirstOrDefaultAsync(p => p.Id == Command)
            ?? throw new ArgumentException("Can't found plan operaton");

            operation.IsDeleted = true;
            plan.Update(operation);

            var account = await accounts.FirstOrDefaultAsync(a => a.Id == operation.AccountId && !a.IsDeleted, token)
                ?? throw new ArgumentException($"Can't found account by {operation.AccountId}");

            var category = await GetRepository<Category>().FirstOrDefaultAsync(c => c.Id == operation.CategoryId && !c.IsDeleted, token)
                ?? throw new ArgumentException($"Can't found category by {operation.CategoryId}");

            await budget.AddAsync(new BudgetOperation
            {
                AccountId = operation.AccountId,
                Amount = operation.Amount,
                CategoryId = operation.CategoryId,
                Comment = operation.Comment,
                CreatedBy = operation.CreatedBy,
                CreatedOn = operation.CreatedOn,
                Type = OperationType.Budget,
                Shapshot = operation.Shapshot
            }, token);

            account.ChangeBalance(category.Type == CategoryType.Income ? operation.Amount : -operation.Amount);

            accounts.Update(account);
        }
    }
}
