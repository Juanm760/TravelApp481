using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using TravelingApp481.ViewModels;
using TravelingApp481.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace TravelingApp481
{
    public partial class App : PrismApplication
    {
        //public App ()
        //{
        //	InitializeComponent();

        //	MainPage = new TravelingApp481.MainPage();
        //}
        public App() : this(null) { }

       // public App(IPlatformInitializer initializer = null) : base(initializer) { }
        public App(IPlatformInitializer initializer) : base(initializer) { }


        protected override async void OnInitialized()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnInitialized)}");
            InitializeComponent();

            await NavigationService.NavigateAsync($"{nameof(NavigationPage)}/{nameof(MainPage)}");
        }
        protected override void RegisterTypes(Prism.Ioc.IContainerRegistry containerRegistry)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(RegisterTypes)}");

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, TravelingApp481PageViewModel>();
            containerRegistry.RegisterForNavigation<TabPageA, TabPageAViewModel>();
            containerRegistry.RegisterForNavigation<TabPageB, TabPageBViewModel>();
            containerRegistry.RegisterForNavigation<TabPageC, TabPageCViewModel>();
            containerRegistry.RegisterForNavigation<TabContainer, TabContainerViewModel>();

        }


        protected override void OnStart()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnStart)}");
            base.OnStart();
        }


        protected override void OnSleep()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnSleep)}");
            base.OnSleep();
        }

        protected override void OnResume()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnResume)}");
             base.OnResume();		
        }
    }
}
