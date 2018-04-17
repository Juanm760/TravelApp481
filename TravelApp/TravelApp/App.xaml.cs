using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using TravelApp.Views;
using Xamarin.Forms;

namespace TravelApp
{
	public partial class App : PrismApplication
	{
        //public App ()
        //{
        //InitializeComponent();

        //MainPage = new TravelApp.MainPage();
        //}

        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();
            await NavigationService.NavigateAsync("MainPage");
        }

        protected override void RegisterTypes(Prism.Ioc.IContainerRegistry containerRegistry)
        {
            //containerRegistry.RegisterForNavigation<NavigationPage>();
            //   containerRegistry.RegisterForNavigation<MainPage, TravelAppPageViewModel>();
            containerRegistry.RegisterForNavigation<MainPage>();
        }

        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
