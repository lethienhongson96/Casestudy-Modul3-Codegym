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

                Products.ForEach(el => el.Status = Enums.Status.InActive);
                context.UpdateRange(Products);

                category.Status = Enums.Status.InActive;
                context.Update(category);

                return context.SaveChanges();
            }
            return -1;
        }

        /// <summary>
        /// Get list categories with Status = Active
        /// </summary>
        public List<Category> Categories => context.Categories.ToList().FindAll(el => el.Status == Enums.Status.Active);

        public Category GetCategoryById(int id) => context.Categories.ToList().Find(el => el.Id == id);


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

        public int RemoveProduct(int id)
        {
            Product product = context.Products.FirstOrDefault(el => el.Id == id);

            if (product != null)
            {
                product.Status = Enums.Status.InActive;
                return context.SaveChanges();
            }
            return -1;
        }

        /// <summary>
        /// Get List Active Products by CategoryId 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<Product> GetProductsByCategoryId(int id) =>
            context.Products.ToList().FindAll(el => el.CategoryId == id && el.Status == Enums.Status.Active);

        public List<ReStoreCategoryView> GetInActiveCategories()
        {
            List<Category> InActivecategories = context.Categories.ToList().FindAll(el => el.Status == Enums.Status.InActive);
            List<ReStoreCategoryView> reStoreCategoryViews = new List<ReStoreCategoryView>();

            foreach (var item in InActivecategories)
            {
                var reStoreCategoryView = new ReStoreCategoryView()
                {
                    Id = item.Id,
                    Name = item.Name,
                };
                reStoreCategoryViews.Add(reStoreCategoryView);
            }
            return reStoreCategoryViews;
        }

        public int RestoreCategories(List<ReStoreCategoryView> reStoreCategoryViews)
        {
            List<Category> Categories = new List<Category>();
            foreach (var item in reStoreCategoryViews)
                if (item.IsRestore)
                {
                    var category = context.Categories.FirstOrDefault(el => el.Id == item.Id);
                    category.Status = Enums.Status.Active;
                    Categories.Add(category);

                    context.Products.ToList().FindAll(el =>
                        el.CategoryId == category.Id).ForEach(el => el.Status = Enums.Status.Active);
                }
            context.UpdateRange(Categories);

            return Task.Run(async () => await context.SaveChangesAsync()).Result;
        }
    }
}
