using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using MotobikeShop.Models;
using MotobikeShop.Models.Entities;
using MotobikeShop.Models.ViewModels;
using MotobikeShop.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MotobikeShop.RepositoryImps
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private const string ProductImageDefault = "default_product_image.png";

        public ProductRepository(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            this.context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public int CreateProduct(CreateProductView productView)
        {
            Product product = new Product()
            {
                Name = productView.Name,
                PricePerUnit = productView.Price,
                CreateAt = productView.CreateAt,
                CreateBy = productView.CreateBy,
                CategoryId = productView.CategoryId
            };
            if (productView.IformfilePath != null)
                product.ImagePath = UploadedFile(productView.IformfilePath);

            context.Products.Add(product);
            return (context.SaveChanges());
        }

        public int DeleteProduct(int id)
        {
            var product = context.Products.FirstOrDefault(el => el.Id == id);

            if (product != null)
            {
                product.Status = Enums.Status.InActive;
                context.Update(product);

                return context.SaveChanges();
            }
            return -1;
        }

        public EditProductView FindProductToView(int id)
        {
            var product = context.Products.FirstOrDefault(el => el.Id == id);

            var productview = new EditProductView()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.PricePerUnit,
                CreateAt = product.CreateAt,
                CreateBy = product.CreateBy,
                CategoryId = product.CategoryId,
                ImgPath = product.ImagePath
            };

            return productview;
        }

        public List<Product> ProductList => context.Products.ToList().FindAll(el => el.Status == Enums.Status.Active);

        public int UpdateProduct(EditProductView productView)
        {
            var product = context.Products.FirstOrDefault(el => el.Id == productView.Id);

            product.Name = productView.Name;
            product.CategoryId = productView.CategoryId;
            product.CreateAt = productView.CreateAt;
            product.CreateBy = productView.CreateBy;
            product.PricePerUnit = productView.Price;

            if (productView.IformfilePath != null)
            {
                product.ImagePath = UploadedFile(productView.IformfilePath);

                if (!string.IsNullOrEmpty(productView.ImgPath) && productView.ImgPath != ProductImageDefault)
                {
                    string DelPath = Path.Combine(_webHostEnvironment.WebRootPath, "Images/ProductImages", productView.ImgPath);
                    File.Delete(DelPath);
                }
            }
            context.Update(product);
            return (context.SaveChanges());
        }

        public string UploadedFile(IFormFile formFile)
        {
            string uniqueFileName = null;

            if (formFile != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "Images/ProductImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + formFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using var fileStream = new FileStream(filePath, FileMode.Create);
                formFile.CopyTo(fileStream);
            }
            return uniqueFileName;
        }

        public List<ReStoreView> GetInActiveProducts()
        {
            List<Product> InActiveProducts = context.Products.ToList().FindAll(el => el.Status == Enums.Status.InActive);
            List<ReStoreView> ReStoreViews = new List<ReStoreView>();

            foreach (var item in InActiveProducts)
            {
                var reStoreView = new ReStoreView()
                {
                    Id = item.Id,
                    Name = item.Name,
                };
                ReStoreViews.Add(reStoreView);
            }
            return ReStoreViews;
        }

        public int RestoreProducts(List<ReStoreView> ReStoreViews)
        {
            List<Product> products = new List<Product>();

            foreach (var item in ReStoreViews)
                if (item.IsRestore)
                {
                    Product product = context.Products.FirstOrDefault(el => el.Id == item.Id);
                    product.Status = Enums.Status.Active;
                    products.Add(product);
                }
            context.UpdateRange(products);

            return Task.Run(async () => await context.SaveChangesAsync()).Result;
        }
    }
}
