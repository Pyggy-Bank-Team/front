using PiggyBank.Common.Commands.Operations;
using PiggyBank.Common.Interfaces;
using PiggyBank.Common.Models.Dto;
using PiggyBank.Domain.Handler.Operations;
using PiggyBank.Domain.Queries.Operations;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Services
{
    public partial class PiggyService : IOperationService
    {
        public Task AddBudgetOperation(AddBudgetOperationCommand command, CancellationToken token)
            => _handlerDispatcher.Invoke<AddBudgetOperationHandler, AddBudgetOperationCommand>(command, token);

        public Task AddPlanOperation(AddPlanOperationCommand command, CancellationToken token)
            => _handlerDispatcher.Invoke<AddPlanOperationHandler, AddPlanOperationCommand>(command, token);

        public Task AddTransferOperation(AddTransferOperationCommand command, CancellationToken token)
            => _handlerDispatcher.Invoke<AddTransferOperationHandler, AddTransferOperationCommand>(command, token);

        public Task ApplyPlanOperation(int planOperationId, CancellationToken token)
            => _handlerDispatcher.Invoke<ApplyPlanOperationHandler, int>(planOperationId, token);

        public Task DeleteBudgetOperation(int id, CancellationToken token)
            => _handlerDispatcher.Invoke<DeleteBudgetOperationHanlder, int>(id, token);

        public Task DeletePlanOperation(int operationId, CancellationToken token)
            => _handlerDispatcher.Invoke<DeletePlanOperationHandler, int>(operationId, token);

        public Task DeleteTransferOperation(int operationId, CancellationToken token)
            => _handlerDispatcher.Invoke<DeleteTransferOperationHandler, int>(operationId, token);

        public Task<OperationDto> GetOperation(int id, CancellationToken token)
            => _queryDispatcher.Invoke<GetOperationByIdQuery, OperationDto>(id);

        public Task<OperationDto[]> GetOperations(Guid userId, CancellationToken token)
            => _queryDispatcher.Invoke<GetOperationsQuery, OperationDto[]>(userId);

        public Task UpdateOperation(UpdateOperationCommand command, CancellationToken token)
        {
            throw new NotImplementedException();
        }
    }
}
