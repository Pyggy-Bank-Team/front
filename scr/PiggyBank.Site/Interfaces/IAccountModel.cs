using System.Threading.Tasks;
using PiggyBank.Common.Models.Dto;

namespace PiggyBank.Site.Interfaces
{
    public interface IAccountModel : IPropertyChanged
    {
        Task<AccountInfoDto[]> GetAccounts();

        Task AddAccount(AccountInfoDto account);

        Task UpdateAccount(AccountInfoDto account);
    }
}
