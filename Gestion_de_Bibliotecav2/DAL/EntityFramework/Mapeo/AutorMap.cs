using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity.ModelConfiguration; Ver
using Gestion_de_Bibliotecav2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework.Mapeo
{
    public class AutorMap
    {
        public AutorMap(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(autor => autor.ID);
                entity.Property(autor => autor.ID);
                      //.HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
                entity.Property(autor => autor.Nombre)
                      .IsRequired();
            });


            /*this.HasKey(autor => autor.ID);

            this.Property(autor => autor.ID)
            .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(autor => autor.Nombre)
                .IsRequired();*/

           /* this.HasMany(autor => autor.Libro_Autor)
                .WithMany()
                .Map(m =>
                {
                    m.MapLeftKey("AutorID");
                    m.MapRightKey("LibroID");
                    m.ToTable("Libro_Autor");
                });*/
        }
    }
}
