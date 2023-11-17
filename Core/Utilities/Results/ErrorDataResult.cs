using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        // Hata mesajı ve veri ile başarısız bir sonucu temsil eden constructor.
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }

        // Hata mesajı ve veri olmadan başarısız bir sonucu temsil eden constructor.
        public ErrorDataResult(T data) : base(data, false)
        {
        }

        // Hata mesajı ile başarısız bir sonucu temsil eden constructor (veri olmadan).
        public ErrorDataResult(string message) : base(default, false, message)
        {
        }

        // Başarısız bir sonucu temsil eder (ne veri ne de mesaj).
        public ErrorDataResult() : base(default, false)
        {
        }
    }
}

