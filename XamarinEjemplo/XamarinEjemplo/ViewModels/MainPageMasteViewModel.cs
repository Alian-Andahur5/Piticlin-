﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinEjemplo.Models;

namespace XamarinEjemplo.ViewModels
{
    public class MainPageMasterViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }

        public MainPageMasterViewModel()
        {
            MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
            {
               
                    new MainPageMenuItem { Id = 0, Title = "Home" },
                    new MainPageMenuItem { Id = 1, Title = "Crear Coleccion" },
                    new MainPageMenuItem { Id = 2, Title = "Coleccion Creada"},
                    new MainPageMenuItem { Id = 3, Title = "Crear Moneda" },
                    new MainPageMenuItem { Id = 4, Title = "Crear Subasta" },
                    new MainPageMenuItem { Id = 5, Title = "Subasta Creada" },
                    new MainPageMenuItem { Id = 6, Title = "Crear Venta" },
                    new MainPageMenuItem { Id = 7, Title = "Perfil" }



                });
        }

        #region INotifyPropertyChanged Implementation
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }

}
