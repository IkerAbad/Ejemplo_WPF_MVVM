using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWPF.Model
{

    public class Dependiente
    {
        private string nss;
        private string nombre;
        private string apellido;
        private int comision;

        public string NSS
        {
            get => nss;
            set
            {
                nss = value;
                OnPropertyChanged("NSS");
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
                OnPropertyChanged("Nombre");
            }
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                apellido = value;
                OnPropertyChanged("Apellido");
            }
        }

        public int Comision
        {
            get => comision;
            set
            {
                comision = value;
                OnPropertyChanged("Comision");
            }
        }
        #region INotifyPropertyChanged Members  

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

    }
}
