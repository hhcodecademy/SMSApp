using SMSApp.DAL.Models;
using SMSApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.BLL.Services.Interfaces
{
    public interface IGenericService<Tdto,Tentity>where Tentity :BaseEntity, new() where Tdto : class
    {
        public Tdto Create(Tdto item);
        public Tdto GetById(int id);
        public List<Tdto> GetList();
        public void Delete(int id);
        public Tdto Update(Tdto item);

    }
}
