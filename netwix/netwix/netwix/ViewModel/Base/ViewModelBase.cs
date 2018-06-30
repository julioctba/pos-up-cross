using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace netwix.ViewModel.Base
{
   public abstract class ViewModelBase : BindableObject
    {
        string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(); }
        }

        public ViewModelBase(string title)
        {
            Title = title;
        }

        public virtual Task InitializeAsync(object navegationData)
        {
            return Task.FromResult(true);
        }
    }
}
