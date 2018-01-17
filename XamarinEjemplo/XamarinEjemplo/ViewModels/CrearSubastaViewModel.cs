using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace XamarinEjemplo.ViewModels
{
    public class CrearSubastaViewModel : INotifyPropertyChanged
    {

        DateTime startTime = DateTime.Now;
        public DateTime StartTime
        {
            get { return startTime; }
            set
            {
                startTime = value;
                NotifyProperty();
            }
        }

        DateTime endTime = DateTime.Now;
        public DateTime EndTime
        {
            get { return endTime; }
            set {
                endTime = value;
                NotifyProperty();
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
