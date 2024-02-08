using Gestion_de_Bibliotecav2.DAL;
using Gestion_de_Bibliotecav2.DAL.EntityFramework;
using Gestion_de_Bibliotecav2.Dominio;
using Org.BouncyCastle.Asn1.BC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Servicios
{
    public class ServicioEjemplar
    {
        private RepositorioEjemplares repositorioEjemplar;

        public Ejemplar Get(int id)
        {
            return repositorioEjemplar.Get(id);
        }

        public List<Ejemplar> GetAll()
        {
            return (List<Ejemplar>)repositorioEjemplar.GetAll();
        }

        public void Agregar(Ejemplar ejemplar)
        {
            if (ejemplar.ID != null && !repositorioEjemplar.Existe(ejemplar.ID))
            {
                repositorioEjemplar.Agregar(ejemplar);
            }

            throw new SystemException();
        }

        public void Actualizar(Ejemplar ejemplar)
        {
            if (ejemplar.ID != null && repositorioEjemplar.Existe(ejemplar.ID))
            {
                repositorioEjemplar.Actualizar(ejemplar.ID, ejemplar);
            }

            throw new SystemException();
        }

        public void Eliminar(Ejemplar ejemplar)
        {
            if (ejemplar.ID != null && repositorioEjemplar.Existe(ejemplar.ID))
            {
                repositorioEjemplar.Eliminar(ejemplar.ID, ejemplar);
            }

            throw new SystemException();
        }

        public List<Ejemplar> buscarPorISBN(string isbn)
        {
            return repositorioEjemplar.buscarPorISBN(isbn);
        }

        public List<string> BuscarAutor(string nombre)
        {
            return repositorioEjemplar.BuscarAutor(nombre);
        }

        public List<string> BuscarCategorias(string nombre)
        {
            return repositorioEjemplar.BuscarCategorias(nombre);
        }

        public List<string> BuscarEditoriales(string nombre)
        {
            return repositorioEjemplar.BuscarEditoriales(nombre);
        }
    }
}
