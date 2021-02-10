using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message):this(success)
        {
            //read only sadece constructor içinde set edilebilir!!
            Message = message;
        }

        public Result(bool success) 
        {
            //mesaj göndermeden de çalıssın diye
            Success = Success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
