using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Product{ProductId=1,CategoryId=1,ProductName="bardak",UnitPrice=15, UnitInStock=15},
                new Product{ProductId=2,CategoryId=2,ProductName="kamera",UnitPrice=1500, UnitInStock=8},
                new Product{ProductId=3,CategoryId=2,ProductName="telefon",UnitPrice=3500, UnitInStock=20},
                new Product{ProductId=4,CategoryId=2,ProductName="harddisk",UnitPrice=500, UnitInStock=4},
                new Product{ProductId=5,CategoryId=1,ProductName="sürahi",UnitPrice=50, UnitInStock=150}
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

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(x => x.CategoryId==categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);            
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitInStock= product.UnitInStock;
            productToUpdate.CategoryId= product.CategoryId;
        }
    }
}
