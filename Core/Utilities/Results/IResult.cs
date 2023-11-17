using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        // İşlem başarılı mı başarısız mı? Bu bilgiyi taşıyan özellik.
        bool Success { get; }

        // İşlemle ilgili bir mesajı taşıyan özellik.
        string Message { get; }
    }
    /*
    Bu arayüz, genellikle işlemlerin sonuçlarını temsil etmek için kullanılır.
    Success özelliği, bir işlemin başarılı olup olmadığını belirtir (true ise başarılı, false ise başarısız).
    Message özelliği, işlemle ilgili herhangi bir bilgiyi içerir ve işlem başarılı olsa bile bu bilgi boş olabilir.
    Bu arayüzü implemente eden sınıflar, işlemlerin sonuçlarıyla ilgili bilgileri taşıyabilirler.
     */
}