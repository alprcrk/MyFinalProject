using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            //IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            // NorthwindContext sınıfından bir örnek oluşturarak veritabanı bağlantısını başlatır.
            using (NorthwindContext context = new NorthwindContext())
            {
                // Eğer filtre belirtilmemişse, tüm ürünleri getir.
                // Aksi takdirde, filtreleme kriterlerine uyan ürünleri getir.
                return filter == null
                    ? context.Set<Product>().ToList() // Filtre yoksa, tüm ürünleri getir.
                    : context.Set<Product>().Where(filter).ToList(); // Filtre varsa, belirtilen kriterlere uyan ürünleri getir.
            }
        }
        // Yukarıdaki kod, Product tipindeki nesneleri veritabanından çekmek için kullanılan bir metodu tanımlar.

        // Bu metodun parametresi, isteğe bağlı bir filtre ifadesini kabul eder.
        // Filtre belirtilirse, sadece belirtilen kriterlere uyan ürünleri getirir; aksi takdirde, tüm ürünleri getirir.


        public void Update(Product entity)
        {
            // NorthwindContext sınıfından bir örnek oluşturarak veritabanı bağlantısını başlatır.
            using (NorthwindContext context = new NorthwindContext())
            {
                // Veritabanındaki var olan bir varlık üzerinde güncelleme yapılacaksa, varlığı takip eden nesneyi alır.
                var updatedEntity = context.Entry(entity);

                // EntityState.Modified, varlığın değiştirildiğini belirten bir durumu temsil eder.
                // Bu, varlığın veritabanındaki karşılığının güncellenmesi gerektiğini gösterir.
                updatedEntity.State = EntityState.Modified;

                // Değişiklikleri veritabanına kaydet.
                context.SaveChanges();
            }
        }
        // Yukarıdaki kod, Product tipindeki bir varlığın güncellenmesi için kullanılan bir metodu tanımlar.
        // Bu metodun parametresi, güncellenecek Product tipindeki bir varlığı kabul eder.


    }
}
