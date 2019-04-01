using System.Collections.Generic;
using System.Linq;
using DellChallenge.D1.Api.Dto;

namespace DellChallenge.D1.Api.Dal
{
    public class ProductsService : IProductsService
    {
        private readonly ProductsContext _context;

        public ProductsService(ProductsContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductDto> GetAll()
        {
            return _context.Products.Select(p => MapToDto(p));
        }

        public ProductDto Add(NewProductDto newProduct)
        {
            var product = MapToData(newProduct);
            _context.Products.Add(product);
            _context.SaveChanges();
            var addedDto = MapToDto(product);
            return addedDto;
        }

        public ProductDto Delete(string id)
        {
            Product prod = _context.Products.Where(w => w.Id == id).FirstOrDefault();
            if (prod != null)
            {
                _context.Products.Remove(prod);
                _context.SaveChanges();
                var deleted = MapToDto(prod);
                return deleted;
            }
            return null;
        }

        public ProductDto Get(string id)
        {
            return MapToDto(_context.Products.Find(id));
        }

        public ProductDto Put(ProductDto product)
        {
            Product p = _context.Products.Find(product.Id);
            if(p == null)
            {
                Product newProd = MapToData(product);
                _context.Products.Add(newProd);
                _context.SaveChanges();
                return MapToDto(newProd);
            }
            else
            {
                p.Name = product.Name;
                p.Category = product.Category;
                _context.Products.Update(p);
                _context.SaveChanges();
                return MapToDto(p);
            }
        }

        private Product MapToData(NewProductDto newProduct)
        {
            return new Product
            {
                Category = newProduct.Category,
                Name = newProduct.Name
            };
        }

        private ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Category = product.Category
            };
        }
    }
}
