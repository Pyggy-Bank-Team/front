using PiggyBank.Common.Commands.Categories;
using PiggyBank.Common.Models.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Common.Interfaces
{
    public interface ICategoryService
    {
        /// <summary>
        /// Add a new category
        /// </summary>
        Task AddCategory(AddCategoryCommand command, CancellationToken token);

        /// <summary>
        /// Get categories
        /// </summary>
        Task<CategoryDto[]> GetCategories(Guid userId, CancellationToken token);

        /// <summary>
        /// Get category by id
        /// </summary>
        Task<CategoryDto> GetCategory(int id, CancellationToken token);

        /// <summary>
        /// Update exists entity
        /// </summary>
        Task UpdateCategory(UpdateCategoryCommand command, CancellationToken token);

        /// <summary>
        /// Delete exists entity
        /// </summary>
        Task DeleteCategory(int id, CancellationToken token);

        /// <summary>
        /// Archive exists entity
        /// </summary>
        Task ArchiveCategory(int id, CancellationToken token);
    }
}
