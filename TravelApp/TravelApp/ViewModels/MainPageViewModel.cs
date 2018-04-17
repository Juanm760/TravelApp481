using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace TravelApp.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        INavigationService _navigationService;

        public DelegateCommand NavToPageOneCommand { get; set; }

        public string _title;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
        public MainPageViewModel(INavigationService navigationService)
        {
            Debug.WriteLine($"**** {this.GetType().Name}: ctor");
        }
    }
}