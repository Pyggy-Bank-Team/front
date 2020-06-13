using Microsoft.EntityFrameworkCore;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Categories
{
    public class ArchiveCategoryHandler : BaseHandler<int>
    {
        public ArchiveCategoryHandler(PiggyContext context, int command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var repository = GetRepository<Category>();
            var category = await repository.FirstOrDefaultAsync(a => a.Id == Command && !a.IsDeleted);

            if (category == null || category.IsArchived)
                return;

            category.IsArchived = true;
            repository.Update(category);
        }
    }
}
