using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorResult : Result
    {
        // Hata mesajı ile başarısız bir sonucu temsil eden constructor.
        public ErrorResult(string message) : base(false, message)
        {
        }

        // Sadece başarısız bir sonucu temsil eden constructor (mesaj olmadan).
        public ErrorResult() : base(false)
        {
        }
    }
}