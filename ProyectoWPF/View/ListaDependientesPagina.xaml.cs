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
using ProyectoWPF.Model;
using ProyectoWPF.ViewModel;

namespace ProyectoWPF.View
{
    /// <summary>
    /// Lógica de interacción para ListaDependientesPagina.xaml
    /// </summary>
    public partial class ListaDependientesPagina : Page
    {
        public ListaDependientesPagina()
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
            AñadirDependientePagina añadirDependientePagina = new AñadirDependientePagina();
            this.NavigationService.Navigate(añadirDependientePagina);
        }

        private void Ver(object sender, RoutedEventArgs e)
        {
            DependientesPerfilPagina dependientesPerfilPagina = new DependientesPerfilPagina(this.DependientesGrid.SelectedItem);
            this.NavigationService.Navigate(dependientesPerfilPagina);
        }

        private void Editar(object sender, RoutedEventArgs e)
        {
            DependientesPerfilEditPagina dependientesPerfilEditPagina = new DependientesPerfilEditPagina(this.DependientesGrid.SelectedItem);
            this.NavigationService.Navigate(dependientesPerfilEditPagina);
        }

        private void Borrar(object sender, RoutedEventArgs e)
        {
            if (DependientesGrid.SelectedItem != null)
            {

                foreach(ListViewItem item in DependientesGrid.SelectedItems)
                {
                    DependientesGrid.Items.Remove(item);
                }

                Dependiente dependiente = new Dependiente();


                DependienteViewModel dependienteViewModel = new DependienteViewModel();

                dependienteViewModel.Dependientes.Remove(dependiente);
            }
            else
            {
                MessageBox.Show("Elige el dependiente a borrar");
            }
        }
    }
}
