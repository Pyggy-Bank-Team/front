using System;

namespace PiggyBank.Site.Interfaces
{
    public interface IPropertyChanged
    {
        event EventHandler PropertyChanged;
    }
}
