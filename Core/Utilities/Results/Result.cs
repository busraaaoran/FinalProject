using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //c#'ta this demek o classın kendisi demektir.
        //burada this(success) diyerek 2 parametreli constructor çalışırken
        //tek parametreli constructorın da çalışmasını sağladık.
        //Çünkü iki parametreli olan zaten tek parametreliyi kapsıyor.

        public Result(bool success, string message):this(success)
        {
            
            Message = message; 
            //bu noktada set edebiliyoruz, nasıl oluyor diye düşünürsek
            //read only (get) olarak yazdığımız result !!sadece!! constructor içinde set edilebiliyor.
        }

        //Burada overload ediyoruz.
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
