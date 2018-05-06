using Prism.Mvvm;
using Prism.Commands;
using Prism.Navigation;
using System.Diagnostics;
using System;

namespace TravelApp
{
    public class TravelAppPageViewModel : BindableBase
    {
        INavigationService _navigationService;

        public DelegateCommand NavToPageOneCommand { get; set; }

        public string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public TravelAppPageViewModel(INavigationService navigationService)
        {
            Debug.WriteLine($"**** {this.GetType().Name}: ctor");
        }
    }
}