﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public class RepositorioPrestamos : Repository<Dominio.Prestamo, AdministradorPrestamosDBContext>, IRepositorioPrestamos
    {
        public RepositorioPrestamos(AdministradorPrestamosDBContext pDBContext) : base(pDBContext)
        {

        }
    }
}
