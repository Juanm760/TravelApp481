using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;
using TravelingApp481.Views;

namespace TravelingApp481.ViewModels
{
    public class TravelingApp481PageViewModel : BindableBase ,INavigationAware
	{
        INavigationService _navigationService;

        public DelegateCommand NavigateToTabContainerCommand { get; set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public TravelingApp481PageViewModel (INavigationService navigationService)
		{
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(TravelingApp481PageViewModel)}:  ctor");

            Title = "Main Page";
            _navigationService = navigationService;
            NavigateToTabContainerCommand = new DelegateCommand(OnNavigateToTabContainer);

        }

        private void OnNavigateToTabContainer()
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigateToTabContainer)}");

            //TabContainer in views not viewModels 
            _navigationService.NavigateAsync(nameof(TabContainer));

        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedFrom)}");
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatedTo)}");
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            Debug.WriteLine($"**** {this.GetType().Name}.{nameof(OnNavigatingTo)}");
        
        }
	}
}