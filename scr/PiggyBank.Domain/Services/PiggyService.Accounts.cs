using PiggyBank.Common.Commands.Accounts;
using PiggyBank.Common.Enums;
using PiggyBank.Common.Interfaces;
using PiggyBank.Common.Models.Dto;
using PiggyBank.Common.Models.Generic;
using PiggyBank.Domain.Handler.Accounts;
using PiggyBank.Domain.Queries.Accounts;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Services
{
    public partial class PiggyService : IAccountService
    {
        public Task AddAccount(AddAccountCommand command, CancellationToken token)
             => _handlerDispatcher.Invoke<AddAccountHandler, AddAccountCommand>(command, token);

        public Task ArchiveAccount(int id, CancellationToken token)
            => _handlerDispatcher.Invoke<ArchiveAccountHandler, int>(id, token);

        public Task DeleteAccount(int id, CancellationToken token)
            => _handlerDispatcher.Invoke<DeleteAccountHandler, int>(id, token);

        public Task<AccountDto> GetAccount(int accountId, CancellationToken token)
            => _queryDispatcher.Invoke<GetAccountByIdQuery, AccountDto>(accountId);

        public Task<AccountInfoDto[]> GetAccounts(Guid userId, CancellationToken token)
            => _queryDispatcher.Invoke<GetAccountsQuery, AccountInfoDto[]>(userId);

        public Task<GenericGroup<AccountType, AccountInfoDto>[]> GetAccountsGroupByType(CancellationToken token)
            => _queryDispatcher.Invoke<GetAccountsGroupByTypeQuery, GenericGroup<AccountType, AccountInfoDto>[]>();

        public Task UpdateAccount(UpdateAccountCommand command, CancellationToken token)
            => _handlerDispatcher.Invoke<UpdateAccountHandler, UpdateAccountCommand>(command, token);
    }
}
