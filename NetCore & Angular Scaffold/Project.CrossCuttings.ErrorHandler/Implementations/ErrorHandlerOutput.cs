using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Project.CrossCuttings.ErrorHandler.Implementations
{
    public sealed class ErrorHandlerOutput
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public object Result { get; set; }

        public ErrorHandlerOutput(HttpStatusCode httpStatusCode, object result)
        {
            HttpStatusCode = httpStatusCode;
            Result = result;
        }
    }
}
