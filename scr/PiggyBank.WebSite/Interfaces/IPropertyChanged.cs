using System;

namespace PiggyBank.WebSite.Interfaces
{
    public interface IPropertyChanged
    {
        event EventHandler PropertyChanged;
    }
}
