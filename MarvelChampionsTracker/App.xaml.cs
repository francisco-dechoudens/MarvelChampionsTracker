using System;
using MarvelChampionsTracker.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarvelChampionsTracker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new TrackerPage();
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
