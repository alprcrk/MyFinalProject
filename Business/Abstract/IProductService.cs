using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // IProductService, ürün işlemleri için temel işlevleri tanımlayan bir arayüzdür.
    public interface IProductService
    {
        // Tüm ürünleri getiren bir metot.
        List<Product> GetAll();

        // Belirli bir kategoriye ait ürünleri getiren bir metot.
        // Parametre olarak kategori kimliği (id) alır.
        List<Product> GetAllByCategoryId(int id);

        // Belirli bir fiyat aralığına ve birim fiyatına sahip ürünleri getiren bir metot.
        // Parametre olarak minimum ve maksimum birim fiyat değerlerini alır.
        List<Product> GetByUnitPrice(decimal min, decimal max);

        List<ProductDetailDto> GetProductDetails();
    }
}

