﻿using Gestion_de_Bibliotecav2.DAL.EntityFramework;
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

        public Usuario Get(int id)
        {
            return repositorioUsuarios.Get(id);   
        }

        public Usuario obtenerPorDni(int dni)
        {
            return repositorioUsuarios.obtenerPorDni(dni);
        }

        public List<Usuario> GetAll()
        {
            return (List<Usuario>) repositorioUsuarios.GetAll();
        }

        public void Agregar(Usuario usuario) 
        {
            if (usuario.ID != null && !repositorioUsuarios.Existe(usuario.ID)){ //No debe existir el usuario
                repositorioUsuarios.Agregar(usuario);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Actualizar(Usuario usuario)
        {
            if (usuario.ID != null && repositorioUsuarios.Existe(usuario.ID)){ //Debe de existir el usuario
                repositorioUsuarios.Actualizar(usuario.ID,usuario);
            }
         
            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Eliminar(Usuario usuario)
        {
            if (usuario.ID != null && repositorioUsuarios.Existe(usuario.ID)) //Debe de existir el usuario
            {
                repositorioUsuarios.Eliminar(usuario.ID, usuario);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }


        public void Eliminar(int dni)
        {
            if (dni != null && repositorioUsuarios.Existe(dni)) //Debe de existir el usuario
            {
                repositorioUsuarios.Eliminar(dni);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public bool Existe(int dni)
        {
            return repositorioUsuarios.Existe(dni);
        }

    }
}
