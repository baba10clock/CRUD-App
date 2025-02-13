using System;
using CRUDApp.DatabaseContext;
using CRUDApp.Interfaces;
using CRUDApp.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDApp.Services
{
    public class ProductCatalogue : IProductCatalogue
    {
        private readonly CRUDAppDatabaseContext _context;

        public ProductCatalogue(CRUDAppDatabaseContext context) => _context = context;

        public async Task<List<Product>> GetAllAsync() => await _context.Products.ToListAsync();

        public async Task<Product?> GetByIdAsync(int id) => await _context.Products.FindAsync(id);

        public async Task AddAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(int id, Product product)
        {
            var existing = await _context.Products.FindAsync(id);
            if (existing is null)
                return false;
            existing.Name = product.Name;
            existing.Description = product.Description;
            existing.Price = product.Price;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product is null)
                return false;
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
