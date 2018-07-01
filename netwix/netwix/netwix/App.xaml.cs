using netwix.Services;
using netwix.ViewModel.Base;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace netwix
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            BuildDependencies();

            InitNavigation();
        }

        async void InitNavigation()
        {
            var navigationService = ViewModelLocator.Instance.Resolve<INavigationService>();
            await navigationService.Initialize();
        }

        void BuildDependencies()
        {
            ViewModelLocator.Instance.Build();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
