using Microsoft.AspNetCore.Components;
using PiggyBank.Common.Models.Dto;
using PiggyBank.WebSite.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PiggyBank.WebSite.ViewModels.Accounts
{
    public class AccountsViewModel : ComponentBase
    {
        private const string DisplayNone = "display:none;";
        private const string DisplayBlock = "display:block;";

        [Inject]
        public IAccountModel AccountModel { get; set; }

        public IList<AccountInfoDto> Accounts { get; set; }

        public AccountInfoDto SelectedAccount { get; set; }

        public bool ShowEditModal { get; set; } = false;

        public string ArchivedAccountsStyle { get; set; } = DisplayNone;

        protected override async Task OnInitializedAsync()
        {
            Accounts = await AccountModel.GetAccounts();
            AccountModel.PropertyChanged += (o, e) => StateHasChanged();
        }

        public void OnShow(AccountInfoDto selectedAccount)
        {
            SelectedAccount = selectedAccount;
            ShowEditModal = true;
        }

        public void ShowArchived(bool show)
            => ArchivedAccountsStyle = show
                                     ? DisplayBlock
                                     : DisplayNone;

        public Task OnSaved(AccountInfoDto savedAccount)
        {
            ShowEditModal = false;
            return AccountModel.UpdateAccount(savedAccount);
        }

        public void OnHided()
        {
            ShowEditModal = false;
        }
    }
}
