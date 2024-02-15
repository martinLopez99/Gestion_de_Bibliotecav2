using Gestion_de_Bibliotecav2.Dominio;
using Gestion_de_Bibliotecav2.Servicios;
using Microsoft.Extensions.Logging.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Controladores
{
    public class ControladorUsuario
    {
        ServicioUsuario servicioUsuario;
        public void CrearUsuario(Usuario usuario)
        {
            try
            {
                servicioUsuario.Agregar(usuario);
                //La pantalla deberia mostrar que se guardo con exito

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

        public void ModificarUsuario(Usuario usuario)
        {
            try
            {
                servicioUsuario.Actualizar(usuario);
                //La pantalla deberia mostrar que se actualizo con exito

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

        public bool Existe(string dni)
        {
           return servicioUsuario.Existe(int.Parse(dni));
        }

        public List<Usuario> obtenerUsuario(string dniONombre)
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario> ();
                int number1 = 0;
                bool canConvert = int.TryParse(dniONombre, out number1);
                if (dniONombre != null && canConvert)
                {
                    usuarios.Add(servicioUsuario.obtenerPorDni(int.Parse(dniONombre)));
                }
                else 
                {
                    usuarios.Add(servicioUsuario.Get(int.Parse(dniONombre)));
                }

                return usuarios;

            }
            catch (SystemException s)
            {
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
            
        }

        public List<Usuario> GetAll()
        {
            return servicioUsuario.GetAll();
        }

        public void Eliminar(string dni)
        {
            try
            {
                servicioUsuario.Eliminar(int.Parse(dni));
                //La pantalla deberia mostrar que se eliminó con exito

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
    }
}
