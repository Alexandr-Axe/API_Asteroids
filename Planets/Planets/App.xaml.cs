using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Planets.View;

namespace Planets
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SpaceObjectsPage());
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
