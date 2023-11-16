using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //Bu clasa diğer katmanlarda ulaşabilsin (public)
    //(DataAcces) ürünü ekleyecek (Business) ürünü kontrol edecek (ConsoleUI) ürünü gösterecek (Entities) 3 katmanıda kullanacak.
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
