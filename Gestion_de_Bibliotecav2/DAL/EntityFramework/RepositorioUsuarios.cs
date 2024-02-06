using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public class RepositorioUsuarios : Repository<Dominio.Usuario, AdministradorPrestamosDBContext>, IRepositorioUsuarios
    {
        public RepositorioUsuarios(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        public Usuario obtenerPorDni(int dni)
        {
            List<Usuario> usuarios = (List<Usuario>) GetAll();
            Usuario usuarioBuscado = new Usuario();

            foreach (Usuario usuario in usuarios)
            {
                if (usuario.DNI == dni)
                {
                    usuarioBuscado = usuario;
                    return usuarioBuscado;
                }
            }

            return usuarioBuscado;
        }

        public void EliminarPorDni(int dni)
        {
            Usuario usuario = obtenerPorDni(dni);

            Eliminar(usuario.ID,usuario);
        }

    }
}
