using MotobikeShop.Models;
using MotobikeShop.Models.Entities;
using MotobikeShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.RepositoryImps
{
    public class HomeRepository : IHomeRepository
    {
        private readonly AppDbContext context;

        public HomeRepository(AppDbContext context)
        {
            this.context = context;
        }
        public List<Category> GetCategories() =>
            context.Categories.ToList();

        public List<Product> GetProductsByCateId(int id) =>
            context.Products.ToList().FindAll(el => el.CategoryId == id);
    }
}
