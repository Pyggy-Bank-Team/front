using Microsoft.EntityFrameworkCore;
using PiggyBank.Common.Enums;
using PiggyBank.Common.Models.Dto;
using PiggyBank.Common.Models.Generic;
using PiggyBank.Model;
using PiggyBank.Model.Models.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PiggyBank.Domain.Queries.Accounts
{
    public class GetAccountsGroupByTypeQuery : BaseQuery<GenericGroup<AccountType, AccountInfoDto>[]>
    {
        public GetAccountsGroupByTypeQuery(PiggyContext context) : base(context) { }

        public override async Task<GenericGroup<AccountType, AccountInfoDto>[]> Invoke()
        {
            var query = GetRepository<Account>().GroupBy(a => a.Type)
            .Select(g => new
            {
                g.Key,
                Account = g
            });

            try
            {
                var temp = await query.ToArrayAsync();
            }
            catch (Exception ex)
            {

                throw;
            }

            return null;
        }

    }
}
