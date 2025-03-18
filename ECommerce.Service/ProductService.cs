using ECommerce.Core;
using ECommerce.Core.Entities;
using ECommerce.Core.Services.Contracts;
using ECommerce.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IReadOnlyList<Product>> GetProductsAsync(ProductSpecParams productSpec)
        {
            var spec = new ProductWithBrandAndCategorySpecification(productSpec);
            var products = await _unitOfWork.Repository<Product>().GetAllWithSpecAsync(spec);
            return products; 
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var spec = new ProductWithBrandAndCategorySpecification(id);
            var product = await _unitOfWork.Repository<Product>().GetWithSpecAsync(spec);
            return product;

        }

        public Task<IReadOnlyList<ProductCategory>> GetProductCategoriesAsync()
        {
            var categories = _unitOfWork.Repository<ProductCategory>().GetAllAsync();
            return categories;
        }

        public Task<IReadOnlyList<ProductBrand>> GetProductBrandsAsync()
        {
            var brands = _unitOfWork.Repository<ProductBrand>().GetAllAsync();
            return brands;
        }
    }
}
