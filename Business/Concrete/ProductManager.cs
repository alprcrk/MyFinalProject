using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            //Yetkisi var mı?
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            // _productDal, Product türündeki nesnelerle ilgili veri erişim işlemlerini sağlayan bir sınıfın örneğidir.
            // GetAll metodu, tüm ürünleri getirmek için kullanılan bir metottur.
            // Bu metot, isteğe bağlı bir filtreleme kriteri içerebilir.

            // GetAllByCategoryId metodu, verilen kategori kimliğine sahip ürünleri getirmek için kullanılır.
            // LINQ ifadesi kullanılarak, ürünlerin CategoryId özelliği ile belirtilen kategori kimliği eşleştirilir.

            // Örneğin, eğer id değeri 1 ise, sadece CategoryId'si 1 olan ürünleri getirir.
            // Ayrıca, GetAll metodu, Product tipindeki nesnelerin veritabanından çekilmesini sağlar ve bir filtre ifadesi içerebilir.

            // İlgili filtre ifadesi, CategoryId özelliğinin, belirtilen id değerine eşit olduğu durumu kontrol eder.
            // Bu sayede, sadece belirli bir kategoriye ait ürünlerin listesi elde edilir.

            // Son olarak, bu filtreleme kriterine uyan ürünlerin listesi döndürülür.
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            // GetByUnitPrice metodu, belirli bir birim fiyat aralığına sahip ürünleri getirmek için kullanılır.
            // LINQ ifadesi kullanılarak, ürünlerin UnitPrice özelliği, belirtilen min ve max değerleri arasında olup olmadığı kontrol edilir.
            // Örneğin, eğer min değeri 50, max değeri 100 ise, ürünlerin birim fiyatları 50 ile 100 arasında olanları getirir.
            // İlgili filtre ifadesi, UnitPrice özelliğinin, belirtilen min ve max değerleri arasında olup olmadığını kontrol eder.
            // Bu sayede, belirli bir birim fiyat aralığına sahip ürünlerin listesi elde edilir.

            // Son olarak, bu filtreleme kriterine uyan ürünlerin listesi döndürülür.
            return _productDal.GetAll(p => p.UnitPrice>=min && p.UnitPrice<=max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
