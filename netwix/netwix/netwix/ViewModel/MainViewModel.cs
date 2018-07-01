using netwix.Models;
using netwix.Services;
using netwix.ViewModel.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Linq;

namespace netwix.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        readonly ISerieService _serieService;

        public ICommand ItemClickCommand { get; }

        public ObservableCollection<Serie> Items { get; }

        public MainViewModel(ISerieService serieService) : base("NetWix")
        {
            _serieService = serieService;
            Items = new ObservableCollection<Serie>();
            ItemClickCommand = new Command<Serie>(async (item)
                => await ItemClickCommandExecute(item));
        }


        async Task ItemClickCommandExecute(Serie serie)
        {
            if (serie != null)
                await NavigationService.NavigateToAsync<DetailViewModel>(serie);
        }


        public override async Task InitializeAsync(object navgationData)
        {
            await base.InitializeAsync(navgationData);

            await LoadDataAsync();
        }

        async Task LoadDataAsync()
        {
            var result = await _serieService.GetSeriesAsync();
            AddItens(result);
        }

        private void AddItens(SerieResponse result)
        {
            Items.Clear();
            result?.Series.ToList()?.ForEach(i => Items.Add(i));
        }



    }
}
