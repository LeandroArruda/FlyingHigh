using System;
using System.Collections.Generic;
using System.Linq;
using FlyingHigh.Domain.Common;
using FlyingHigh.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace FlyingHigh.Infra.Data.EF
{
    public class Repository : IRepository
    {
        private readonly DbContext _dbContext;
        public T Add<T>(T entity) where T : Entity
        {
            _dbContext.Set<T>().Add(entity);
            _dbContext.SaveChanges();

            return entity;
        }

        public void Delete<T>(T entity) where T : Entity
        {
            _dbContext.Set<T>().Remove(entity);
            _dbContext.SaveChanges();
        }

        public T GetById<T>(Guid id) where T : Entity
        {
            return _dbContext.Set<T>().SingleOrDefault(e => e.Id == id);
        }

        public List<T> List<T>() where T : Entity
        {
            return _dbContext.Set<T>().ToList();
        }

        public void Update<T>(T entity) where T : Entity
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
    }
}