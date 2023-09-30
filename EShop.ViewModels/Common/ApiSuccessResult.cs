using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObj)
        {
            IsSucceed = true;
            ResultObj = resultObj;
        }

        public ApiSuccessResult()
        {
            IsSucceed = true;
        }
    }
}
