using netwix.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace netwix.Services
{
    public interface INavegation
    {
        Task Initializa();
        Task NavegateToAsync<TViewModel>() where TViewModel : ViewModelBase;
        Task NavegateToAsync<TViewModel>(object parameter) 
            where TViewModel : ViewModelBase;
        Task NavegateToAsync(Type viewModelType);
        Task NavegateToAsync(Type viewModelType, object parameter);
        Task NavegateBackAsync();
        Task NavegateAndClearBackStackAsync<TViewModel>(object parameter = null)
            where TViewModel : ViewModelBase;

        Task RemoveLastFromBackStack();

    }
}
