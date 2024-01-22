using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public abstract class Repository<TEntidad, TDBContext> : IRepository<TEntidad> where TEntidad : class
                                                                                   where TDBContext : DbContext
    {
        protected readonly TDBContext iDBContext;

        public Repository(TDBContext pDBContext)
        {
            if (pDBContext == null)
            {
                throw new ArgumentNullException(nameof(pDBContext));
            }

            this.iDBContext = pDBContext;
        }

        public void Agregar(TEntidad pEntidad)
        {
            if (pEntidad == null)
            {
                throw new ArgumentNullException(nameof(pEntidad));
            }

            this.iDBContext.Set<TEntidad>().Add(pEntidad);
        }

        public TEntidad Get(int pId)
        {
            return this.iDBContext.Set<TEntidad>().Find(pId);
        }

        public IEnumerable<TEntidad> GetAll()
        {
            return this.iDBContext.Set<TEntidad>();
        }

        public void Eliminar(TEntidad pEntidad)
        {
            if (pEntidad == null)
            {
                throw new ArgumentNullException(nameof(pEntidad));
            }

            this.iDBContext.Set<TEntidad>().Remove(pEntidad);
        }
    }
}
