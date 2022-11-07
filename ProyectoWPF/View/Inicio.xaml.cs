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
    /// Lógica de interacción para Inicio.xaml
    /// </summary>
    public partial class Inicio : Page
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Dependientes(object sender, RoutedEventArgs e)
        {
            ListaDependientesPagina listaDependientesPagina = new ListaDependientesPagina();
            this.NavigationService.Navigate(listaDependientesPagina);

        }

        private void Articulos(object sender, RoutedEventArgs e)
        {
            ListaArticulosPagina listaArticulosPagina = new ListaArticulosPagina();
            this.NavigationService.Navigate(listaArticulosPagina);
        }

        private void Ventas(object sender, RoutedEventArgs e)
        {
            ListaVentasPagina listaVentasPagina = new ListaVentasPagina();
            this.NavigationService.Navigate(listaVentasPagina);
        }
    }
}
