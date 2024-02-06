﻿using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public class RepositorioPrestamos : Repository<Dominio.Prestamo, AdministradorPrestamosDBContext>, IRepositorioPrestamos
    {
        public RepositorioPrestamos(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        public List<Prestamo> buscarPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            List<Prestamo> prestamos = (List<Prestamo>) GetAll();

            List<Prestamo> prestamosIntervalo = new List<Prestamo>();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.FechaVencimiento >= fechaInicio && prestamo.FechaVencimiento <= fechaFin)
                {
                    prestamosIntervalo.Add(prestamo);
                }
            }

            return prestamosIntervalo;
        }

        public List<Prestamo> buscarPorCodigoEjemplar(int codigo)
        {
            List<Prestamo> prestamos = (List<Prestamo>)GetAll();
            List<Prestamo> prestamosCodigo= new List<Prestamo>();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Ejemplar.Codigo == codigo)
                {
                    prestamosCodigo.Add(prestamo);
                }
            }

            return prestamosCodigo;

        }

        public List<Prestamo> buscarPorNombreEjemplar(string nombre)
        {
            List<Prestamo> prestamos = (List<Prestamo>)GetAll();
            List<Prestamo> prestamosNombre = new List<Prestamo>();

            foreach (Prestamo prestamo in prestamos)
            {
                if (prestamo.Ejemplar.Libro.Nombre.Contains(nombre))
                {
                    prestamosNombre.Add(prestamo);
                }
            }

            return prestamosNombre;

        }

    }
}
