using System;
using System.Collections.Generic;
using FlyingHigh.Domain.Common;

namespace FlyingHigh.Domain.Interfaces
{
    public interface IRepository
    {
         T GetById<T>(Guid id) where T : Entity;
        List<T> List<T>() where T : Entity;
        T Add<T>(T entity) where T : Entity;
        void Update<T>(T entity) where T : Entity;
        void Delete<T>(T entity) where T : Entity;
    }
}