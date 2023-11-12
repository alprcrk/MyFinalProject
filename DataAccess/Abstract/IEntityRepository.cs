using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // Genel IEntityRepository arayüzü, temel CRUD operasyonlarını içerir.
    // Bu operasyonlar, genellikle veritabanı işlemlerini yöneten sınıflar tarafından uygulanır.
    // generic constraint
    // class : referans tip
    // IEntity : IEntity olabilir vey IEntity implemente eden bir nesne olabilir
    public interface IEntityRepository<T> where T : class, IEntity
    {
        // Belirli bir filtreye sahip tüm öğeleri getiren metod
        // Filtre, isteğe bağlı olarak sağlanabilir; filtre sağlanmazsa tüm öğeleri getirir.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        // Belirli bir filtreye sahip ilk öğeyi getiren metod
        // Bu metod genellikle bir öğeyi detaylı olarak getirmek için kullanılır.
        T Get(Expression<Func<T, bool>> filter);

        // Yeni bir öğe ekleyen metod
        void Add(T entity);

        // Var olan bir öğeyi güncelleyen metod
        void Update(T entity);

        // Var olan bir öğeyi silen metod
        void Delete(T entity);
    }
}
