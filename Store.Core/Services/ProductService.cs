using Store.Core.Entities;
using Store.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Store.Core.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> Delete(int id)
        {
            await _unitOfWork.ProductRepository.Delete(id);
            await _unitOfWork.SaveChangesAsync();
            return true;
        }

        public async Task<Product> FindOne(int id)
        {
            return await _unitOfWork.ProductRepository.GetById(id);
        }

        public IEnumerable<Product> Find()
        {
            return _unitOfWork.ProductRepository.GetAll();
        }

        public async Task Add(Product product)
        {
            await _unitOfWork.ProductRepository.Add(product);
            await _unitOfWork.SaveChangesAsync();
        }

        public async Task<bool> Update(int id, Product product)
        {
            var productExist = await _unitOfWork.ProductRepository.GetById(id);

            productExist.Name = product.Name;
            productExist.Description = product.Description;
            productExist.AgeRestriction = product.AgeRestriction;
            productExist.Company = product.Company;
            productExist.Price = product.Price;

            await _unitOfWork.SaveChangesAsync();
            return true;
        }        
    }
}
