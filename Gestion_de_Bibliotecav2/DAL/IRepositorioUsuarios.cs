using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav2.DAL
{
    public interface IRepositorioUsuarios : IRepository<Dominio.Usuario>
    {
        // Operaciones de usuarios
        //Usuario ObtenerUsuarioPorId(int usuarioId);
        //Usuario ObtenerUsuarioPorNombre(string nombreUsuario);

        //void RegistrarUsuario(Usuario usuario);
        //void ActualizarUsuario(Usuario usuario);
        //void EliminarUsuario(int usuarioId);

    }
}
