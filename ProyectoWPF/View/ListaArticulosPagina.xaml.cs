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
    /// Lógica de interacción para ListaArticulosPagina.xaml
    /// </summary>
    public partial class ListaArticulosPagina : Page
    {

        public ListaArticulosPagina()
        {
            InitializeComponent();
        }

        public ListaArticulosPagina(Article article)
        {
            ArticleViewModel articleViewModel = new ArticleViewModel();
            
        }

        private void Inicio(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();           
            this.NavigationService.Navigate(inicio);
        }

        private void Añadir(object sender, RoutedEventArgs e)
        {
            AñadirArticuloPagina añadirArticuloPagina = new AñadirArticuloPagina();      
            this.NavigationService.Navigate(añadirArticuloPagina);
        }

        private void Ver(object sender, RoutedEventArgs e)
        {
            ArticuloInformacionPagina articuloInformacionPagina = new ArticuloInformacionPagina(this.ArticleGrid.SelectedItem);
            this.NavigationService.Navigate(articuloInformacionPagina);
        }
        private void Editar(object sender, RoutedEventArgs e)
        {
            ArticuloInformacionEditPagina articuloInformacionPaginaEditPagina = new ArticuloInformacionEditPagina(this.ArticleGrid.SelectedItem);
            this.NavigationService.Navigate(articuloInformacionPaginaEditPagina);
        }

        private void Borrar(object sender, RoutedEventArgs e)
        {

            if (ArticleGrid.SelectedItem != null)
            {
                this.DataContext = ArticleGrid.SelectedItem;

                Article article = new Article();

                ArticleViewModel articleViewModel = new ArticleViewModel();

                articleViewModel.Articles.Remove(article);
            }
            else
            {
                MessageBox.Show("Elige el articulo a borrar");
            }
        }
    }
}
