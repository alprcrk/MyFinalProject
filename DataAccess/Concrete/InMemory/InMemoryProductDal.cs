using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            //Oracle, Sql Server, Postgres, MongoDb
            _products = new List<Product>() {
                new Product() {ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product() {ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product() {ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product() {ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product() {ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ - Language Integrated Query
            //her dolaştığında ki -p- o elemana(-new Product()-) karışılık geliyor
            //Lambda p=>

            // _products isimli bir Product koleksiyonu olduğunu varsayalım.
            // Bu koleksiyonun içinde Product nesneleri bulunmaktadır.
            // productToDelete adında bir Product değişkeni tanımlanır.
            // Bu değişken, _products koleksiyonu içindeki belirli bir ürünü temsil edecektir.
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); 
            //SingleOrDefault - tek bir eleman bulmaya yarar                                                                                   
            // Yukarıdaki satır, _products koleksiyonundaki ürünler arasında gezinir ve                                                                                    
            // verilen koşula (p.ProductId == product.ProductId) uyan ilk ürünü seçer.                                                                                        
            // Eğer hiç ürün bulunmazsa, productToDelete değeri null olacaktır.
            // Burada SingleOrDefault metodu kullanılmıştır, bu da koleksiyon içinde 
            // yalnızca bir öğe bulunmasını beklediğimizi gösterir. 
            // Eğer bu koşulu sağlayan birden fazla ürün varsa ya da hiç ürün yoksa,
            // SingleOrDefault metodunun davranışı değişir ve ya hata fırlatır ya da null döner.
            _products.Remove(productToDelete); //DELETE
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            // Tüm ürünleri içeren koleksiyonu döndür
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            // Belirli bir kategori ID'sine sahip ürünleri filtreleyip bir liste olarak döndür
            // Where metodu, belirli bir koşulu sağlayan öğeleri seçmek için kullanılır.
            // Bu durumda, p.CategoryId, belirtilen categoryId ile eşleşen ürünleri seçecektir.
            // ToList metodu, LINQ sorgusunun sonucunu bir liste haline getirir.
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            // Gönderilen ürünün ID'sine sahip olan listedeki ürünü bul
            // SingleOrDefault metodu, koleksiyon içinde yalnızca bir öğe bulmasını bekler.
            // Eğer verilen ID'ye sahip birden fazla ürün varsa ya da hiç ürün yoksa,
            // SingleOrDefault metodunun davranışı değişir ve ya hata fırlatır ya da null döner.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;  
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

            //------------------
            // Bulunan ürün varsa, gönderilen ürünle güncelle
            //if (productToUpdate != null)
            //{
            //    // Ürün özelliklerini güncelle
            //    productToUpdate.ProductName = product.ProductName;
            //    productToUpdate.CategoryId = product.CategoryId;
            //    productToUpdate.UnitPrice = product.UnitPrice;
            //    productToUpdate.UnitsInStock = product.UnitsInStock;
            //}
            //else
            //{
            //    // Eğer ürün bulunamazsa, uygun bir işlem gerçekleştir (hata fırlatma, loglama vb.)
            //    // Örneğin:
            //    // throw new Exception("Güncellenmek istenen ürün bulunamadı.");
            //    // veya
            //    // Logger.LogError("Güncellenmek istenen ürün bulunamadı. ProductId: " + product.ProductId);
            //}
        }
    }
}
