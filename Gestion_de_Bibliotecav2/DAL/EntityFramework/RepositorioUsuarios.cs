﻿using Gestion_de_Bibliotecav2.Dominio;
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
        public bool ExistePorDni(int dni)
        {
            List<Usuario> usuarios = (List<Usuario>)GetAll();
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.DNI == dni)
                {
                    return true;
                }
            }
            return false;
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
                }
            }

            return usuarioBuscado;
        }

        public void Eliminar(int dni)
        {
            Usuario usuario = obtenerPorDni(dni);

            Eliminar(usuario.ID,usuario);
        }

    }
}
