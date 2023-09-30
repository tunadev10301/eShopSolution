using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationError { get; set; }

        public ApiErrorResult() { }
        public ApiErrorResult(string message)
        {
            IsSucceed = false;
            Message = message;
        }

        public ApiErrorResult(string[] validationErrors)
        {
            IsSucceed = false;
            ValidationError = validationErrors;
        }
    }
}
