using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // Başarı durumu ve mesaj ile bir sonucu temsil eden constructor.
        public Result(bool success, string message) : this(success)
        {
            Message = message;
        }

        // Sadece başarı durumu ile bir sonucu temsil eden constructor.
        public Result(bool success)
        {
            Success = success;
        }

        // Sonucun başarı durumunu temsil eden özellik.
        public bool Success { get; }

        // Sonucun taşıdığı mesajı temsil eden özellik.
        public string Message { get; }
    }
    /*
    Result(bool success, string message): Başarı durumu ve mesaj ile bir sonucu temsil eder.
    Result(bool success): Sadece başarı durumu ile bir sonucu temsil eder.
    bool Success: Sonucun başarı durumunu temsil eden bir özelliktir.
    string Message: Sonucun taşıdığı mesajı temsil eden bir özelliktir. Mesaj olmayabilir (null olabilir).
     */
}
