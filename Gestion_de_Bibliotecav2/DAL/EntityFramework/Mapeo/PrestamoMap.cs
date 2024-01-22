using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestion_de_Bibliotecav2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework.Mapeo
{
    public class PrestamoMap
    {
        public PrestamoMap(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Prestamo>(entity =>
            {
                entity.HasKey(prestamo => prestamo.ID);

                entity.Property(prestamo => prestamo.ID)
                      .ValueGeneratedOnAdd();

                entity.Property(prestamo => prestamo.FechaEntrega)
                      .IsRequired();

                entity.Property(prestamo => prestamo.FechaVencimiento)
                      .IsRequired();

                entity.Property(prestamo => prestamo.FechaDevolucion);

                /* Esta entidad no tiene que ser guardada a menos que se especifique la otra relación
                entity.HasRequired(prestamo => prestamo.Ejemplar)
                    .WithMany()
                    .HasForeignKey(prestamo => prestamo.Ejemplar.ID);

                entity.HasRequired(prestamo => prestamo.Usuario)
                    .WithMany()
                    .HasForeignKey(prestamo => prestamo.Usuario.ID);*/
            });



            /*
            this.HasKey(prestamo => prestamo.ID);

            this.Property(prestamo => prestamo.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(prestamo => prestamo.FechaEntrega)
                .IsRequired();

            this.Property(prestamo => prestamo.FechaVencimiento)
                .IsRequired();

            this.Property(prestamo => prestamo.FechaDevolucion)
                .IsOptional();

            this.HasRequired(prestamo => prestamo.Ejemplar)
                .WithMany()
                .HasForeignKey(prestamo => prestamo.Ejemplar.ID);

            this.HasRequired(prestamo => prestamo.Usuario)
                .WithMany()
                .HasForeignKey(prestamo => prestamo.Usuario.ID);
            */
        }
    }
}
