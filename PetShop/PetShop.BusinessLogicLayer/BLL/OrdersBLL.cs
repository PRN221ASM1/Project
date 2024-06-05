using Microsoft.EntityFrameworkCore;
using PetShop.DataAccessLayer.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.BusinessLogicLayer.BLL
{
    public class OrdersBLL
    {
        private readonly OrdersDAO _ordersDAO;
        public OrdersBLL(DbContext context)
        {
            _ordersDAO = new OrdersDAO(context);
        }

    }
}
