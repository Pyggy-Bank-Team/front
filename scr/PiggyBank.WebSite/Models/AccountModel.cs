using PiggyBank.Common.Enums;
using PiggyBank.Common.Models.Dto;
using PiggyBank.WebSite.Interfaces;
using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PiggyBank.WebSite.Models
{
    public class AccountModel : IAccountModel
    {
        private readonly HttpClient _httpClient;

        //For example
        private AccountInfoDto[] _accounts;

        public AccountModel(IHttpClientFactory httpFactory)
        {
            _httpClient = httpFactory.CreateClient();
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
