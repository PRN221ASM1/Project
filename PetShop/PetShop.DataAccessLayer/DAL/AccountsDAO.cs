using Microsoft.EntityFrameworkCore;
using PetShop.DataAccessLayer.DAL.Interface;
using PetShop.DataAccessLayer.Models;

namespace PetShop.DataAccessLayer.DAL
{
    public class AccountsDAO :IEntityDao<Account>
    {
        private readonly DbContext _context;
        public AccountsDAO(DbContext context)
        {
            _context = context;
        }

        public bool Delete(Account entity)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAll(IList<Account> entities)
        {
            throw new NotImplementedException();
        }

        public bool DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Account> GetAlls()
        {
            throw new NotImplementedException();
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Account entity)
        {
            throw new NotImplementedException();
        }
    }
}
