using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using XamarinEjemplo.Models;
using System.Linq;
using XamarinEjemplo.Providers;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinEjemplo.Views;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XamarinEjemplo.ViewModels
{
    public class LoginPageViewModel : INotifyPropertyChanged
    {

        public ICommand LoginButton { get; set; }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _clave;

        public string Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        public LoginPageViewModel()
        {
            LoginButton = new Command(async () => await Login());
        }

        private async Task Login()
        {
            var credenciales = new JObject{
                    new JProperty("email",Email),
                    new JProperty("clave",Clave)
                };
            // no se guardo el ultimo cambio sigue llegando usuarios , debe legar usuario de nuev
            var response = await ServicesHttp.ConsumeAPI("usuario/authenticate", credenciales);
            var correct = (int)response.StatusCode;
            if (correct == 200)
            {
                Authenticate authenticate = JsonConvert.DeserializeObject<Authenticate>(await response.Content.ReadAsStringAsync());
                    //await (App.Current.MainPage as NavigationPage).PushAsync(new MainPage());
                   await ((NavigationPage)App.Current.MainPage).PushAsync(new MainPage());
                }
                else {
                await ((NavigationPage)App.Current.MainPage).DisplayAlert("Mensaje", "Credenciales incorrectas", "Reintentar");
                }
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
