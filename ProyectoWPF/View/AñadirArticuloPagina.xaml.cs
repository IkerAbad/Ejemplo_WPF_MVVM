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
    /// Lógica de interacción para AñadirArticuloPagina.xaml
    /// </summary>
    public partial class AñadirArticuloPagina : Page
    {
        public AñadirArticuloPagina()
        {
            InitializeComponent();
        }
        private void Articulos(object sender, RoutedEventArgs e)
        {
            ListaArticulosPagina listaArticulosPagina = new ListaArticulosPagina();
            this.NavigationService.Navigate(listaArticulosPagina);
        }

        private void Añadir(object sender, RoutedEventArgs e)
        {
            int codigoArt = int.Parse(this.codigo.Text);
            int pcoste = int.Parse(this.pcoste.Text);
            int iva = int.Parse(this.iva.Text);

            Article article = new Article { CodigoArticulo = codigoArt, Nombre = this.nombre.Text, Descripcion = this.descripcion.Text, PCoste = pcoste, IVA = iva };

            ArticleViewModel articleViewModel = new ArticleViewModel();
            articleViewModel.Articles.Add(article);

            ListaArticulosPagina listaArticulosPagina = new ListaArticulosPagina();
            this.NavigationService.Navigate(listaArticulosPagina);
        }
    }
}
