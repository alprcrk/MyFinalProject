using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        // Veri, başarı durumu ve mesaj ile bir veri sonucu oluşturulur.
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }

        // Sadece veri ve başarı durumu ile bir veri sonucu oluşturulur (mesaj olmadan).
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        // Veri sonucunun taşıdığı veriyi temsil eder.
        public T Data { get; }
    }
}