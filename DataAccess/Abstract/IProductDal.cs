using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // IProductDal arayüzü, IEntityRepository<Product> arayüzünü uygular.
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
// Yukarıdaki kod, DataAccess.Abstract ad alanında IProductDal adında bir arayüz tanımlar.

// IProductDal arayüzü, IEntityRepository<Product> arayüzünü uygular.
// Bu, IProductDal'ın, Product tipi için temel veri erişim işlevlerini içeren bir arayüz olduğunu gösterir.
// IEntityRepository<Product>, genellikle veritabanı işlemleri gibi genel veri erişim operasyonlarını tanımlayan bir arayüzdür.

// Bu arayüz, Product tipindeki nesnelerle ilgili veritabanı işlemlerini gerçekleştirmek üzere kullanılabilir.
// Örneğin, Product tipindeki nesnelerin ekleme, güncelleme, silme ve sorgulama gibi işlemleri içerebilir.

// Not: Product tipinin tanımı bu kod parçasında bulunmamıştır. Product tipinin IEntity arayüzünü uyguladığı ve gerekli özelliklere sahip olduğu varsayılır.

// Bu arayüzü implemente eden sınıflar, Product tipindeki nesnelerle çalışan veri erişim katmanını sağlamak üzere tasarlanmalıdır.

