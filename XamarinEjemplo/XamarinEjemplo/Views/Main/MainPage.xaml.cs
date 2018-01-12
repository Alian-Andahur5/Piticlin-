using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                item.TargetType = typeof(CrearColeccionPage);
            }
           
            else if (item.Id == 1)
            {
                item.TargetType = typeof(HistorialPage);
            }
            else if (item.Id == 2)
            {
                item.TargetType = typeof(LoginPage);
            }
            else if (item.Id == 3)
            {
                item.TargetType = typeof(CrearMonedaPage);   
            }



            var page = (Page)Activator.CreateInstance(item.TargetType);
            page.Title = item.Title;

            Detail = new NavigationPage(page);
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}