﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEjemplo.ViewModels;

namespace XamarinEjemplo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ColeccionesPage : ContentPage
	{
		public ColeccionesPage ()
		{
			InitializeComponent ();
            BindingContext = new ColeccionesPageViewModel();

        }
	}
}