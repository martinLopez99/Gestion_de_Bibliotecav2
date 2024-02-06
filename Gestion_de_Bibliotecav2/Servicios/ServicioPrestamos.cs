using Gestion_de_Bibliotecav2.DAL;
using Gestion_de_Bibliotecav2.DAL.EntityFramework;
using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Bibliotecav2.Servicios
{
    internal class ServicioPrestamos
    {
        private RepositorioPrestamos repositorioPrestamos;

        public Prestamo findById(int id)
        {
            return repositorioPrestamos.Get(id);
        }

        public List<Prestamo> findAll()
        {
            return (List<Prestamo>)repositorioPrestamos.GetAll();
        }

        public void Agregar(Prestamo prestamo)
        {
            if (prestamo.ID != null && !repositorioPrestamos.Existe(prestamo.ID))
            { //No debe existir el usuario
                repositorioPrestamos.Agregar(prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Actualizar(Prestamo prestamo)
        {
            if (prestamo.ID != null && repositorioPrestamos.Existe(prestamo.ID))
            { //Debe de existir el usuario
                repositorioPrestamos.Actualizar(prestamo.ID, prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

        public void Eliminar(Prestamo prestamo)
        {
            if (prestamo.ID != null && repositorioPrestamos.Existe(prestamo.ID)) //Debe de existir el usuario
            {
                repositorioPrestamos.Eliminar(prestamo.ID, prestamo);
            }

            throw new SystemException(); // Si no pasa por el condicional devuelvo un error (sera atrapado por el controlador)
        }

    }
}

