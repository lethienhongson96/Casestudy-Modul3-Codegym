using Microsoft.AspNetCore.Http;
using MotobikeShop.Models.Entities;
using MotobikeShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.Repositories
{
    public interface IProductRepository
    {
        int CreateProduct(CreateProductView productView);

        string UploadedFile(IFormFile formFile);

        List<Product> ProductList { get; }

        int DeleteProduct(int id);

        EditProductView FindProductToView(int id);

        int UpdateProduct(EditProductView productView);

        List<ReStoreView> GetInActiveProducts();

        int RestoreProducts(List<ReStoreView> reStoreCategoryViews);
    }
}
