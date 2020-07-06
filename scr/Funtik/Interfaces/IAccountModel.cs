using System.Threading.Tasks;
using Funtik.Models.Requests;

namespace Funtik.Interfaces
{
    public interface IAccountModel : IPropertyChanged
    {
        Task<AccountInfoDto[]> GetAccounts();

        Task AddAccount(AccountInfoDto account);

        Task UpdateAccount(AccountInfoDto account);
    }
}
