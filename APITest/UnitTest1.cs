using System;
using Xunit;
using Gestion_de_Bibliotecav2.Servicios;

public class OpenLibraryApiClientTests
{
    [Fact]
    public async Task ObtenerLibroAsync_isbn_DeberiaRetornarResultados()
    {
        // Arrange
        var openLibraryApiClient = new OpenLibraryApiClient();

        // Act
        string resultado = await openLibraryApiClient.ObtenerLibroAsync_isbn("your_isbn");

        // Assert
        Assert.NotNull(resultado);
        // Agrega más aserciones según sea necesario
    }

    [Fact]
    public async Task ObtenerLibroAsync_nombre_DeberiaRetornarListaVacia()
    {
        // Arrange
        var openLibraryApiClient = new OpenLibraryApiClient();

        // Act
        List<string> resultado = await openLibraryApiClient.ObtenerLibroAsync_nombre("your_nombre");

        // Assert
        Assert.Empty(resultado);
        // Agrega más aserciones según sea necesario
    }
}
