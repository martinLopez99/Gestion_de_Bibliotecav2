using System.Text;
using System.Threading.Tasks;
using Gestion_de_Bibliotecav2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework.Mapeo
{
    public class LibroMap
    {
        private ModelBuilder modelBuilder;
        public LibroMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void MapClass()
        {
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.HasKey(libro => libro.ID);
                entity.Property(libro => libro.ID)
                      .ValueGeneratedOnAdd();
                entity.Property(libro => libro.ISBN)
                      .IsRequired();
                entity.Property(libro => libro.Nombre) 
                      .IsRequired();
                entity.Property(libro => libro.FechaPublicacion)
                      .IsRequired();
                entity.HasOne(libro => libro.Editorial)
                      .WithMany()
                      .HasForeignKey(libro => libro.Editorial.ID);
                entity.HasMany(libro => libro.Libro_Autor)
                      .WithMany();
                entity.HasMany(libro => libro.Libro_Categoria);
            });



            /*
            this.HasKey(libro => libro.ID);

            this.Property(libro => libro.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(libro => libro.ISBN)
                .IsRequired();

            this.Property(libro => libro.Nombre)
                .IsRequired();

            this.Property(libro => libro.FechaPublicacion)
                .IsRequired();

            this.HasRequired(libro => libro.Editorial)
                .WithMany()
                .HasForeignKey(libro => libro.Editorial.ID);

            this.HasMany(libro => libro.Libro_Autor)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("LibroID");
                    m.MapRightKey("AutorID");
                    m.ToTable("Libro_Autor");
                });
            */
        }
    }
}

