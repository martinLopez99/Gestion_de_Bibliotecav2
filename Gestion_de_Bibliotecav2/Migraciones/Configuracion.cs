using System;
using System.Collections.Generic;
using System.Text;
using Gestion_de_Bibliotecav2.DAL.EntityFramework;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;


namespace Gestion_de_Bibliotecav2.Migraciones
{

    internal sealed class Configuracion // : DbMigrationsConfiguration<Gestion_de_Bibliotecav2.DAL.EntityFramework.AdministradorPrestamosDBContext>
    {
        public Configuracion()
        {
            //AutomaticMigrationsEnabled = false;
            //ContextKey = "Gestion_de_Biblioteca.DAL.EntityFramework.AdministradorPrestamosDBContext";
        }
        /*
        protected override void OnConfiguring(AdministradorPrestamosDBContext optionsBuilder) //VER
        {
            // Utilizando MySQL
            //optionsBuilder.UseMySQL("server=localhost;database=library;user=user;password=password");
        }

        protected override void Seed(Gestion_de_Bibliotecav2.DAL.EntityFramework.AdministradorPrestamosDBContext pContext)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }*/
    }
}
