using System.ComponentModel;

namespace Agenda.ClientUI.Models
{
    public class DepartamentoModel : INotifyPropertyChanged
    {
        //Método da interface INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;

        // Esta rotina é chamada cada vez que o valor da propridade 
        // for definida. Isso vai disparar um evento para notificar 
        // a WPF via data binding que algo mudou
        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private string _nomeDepartamento;

        public string NomeDepartamento
        {
            get { return _nomeDepartamento; }
            set { _nomeDepartamento = value;
                OnPropertyChanged("NomeDepartamento");
            }
        }


    }
}
