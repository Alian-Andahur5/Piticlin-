using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinEjemplo.Models;

namespace XamarinEjemplo.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private List<Persona> _personas;
        public List<Persona> Personas
        {
            get { return _personas; }
            set {
                _personas = value;
                OnPropertyChanged();
            }
        }

        public MainPageViewModel()
        {
            Personas = new List<Persona> {
                new Persona{
                    Nombre = "Juan",
                    Apellido = "Rivera",
                    Foto = "profile.png"
                },
                new Persona{
                    Nombre = "Ivan",
                    Apellido = "Peters",
                    Foto = "profile.png"
                },
                 new Persona{
                    Nombre = "Ivan",
                    Apellido = "Peters",
                    Foto = "profile.png"
                },
                  new Persona{
                    Nombre = "Ivan",
                    Apellido = "Peters",
                    Foto = "profile.png"
                },
                   new Persona{
                    Nombre = "Ivan",
                    Apellido = "Peters",
                    Foto = "profile.png"
                },
                    new Persona{
                    Nombre = "Ivan",
                    Apellido = "Peters",
                    Foto = "profile.png"
                }
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null) {
            if (PropertyChanged == null)
                return;
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
