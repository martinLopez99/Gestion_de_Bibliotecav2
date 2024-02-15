using Gestion_de_Bibliotecav2.Dominio;
using Gestion_de_Bibliotecav2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Controladores
{
    public class ControladorEditorial
    {
        ServicioEditorial servicioEditorial;

        public List<Editorial> BuscarEditorialesPorCoincidencia(string nombre)
        {
            return servicioEditorial.BuscarEditorialesPorCoincidencia(nombre);
        }
    }
}
