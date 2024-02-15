using Gestion_de_Bibliotecav2.Dominio;
using Gestion_de_Bibliotecav2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Controladores
{
    public class ControladorEjemplar
    {
        ServicioEjemplar servicioEjemplar;
        

        public void CrearEjemplar(Ejemplar ejemplar)
        {
            try
            {
                servicioEjemplar.Agregar(ejemplar);
                //La pantalla deberia mostrar que se agregó con exito.
            }
            catch (SystemException s)
            {
                //La panntalla deberia mostrar que algun parametro esta mal
            }
            catch (Exception ex)
            {
                //La panntalla deberia mostrar el siguiente error "ex.ToString()"
            }

        }

        public List<Categoria> BuscarCategorias(string categoria)
        {
            return servicioEjemplar.BuscarCategorias(categoria);
        }

        public List<Ejemplar> BuscarEjemplaresPorIsbnONombre(string isbnONombre)
        {
            List<Ejemplar> listaEjemplares = new List<Ejemplar>();
            long number1 = 0;
            bool canConvert = long.TryParse(isbnONombre, out number1);
            if (canConvert)
            {
                listaEjemplares.Add(servicioEjemplar.buscarPorISBN(isbnONombre));
            }
            else
            {
                listaEjemplares.AddRange(servicioEjemplar.buscarPorNombre);
            }
            return listaEjemplares;
        }

        public void ModificarEjemplar(Ejemplar ejemplar)// necesito un nuevo constructor de ejemplar para poder cargarle una fecha de baja
        {
            try
            {
                servicioEjemplar.Actualizar(ejemplar);
                // Mensaje de exito
            }
            catch (SystemException s)
            {
                // Algun parametro esta mal (id o no existe)
            }
            catch (Exception e)
            {
                // Se debe mostrar este error "e.Message.ToString()"
            }
        }

        public void EliminarEjemplar(Ejemplar ejemplar)
        {
            try
            {
                servicioEjemplar.Eliminar(ejemplar);
                // Mensaje de exito
            }
            catch (SystemException s)
            {                
                // Algun parametro esta mal (id o no existe)
            }
            catch (Exception e)
            {
                // Se debe mostrar este error "e.Message.ToString()"
            }
        }

        public List<Editorial> BuscarEditoriales(string nombre)
        {
           return servicioEjemplar.BuscarEditoriales(nombre);
        }
    }
}
