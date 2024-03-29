﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Bibliotecav2.DAL
{
    public interface IRepository<TEntidad> where TEntidad : class
    {
        void Agregar(TEntidad pEntidad);

        void Eliminar(int pId, TEntidad pEntidad);
        void Actualizar (int pId, TEntidad pEntidad);

        TEntidad Get(int pId);

        IEnumerable<TEntidad> GetAll();
        bool Existe(int pId);

    }
}
