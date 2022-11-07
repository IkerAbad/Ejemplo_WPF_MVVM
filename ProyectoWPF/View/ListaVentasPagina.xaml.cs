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
using ProyectoWPF.ViewModel;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ProyectoWPF.Model;

namespace ProyectoWPF.View
{
    /// <summary>
    /// Lógica de interacción para ListaVentasPagina.xaml
    /// </summary>
    public partial class ListaVentasPagina : Page
    {
        public ListaVentasPagina()
        {
            InitializeComponent();
        }
        private void Inicio(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            this.NavigationService.Navigate(inicio);
        }

        private void Añadir(object sender, RoutedEventArgs e)
        {
            AñadirVentaPagina añadirVentaPagina = new AñadirVentaPagina();
            this.NavigationService.Navigate(añadirVentaPagina);
        }

        private void Ver(object sender, RoutedEventArgs e)
        {
            VentasInformacionPagina ventasInformacionPagina = new VentasInformacionPagina(this.VentasGrid.SelectedItem);
            this.NavigationService.Navigate(ventasInformacionPagina);
        }

        private void Editar(object sender, RoutedEventArgs e)
        {
            VentasInformacionEditPagina ventasInformacionEditPagina = new VentasInformacionEditPagina(this.VentasGrid.SelectedItem);
            this.NavigationService.Navigate(ventasInformacionEditPagina);
        }

        private void Eliminar(object sender, RoutedEventArgs e)
        {
            if (VentasGrid.SelectedItem != null)
            {
                this.DataContext = VentasGrid.SelectedItem;


                Ventas ventas = new Ventas();


                VentasViewModel ventasViewModel = new VentasViewModel();

                ventasViewModel.Ventas.Remove(ventas);
            }
            else
            {
                MessageBox.Show("Elige la venta a borrar");
            }
        }
    }
}
