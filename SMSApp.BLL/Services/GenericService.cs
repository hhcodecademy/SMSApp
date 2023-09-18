using AutoMapper;
using SMSApp.BLL.Services.Interfaces;
using SMSApp.DAL.Models;
using SMSApp.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSApp.BLL.Services
{
    public class GenericService<Tdto, Tentity> : IGenericService<Tdto, Tentity> where Tdto : class where Tentity : BaseEntity,new ()
    {
        private readonly IGenericRepository<Tentity> _genericRepository;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<Tentity> genericRepository, IMapper mapper)
        {
            _genericRepository = genericRepository;
            _mapper = mapper;
        }

        public Tdto Create(Tdto item)
        {
            Tentity entity = _mapper.Map<Tentity>(item);
            Tentity dbEntity =  _genericRepository.Create(entity);
            return _mapper.Map<Tdto>(dbEntity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Tdto GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Tdto> GetList()
        {
            throw new NotImplementedException();
        }

        public Tdto Update(Tdto item)
        {
            throw new NotImplementedException();
        }
    }
}
