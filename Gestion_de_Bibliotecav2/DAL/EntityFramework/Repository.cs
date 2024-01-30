using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace Gestion_de_Bibliotecav2.DAL.EntityFramework
{
    public abstract class Repository<TEntidad, TDBContext> : IRepository<TEntidad> where TEntidad : class, IEntity
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


        public void Actualizar(TEntidad pEntidad)
        {
            if (pEntidad == null)
            {
                throw new ArgumentNullException(nameof(pEntidad));
            }
            
            var entity = this.iDBContext.Set<TEntidad>().Find(pEntidad.Id);
            this.iDBContext.Entry(entity).CurrentValues.SetValues(pEntidad);
        }

        public bool Existe(int pId)
        {
            return this.iDBContext.Set<TEntidad>().Any(e => e.Id == pId);
        }
    }
}
