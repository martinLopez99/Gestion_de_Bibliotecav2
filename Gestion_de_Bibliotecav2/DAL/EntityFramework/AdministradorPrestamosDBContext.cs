using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using Gestion_de_Bibliotecav2.Dominio;
using Gestion_de_Bibliotecav2.Migraciones;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public class AdministradorPrestamosDBContext : DbContext
    {
        public AdministradorPrestamosDBContext() : base("Gestion_De_Biblioteca")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<AdministradorPrestamosDBContext, Configuracion>());
        }

        public IDbSet<Prestamo> Prestamos { get; set; }

        public IDbSet<Usuario> Usuarios { get; set; }

        public IDbSet<Ejemplar> Ejemplares { get; set; }

        protected override void OnModelCreating(DbModelBuilder pModelBuilder)
        {
            pModelBuilder.Configurations.AddFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());

            base.OnModelCreating(pModelBuilder);
        }
    }
}
