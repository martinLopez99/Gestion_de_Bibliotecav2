﻿using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Microsoft.EntityFrameworkCore;

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

        public void Eliminar(int pId, TEntidad pEntidad) //La entidad que se pasa aca va a ser el objeto usuario con el atributo de baja como "TRUE"
        {
            if (pEntidad == null)
            {
                throw new ArgumentNullException(nameof(pEntidad));
            }

            var entity = this.iDBContext.Set<TEntidad>().Find(pId);             //Te trae el objeto
            this.iDBContext.Entry(entity).CurrentValues.SetValues(pEntidad);    //Setea el/los valores
        }


        public void Actualizar(int pid, TEntidad pEntidad)
        {
            if (pEntidad == null)
            {
                throw new ArgumentNullException(nameof(pEntidad));
            }
            
            var entity = this.iDBContext.Set<TEntidad>().Find(pid);             //Te trae el objeto
            this.iDBContext.Entry(entity).CurrentValues.SetValues(pEntidad);    //Setea el/los valores
        }

        public bool Existe(int pId)
        {
            return (this.iDBContext.Set<TEntidad>().Find(pId) != null) ? true : false;
        }


    }
}
