using Gestion_de_Bibliotecav2.Dominio;
using Gestion_de_Bibliotecav2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Controladores
{
    public class ControladorCategoria
    {
        ServicioCategoria servicioCategoria;

        public List<Categoria> BuscarCategoriasPorCoincidencia(string nombre)
        {
            return servicioCategoria.BuscarCategoriasPorCoincidencia(nombre);
        }
    }
}
