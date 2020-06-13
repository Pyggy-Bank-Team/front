using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Commands.Categories;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Handler.Categories
{
    public class UpdateCategoryHandler : BaseHandler<UpdateCategoryCommand>
    {
        public UpdateCategoryHandler(PiggyContext context, UpdateCategoryCommand command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            var repository = GetRepository<Category>();
            var category = await repository
                .FirstOrDefaultAsync(a => a.Id == Command.Id);

            if (category == null)
                return;

            category.Title = Command.Title;
            category.Type = Command.Type;
            category.HexColor = Command.HexColor;

            repository.Update(category);
        }
    }
}
