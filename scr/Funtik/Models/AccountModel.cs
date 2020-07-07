using System;
using System.Linq;
using System.Threading.Tasks;
using Funtik.Enums;
using Funtik.Interfaces;
using Funtik.Models.Services.Requests;

namespace Funtik.Models
{
    public class AccountModel : IAccountModel
    {
        //For example
        private AccountInfoDto[] _accounts;

        public AccountModel()
        {
            _accounts = new[]
            {
                new AccountInfoDto
                {
                    Id = 1,
                    Balance = 100,
                    Currency = "RUB",
                    Title = "Rocket",
                    Type = AccountType.Card
                },
                new AccountInfoDto
                {
                    Id = 2,
                    Balance = 200,
                    Currency = "RUB",
                    Title = "Tinkoff",
                    Type = AccountType.Card
                },
                new AccountInfoDto
                {
                    Id = 3,
                    Balance = 400,
                    Currency = "RUB",
                    Title = "Home money",
                    Type = AccountType.Cash
                },
                new AccountInfoDto
                {
                    Id = 3,
                    Balance = 400,
                    Currency = "RUB",
                    Title = "Russian Standart",
                    Type = AccountType.Card,
                    IsArchived = true
                }
            };
        }

        public Task AddAccount(AccountInfoDto account)
        {
            throw new System.NotImplementedException();
        }

        public async Task<AccountInfoDto[]> GetAccounts()
        {
            await Task.Delay(2000);
            return _accounts;
        }

        public async Task UpdateAccount(AccountInfoDto account)
        {
            var existAccount = _accounts.FirstOrDefault(a => a.Id == account.Id);

            if (existAccount == null)
                return;

            await Task.Delay(1000);

            existAccount.Title = account.Title;
            existAccount.Balance = account.Balance;
            existAccount.Currency = account.Currency;
            existAccount.IsArchived = account.IsArchived;
            existAccount.Type = account.Type;

            PropertyChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler PropertyChanged;
    }
}
