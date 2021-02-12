using DesafioQuiz.Data.Context;
using DesafioQuiz.Data.Interfaces;
using DesafioQuiz.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DesafioQuiz.Data.Repository
{
    public abstract class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly DesafioQuizContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(DesafioQuizContext db)
        {
            Db = db;
            DbSet = Db.Set<TEntity>();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();

        }

        public TEntity GetById(int id)
        {
            return DbSet.FirstOrDefault(x => x.Id == id);
        }

        public TEntity GetByCode(Guid code)
        {
            return DbSet.FirstOrDefault(x => x.Guid == code);
        }

        public TEntity Save(TEntity entity)
        {
            DbSet.Add(entity);
            SaveChanges();
            return entity;
        }

        public void Update(TEntity entity)
        {
            DbSet.Update(entity);
            SaveChanges();
        }

        public void Delete(int id)
        {
            DbSet.Remove(new TEntity { Id = id });
            SaveChanges();
        }

        public int Count()
        {
            return DbSet.Count();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
    }
}
