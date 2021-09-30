using System.ComponentModel;

namespace Agenda.ClientUI.Models
{
    public class UsuarioModel : INotifyPropertyChanged
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

        private string _nome;
        private string _email;
        private int _celular;
        private int _ramal;
        private string _departamento;

        public string Nome
        {
            get { return _nome; }
            set { 
                _nome = value;
                OnPropertyChanged("Nome");
            }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value;
                OnPropertyChanged("Email");
            }
        }

        public int Celular
        {
            get { return _celular; }
            set { _celular = value;
                OnPropertyChanged("Celular");
            }
        }

        public int Ramal
        {
            get { return _ramal; }
            set { _ramal = value;
                OnPropertyChanged("Ramal");
            }
        }

        public string Departamento
        {
            get { return _departamento; }
            set { _departamento = value;
                OnPropertyChanged("Departamento");
            }
        }

        private string _cargo;

        public string Cargo
        {
            get { return _cargo; }
            set { _cargo = value;
                OnPropertyChanged("Cargo");
            }
        }

        private string _recado;

        public string Recado
        {
            get { return _recado; }
            set { _recado = value;
                OnPropertyChanged("Recado");
            }
        }

    }
}
