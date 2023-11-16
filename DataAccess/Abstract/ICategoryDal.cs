using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // ICategoryDal arayüzü, Category türündeki varlıklar için temel CRUD operasyonlarını içerir.
    // Ayrıca, belirli bir kategoriye ait olan tüm varlıkları getiren özel bir metod içerir.
    //public interface ICategoryDal
    
    public interface ICategoryDal:IEntityRepository<Category> //GÜNCEL
    {

        //---------------------------------ESKİ KOD BLOĞU
        //// Tüm kategorileri getiren metod
        //List<Category> GetAll();

        //// Yeni bir kategori ekleyen metod
        //void Add(Category category);

        //// Var olan bir kategoriyi güncelleyen metod
        //void Update(Category category);

        //// Var olan bir kategoriyi silen metod
        //void Delete(Category category);

        //// Belirli bir kategoriye ait tüm varlıkları getiren özel metod
        //List<Category> GetAllByCategory(int categoryId);
    }
}
