using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        // Ürün testi yapılacaksa
        //ProductTest();

        // Kategori testi yapılacaksa
        CategoryTest();
    }

    private static void CategoryTest()
    {
        // EfCategoryDal, Entity Framework kullanarak kategori verilerine erişim sağlayan bir sınıftır.
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

        // Tüm kategorileri getirme işlemi
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        // EfProductDal, Entity Framework kullanarak ürün verilerine erişim sağlayan bir sınıftır.
        ProductManager productManager = new ProductManager(new EfProductDal());

        // Ürün detaylarını getirme işlemi
        var result = productManager.GetProductDetails();

        // İşlem başarılıysa
        if (result.Success == true)
        {
            // Her bir ürün detayını ekrana yazdırma işlemi
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }
        // İşlem başarısızsa
        else
        {
            // Hata mesajını ekrana yazdırma işlemi
            Console.WriteLine(result.Message);
        }
    }
}
