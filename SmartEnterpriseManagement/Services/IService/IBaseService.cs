using SmartEnterprise_Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartEnterprise.Services.IService
{
    public interface IBaseService<T> where T : BaseEntity
    {
        void Add(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Delete(int id);
    }
}
