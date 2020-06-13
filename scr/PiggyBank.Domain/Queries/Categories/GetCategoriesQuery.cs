using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Models.Dto;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Queries.Categories
{
    public class GetCategoriesQuery : BaseQuery<CategoryDto[]>
    {
        private readonly Guid _userId;
        public GetCategoriesQuery(PiggyContext context, Guid userId)
            : base(context)
            => _userId = userId;

        public override Task<CategoryDto[]> Invoke()
            => GetRepository<Category>().Where(c => c.CreatedBy == _userId && !c.IsDeleted)
            .Select(c => new CategoryDto
            {
                Id = c.Id,
                HexColor = c.HexColor,
                Title = c.Title,
                Type = c.Type
            }).ToArrayAsync();
    }
}
