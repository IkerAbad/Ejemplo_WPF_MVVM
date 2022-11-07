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
    /// Lógica de interacción para AñadirDependientePagina.xaml
    /// </summary>
    public partial class AñadirDependientePagina : Page
    {
        public AñadirDependientePagina()
        {
            InitializeComponent();
        }
        private void Dependientes(object sender, RoutedEventArgs e)
        {
            ListaDependientesPagina listaDependientesPagina = new ListaDependientesPagina();
            this.NavigationService.Navigate(listaDependientesPagina);
        }

        private void Añadir(object sender, RoutedEventArgs e)
        {
            Dependiente dependiente = new Dependiente { NSS = this.nss.Text, Nombre = this.nombre.Text, Apellido = this.apellido.Text, Comision = int.Parse(this.comision.Text) };

            DependienteViewModel dependienteViewModel = new DependienteViewModel();
            dependienteViewModel.Dependientes.Add(dependiente);

            ListaDependientesPagina listaDependientesPagina = new ListaDependientesPagina();
            this.NavigationService.Navigate(listaDependientesPagina);
        }
    }
}
