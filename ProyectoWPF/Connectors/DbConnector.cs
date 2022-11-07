using ProyectoWPF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoWPF.Connectors
{
    public class DbConnector
    {
        public ArticleCollection listarArticulos()
        {
            ArticleCollection lista = new ArticleCollection();
            lista.Add(new Article(1, "Patata", 20, 40, 60));
            lista.Add(new Article(2, "Libro", 20, 40, 60));
            lista.Add(new Article(3, "Botella", 20, 40, 60));
            lista.Add(new Article(4, "Portatil", 20, 40, 60));
            lista.Add(new Article(5, "Raton", 20, 40, 60));
            return lista;
        }
    }
}
