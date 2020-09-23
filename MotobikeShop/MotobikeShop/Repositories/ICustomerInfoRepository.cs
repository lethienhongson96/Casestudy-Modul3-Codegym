using MotobikeShop.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Repositories
{
    public interface ICustomerInfoRepository
    {
        int CreateInfoCustomer(InfoCustomer infoCustomer);

        InfoCustomer GetInfoCustomerById(int id);
    }
}
