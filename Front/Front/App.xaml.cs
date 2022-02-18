using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FrontEnd.Pages;

namespace Front
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MyPlansPage());
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
