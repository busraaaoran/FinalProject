using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal() //consturctor bellekte referans alındığı zaman çalışan bloktur.
        {
            //oracle,sql,postreSql,mongoDb gibi bir simülasyon yapıyoruz.
            _products = new List<Product>
            {
            new Product{CategoryID = 1,ProductID = 1,ProductName = "Bardak",UnitPrice = 15, UnitsInStock = 15},
            new Product { CategoryID = 2, ProductID = 1, ProductName = "Kamera", UnitPrice = 500, UnitsInStock = 3 },
            new Product { CategoryID = 3, ProductID = 2, ProductName = "Telefon", UnitPrice = 1500, UnitsInStock = 2 },
            new Product { CategoryID = 4, ProductID = 2, ProductName = "Klavye", UnitPrice = 150, UnitsInStock = 65 },
            new Product { CategoryID = 5, ProductID = 2, ProductName = "Fare", UnitPrice = 85, UnitsInStock = 1 }

            };

        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ olmadan delete yapmak için döngü kullanmak gerek.
            //Product ProductToDelete = null;

            //foreach (var p in _products)
            //{
            //    if(product.ProductID == p.ProductID)
            //    {
            //        ProductToDelete = p;
            //    }

            //}
            //LINQ = language integrated query 
            // aşağıdaki tek satır yukarıdaki foreach ile aynı işlevde
            //p=> demek her p için demek foreachiç parentez içi gibi
            Product ProductToDelete = _products.SingleOrDefault(p =>p.ProductID==product.ProductID);

            _products.Remove(ProductToDelete);

            
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product ProductToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            ProductToUpdate.ProductName = product.ProductName;
            ProductToUpdate.UnitPrice = product.UnitPrice;
            ProductToUpdate.UnitsInStock = product.UnitsInStock;
            ProductToUpdate.CategoryID = product.CategoryID;

        }
    }
}
