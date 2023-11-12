using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    // IEntity arayüzünü uygulayan Customer sınıfı.
    public class Customer : IEntity
    {
        // Müşterinin benzersiz kimliğini temsil eden özellik.
        public string CustomerId { get; set; }

        // Müşterinin iletişim kişisinin adını temsil eden özellik.
        public string ContactName { get; set; }

        // Müşterinin şirket adını temsil eden özellik.
        public string CompanyName { get; set; }

        // Müşterinin bulunduğu şehiri temsil eden özellik.
        public string City { get; set; }
    }
    // Yukarıdaki kod, Entities.Concrete ad alanında Customer adında bir sınıf tanımlar.

    // Customer sınıfı dört özelliğe sahiptir:
    // 1. CustomerId: Müşterinin benzersiz kimliğini temsil eder.
    // 2. ContactName: Müşterinin iletişim kişisinin adını temsil eder.
    // 3. CompanyName: Müşterinin şirket adını temsil eder.
    // 4. City: Müşterinin bulunduğu şehri temsil eder.

    // Bu özelliklerin her biri, değerlerini okumanıza ve değiştirmenize izin veren genel erişimciler (get ve set) içerir.

    // Not: IEntity arayüzü geçerli, ancak bu kod parçasında tanımı sağlanmamıştır.
    // IEntity'nin tanımının kodun başka bir yerinde yapıldığı varsayılır.

    // Bu sınıf, her biri benzersiz bir kimlik, iletişim adı, şirket adı ve şehir bilgisi içeren müşteri örnekleri oluşturmak için kullanılabilir.
    // Özellikler genel olduğundan, diğer kod parçalarından erişilebilir ve değiştirilebilir.
}
