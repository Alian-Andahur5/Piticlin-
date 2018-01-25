using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinEjemplo.Models;
using System.Linq;

namespace XamarinEjemplo.ViewModels
{
    public class ColeccionesPageViewModel : INotifyPropertyChanged
    {
        private List<Coleccion> _listColeccion;

        public List<Coleccion> ListColeccion
        {
            get { return _listColeccion; }
            set { _listColeccion = value; }
        }

        private List<SeparatedItems> _listSeparatedItems = new List<SeparatedItems>();
        public List<SeparatedItems> ListSeparatedItems
        {
            get { return _listSeparatedItems; }
            set { _listSeparatedItems = value; }
        }
        
        public ColeccionesPageViewModel()
        {
            //aqui le pega a la api en vez de datos duros
            ListColeccion = new List<Coleccion>
            {
                new Coleccion{

                    Id = "",
                    Nombre = "Coleccion 1",
                    Detalle = " mi primera coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                    
                },
                new Coleccion{
                    Id = "",
                    Nombre = "Coleccion 2",
                    Detalle = " mi segunda coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                },
                new Coleccion{
                    Id = "",
                    Nombre = "Coleccion 3",
                    Detalle = " mi tercera coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                },
                new Coleccion{
                    Id = "",
                    Nombre = "Coleccion 4",
                    Detalle = " mi cuarta coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                },
                new Coleccion{
                    Id = "",
                    Nombre = "Coleccion 5",
                    Detalle = " mi quinta coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                },
                new Coleccion{
                 Id = "",
                    Nombre = "Coleccion 6",
                    Detalle = " mi sexta coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                },
                new Coleccion{
                    Id = "",
                    Nombre = "Coleccion 7",
                    Detalle = " mi septima coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                },
                new Coleccion{
                    Id = "",
                    Nombre = "Coleccion 8",
                    Detalle = " mi octava coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                },
                new Coleccion{
                 Id = "",
                    Nombre = "Coleccion 9",
                    Detalle = " mi novena coleccion ",
                    Foto = "coin.jpg",
                    Tipo = "",
                    FechaCreacion = "12/02/2017"
                }
            };

            var cantPares = ListColeccion.Count / 2;
            var sobrante = ListColeccion.Count % 2;
            var count = 0;
                for (int i = 0; i < cantPares; i++)
                {
                    var fila = ListColeccion.GetRange(count, 2);
                    ListSeparatedItems.Add(
                        new SeparatedItems
                        {
                            ItemA = fila[0],
                            ItemB = fila[1]
                        }
                        );
                count += 2;
                }
            if (sobrante != 0) {
                ListSeparatedItems.Add(
                        new SeparatedItems
                        {
                            ItemA = ListColeccion.Last(),
                            ItemB = null
                        }
                        );
            }
        }

        public class SeparatedItems{
            
           public Coleccion ItemA { get; set; }
           public Coleccion ItemB { get; set; }
            
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyProperty([CallerMemberName] string propertyName = null)
        {

            var changed = PropertyChanged;
            if (changed == null)
                return;

            changed.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
