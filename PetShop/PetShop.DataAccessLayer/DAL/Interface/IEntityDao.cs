using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.DataAccessLayer.DAL.Interface
{
    public interface IEntityDao<T>
    {
        T GetById(int id);
        IList<T> GetAlls();
        bool DeleteById(int id);
        bool Delete(T entity);
        bool DeleteAll(IList<T> entities);
        bool Update(T entity);
    }
}
