﻿using System.Text;
using System.Threading.Tasks;
using Gestion_de_Bibliotecav2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework.Mapeo
{
    public class CategoriaMap
    {
        private ModelBuilder modelBuilder;
        public CategoriaMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void MapClass()
        {
            modelBuilder.Entity<Categoria>(entity => {
                entity.HasKey(categoria => categoria.ID);
                entity.Property(categoria => categoria.ID)
                      .ValueGeneratedOnAdd();
                entity.Property(categoria => categoria.Nombre);
            });

            /*

            this.HasKey(categoria => categoria.ID);

            this.Property(categoria => categoria.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(categoria => categoria.Nombre)
                .IsRequired();*/
        }
    }
}
