using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal

    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="bardak",UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2,CategoryId=2,ProductName="kamera",UnitPrice=1500, UnitsInStock=8},
                new Product{ProductId=3,CategoryId=2,ProductName="telefon",UnitPrice=3500, UnitsInStock=20},
                new Product{ProductId=4,CategoryId=2,ProductName="harddisk",UnitPrice=500, UnitsInStock=4},
                new Product{ProductId=5,CategoryId=1,ProductName="sürahi",UnitPrice=50, UnitsInStock=150}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(x=>x.ProductId==product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            return null;
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);            
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock= product.UnitsInStock;
            productToUpdate.CategoryId= product.CategoryId;
        }
    }
}
