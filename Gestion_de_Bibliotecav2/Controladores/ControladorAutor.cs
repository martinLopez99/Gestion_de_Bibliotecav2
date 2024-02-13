using Gestion_de_Bibliotecav2.Dominio;
using Gestion_de_Bibliotecav2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Controladores
{
    internal class ControladorAutor
    {
        ServicioAutor servicioAutor;

        public void CrearAutor(string nombre)
        {
            Autor autor = new Autor(nombre);
            servicioAutor.Agregar(autor);
        }

        public Autor BuscarAutorPorNombre(string nombre)
        {
            return servicioAutor.BuscarAutor(nombre);
        }
    }
}
