using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    static void Main(string[] args)
    {
        //ProductTest();
        //Ioc
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        // ProductManager sınıfından bir örnek oluşturarak, veri erişim operasyonlarını yöneten bir yönetici nesnesi oluşturulur.
        // EfProductDal, Entity Framework kullanarak veri erişim işlemlerini gerçekleştiren bir sınıftır.
        ProductManager productManager = new ProductManager(new EfProductDal());

        // ProductManager sınıfının GetAll metodu çağrılarak, tüm ürünleri getiren bir liste elde edilir.
        foreach (var product in productManager.GetProductDetails())
        {
            // Her bir ürünün adı ekrana yazdırılır.
            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        }
    }
}
