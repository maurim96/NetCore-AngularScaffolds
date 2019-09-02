using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Project.CrossCuttings.ErrorHandler.Implementations;
using Project.CrossCuttings.ErrorHandler.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Web.Filters
{
    public class WebApiExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private readonly IErrorHandler _errorHandler;

        public WebApiExceptionFilterAttribute(IErrorHandler errorHandler)
        {
            _errorHandler = errorHandler;
        }

        public override void OnException(ExceptionContext exceptionContext)
        {
            ErrorHandlerOutput errorHandlerOutput = _errorHandler.HandleException(exceptionContext.Exception);
            exceptionContext.HttpContext.Response.StatusCode = (int)errorHandlerOutput.HttpStatusCode;
            exceptionContext.Result = new JsonResult(errorHandlerOutput.Result);
            exceptionContext.ExceptionHandled = true;
        }
    }
}
