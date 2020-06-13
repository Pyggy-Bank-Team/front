using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Models.Dto;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Queries.Operations
{
    public class GetOperationByIdQuery : BaseQuery<OperationDto>
    {
        private readonly int _operationId;
        public GetOperationByIdQuery(PiggyContext context, int operationId)
            : base(context)
            => _operationId = operationId;

        public override Task<OperationDto> Invoke()
            => GetRepository<Operation>().Where(o => o.Id == _operationId)
            .Select(o => new OperationDto
            {
                Id = o.Id,
                Comment = o.Comment,
                Type = o.Type
            })
            .FirstOrDefaultAsync();
    }
}
