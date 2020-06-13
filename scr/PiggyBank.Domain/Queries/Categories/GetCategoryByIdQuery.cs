using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Models.Dto;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Queries.Categories
{
    public class GetCategoryByIdQuery : BaseQuery<CategoryDto>
    {
        private readonly int _categoryId;
        public GetCategoryByIdQuery(PiggyContext context, int categoryId)
            : base(context)
            => _categoryId = categoryId;

        public override Task<CategoryDto> Invoke()
            => GetRepository<Category>().Where(c => c.Id == _categoryId && !c.IsDeleted)
            .Select(c => new CategoryDto
            {
                Id = c.Id,
                HexColor = c.HexColor,
                Title = c.Title,
                Type = c.Type
            }).FirstOrDefaultAsync();
    }
}
