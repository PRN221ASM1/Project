using Microsoft.EntityFrameworkCore;
using PetShop.DataAccessLayer.DAL;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BusinessLogicLayer.BLL
{
    public class AccountsBLL
    {
        private readonly AccountsDAO _accountsDAO;
        public AccountsBLL(DbContext context)
        {
            _accountsDAO = new AccountsDAO(context);
        }
    }
}
