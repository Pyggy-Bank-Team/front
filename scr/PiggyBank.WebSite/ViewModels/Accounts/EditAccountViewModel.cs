using Microsoft.AspNetCore.Components;
using PiggyBank.Common.Enums;
using PiggyBank.Common.Models.Dto;
using PiggyBank.WebSite.Interfaces;
using System;
using System.Threading.Tasks;

namespace PiggyBank.WebSite.ViewModels.Accounts
{
    public class EditAccountViewModel : ComponentBase
    {
        [Inject]
        public IAccountModel AccountModel { get; set; }

        [Parameter]
        public EventCallback<EventArgs> GoBack { get; set; }

        [Parameter]
        public AccountInfoDto Model { get; set; }

        public async Task OnSave()
        {
            //if (Model.Id != default)
            //{
            //    await AccountModel.UpdateAccount(new AccountDto());
            //}
            //else
            //{
            //    await AccountModel.AddAccount(new AccountDto());
            //}

            await OnGoBack();
        }

        public Task OnGoBack() => GoBack.InvokeAsync(EventArgs.Empty);

        public void OnTypeChanged(ChangeEventArgs args)
        {
            Model.Type = (AccountType)Enum.Parse(typeof(AccountType), (string)args.Value);
        }
    }
}
