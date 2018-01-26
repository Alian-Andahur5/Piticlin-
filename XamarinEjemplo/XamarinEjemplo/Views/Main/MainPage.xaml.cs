using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinEjemplo.Models;

namespace XamarinEjemplo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MainPageMenuItem;
            if (item == null)
                return;
            if (item.Id == 0)
            {
                item.TargetType = typeof(MainPageDetail);
            }
           
            else if (item.Id == 1)
            {
                item.TargetType = typeof(SubastaCreadaPage);
            }
            else if (item.Id == 2)
            {
                item.TargetType = typeof(MonedaPage);
            }
            else if (item.Id == 3)
            {
                item.TargetType = typeof(CrearMonedaPage);   
            }
            else if (item.Id == 4)
            {
                item.TargetType = typeof(CrearSubastaPage);
            }
            else if (item.Id == 5)
            {
                item.TargetType = typeof(CrearVentaPage);
            }
            else if (item.Id == 6)
            {
                item.TargetType = typeof(CrearColeccionPage);
            }
            else if (item.Id == 7)
            {
                item.TargetType = typeof(ColeccionPage);
            }
            else if (item.Id == 8)
            {
                item.TargetType = typeof(DatosPerfilPage);
            }


            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}