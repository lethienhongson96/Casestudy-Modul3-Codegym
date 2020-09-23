using MotobikeShop.Models;
using MotobikeShop.Models.Entities;
using MotobikeShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.RepositoryImps
{
    public class CustomerRepository : ICustomerInfoRepository
    {
        private readonly AppDbContext context;

        public CustomerRepository(AppDbContext context)
        {
            this.context = context;
        }
        public int CreateInfoCustomer(InfoCustomer infoCustomer)
        {
            context.Add(infoCustomer);
            return context.SaveChanges();
        }

        public InfoCustomer GetInfoCustomerById(int id)
        {
            return context.InfoCustomers.FirstOrDefault(el=>el.Id==id);
        }
    }
}
