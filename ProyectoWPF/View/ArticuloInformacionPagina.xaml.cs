using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoWPF.View
{
    /// <summary>
    /// Lógica de interacción para ArticuloInformacionPagina.xaml
    /// </summary>
    public partial class ArticuloInformacionPagina : Page
    {
        public ArticuloInformacionPagina()
        {
            InitializeComponent();
        }

        private void Articulos(object sender, RoutedEventArgs e)
        {
            ListaArticulosPagina listaArticulosPagina = new ListaArticulosPagina();
            this.NavigationService.Navigate(listaArticulosPagina);
        }

        public ArticuloInformacionPagina(object data) : this()
        {
            this.DataContext = data;
        }
    }
}
