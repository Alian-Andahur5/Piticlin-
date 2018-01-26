using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinEjemplo.ViewModels
{
    public class SubastaCreadaViewModel: INotifyPropertyChanged
    {
        public ICommand PrevImage { get; set; }
        public ICommand NextImage  { get; set; }
        private string _srcImage;
        public string SrcImage
        {
            get { return _srcImage; }
            set { _srcImage = value; NotifyProperty(); }
        }

        private string[] ListImages = { "foto.jpg", "fondo.jpg","fondo2.jpg"};
        private int _indiceImage = 0;
        public SubastaCreadaViewModel()
        {
            PrevImage = new Command(PrevImageChange);
            NextImage = new Command(NextImageChange);
            SrcImage = ListImages[_indiceImage];
        }

        private void NextImageChange(object obj)
        {
            if (_indiceImage < ListImages.Length-1) {
                 _indiceImage += 1;
                SrcImage = ListImages[_indiceImage];
            }
        
        }

        private void PrevImageChange(object obj)
        {
            if (_indiceImage != 0)
            {
                _indiceImage -= 1;
                SrcImage = ListImages[_indiceImage];
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
