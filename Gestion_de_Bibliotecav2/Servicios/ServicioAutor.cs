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
    internal class ServicioAutor
    {
        private RepositorioAutor repositorioAutor;

        public Autor Get(int id)
        {
            return repositorioAutor.Get(id);
        }

        public List<Autor> GetAll()
        {
            return (List<Autor>)repositorioAutor.GetAll();
        }

        public void Agregar(Autor autor)
        {
            if (autor.ID != null && !repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Agregar(autor);
            }

            throw new SystemException();
        }

        public void Actualizar(Autor autor)
        {
            if (autor.ID != null && repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Actualizar(autor.ID, autor);
            }

            throw new SystemException();
        }

        public void Eliminar(Autor autor)
        {
            if (autor.ID != null && repositorioAutor.Existe(autor.ID))
            {
                repositorioAutor.Eliminar(autor.ID, autor);
            }

            throw new SystemException();
        }

        public Autor BuscarAutor(string nombre)
        {
            return repositorioAutor.BuscarPorNombre(nombre);
        }
    }
}
