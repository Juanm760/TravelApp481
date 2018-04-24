using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Prism.Mvvm;
using Xamarin.Forms;

namespace TravelingApp481.ViewModels
{
	public class TravelingApp481PageViewModel : BindableBase
	{
		public TravelingApp481PageViewModel ()
		{
            Debug.WriteLine($"****{this.GetType().Name}:  ctor");
			
		}
	}
}