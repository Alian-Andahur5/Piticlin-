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
        private List<Item> _listMonedas;

        public List<Item> ListMonedas
        {
            get { return _listMonedas; }
            set { _listMonedas = value; }
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
            ListMonedas = new List<Item>
            {
                new Item{
                    Nombre = "Moneda 1",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                },
                new Item{
                    Nombre = "Moneda 2",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                },
                new Item{
                    Nombre = "Moneda 3",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                },
                new Item{
                    Nombre = "Moneda 4",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                },
                new Item{
                    Nombre = "Moneda 5",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                },
                new Item{
                    Nombre = "Moneda 6",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                },
                new Item{
                    Nombre = "Moneda 7",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                },
                new Item{
                    Nombre = "Moneda 8",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                },
                new Item{
                    Nombre = "Moneda 9",
                    Anio = "1990",
                     Ceca= "",
                     Nacionalidad = "Chile",
                     Material = "Cobre",
                     Origen = "",
                     TipoColeccionesta = "",
                     TipoMaterial = "",
                     CoinImage = "coin.jpg"
                }
            };

            var cantPares = ListMonedas.Count / 2;
            var sobrante = ListMonedas.Count % 2;
            var count = 0;
                for (int i = 0; i < cantPares; i++)
                {
                    var fila = ListMonedas.GetRange(count, 2);
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
                            ItemA = ListMonedas.Last(),
                            ItemB = null
                        }
                        );
            }
        }

        public class SeparatedItems{
            
           public Item ItemA { get; set; }
           public Item ItemB { get; set; }
            
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
