using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //IDisposable pattern implementation of c#
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }
        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext()) // Değişken
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            // TContext sınıfından bir örnek oluşturarak veritabanı bağlantısını başlatır.
            using (TContext context = new TContext())
            {
                // Eğer filtre belirtilmemişse, tüm ürünleri getir.
                // Aksi takdirde, filtreleme kriterlerine uyan ürünleri getir.
                return filter == null
                    ? context.Set<TEntity>().ToList() // Filtre yoksa, tüm ürünleri getir.
                    : context.Set<TEntity>().Where(filter).ToList(); // Filtre varsa, belirtilen kriterlere uyan ürünleri getir.
            }
        }
        // Yukarıdaki kod, TEntity tipindeki nesneleri veritabanından çekmek için kullanılan bir metodu tanımlar.

        // Bu metodun parametresi, isteğe bağlı bir filtre ifadesini kabul eder.
        // Filtre belirtilirse, sadece belirtilen kriterlere uyan ürünleri getirir; aksi takdirde, tüm ürünleri getirir.

        public void Update(TEntity entity)
        {
            // TContext sınıfından bir örnek oluşturarak veritabanı bağlantısını başlatır.
            using (TContext context = new TContext())
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
        // Yukarıdaki kod, TEntity tipindeki bir varlığın güncellenmesi için kullanılan bir metodu tanımlar.
        // Bu metodun parametresi, güncellenecek TEntity tipindeki bir varlığı kabul eder.
    }
}
