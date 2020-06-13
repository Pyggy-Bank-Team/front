using PiggyBank.Common.Commands.Operations;
using PiggyBank.Common.Models.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Common.Interfaces
{
    public interface IOperationService
    {
        /// <summary>
        /// Add a new budget operation
        /// </summary>
        Task AddBudgetOperation(AddBudgetOperationCommand command, CancellationToken token);

        /// <summary>
        /// Add a new transfer operation
        /// </summary>
        Task AddTransferOperation(AddTransferOperationCommand command, CancellationToken token);

        /// <summary>
        /// Add a new plan operation
        /// </summary>
        Task AddPlanOperation(AddPlanOperationCommand command, CancellationToken token);

        /// <summary>
        /// Apply exists plan operation
        /// </summary>
        Task ApplyPlanOperation(int planOperationId, CancellationToken token);

        /// <summary>
        /// Get operations
        /// </summary>
        Task<OperationDto[]> GetOperations(Guid userId, CancellationToken token);

        /// <summary>
        /// Get operation by id
        /// </summary>
        Task<OperationDto> GetOperation(int id, CancellationToken token);

        /// <summary>
        /// Update exists entity
        /// </summary>
        Task UpdateOperation(UpdateOperationCommand command, CancellationToken token);

        /// <summary>
        /// Delete budget operation
        /// </summary>
        Task DeleteBudgetOperation(int id, CancellationToken token);

        /// <summary>
        /// Delete plan operation
        /// </summary>
        Task DeletePlanOperation(int operationId, CancellationToken token);

        /// <summary>
        /// Delee transfer operation
        /// </summary>
        Task DeleteTransferOperation(int operationId, CancellationToken token);
    }
}
