using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.DAL.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        T GetById(int id);
        T Create(T entity);
        T Update(T entity);
        T Delete(int id);

    }
}
