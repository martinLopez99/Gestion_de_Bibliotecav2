using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav2.DAL
{
    public interface IRepositorioEjemplares : IRepository<Dominio.Ejemplar>
    {
        // Alta de ejemplar
        //void AgregarEjemplar(Ejemplar ejemplar);

        //// Búsqueda de ejemplar por ID
        //Ejemplar ObtenerEjemplarPorId(int id);

        //// Búsqueda de ejemplares disponibles para préstamo
        //List<Ejemplar> ObtenerEjemplaresDisponibles();

        //// Actualización de información de un ejemplar
        //void ActualizarEjemplar(Ejemplar ejemplar);

    }
}
