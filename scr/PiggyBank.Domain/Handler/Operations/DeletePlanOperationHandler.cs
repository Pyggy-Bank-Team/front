using Microsoft.EntityFrameworkCore;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Operations
{
    public class DeletePlanOperationHandler : BaseHandler<int>
    {
        public DeletePlanOperationHandler(PiggyContext context, int command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var repository = GetRepository<PlanOperation>();
            var operation = await repository.FirstOrDefaultAsync(p => p.Id == Command, token);

            if (operation !=null)
            {
                operation.IsDeleted = true;
                repository.Update(operation);
            }
        }
    }
}
