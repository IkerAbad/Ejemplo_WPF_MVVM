using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWPF.Model
{
    public class Ventas
    {
        private int codigo;
        private DateTime fecha;
        private int importe;
        private string formaPago;
        private string nTarjeta;

        public int Codigo
        {
            get => codigo;
            set
            {
                codigo = value;
                OnPropertyChanged("Codigo");
            }
        }

        public DateTime Fecha
        {
            get => fecha;
            set
            {
                fecha = value;
                OnPropertyChanged("Fecha");
            }
        }

        public int Importe
        {
            get => importe;
            set
            {
                importe = value;
                OnPropertyChanged("Importe");
            }
        }

        public string FormaPago
        {
            get => formaPago;
            set
            {
                formaPago = value;
                OnPropertyChanged("FormaPago");
            }
        }

        public string NTarjeta
        {
            get => nTarjeta;
            set
            {
                nTarjeta = value;
                OnPropertyChanged("NTarjeta");
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
