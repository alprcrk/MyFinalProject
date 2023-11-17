using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public interface IDataResult<T> : IResult
    {
        // IDataResult, IResult arayüzünü miras alır, bu nedenle IResult'tan gelen özelliklere sahiptir.

        // Veriyi temsil eden özellik.
        T Data { get; }
    }
}
