using MotobikeShop.Models;
using MotobikeShop.Models.Entities;
using MotobikeShop.Models.ViewModels;
using MotobikeShop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.RepositoryImps
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext context;
        private const int DefaultCategoryId = 4;

        public CategoryRepository(AppDbContext context)
        {
            this.context = context;
        }

        public int CreateCategory(Category category)
        {
            context.Add(category);
            return (context.SaveChanges());
        }

        public int DeleteCategory(int id)
        {
            var category = context.Categories.FirstOrDefault(el => el.Id == id);

            if (category != null)
            {
                List<Product> Products = context.Products.ToList().FindAll(el => el.CategoryId == category.Id);

                Products.ForEach(el => el.CategoryId = DefaultCategoryId);
                context.UpdateRange(Products);

                context.Categories.Remove(category);

                return context.SaveChanges();
            }
            return -1;
        }

        public IEnumerable<Category> GetCategories()
        {
            return context.Categories.ToList();
        }

        public Category GetCategoryById(int id)
        {
            return context.Categories.ToList().Find(el => el.Id == id); 
        }

        public List<MoveDefaultView> GetListMoveDefaultViewByCateId(int id)
        {
            List<Product> products = context.Products.ToList().FindAll(el => el.CategoryId == id);
            List<MoveDefaultView> moveDefaultViewList = new List<MoveDefaultView>();

            foreach (var item in products)
            {
                MoveDefaultView moveDefaultView = new MoveDefaultView
                {
                    Id = item.Id,
                    Name = item.Name,
                    CategoryId = item.CategoryId
                };
                moveDefaultViewList.Add(moveDefaultView);
            }
            return moveDefaultViewList;
        }

        public Product GetProductById(int id)
        {
            return context.Products.FirstOrDefault(el => el.Id == id);
        }

        public int MoveCategoryForProduct(int id)
        {
            var product = context.Products.FirstOrDefault(el => el.Id == id);
            product.CategoryId = DefaultCategoryId;

            context.Update(product);

            return context.SaveChanges();
        }

        public int MoveRangeCategoryForProduct(List<Product> products)
        {
            context.UpdateRange(products);
            return context.SaveChanges();
        }

        public int UpdateCategory(Category category)
        {
            if (category == null)
                return -1;
            var FindCategory = GetCategoryById(category.Id);

            FindCategory.Name = category.Name;
            FindCategory.Status = category.Status;
            FindCategory.CreateAt = category.CreateAt;

            context.Update(FindCategory);
            return context.SaveChanges();
        }
    }
}
