using KIAMS.Services;
using KIAMS.Views;
using KIAMS.Views.Accounts;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KIAMS
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new DashView());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
