using Gestion_de_Bibliotecav2.Servicios;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public async Task ObtenerInfoIsbn()
        {
            // Arrange
            using var httpClient = new HttpClient();
            var openLibraryApiClient = new OpenLibraryApiClient(httpClient);
            var isbn = "9783608960358";

            // Act
            HttpResponseMessage response = await openLibraryApiClient.ObtenerLibroAsync_isbn(isbn);

            // Assert
            Assert.NotNull(response);
            // Obtener el contenido JSON como una cadena
            string jsonResponse = await response.Content.ReadAsStringAsync();

            
            Assert.NotNull(response);
            
        }

        [Fact]
        public async Task ObtenerInfoNombre()
        {
            // Arrange
            using var httpClient = new HttpClient();
            var openLibraryApiClient = new OpenLibraryApiClient(httpClient);
            var nombre = "harry+potter";

            // Act
            HttpResponseMessage response = await openLibraryApiClient.ObtenerLibroAsync_nombre(nombre);

            // Imprimir el contenido si la solicitud fue exitosa
            if (response != null && response.IsSuccessStatusCode)
            {
                string jsonResponse = await response.Content.ReadAsStringAsync();
                //Console.WriteLine(jsonResponse);

                // Deserializar el JSON en un objeto Rootobject
                Rootobject rootObject = JsonConvert.DeserializeObject<Rootobject>(jsonResponse);

                if (rootObject != null)
                {
                    // Acceder a la lista de objetos Doc
                    Doc[] docs = rootObject.docs;

                    if (docs != null)
                    {
                        // Acceder a cada objeto Doc
                        foreach (var doc in docs)
                        {
                            Console.WriteLine($"Título del libro: {doc.title}");
                            Console.WriteLine($"Año de publicación: {doc.first_publish_year}");
                            Console.WriteLine($"Autores: {string.Join(", ", doc.author_name)}");
                            Console.WriteLine($"Temas: {string.Join(", ", doc.subject)}");
                            Console.WriteLine();
                        }

                        Assert.NotNull(docs); // Asegurarse de que la lista de documentos no sea nula si es necesaria
                    }
                }
            }
            else
            {
                Console.WriteLine($"Error en la solicitud. Estado: {response?.StatusCode}");
            }
        }


        // Definición simple de la clase Libro para el ejemplo
        public class OpenLibraryResponse
        {
            public int Start { get; set; }
            public int NumFound { get; set; }
            public List<Docs> Docs { get; set; }
        }

        public class Docs
        {
            public string Title { get; set; }
            public int FirstPublishYear { get; set; }
            public List<string> AuthorName { get; set; }
            public List<string> Subject { get; set; }
        }

    }
}
