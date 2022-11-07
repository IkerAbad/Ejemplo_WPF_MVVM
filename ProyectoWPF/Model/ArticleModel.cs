using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ProyectoWPF.Model
{
    public class Article
    {
        private int codigoArticulo;
        private string nombre;
        private string descripcion;
        private int pCoste;
        private int iva;
        private double pVenta;

        public int CodigoArticulo
        {
            get => codigoArticulo;
            set
            {
                codigoArticulo = value;
                OnPropertyChanged("CodigoArticulo");
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

        public string Descripcion
        {
            get => descripcion;
            set
            {
                descripcion = value;
                OnPropertyChanged("Descripcion");
            }
            
        }

        public int PCoste
        {
            get => pCoste;
            set
            {
                pCoste = value;
                OnPropertyChanged("PCoste");
            }
        }

        public int IVA
        {
            get => iva;
            set
            {
                iva = value;
                OnPropertyChanged("IVA");
            }
        }

        public double PVenta
        {
            get
            {
                int total1 = (pCoste * 20) / 100;
                int total2 = (iva / 100) * pCoste;
                int total = pCoste + total1 + total2;
                pVenta = total;
                return pVenta;
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
