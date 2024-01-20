using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    // Kategori işlemlerini gerçekleştiren CategoryManager sınıfı
    public class CategoryManager : ICategoryService
    {
        // Kategori verilerine erişimi sağlayan veri erişim sınıfı
        private ICategoryDal _categoryDal;

        // Dependency injection kullanılarak bir ICategoryDal implementasyonu enjekte edilir
        public CategoryManager(ICategoryDal categoryDal)
        {
            // Oluşturulan CategoryManager sınıfının bir örneği oluşturulurken, bir ICategoryDal implementasyonu alınır.
            // Bu sayede CategoryManager sınıfı, veritabanı işlemlerini gerçekleştirebileceği bir veri erişim sınıfına sahip olur.
            _categoryDal = categoryDal;
        }

        // Tüm kategorileri getirme işlemi
        public IDataResult< List<Category>> GetAll()
        {
            // Veritabanından tüm kategorileri çekme işlemi
            // _categoryDal.GetAll() metodu, ICategoryDal implementasyonuna bağlı olarak, kategorilerin veritabanından çekilmesini sağlar.
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        // Belirli bir kategori ID'sine sahip kategoriyi getirme işlemi
        public IDataResult<Category> GetById(int categoryId)
        {
            // Veritabanından belirli bir kategori ID'sine sahip kategoriyi çekme işlemi
            // _categoryDal.Get() metodu, ICategoryDal implementasyonuna bağlı olarak, belirli bir kategori ID'sine sahip kategorinin veritabanından çekilmesini sağlar.
            return new SuccessDataResult<Category> (_categoryDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
