using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public class RepositorioCategorias : Repository<Dominio.Categoria, AdministradorPrestamosDBContext>, IRepositorioCategorias
    {
        public RepositorioCategorias(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        public List<Categoria> BuscarCategoriasPorCoincidencia(string nombre)
        {
            List<Categoria> cateogrias = (List<Categoria>) GetAll();
            List<Categoria> buscados = new List<Categoria>();

            foreach (Categoria categoria in cateogrias)
            {
                if (categoria.Nombre.Contains(nombre))
                {
                    buscados.Add(categoria);
                }
            }
            return buscados;
        }
    }
}
