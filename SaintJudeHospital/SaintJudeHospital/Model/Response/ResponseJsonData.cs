using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaintJudeHospital.Model.Response
{
    public static class ResponseJsonData
    {
        public static JsonResult Ok<T>(T data, string message = "OK")
        {
            return new JsonResult(new ResponseOkModel<T>
            {
                StatusCode = StatusCodeEnum.Ok,
                Data = data,
                Message = message
            });
        }

        public static JsonResult Error(string message = "Error", IList<string> messages = null)
        {
            return new JsonResult(new ResponseErrorModel
            {
                StatusCode = StatusCodeEnum.Error,
                Message = message,
                Messages = messages
            });
        }
    }

    public class ResponseOkModel<T> : ResponseModel
    {
        public T Data { set; get; }
    }

    public class ResponseErrorModel : ResponseModel
    {
        public IList<string> Messages { set; get; }
    }

    public class ResponseModel
    {
        public string Message { set; get; }
        public StatusCodeEnum StatusCode { set; get; }
    }

    public enum StatusCodeEnum
    {
        //     It indicates that the request succeeded. 
        Ok = 200,        
        //     It indicates that the request is failed.
        Error = 400
    }
}
