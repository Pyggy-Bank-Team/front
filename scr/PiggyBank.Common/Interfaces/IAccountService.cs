using PiggyBank.Common.Commands.Accounts;
using PiggyBank.Common.Enums;
using PiggyBank.Common.Models.Dto;
using PiggyBank.Common.Models.Generic;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Common.Interfaces
{
    public interface IAccountService
    {
        /// <summary>
        /// Add a new account
        /// </summary>
        Task AddAccount(AddAccountCommand command, CancellationToken token);

        /// <summary>
        /// Get accounts
        /// </summary>
        Task<AccountInfoDto[]> GetAccounts(Guid userId, CancellationToken token);

        /// <summary>
        /// Get accounts group by type
        /// </summary>
        Task<GenericGroup<AccountType, AccountInfoDto>[]> GetAccountsGroupByType(CancellationToken token);

        /// <summary>
        /// Get account by id
        /// </summary>
        Task<AccountDto> GetAccount(int id, CancellationToken token);

        /// <summary>
        /// Update exists entity
        /// </summary>
        Task UpdateAccount(UpdateAccountCommand command, CancellationToken token);

        /// <summary>
        /// Delete exists entity
        /// </summary>
        Task DeleteAccount(int id, CancellationToken token);

        /// <summary>
        /// Archive exists entity
        /// </summary>
        Task ArchiveAccount(int id, CancellationToken token);
    }
}
