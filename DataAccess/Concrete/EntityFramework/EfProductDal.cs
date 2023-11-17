using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    // Entity Framework ile çalışacak ProductDal sınıfı
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        // IProductDal'dan miras alınan ve özel bir sorguyu gerçekleştiren metod
        public List<ProductDetailDto> GetProductDetails()
        {
            // Context oluşturuluyor (IDisposable nesne olduğu için 'using' bloğu içinde kullanılır)
            using (NorthwindContext context = new NorthwindContext())
            {
                // LINQ sorgusu ile ürün detaylarını çeken sorgu
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };

                // Sorgu sonucunu liste olarak döndürme
                return result.ToList();
            }
            /*
                Bu sınıf, EfEntityRepositoryBase sınıfını kullanarak genel CRUD operasyonlarını gerçekleştirir.
                Ayrıca IProductDal arayüzünden türemiş ve özel bir işlem olan GetProductDetails metodunu implement etmiştir.
                Bu metod, Product ve Category tablolarını kullanarak birleştirilmiş bir DTO olan ProductDetailDto nesnesini oluşturarak, ürün detaylarını getirir.
                Bu sınıfın EfEntityRepositoryBase sınıfını kullanarak genel CRUD operasyonlarını gerçekleştirmesi,
                kodun tekrarını önler ve veritabanı işlemlerini yönetmeyi kolaylaştırır.
             */
        }
    }
}

