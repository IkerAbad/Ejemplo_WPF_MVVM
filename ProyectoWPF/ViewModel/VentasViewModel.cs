using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.ComponentModel;
using ProyectoWPF.Model;
using System.Windows;

namespace ProyectoWPF.ViewModel
{
    class VentasViewModel
    {
        private IList<Ventas> _VentasList;

        public VentasViewModel()
        {
            _VentasList = new List<Ventas>
            {
               
                new Ventas{Codigo=1, Fecha= new DateTime(), Importe=10, FormaPago="Contado",NTarjeta=""},
                new Ventas{Codigo=2, Fecha= new DateTime(), Importe=20, FormaPago="Tarjeta",NTarjeta="1563952182682685"},
                new Ventas{Codigo=3, Fecha= new DateTime(), Importe=15, FormaPago="Contado",NTarjeta=""},
                new Ventas{Codigo=4, Fecha= new DateTime(), Importe=13, FormaPago="Contado",NTarjeta=""},
                new Ventas{Codigo=5, Fecha= new DateTime(), Importe=11, FormaPago="Contado",NTarjeta=""},
                new Ventas{Codigo=6, Fecha= new DateTime(), Importe=20, FormaPago="Tarjeta",NTarjeta="9635821147256985"},
                new Ventas{Codigo=7, Fecha= new DateTime(), Importe=10, FormaPago="Contado",NTarjeta=""},
                new Ventas{Codigo=8, Fecha= new DateTime(), Importe=13, FormaPago="Tarjeta",NTarjeta="3689282196852654"}
                
            };
        }

        public IList<Ventas> Ventas
        {
            get => _VentasList;
            set => _VentasList = value;
        }

        private ICommand mUpdater;
        public ICommand UpdateCommand
        {
            get
            {
                if (mUpdater == null)
                    mUpdater = new Updater();
                return mUpdater;
            }
            set => mUpdater = value;
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter) => true;

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
