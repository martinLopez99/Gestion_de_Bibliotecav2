using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity.ModelConfiguration;
using Gestion_de_Bibliotecav2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework.Mapeo
{
    public class EjemplarMap
    {
        public EjemplarMap(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ejemplar>(entity =>
            {
                entity.HasKey(ejemplar => ejemplar.ID);
                entity.Property(ejemplar => ejemplar.ID);
                entity.Property(ejemplar => ejemplar.Codigo)
                      .IsRequired();
                entity.Property(ejemplar => ejemplar.FechaAlta)
                      .IsRequired();
                entity.Property(ejemplar => ejemplar.FechaBaja);
                      //.IsOptional(); Creo que si lo dejas vacio, por defecto queda como opcional
                entity.Property(ejemplar => ejemplar.Disponibilidad)
                      .IsRequired();
                entity.HasOne(ejemplar => ejemplar.Libro)
                      .WithMany()
                      .HasForeignKey(ejemplar => ejemplar.Libro.ID);
            });

            /*
            this.HasKey(ejemplar => ejemplar.ID);

            this.Property(ejemplar => ejemplar.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(ejemplar => ejemplar.Codigo)
                .IsRequired();

            this.Property(ejemplar => ejemplar.FechaAlta)
                .IsRequired();

            this.Property(ejemplar => ejemplar.FechaBaja)
                .IsOptional();

            this.Property(ejemplar => ejemplar.Disponibilidad)
                .IsRequired();

            this.HasRequired(ejemplar => ejemplar.Libro)
                .WithMany()
                .HasForeignKey(ejemplar => ejemplar.Libro.ID);*/
        }
    }
}