﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMSArticle.RepositoryLayer
{
    public interface IGenericRepository<T>:IDisposable
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Delete(int id);
        void Save();
    }
}
