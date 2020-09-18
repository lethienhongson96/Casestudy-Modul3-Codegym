using MotobikeShop.Models.Entities;
using MotobikeShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Repositories
{
    public interface ICategoryRepository
    {
        int CreateCategory(Category category);

        List<Category> Categories { get; }

        Category GetCategoryById(int id);

        int UpdateCategory(Category category);

        int DeleteCategory(int id);

        int RemoveProduct(int id);

        List<Product> GetProductsByCategoryId(int id);

        List<ReStoreView> GetInActiveCategories();

         int RestoreCategories(List<ReStoreView> reStoreCategoryViews);
    }
}
