using Microsoft.EntityFrameworkCore;
using SMSApp.DAL.Models;
using SMSApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.DAL.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity, new()
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<T>();
        }
        public T GetById(int id)
        {
            return _dbSet.FirstOrDefault(x => x.Id == id);

        }

        public T Create(T entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public T Delete(int id)
        {
            var exsitingEntity = _dbSet.FirstOrDefault(x => x.Id == id);
            _dbSet.Remove(exsitingEntity);
            _dbContext.SaveChanges();
            return exsitingEntity;
        }



        public T Update(T entity)
        {
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
            return entity;
        }
    }
}
