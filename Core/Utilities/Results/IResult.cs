using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{

    //for basic 
    public interface IResult
    {
        bool Success { get; }
        string Message { get; }

    }
}
