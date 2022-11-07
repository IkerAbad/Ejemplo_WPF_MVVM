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
    /// Lógica de interacción para VentasInformacionEditPagina.xaml
    /// </summary>
    public partial class VentasInformacionEditPagina : Page
    {

        public VentasInformacionEditPagina()
        {
            InitializeComponent();
        }

        public VentasInformacionEditPagina(object data) : this()
        {
            this.DataContext = data;
        }

        private void Ventas(object sender, EventArgs e)
        {
            ListaVentasPagina listaVentasPagina = new ListaVentasPagina();
            this.NavigationService.Navigate(listaVentasPagina);
        }
    }
}
