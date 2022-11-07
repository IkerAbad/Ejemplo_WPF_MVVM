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
    class ArticleViewModel
    {
        public IList<Article> _ArticleList;

        public ArticleViewModel()
        {
            _ArticleList = new List<Article>
            {
                new Article{CodigoArticulo = 1, Nombre="Raj", Descripcion = "Beniwal", PCoste = 20, IVA = 10},
                new Article{CodigoArticulo = 2, Nombre="Mark", Descripcion = "henry", PCoste = 20, IVA = 21},
                new Article{CodigoArticulo = 3, Nombre="Mahesh", Descripcion = "Chand", PCoste = 20, IVA = 10},
                new Article{CodigoArticulo = 4, Nombre="Vikash", Descripcion = "Nanda", PCoste = 20, IVA = 4},
                new Article{CodigoArticulo = 5, Nombre="Harsh", Descripcion = "Kumar", PCoste = 20, IVA = 10},
                new Article{CodigoArticulo = 6, Nombre="Reetesh", Descripcion = "Tomar", PCoste = 20, IVA = 21},
                new Article{CodigoArticulo = 7, Nombre="Deven", Descripcion = "Verma", PCoste = 20, IVA = 4},
                new Article{CodigoArticulo = 8, Nombre="Ravi", Descripcion = "Taneja", PCoste = 20, IVA = 10}
            };
        }

        public IList<Article> Articles
        {
            get { return _ArticleList; }
            set { _ArticleList = value; }
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
