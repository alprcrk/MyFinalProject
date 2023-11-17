using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        // Başarılı bir veri sonucu döndürmek için kullanılır.
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }

        // Başarılı bir veri sonucu döndürmek için kullanılır (mesaj olmadan).
        public SuccessDataResult(T data) : base(data, true)
        {
        }

        // Başarılı bir mesaj döndürmek için kullanılır (veri olmadan).
        public SuccessDataResult(string message) : base(default, true, message)
        {
        }

        // Başarılı bir sonucu temsil eder (ne veri ne de mesaj).
        public SuccessDataResult() : base(default, true)
        {
        }
    }
}
