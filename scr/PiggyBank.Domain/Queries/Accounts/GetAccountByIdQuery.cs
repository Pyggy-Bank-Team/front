using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Models.Dto;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Queries.Accounts
{
    public class GetAccountByIdQuery : BaseQuery<AccountDto>
    {
        private readonly int _accountId;
        public GetAccountByIdQuery(PiggyContext context, int accountId) : base(context)
            => _accountId = accountId;

        public override Task<AccountDto> Invoke()
            => GetRepository<Account>().Where(a => a.Id == _accountId && !a.IsDeleted)
            .Select(a => new AccountDto
            {
                Id = a.Id,
                Balance = a.Balance,
                Currency = a.Currency,
                IsArchived = a.IsArchived,
                IsDeleted = a.IsDeleted,
                Title = a.Title,
                Type = a.Type
            }).FirstOrDefaultAsync();
    }
}
