﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        // Ürün başarıyla eklendi mesajı
        public static string ProductAdded = "Ürün eklendi";
        // Ürün ismi geçersiz mesajı
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        // Sistem bakımda mesajı
        public static string MaintenanceTime = "Sistem Bakımda";
        // Ürün başarıyla listelendi mesajı
        public static string ProductsListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Bir kategoride en fazla 10 ürün olabilir";
        public static string ProductNameAlreadyExists = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor ";
    }
}

