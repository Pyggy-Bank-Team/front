using Microsoft.AspNetCore.Components;

namespace PiggyBank.WebSite.ViewModels
{
    public class ViewModelBase<T> : ComponentBase
    {
        public string Class { get; set; }

        public T Model { get; set; }
    }
}
