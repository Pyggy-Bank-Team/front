using PiggyBank.Common.Models.Dto;
using System.Threading.Tasks;

namespace PiggyBank.WebSite.Interfaces
{
    public interface IAccountModel : IPropertyChanged
    {
        Task<AccountInfoDto[]> GetAccounts();

        Task AddAccount(AccountInfoDto account);

        Task UpdateAccount(AccountInfoDto account);
    }
}
