using System.ComponentModel;

namespace Agrinova.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private float _temperature;
        private float _humidade;
        public float Temperatura
        {
            get => _temperature;
            set 
            {
                _temperature = value;
                RaisePropertyChanged(nameof(Temperatura));
            }
        }
        public float Humidade
        {
            get => _humidade;
            set
            {
                _humidade = value;
                RaisePropertyChanged(nameof(Temperatura));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
