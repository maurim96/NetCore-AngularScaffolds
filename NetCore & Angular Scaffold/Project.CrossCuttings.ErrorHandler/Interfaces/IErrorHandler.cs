using Project.CrossCuttings.ErrorHandler.Implementations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.CrossCuttings.ErrorHandler.Interfaces
{
    public interface IErrorHandler
    {
        /// <summary>
        /// Handles the exception, logging the error.
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        ErrorHandlerOutput HandleException(Exception exception);
    }
}
