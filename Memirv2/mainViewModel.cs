using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memirv2
{
    public class mainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string ip;
        public string Ip //The Ip propery for the binding
        {
            get { return ip; }
            set
            {
                ip = value;
                OnPropertyChanged(nameof(Ip));
            }
        }

        private string port;
        public string Port //The Port propery for the binding
        {
            get { return port; }
            set
            {
                port = value;
                OnPropertyChanged(nameof(Port));
            }
        }
    }
}
