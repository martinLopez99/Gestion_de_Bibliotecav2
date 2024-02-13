﻿using Gestion_de_Bibliotecav2.Dominio;
using Gestion_de_Bibliotecav2.Servicios;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public class RepositorioLibros : Repository<Dominio.Libro, AdministradorPrestamosDBContext>, IRepositorioLibros
    {
        public RepositorioLibros(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        private RepositorioAutores repositorioAutor;
        private RepositorioCategorias repositorioCategoria;

        // METODOS TODO
        // Existencia  isbn BD 
        // Buscar Api Cargar datos si no existe en la base de datos

        public bool ExisteIsbn(string isbn)
        {
            List<Libro> libros = (List<Libro>)GetAll();
            return libros.Any(libro => libro.ISBN == isbn);
        }

        public bool ExisteNombre(string nombre)
        {
            List<Libro> libros = (List<Libro>) GetAll();
            return libros.Any(libro => libro.Nombre == nombre);
        }

        public Libro BuscarPorIsbn(string isbn) 
        {
            List<Libro> libros = (List<Libro>)GetAll();
            return libros.FirstOrDefault(libro => libro.ISBN == isbn);
        }

        public async void Cargar(string isbn)
        {
            using var httpClient = new HttpClient();
            var openLibraryApiClient = new OpenLibraryApiClient(httpClient);

            HttpResponseMessage response = await openLibraryApiClient.ObtenerLibroAsync_isbn(isbn);

            if (response != null && response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();

                RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(jsonResponse);

                if (rootObject != null)
                {
                    Docs[] docs = rootObject.docs;

                    if (docs != null)
                    {
                        foreach (var doc in docs)
                        {
                            //Metodo que crea el autor y lo guarda. Devuelve los objetos
                            List<Autor> autores = repositorioAutor.SaveAutor(doc);

                            //Metodo que crea el libro y lo guarda. Que devuelva el objeto
                            Libro libro = SaveLibro(doc,isbn);

                            //Metodo que crea la categoria y lo guarda. Que devuelva el objeto
                            List<Categoria> categorias = repositorioCategoria.SaveLibro(doc);

                            //Metodo que asocia el libro con el autor. y tal vez el libro tambien
                            AsociarLibroAutor(libro,autores,categorias); // Agregale Categoria

                        }


                    }


                }
            }
        }
        
        private Libro SaveLibro(Docs doc, string isbn)
        {
            //Si no existe lo creo
            if (!ExisteIsbn(isbn))
            {
                DateTime fechaPublicacion = new DateTime(doc.FirstPublishYear, 1, 1);
                Libro libro = new Libro(isbn, doc.Title, fechaPublicacion);
                Agregar(libro);
                return libro;
            }
            return BuscarPorIsbn(isbn);
        }

        private void AsociarLibroAutor(Libro libro, List<Autor> autores, List<Categoria> categorias)
        {
            foreach (Autor autor in autores)
            {
                VerificarRelaciones(libro, autor, null);
            }

            foreach (Categoria categoria in categorias)
            {
                VerificarRelaciones(libro, null, categoria);
            }

            Actualizar(libro,autores,categorias);
        }

        private void VerificarRelaciones(Libro libro, Autor autor, Categoria categoria)
        {
            // Verificar si el autor ya está asociado al libro
            if (!libro.Autores.Contains(autor))
            {
                libro.Autores.Add(autor);
            }

            // Verificar si el libro ya está asociado al autor
            if (!autor.Libros.Contains(libro))
            {
                autor.Libros.Add(libro);
            }

            // Verificar si la categoría ya está asociada al libro
            if (!libro.Categorias.Contains(categoria))
            {
                libro.Categorias.Add(categoria);
            }

        }

        private bool Actualizar(Libro libro, List<Autor> autores, List<Categoria> categorias)
        {
            try
            {
                Actualizar(libro.ID, libro);

                foreach (Autor autor in autores)
                {
                    // Suponiendo que cada autor tiene un ID
                    repositorioAutor.Actualizar(autor.ID, autor);
                }

                foreach (Categoria categoria in categorias)
                {
                    // Suponiendo que cada categoría tiene un ID
                    repositorioCategoria.Actualizar(categoria.ID, categoria);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

    }
}
