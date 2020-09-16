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
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private const string ProductImageDefault = "default_product_image.png";

        public ProductRepository(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
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
                Status = productView.Status,
                CategoryId = productView.CategoryId
            };
            if (productView.IformfilePath != null)
                product.ImagePath = UploadedFile(productView.IformfilePath);

            _context.Products.Add(product);

            return (_context.SaveChanges());
        }

        public int DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(el => el.Id == id);

            if (product != null)
            {
                if (!string.IsNullOrEmpty(product.ImagePath) && product.ImagePath != ProductImageDefault)
                {
                    string DelPath = Path.Combine(_webHostEnvironment.WebRootPath, "Images/ProductImages", product.ImagePath);
                    File.Delete(DelPath);
                }
                _context.Products.Remove(product);

                return _context.SaveChanges();
            }
            return -1;
        }

        public EditProductView FindProductToView(int id)
        {
            var product = _context.Products.FirstOrDefault(el => el.Id == id);

            var productview = new EditProductView()
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.PricePerUnit,
                CreateAt = product.CreateAt,
                CreateBy = product.CreateBy,
                Status = product.Status,
                CategoryId = product.CategoryId,
                ImgPath = product.ImagePath
            };

            return productview;
        }

        public List<Product> GetProductList()
        {
            return _context.Products.ToList();
        }

        public int UpdateProduct(EditProductView productView)
        {
            var product = _context.Products.FirstOrDefault(el => el.Id == productView.Id);

            product.Name = productView.Name;
            product.CategoryId = productView.CategoryId;
            product.CreateAt = productView.CreateAt;
            product.CreateBy = productView.CreateBy;
            product.PricePerUnit = productView.Price;
            product.Status = productView.Status;

            if (productView.IformfilePath != null)
            {
                product.ImagePath = UploadedFile(productView.IformfilePath);

                if (!string.IsNullOrEmpty(productView.ImgPath) && productView.ImgPath != ProductImageDefault)
                {
                    string DelPath = Path.Combine(_webHostEnvironment.WebRootPath, "Images/ProductImages", productView.ImgPath);
                    File.Delete(DelPath);
                }
            }

            _context.Update(product);
            return (_context.SaveChanges());
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
    }
}
