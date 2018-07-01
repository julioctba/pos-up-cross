using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;
using netwix.Services;

namespace netwix.ViewModel.Base
{
   public abstract class ViewModelBase : BindableObject
    {
        protected readonly INavigationService NavigationService;

        string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(); }
        }

        public ViewModelBase(string title)
        {
            Title = title;
            NavigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
        }

        public virtual Task InitializeAsync(object navegationData)
        {
            return Task.FromResult(true);
        }
    }
}
