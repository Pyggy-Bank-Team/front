using Microsoft.AspNetCore.Components;

namespace Funtik.ViewModels
{
    public class ViewModelBase<T> : ComponentBase
    {
        public string Class { get; set; }

        public T Model { get; set; }
    }
}
