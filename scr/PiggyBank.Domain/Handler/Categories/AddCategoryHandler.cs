using System.Threading;
using System.Threading.Tasks;
using PiggyBank.Common.Commands.Categories;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;

namespace PiggyBank.Domain.Handler.Categories
{
    public class AddCategoryHandler : BaseHandler<AddCategoryCommand>
    {
        public AddCategoryHandler(PiggyContext context, AddCategoryCommand command)
            : base(context, command) { }

        public override async Task Invoke(CancellationToken token)
        {
            await GetRepository<Category>().AddAsync(new Category
            {
                Title = Command.Title,
                HexColor = Command.HexColor,
                Type = Command.Type,
                CreatedBy = Command.CreatedBy,
                CreatedOn = Command.CreatedOn
            }, token);
        }
    }
}
