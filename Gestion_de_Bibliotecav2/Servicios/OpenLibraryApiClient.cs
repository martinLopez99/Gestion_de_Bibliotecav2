using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;


namespace Gestion_de_Bibliotecav2.Servicios
{
    public class OpenLibraryApiClient
    {
        private readonly HttpClient _httpClient;
        private const string Api = "https://openlibrary.org/search.json?";

        public OpenLibraryApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> ObtenerLibroAsync_isbn(string isbn) //CORREGIR
        {
            string apiUrl = $"{Api}isbn={isbn}";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }

            return null;
        }

        public async Task<List<string>> ObtenerLibroAsync_nombre(string nombre) //CORREGIR
        {
            string apiUrl = $"{Api}q={nombre}";
            HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                // Obtener el contenido JSON como una cadena
                string jsonResponse = await response.Content.ReadAsStringAsync();

                // Imprimir el JSON completo
                Console.WriteLine($"Respuesta JSON completa: {jsonResponse}");

                // No es necesario deserializar si solo deseas imprimir el JSON
                return new List<string>();
            }

            return new List<string>();
        }

    }
}
