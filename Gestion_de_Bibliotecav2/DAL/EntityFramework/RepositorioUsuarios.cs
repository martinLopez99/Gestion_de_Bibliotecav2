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
    }
}
