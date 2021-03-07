using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel void yapıları için süsleme gibi bir başlangıç düşünelim.

    public interface IResult
    {
        //set koymadık sadece okunabilsin istiyoruz, yazmayla işimiz yok.
        bool Success { get; }

        string Message { get; }

    }
}
