﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CMSArticle.ModelLayer;
using CMSArticle.ModelLayer.Context;

namespace CMSArticle.RepositoryLayer
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        CMSContext db;
        DbSet<T> dbContext;

        public GenericRepository(CMSContext context)
        {
            db = context;
            dbContext = context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return dbContext.ToList();
        }
        public T Get(int id)
        {
            return dbContext.Find(id);
        }
        public bool Add(T entity)
        {
            try
            {
                dbContext.Add(entity);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Update(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(T entity)
        {
            try
            {
                db.Entry(entity).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                T entity = dbContext.Find(id);
                db.Entry(entity).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    }
}
