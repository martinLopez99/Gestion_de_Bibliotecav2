using Gestion_de_Bibliotecav2.DAL.EntityFramework;
using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Servicios
{
    public class ServicioUsuario
    {
        private RepositorioUsuarios repositorioUsuarios;

        public Usuario findById(int id)
        {
            return repositorioUsuarios.Get(id);   
        }

        public List<Usuario> findAll()
        {
            return (List<Usuario>) repositorioUsuarios.GetAll();
        }

        public void Agregar(Usuario usuario) 
        {
            if (usuario.ID != null && !repositorioUsuarios.Existe(usuario.ID)){
                repositorioUsuarios.Agregar(usuario);
            }
        }

        public void Actualizar(Usuario usuario)
        {
            if (usuario.ID != null && !repositorioUsuarios.Existe(usuario.ID)){
                repositorioUsuarios.Actualizar(usuario.ID,usuario);
            }
        }


    }
}
