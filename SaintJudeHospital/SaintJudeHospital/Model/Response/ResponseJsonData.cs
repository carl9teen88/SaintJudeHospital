using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaintJudeHospital.Model.Response
{
    public class ResponseJsonData
    {
        public static JsonResult Ok(ResponseOkModel responseOk)
        {
            return new JsonResult(responseOk);
        }

        public static JsonResult Error(ResponseErrorModel responseError)
        {
            return new JsonResult(responseError);
        }
    }

    public class ResponseOkModel : ResponseModel
    {
        public dynamic Data { set; get; }
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
        //
        // Summary:
        //     Equivalent to HTTP status 200. It indicates that the
        //     request succeeded and that the requested information is in the response. This
        //     is the most common status code to receive.
        Ok = 200,
        //
        // Summary:
        //     Equivalent to HTTP status 201. It indicates that
        //     the request resulted in a new resource created before the response was sent.
        Created = 201,
        //
        // Summary:
        //     Equivalent to HTTP status 401. It indicates
        //     that the requested resource requires authentication. The WWW-Authenticate header
        //     contains the details of how to perform the authentication.
        Unauthorized = 401,
        //
        // Summary:
        //     Equivalent to HTTP status 403. It indicates
        //     that the server refuses to fulfill the request.
        Forbidden = 403,
        //
        // Summary:
        //     Equivalent to HTTP status 404. It indicates that
        //     the requested resource does not exist on the server.
        NotFound = 404
    }
}
