using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        // 1. Tüm ürünleri getirir.
        //    Geri dönüş tipi: IDataResult<List<Product>>
        IDataResult<List<Product>> GetAll();

        // 2. Belirli bir kategoriye ait tüm ürünleri getirir.
        //    Parametre: Kategori ID'si (int id)
        //    Geri dönüş tipi: IDataResult<List<Product>>
        IDataResult<List<Product>> GetAllByCategoryId(int id);

        // 3. Belirli bir fiyat aralığına göre ürünleri getirir.
        //    Parametreler: Minimum fiyat (decimal min), Maksimum fiyat (decimal max)
        //    Geri dönüş tipi: IDataResult<List<Product>>
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);

        // 4. Ürün detaylarını içeren özel bir DTO listesini getirir.
        //    Geri dönüş tipi: IDataResult<List<ProductDetailDto>>
        IDataResult<List<ProductDetailDto>> GetProductDetails();

        // 5. Belirli bir ürün ID'sine sahip ürünü getirir.
        //    Parametre: Ürün ID'si (int productId)
        //    Geri dönüş tipi: IDataResult<Product>
        IDataResult<Product> GetById(int productId);

        // 6. Yeni bir ürün ekler.
        //    Parametre: Eklenen ürün (Product product)
        //    Geri dönüş tipi: IResult
        IResult Add(Product product);
    }
}


