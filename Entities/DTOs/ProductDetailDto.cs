using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    // Veri transfer nesnesi (DTO) olarak kullanılan ProductDetailDto sınıfı
    public class ProductDetailDto : IDto
    {
        // Ürün ID'si
        public int ProductId { get; set; }

        // Ürün adı
        public string ProductName { get; set; }

        // Ürünün ait olduğu kategori adı
        public string CategoryName { get; set; }

        // Ürün stok adedi
        public short UnitsInStock { get; set; }
    }
}
