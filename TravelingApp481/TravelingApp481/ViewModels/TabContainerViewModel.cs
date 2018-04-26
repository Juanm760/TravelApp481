using System;

using Xamarin.Forms;

namespace TravelingApp481.ViewModels
{
    public class TabContainerViewModel : ContentPage
    {
        public TabContainerViewModel()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

