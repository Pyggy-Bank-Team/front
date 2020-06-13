using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PiggyBank.Common.Commands.Categories;
using PiggyBank.Common.Interfaces;
using PiggyBank.Common.Models.Dto;
using PiggyBank.WebApi.Extensions;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.WebApi.Controllers
{
    [Authorize]
    [ApiController, Route("api/[controller]")]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _service;

        public CategoriesController(ICategoryService service)
            => _service = service;

        [HttpGet]
        public Task<CategoryDto[]> Get(CancellationToken token)
            => _service.GetCategories(User.GetUserId(), token);

        [HttpGet, Route("{categoryId}")]
        public Task<CategoryDto> GetById(int categoryId, CancellationToken token)
            => _service.GetCategory(categoryId, token);

        [HttpPost]
        public async Task<IActionResult> Post(CategoryDto request, CancellationToken token)
        {
            var command = new AddCategoryCommand
            {
                Title = request.Title,
                HexColor = request.HexColor,
                Type = request.Type,
                CreatedBy = User.GetUserId(),
                CreatedOn = DateTime.UtcNow
            };

            await _service.AddCategory(command, token);
            return Ok();
        }

        [HttpPatch, Route("{categoryId}/Update")]
        public async Task<IActionResult> Update(int categoryId, CategoryDto request, CancellationToken token)
        {
            var command = new UpdateCategoryCommand
            {
                Id = request.Id,
                Title = request.Title,
                Type = request.Type,
                HexColor = request.HexColor
            };

            await _service.UpdateCategory(command, token);

            return Ok();
        }

        [HttpDelete, Route("{categoryId}/Delete")]
        public async Task<IActionResult> Delete(int categoryId, CancellationToken token)
        {
            await _service.DeleteCategory(categoryId, token);
            return Ok();
        }

        [HttpPatch, Route("{categoryId}/Archive")]
        public async Task<IActionResult> Archive(int categoryId, CancellationToken token)
        {
            await _service.ArchiveCategory(categoryId, token);
            return Ok();
        }
    }
}
