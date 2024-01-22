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
    }
}
