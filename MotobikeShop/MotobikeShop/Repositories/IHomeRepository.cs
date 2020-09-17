using MotobikeShop.Models.Entities;
using System.Collections.Generic;

namespace MotobikeShop.Repositories
{
    public interface IHomeRepository
    {
        List<Category> GetCategories();

        List<Product> GetProductsByCateId(int id);
    }
}
