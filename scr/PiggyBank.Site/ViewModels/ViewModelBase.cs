using Microsoft.AspNetCore.Components;

namespace PiggyBank.Site.ViewModels
{
    public class ViewModelBase<T> : ComponentBase
    {
        public string Class { get; set; }

        public T Model { get; set; }
    }
}
