using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Ürün işlemlerini gerçekleştiren ProductManager sınıfı
    public class ProductManager : IProductService
    {
        // Ürün verilerine erişimi sağlayan veri erişim sınıfı
        private IProductDal _productDal;

        // Dependency injection kullanılarak bir IProductDal implementasyonu enjekte edilir
        public ProductManager(IProductDal productDal)
        {
            // Oluşturulan ProductManager sınıfının bir örneği oluşturulurken, bir IProductDal implementasyonu alınır.
            // Bu sayede ProductManager sınıfı, veritabanı işlemlerini gerçekleştirebileceği bir veri erişim sınıfına sahip olur.
            _productDal = productDal;
        }

        // Ürün ekleme işlemi
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            _productDal.Add(product);

            // Başarılı sonuç döndürülüyor
            return new SuccessResult(Messages.ProductAdded);
        }

        // Tüm ürünleri getirme işlemi
        public IDataResult<List<Product>> GetAll()
        {
            // Saat 22:00-23:00 arasında bakım yapılıyorsa hata sonucu döndürülüyor
            if (DateTime.Now.Hour == 14)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }

            // Tüm ürünleri başarılı bir şekilde getirme işlemi
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        // Belirli bir kategoriye ait tüm ürünleri getirme işlemi
        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            // İlgili kategoriye ait ürünleri başarılı bir şekilde getirme işlemi
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        // Belirli bir ürün ID'sine sahip ürünü getirme işlemi
        public IDataResult<Product> GetById(int productId)
        {
            // Belirli bir ürün ID'sine sahip ürünü başarılı bir şekilde getirme işlemi
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        // Belirli bir birim fiyat aralığına sahip ürünleri getirme işlemi
        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            // Belirli bir birim fiyat aralığına sahip ürünleri başarılı bir şekilde getirme işlemi
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        // Ürün detaylarını içeren özel DTO listesini getirme işlemi
        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            // Ürün detaylarını içeren özel DTO listesini başarılı bir şekilde getirme işlemi
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
    }
}
