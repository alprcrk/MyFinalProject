using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {
        // Başarılı bir sonucu temsil eden constructor.
        public SuccessResult(string message) : base(true, message)
        {
        }

        // Sadece başarılı bir sonucu temsil eden constructor (mesaj olmadan).
        public SuccessResult() : base(true)
        {
        }
    }
    /*
        SuccessResult(string message): Başarılı bir sonucu temsil eden constructor. Ayrıca, başarı durumu ile birlikte bir mesajı içerir.
        SuccessResult(): Sadece başarılı bir sonucu temsil eden constructor. Mesaj içermez.
     */
}
