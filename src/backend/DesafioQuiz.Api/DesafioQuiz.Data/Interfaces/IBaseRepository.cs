﻿using DesafioQuiz.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DesafioQuiz.Data.Interfaces
{
    public interface IBaseRepository<TEntity> : IDisposable where TEntity : Entity
    {
        TEntity Save(TEntity entity);

        void Update(TEntity entity);

        void Delete(int id);

        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate);
        IEnumerable<TEntity> GetAll();

        TEntity GetById(int id);

        TEntity GetByCode(Guid code);

        int Count();

        int SaveChanges();
    }
}
