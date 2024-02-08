using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public class RepositorioEjemplares : Repository<Dominio.Ejemplar, AdministradorPrestamosDBContext>, IRepositorioEjemplares
    {
        public RepositorioEjemplares(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        public List<Ejemplar> buscarPorISBN(string isbn)
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>) GetAll();
            List<Ejemplar> ejemplaresEncontrados = new List<Ejemplar>();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                if (ejemplar.Libro.ISBN == isbn)
                {
                    ejemplaresEncontrados.Add(ejemplar);
                }
            }

            return ejemplaresEncontrados;
        }

        //Búsqueda de autor por nombre (alguna parte del nombre?) y devuelve una lista para cargar en una tabla todos los resultados que coincidieron

        private List<Autor> ObtenerAutores()
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>)GetAll();
            List<Autor> autores = new List<Autor>();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                autores.AddRange(ejemplar.Libro.Autores);
            }
            return autores.Distinct().ToList();
        }

        public List<string> BuscarAutor(string nombre)
        {
            List<Autor> autores = ObtenerAutores();
            List<string> buscados = new List<string>();

            foreach (Autor autor in autores)
            {
                if (autor.Nombre.Contains(nombre))
                {
                    buscados.Add(autor.Nombre);
                }
            }
            return buscados;
        }

        // Búsqueda de categoría por nombre y devuelve una lista para cargar las coincidencias en una tabla.

        private List<Categoria> ObtenerCategorias()
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>)GetAll();
            List<Categoria> categorias = new List<Categoria>();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                categorias.AddRange(ejemplar.Libro.Categorias);
            }
            return categorias.Distinct().ToList();
        }

        public List<string> BuscarCategorias(string nombre)  
        {
            List<Categoria> cateogrias = ObtenerCategorias();
            List<string> buscados = new List<string>();

            foreach (Categoria categoria in cateogrias)
            {
                if (categoria.Nombre.Contains(nombre))
                {
                    buscados.Add(categoria.Nombre);
                }
            }
            return buscados;
        }


        // Búsqueda de editorial por nombre y devuelve una lista para cargar las coincidencias en una tabla.

        private List<Editorial> ObtenerEditoriales()
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>)GetAll();
            List<Editorial> editoriales = new List<Editorial>();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                editoriales.Add(ejemplar.Libro.Editorial);
            }
            return editoriales.Distinct().ToList();
        }

        public List<string> BuscarEditoriales(string nombre)
        {
            List<Editorial> editoriales = ObtenerEditoriales();
            List<string> buscados = new List<string>();

            foreach (Editorial editorial in editoriales)
            {
                if (editorial.Nombre.Contains(nombre))
                {
                    buscados.Add(editorial.Nombre);
                }
            }
            return buscados;
        }


        public Ejemplar BuscarejemplarAPI(string isbn)
        {
            return null;
        }

    }
}
