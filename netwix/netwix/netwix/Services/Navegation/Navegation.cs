using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using netwix.ViewModel;
using netwix.ViewModel.Base;
using netwix.Views;
using Xamarin.Forms;

namespace netwix.Services
{
    public class Navegation : INavegation
    {
        protected readonly Dictionary<Type, Type> _mappings;

        protected Application CurrentApplication
        {
            get { return Application.Current; }
        }

        public Navegation()
        {
            _mappings = new Dictionary<Type, Type>();
            CreateViewModelMapping();
        }

        private void CreateViewModelMapping()
        {
            _mappings.Add(typeof(MainViewModel), typeof(MainView));
            _mappings.Add(typeof(DetailViewModel), typeof(DetailView));
        }

        public Task Initializa()
        {
            throw new NotImplementedException();
        }

        public Task NavegateAndClearBackStackAsync<TViewModel>(object parameter = null) where TViewModel : ViewModelBase
        {
            throw new NotImplementedException();
        }

        public Task NavegateBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavegateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            throw new NotImplementedException();
        }

        public Task NavegateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            throw new NotImplementedException();
        }

        public Task NavegateToAsync(Type viewModelType)
        {
            throw new NotImplementedException();
        }

        public Task NavegateToAsync(Type viewModelType, object parameter)
        {
            throw new NotImplementedException();
        }

        #region Not Implemented

        public Task RemoveLastFromBackStack()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
