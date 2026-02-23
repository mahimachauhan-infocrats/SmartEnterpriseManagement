using SmartEnterprise.Repository.Repo;
using SmartEnterprise_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterprise.Services.Service
{
    public class BaseService<T> where T : BaseEntity
    {
        protected readonly Repository<T> _repository = new Repository<T>();
        private int _currentId = 1;

        public void Add(T entity)
        {
            entity.Id = _currentId++;
            _repository.Add(entity);
        }

        public List<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(T entity)
        {
            _repository.Update(entity);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }
    }
}
