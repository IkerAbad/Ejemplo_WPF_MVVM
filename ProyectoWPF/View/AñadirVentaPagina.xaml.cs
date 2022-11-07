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
using ProyectoWPF.ViewModel;
using ProyectoWPF.Model;

namespace ProyectoWPF.View
{
    /// <summary>
    /// Lógica de interacción para AñadirVentaPagina.xaml
    /// </summary>
    public partial class AñadirVentaPagina : Page
    {
        public AñadirVentaPagina()
        {
            InitializeComponent();
        }
        private void Ventas(object sender, EventArgs e)
        {
            ListaVentasPagina listaVentasPagina = new ListaVentasPagina();
            this.NavigationService.Navigate(listaVentasPagina);
        }

        private void Añadir(object sender, RoutedEventArgs e)
        {
           // Ventas ventas = new Ventas { Codigo = int.Parse(this.codigo.Text), Fecha = this.fecha., Importe = int.Parse(this.importe.Text), FormaPago = this.formapago.Text, NTarjeta = this.ntarjeta.Text };

           // VentasViewModel ventasViewModel = new VentasViewModel();
           // ventasViewModel.Ventas.Add(ventas);

           // ListaVentasPagina listaVentasPagina = new ListaVentasPagina();
           // this.NavigationService.Navigate(listaVentasPagina);
        }
    }
}
