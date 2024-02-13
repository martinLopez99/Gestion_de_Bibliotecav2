using Gestion_de_Bibliotecav2.Dominio;
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

                            //Metodo que asocia el libro con el autor. y tal vez el libro tambien
                            AsociarLibroAutor(libro,autores);

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

        private void AsociarLibroAutor(Libro libro, List<Autor> autores)
        {
            foreach (Autor autor in autores)
            {
                //DEBO ASEGURARME QUE LA ASOCIACIÓN NO EXISTA

                //Aca hago la relación 
                libro.Autores.Add(autor);   //Debo de conseguir el id
                                            //Lo ideal seria que los metodos me devuevlan el objeto
                                            //Guardado en la base de dato, asi lo uso para guardarlo 
                                            //En la asociación (ya que ahora no estoy usando un obj completo *Sin id*)
            
                //Debo realizar lo mismo para cada autor
                autor.Libros.Add(libro); //Relaciono a cada autor con el libro 

            }
            
            //Actualizar(libro,autor); //VER

        }

        private bool Actualizar(Libro libro, Autor autor)
        {
            try
            {
                //Actualizar requiere de un id, asi actualiza correctamente el objeto
                //Actualizar(libro);
                repositorioAutor.Actualizar(autor.ID,autor);
                return true;
            }catch (Exception e)
            {
                return false;
            }
        }

    }
}
