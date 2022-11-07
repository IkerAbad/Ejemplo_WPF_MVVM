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
    /// Lógica de interacción para DependientesPerfilEditPagina.xaml
    /// </summary>
    public partial class DependientesPerfilEditPagina : Page
    {

        public DependientesPerfilEditPagina()
        {
            InitializeComponent();
        }

        public DependientesPerfilEditPagina(object data) : this()
        {
            this.DataContext = data;
        }

        private void Dependientes(object sender, EventArgs e)
        {
            ListaDependientesPagina listaDependientesPagina = new ListaDependientesPagina();
            this.NavigationService.Navigate(listaDependientesPagina);
        }

        private void Editar(object sender, RoutedEventArgs e)
        {

            ListaDependientesPagina listaDependientesPagina = new ListaDependientesPagina();
            this.NavigationService.Navigate(listaDependientesPagina);
        }
    }
}
