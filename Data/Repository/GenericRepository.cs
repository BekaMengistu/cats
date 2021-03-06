﻿

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;

namespace Cats.Data.Repository
{
    public class GenericRepository<T> :
   IGenericRepository<T>
        where T : class
    {
        public GenericRepository(CatsContext context)
        {
            _context = context;
        }
        private CatsContext _context;
        public CatsContext db
        {
            get { return _context; }
            set { _context = value; }
        }

        public virtual List<T> GetAll()
        {
            IQueryable<T> query = _context.Set<T>();
            return query.ToList();
        }


        public List<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = _context.Set<T>().Where(predicate);
            return query.ToList();
        }


        public virtual bool Add(T entity)
        {
            _context.Set<T>().Add(entity);
            return true;
        }


        public virtual bool Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
            return true;
        }

        public virtual bool Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return true;
        }




        public virtual T FindById(int id)
        {
            return _context.Set<T>().Find(id);
        }


    }
}