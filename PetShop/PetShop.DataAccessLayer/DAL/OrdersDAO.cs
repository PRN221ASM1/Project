using Microsoft.EntityFrameworkCore;
using PetShop.DataAccessLayer.DAL.Interface;
using PetShop.DataAccessLayer.Models;

namespace PetShop.DataAccessLayer.DAL
{
    public class OrdersDAO :IEntityDao<Order>
    {
        private readonly DbContext _context;
        public OrdersDAO(DbContext context)
        {
            _context = context;
        }

        public bool Delete(Order entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAll(IList<Order> entities)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Order> GetAlls()
        {
            throw new NotImplementedException();
        }

        public Order GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Order entity)
        {
            throw new NotImplementedException();
        }
    }
}
