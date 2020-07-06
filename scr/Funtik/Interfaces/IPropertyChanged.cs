using System;

namespace Funtik.Interfaces
{
    public interface IPropertyChanged
    {
        event EventHandler PropertyChanged;
    }
}
