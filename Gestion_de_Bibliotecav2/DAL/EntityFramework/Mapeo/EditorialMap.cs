using System.Text;
using System.Threading.Tasks;
//using System.Data.Entity.ModelConfiguration;
using Gestion_de_Bibliotecav2.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework.Mapeo
{
    public class EditorialMap
    {
        private ModelBuilder modelBuilder;
        public EditorialMap(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
        public void MapClass()
        {
            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.HasKey(editorial => editorial.ID);
                entity.Property(editorial => editorial.ID)
                       .ValueGeneratedOnAdd();
                entity.Property(editorial => editorial.Nombre)
                      .IsRequired();
                entity.Property(editorial => editorial.Telefono)
                      .IsRequired();
            });
            
            /*
            this.HasKey(editorial => editorial.ID);

            this.Property(editorial => editorial.ID)
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(editorial => editorial.Nombre)
                .IsRequired();

            this.Property(editorial => editorial.Direccion)
                .IsRequired();

            this.Property(editorial => editorial.Telefono)
                .IsRequired();*/
        }
    }
}
