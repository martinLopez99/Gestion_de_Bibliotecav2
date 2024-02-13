﻿using Gestion_de_Bibliotecav2.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public class RepositorioEjemplares : Repository<Dominio.Ejemplar, AdministradorPrestamosDBContext>, IRepositorioEjemplares
    {
        public RepositorioEjemplares(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }

        public List<Ejemplar> buscarPorISBN(string isbn)
        {
            List<Ejemplar> ejemplares = (List<Ejemplar>) GetAll();
            List<Ejemplar> ejemplaresEncontrados = new List<Ejemplar>();

            foreach (Ejemplar ejemplar in ejemplares)
            {
                if (ejemplar.Libro.ISBN == isbn)
                {
                    ejemplaresEncontrados.Add(ejemplar);
                }
            }

            return ejemplaresEncontrados;
        }

        public Ejemplar BuscarejemplarAPI(string isbn)
        {
            return null;
        }

    }
}
