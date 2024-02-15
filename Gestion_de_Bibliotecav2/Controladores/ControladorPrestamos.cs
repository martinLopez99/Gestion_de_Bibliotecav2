using Gestion_de_Bibliotecav2.Dominio;
using Gestion_de_Bibliotecav2.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Gestion_de_Bibliotecav2.Controladores
{
    public class ControladorPrestamos
    {
        ServicioPrestamos servicioPrestamos = new ServicioPrestamos();
        ServicioEjemplar servicioEjemplar = new ServicioEjemplar();
        ServicioUsuario servicioUsuario = new ServicioUsuario();

        public List<Prestamo> BuscarPrestamos(string codigoONombre)
        {
            try
            {
                List<Prestamo> prestamos = new List<Prestamo>();
                int number1 = 0;
                bool canConvert = int.TryParse(codigoONombre, out number1);
                if (canConvert)
                {
                    prestamos = servicioPrestamos.BuscarPorCodigoEjemplar(int.Parse(codigoONombre));
                }
                else
                {
                    prestamos = servicioPrestamos.BuscarPorNombreEjemplar(codigoONombre);
                }

                return prestamos;
            }
            catch (SystemException s)
            {
                // Algun parametro esta mal (id o no existe)
                return null;
            }
            catch (Exception e)
            {
                // Se debe mostrar este error "e.Message.ToString()"
                return null;
            }

            
        }

        public void NuevoPrestamo(Ejemplar ejemplar, Usuario usuario)
        {
            Prestamo prestamo = new Prestamo(usuario, ejemplar);
            servicioPrestamos.Agregar(prestamo);
        }

        public List<Prestamo> ProximosAVencerse()
        {
            return servicioPrestamos.ProximosAVencerse();
        }

        public void EliminarPrestatmo(Prestamo prestamo)
        {
            try
            {
                servicioPrestamos.Eliminar(prestamo);
                //Mensaje de exito
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

        public void RegistrarDevolucion()
        {

        }

        public List<Ejemplar> ejemplaresUsuario(Usuario usuario)//modificar segun lo que pida la pantalla
        {
           return servicioPrestamos.ejemplaresUsuario(usuario);
        }
    }
}
