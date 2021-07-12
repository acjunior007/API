using System;
using System.Collections.Generic;
using System.Text;

namespace Application.CustomExceptions
{
    public class UnprocessableException : Exception
    {
        public object ModelToReturn { get; set; }

        public UnprocessableException(string message) : base(message)
        {
        }

        public UnprocessableException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public UnprocessableException(object returnModel, string message) : base(message)
        {
            ModelToReturn = returnModel;
        }
    }
}