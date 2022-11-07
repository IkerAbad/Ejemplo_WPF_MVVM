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
    class DependienteViewModel
    {
        private IList<Dependiente> _DependientesList;

        public DependienteViewModel()
        {
            _DependientesList = new List<Dependiente>
            {
                new Dependiente{NSS = "11111111111", Nombre = "Alvaro", Apellido = "Rodriguez", Comision = 21},
                new Dependiente{NSS = "22222222222", Nombre = "Mark", Apellido = "Perez", Comision = 21},
                new Dependiente{NSS = "33333333333", Nombre = "Mahesh", Apellido = "Soba", Comision = 21},
                new Dependiente{NSS = "44444444444", Nombre = "Vikash", Apellido = "Martinez", Comision = 21},
                new Dependiente{NSS = "55555555555", Nombre = "Harsh", Apellido = "Sampedro", Comision = 21},
                new Dependiente{NSS = "66666666666", Nombre = "Reetesh", Apellido = "Ortega", Comision = 21},
                new Dependiente{NSS = "77777777777", Nombre = "Deven", Apellido = "Consul", Comision = 21},
                new Dependiente{NSS = "88888888888", Nombre = "Ravi", Apellido = "Sanchez", Comision = 21}
            };
        }

        public IList<Dependiente> Dependientes
        {
            get => _DependientesList;
            set => _DependientesList = value;
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
            set
            {
                mUpdater = value;
            }
        }

        private class Updater : ICommand
        {
            #region ICommand Members  

            public bool CanExecute(object parameter)
            {
                return true;
            }

            public event EventHandler CanExecuteChanged;

            public void Execute(object parameter)
            {

            }

            #endregion
        }
    }
}
