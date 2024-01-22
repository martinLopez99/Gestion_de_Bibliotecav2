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
    public class UsuarioMap
    {
        public UsuarioMap(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(usuario => usuario.ID);

                entity.Property(usuario => usuario.ID);
                    //.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

                entity.Property(usuario => usuario.DNI)
                      .IsRequired();

                entity.Property(usuario => usuario.Nombre)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(usuario => usuario.Score)
                      .IsRequired();

                entity.Property(usuario => usuario.Direccion)
                      .IsRequired()
                      .HasMaxLength(200);

                entity.Property(usuario => usuario.Telefono)
                      .IsRequired();

                entity.Property(usuario => usuario.Email)
                      .IsRequired()
                      .HasMaxLength(100);

                entity.Property(usuario => usuario.LibrosPrestados)
                      .IsRequired();
            });



            /*
            this.HasKey(usuario => usuario.ID);

            this.Property(usuario => usuario.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(usuario => usuario.DNI)
                .IsRequired();

            this.Property(usuario => usuario.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(usuario => usuario.Score)
                .IsRequired();

            this.Property(usuario => usuario.Direccion)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(usuario => usuario.Telefono)
                .IsRequired();

            this.Property(usuario => usuario.Email)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(usuario => usuario.LibrosPrestados)
                .IsRequired();*/
        }
    }
}
